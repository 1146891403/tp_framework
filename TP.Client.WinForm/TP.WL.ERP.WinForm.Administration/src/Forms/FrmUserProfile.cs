using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTreeList;
using System.Threading.Tasks;
using TP.Client.WinForm.Common.Forms;
using TP.Client.WinForm.Common.Helpers;
using TP.Infrastructure.Common.Enums;
using TP.Infrastructure.Common.Extensions;
using TP.WL.ERP.Model.Administration;

namespace TP.WL.ERP.WinForm.Administration.Forms
{
    public partial class FrmUserProfile : FrmEditBase
    {
        public FrmUserProfile()
        {
            InitializeComponent();
        }

        public FrmUserProfile(UserEditModel model) : base(model)
        {
            InitializeComponent();

            teUserName.EditValueChanging += new ChangingEventHandler(TeUserName_EditValueChanging);
            tllueOrganizationTreeList.CustomDrawNodeImages += new CustomDrawNodeImagesEventHandler(TllueOrganizationTreeList_CustomDrawNodeImages);
        }

        public UserEditModel Model { get { return GetEditModel<UserEditModel>(); } }

        protected override void InitializeData()
        {
            if (Model == null)
                return;

            teUserName.DataBindings.Add("Text", Model, "UserName");
            teEmail.DataBindings.Add("Text", Model, "Email");
            teChineseName.DataBindings.Add("Text", Model, "FullName");
            teEnglishName.DataBindings.Add("Text", Model, "Alias");
            teStaffNumber.DataBindings.Add("Text", Model, "StaffNumber");
            cbeGender.DataBindings.Add("EditValue", Model, "Gender");
            tllueOrganization.DataBindings.Add("EditValue", Model, "DepartmentId");
            teDesignation.DataBindings.Add("Text", Model, "Designation");
            deJoinDate.DataBindings.Add("DateTime", Model, "JoinDate");
            bePhone.DataBindings.Add("Text", Model, "Phone");
            beMobile.DataBindings.Add("Text", Model, "Mobile");
            rgLockoutEnabled.DataBindings.Add("EditValue", Model, "LockoutEnabled");
            meRemark.DataBindings.Add("Text", Model, "Remark");
        }

        protected override void InitializeButton()
        {
            CanPrint = true;
            CanDelete = true;
        }

        protected override async Task InitializeEditorsAsync()
        {
            EditorHelper.CreateGenderImageComboBox(cbeGender.Properties);

            await EditorHelper.CreateOrganizationTreeListLookUpEdit(tllueOrganization.Properties, null);
        }

        protected override void InitializeValidation()
        {
            base.InitializeValidation();
            ValidationProvider.SetValidationRule(teUserName, ValidationRulesHelper.RuleIsNotBlank);
            ValidationProvider.SetValidationRule(teEmail, ValidationRulesHelper.RuleIsNotBlank);
            ValidationProvider.SetValidationRule(teChineseName, ValidationRulesHelper.RuleIsNotBlank);
            ValidationProvider.SetValidationRule(cbeGender, ValidationRulesHelper.RuleIsNotBlank);
            ValidationProvider.SetValidationRule(tllueOrganization, ValidationRulesHelper.RuleIsNOtBlankOfTreeList);
            ValidationProvider.SetValidationRule(deJoinDate, ValidationRulesHelper.RuleIsNotBlank);
        }

        protected override async Task SaveDataAsync()
        {
            Model.SubsidiaryId = tllueOrganizationTreeList.FocusedNode != null ? tllueOrganizationTreeList.GetDataRecordByNode(tllueOrganizationTreeList.FocusedNode).As<OrganizationListModel>().SubsidiaryId : 0;

            string content = GetSerializeObject(Model);

            if (string.IsNullOrWhiteSpace(Model.UserId))
                await PostAsync("users", content);
            else
                await PutAsync("users", content);
        }

        private void TeUserName_EditValueChanging(object sender, ChangingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(e.NewValue.ToString()))
            {
                Model.Email = teEmail.Text = $"{e.NewValue}@toppanleefung.com";
            }
        }

        private void TllueOrganizationTreeList_CustomDrawNodeImages(object sender, CustomDrawNodeImagesEventArgs e)
        {
            e.SelectImageIndex = e.Node.GetValue("Category").ToString() == OrganizationCategory.Department.ToString() ? 2 : e.Node.Level;
        }
    }
}