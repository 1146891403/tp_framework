using DevExpress.XtraTreeList;
using System.Threading.Tasks;
using TP.Client.WinForm.Common.Forms;
using TP.Client.WinForm.Common.Helpers;
using TP.Infrastructure.Common.Enums;
using TP.Infrastructure.Common.Extensions;
using TP.WL.ERP.Model.Administration;

namespace TP.WL.ERP.WinForm.Administration.Forms
{
    public partial class FrmOrganization : FrmEditBase
    {
        public FrmOrganization()
        {
            InitializeComponent();
        }

        public FrmOrganization(OrganizationEditModel model) : base(model)
        {
            InitializeComponent();

            tllueParentTreeList.CustomDrawNodeImages += new CustomDrawNodeImagesEventHandler(TllueParentTreeList_CustomDrawNodeImages);
        }

        public OrganizationEditModel Model { get { return GetEditModel<OrganizationEditModel>(); } }

        protected override void InitializeData()
        {
            if (Model == null)
                return;

            teNumber.DataBindings.Add("Text", Model, "Number");
            teDisplayName.DataBindings.Add("Text", Model, "DisplayName");
            lueCategory.DataBindings.Add("EditValue", Model, "Category");
            tllueParent.DataBindings.Add("EditValue", Model, "ParentId");
            seListOrder.DataBindings.Add("EditValue", Model, "ListOrder");
            rgIsEnabled.DataBindings.Add("EditValue", Model, "IsEnabled");
        }

        protected override async Task InitializeEditorsAsync()
        {
            EditorHelper.CreateOrganizationCategoryLookUpEdit(lueCategory.Properties, null);
            await EditorHelper.CreateOrganizationTreeListLookUpEdit(tllueParent.Properties, null);
        }

        protected override void InitializeValidation()
        {
            base.InitializeValidation();

            ValidationProvider.SetValidationRule(teNumber, ValidationRulesHelper.RuleIsNotBlank);
            ValidationProvider.SetValidationRule(teDisplayName, ValidationRulesHelper.RuleIsNotBlank);
            ValidationProvider.SetValidationRule(lueCategory, ValidationRulesHelper.RuleIsNotBlank);
            ValidationProvider.SetValidationRule(tllueParent, ValidationRulesHelper.RuleIsNOtBlankOfTreeList);
        }

        protected override async Task SaveDataAsync()
        {
            var category = Model.Category.ToEnum<OrganizationCategory>();
            string content = string.Empty;
            string action = string.Empty;

            if(category == OrganizationCategory.Group || category == OrganizationCategory.Subsidiary)
            {
                action = "subsidiary";
                content = GetSerializeObject(new SubsidiaryEditModel()
                {
                    Id = Model.Id,
                    Number = Model.Number,
                    DisplayName = Model.DisplayName,
                    ParentId = Model.ParentId,
                    Category = Model.Category,
                    ListOrder = Model.ListOrder,
                    IsEnabled = Model.IsEnabled
                });
            }
            else
            {
                var parentId = category == OrganizationCategory.WorkingGroup ? Model.ParentId : 0;
                var subsidiaryId = tllueParentTreeList.FocusedNode != null ? tllueParentTreeList.GetDataRecordByNode(tllueParentTreeList.FocusedNode).As<OrganizationListModel>().SubsidiaryId : Model.SubsidiaryId;

                action = "department";
                content = GetSerializeObject(new DepartmentEditModel()
                {
                    Id = Model.Id,
                    Number = Model.Number,
                    DisplayName = Model.DisplayName,
                    ParentId = parentId,
                    SubsidiaryId = subsidiaryId,
                    Category = Model.Category,
                    ListOrder = Model.ListOrder,
                    IsEnabled = Model.IsEnabled
                });
            }
            
            if (Model.Id <= 0)
                await PostAsync("organizations", $"add_{action}", content);
            else
                await PutAsync("organizations", $"update_{action}", content);
        }
        
        private void TllueParentTreeList_CustomDrawNodeImages(object sender, CustomDrawNodeImagesEventArgs e)
        {
            e.SelectImageIndex = e.Node.GetValue("Category").ToString() == OrganizationCategory.Department.ToString() ? 2 : e.Node.Level;
        }
    }
}