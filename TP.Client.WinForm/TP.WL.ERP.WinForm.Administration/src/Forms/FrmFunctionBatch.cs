using DevExpress.XtraTreeList;
using System.Threading.Tasks;
using TP.Client.WinForm.Common.Forms;
using TP.Client.WinForm.Common.Helpers;
using TP.WL.ERP.Model.Administration;

namespace TP.WL.ERP.WinForm.Administration.Forms
{
    public partial class FrmFunctionBatch : FrmEditBase
    {
        public FrmFunctionBatch()
        {
            InitializeComponent();
        }

        public FrmFunctionBatch(FunctionBatchEditModel model) : base(model)
        {
            InitializeComponent();

            tllueViewLinkTreeList.CustomDrawNodeImages += new CustomDrawNodeImagesEventHandler(TllueViewLinkTreeList_CustomDrawNodeImages);
        }
        
        public FunctionBatchEditModel Model { get { return GetEditModel<FunctionBatchEditModel>(); } }

        protected override void InitializeData()
        {
            if (Model == null)
                return;

            tllueViewLink.DataBindings.Add("EditValue", Model, "ViewLinkId");
            teNumber.DataBindings.Add("Text", Model, "Number");
            teDisplayName.DataBindings.Add("Text", Model, "DisplayName");
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
            if (ceCategoryCreate.Checked)
                Model.Categories.Add(FunctionCategory.Create, "新建");
            if (ceCategoryRetrieve.Checked)
                Model.Categories.Add(FunctionCategory.Retrieve, "查看");
            if (ceCategoryUpdate.Checked)
                Model.Categories.Add(FunctionCategory.Update, "編輯");
            if (ceCategoryDelete.Checked)
                Model.Categories.Add(FunctionCategory.Delete, "刪除");
            if (ceCategoryImport.Checked)
                Model.Categories.Add(FunctionCategory.Import, "導入");
            if (ceCategoryExport.Checked)
                Model.Categories.Add(FunctionCategory.Export, "導出");

            string content = GetSerializeObject(Model);

            await PostAsync("navs", "bulk_add_function", content);
        }

        private void TllueViewLinkTreeList_CustomDrawNodeImages(object sender, CustomDrawNodeImagesEventArgs e)
        {
            e.SelectImageIndex = e.Node.Level;
        }
    }
}