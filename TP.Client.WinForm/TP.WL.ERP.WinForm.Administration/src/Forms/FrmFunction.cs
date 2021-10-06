using DevExpress.XtraTreeList;
using System.Threading.Tasks;
using TP.Client.WinForm.Common.Forms;
using TP.Client.WinForm.Common.Helpers;
using TP.WL.ERP.Model.Administration;

namespace TP.WL.ERP.WinForm.Administration.Forms
{
    public partial class FrmFunction : FrmEditBase
    {
        public FrmFunction()
        {
            InitializeComponent();
        }

        public FrmFunction(FunctionEditModel model): base(model)
        {
            InitializeComponent();
            tllueViewLinkTreeList.CustomDrawNodeImages += new CustomDrawNodeImagesEventHandler(TllueViewLinkTreeList_CustomDrawNodeImages);
        }

        public FunctionEditModel Model { get { return GetEditModel<FunctionEditModel>(); } }

        protected override void InitializeData()
        {
            if (Model == null)
                return;

            tllueViewLink.DataBindings.Add("EditValue", Model, "ViewLinkId");
            teNumber.DataBindings.Add("Text", Model, "Number");
            teDisplayName.DataBindings.Add("Text", Model, "DisplayName");
            seListOrder.DataBindings.Add("EditValue", Model, "ListOrder");
            rgIsEnabled.DataBindings.Add("EditValue", Model, "IsEnabled");
        }

        protected override async Task InitializeEditorsAsync()
        {
            await EditorHelper.CreateNavigationLinkTreeListLookUpEdit(tllueViewLink.Properties, null);
        }

        protected override void InitializeValidation()
        {
            base.InitializeValidation();
        }

        protected override async Task SaveDataAsync()
        {
            string content = GetSerializeObject(Model);

            if (Model.Id <= 0)
                await PostAsync("navs", "add_function", content);
            else
                await PutAsync("navs", "update_function", content);
        }

        private void TllueViewLinkTreeList_CustomDrawNodeImages(object sender, CustomDrawNodeImagesEventArgs e)
        {
            e.SelectImageIndex = e.Node.Level;
        }
    }
}