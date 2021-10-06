using DevExpress.XtraTreeList;
using System.Threading.Tasks;
using TP.Client.WinForm.Common.Forms;
using TP.Client.WinForm.Common.Helpers;
using TP.WL.ERP.Model.Administration;

namespace TP.WL.ERP.WinForm.Administration.Forms
{
    public partial class FrmRole : FrmEditBase
    {
        public FrmRole()
        {
            InitializeComponent();
        }

        public FrmRole(RoleEditModel model) : base(model)
        {
            InitializeComponent();

            tllueSubsidiaryTreeList.CustomDrawNodeImages += new CustomDrawNodeImagesEventHandler(TllueSubsidiaryTreeList_CustomDrawNodeImages);
        }

        public RoleEditModel Model => GetEditModel<RoleEditModel>();

        protected override void InitializeData()
        {
            if (Model == null)
                return;

            teDisplayName.DataBindings.Add("Text", Model, "DisplayName");
            tllueSubsidiary.DataBindings.Add("EditValue", Model, "SubsidiaryId");
            rgIsEnabled.DataBindings.Add("EditValue", Model, "IsEnabled");
            meDescription.DataBindings.Add("Text", Model, "Description");
        }

        protected override async Task InitializeEditorsAsync()
        {
            await EditorHelper.CreateSubsidiaryTreeListLookUpEdit(tllueSubsidiary.Properties, null);
        }

        protected override void InitializeValidation()
        {
            base.InitializeValidation();
        }

        protected override async Task SaveDataAsync()
        {
            string content = GetSerializeObject(Model);

            if (Model.Id <= 0)
                await PostAsync("permissions", "add_role", content);
            else
                await PutAsync("permissions", "update_role", content);
        }

        private void TllueSubsidiaryTreeList_CustomDrawNodeImages(object sender, CustomDrawNodeImagesEventArgs e)
        {
            e.SelectImageIndex = e.Node.Level;
        }
    }
}