using DevExpress.XtraTreeList;
using System.Threading.Tasks;
using TP.Client.WinForm.Common.Forms;
using TP.Client.WinForm.Common.Helpers;
using TP.WL.ERP.Model.Utilities;

namespace TP.WL.ERP.WinForm.Administration.Forms
{
    public partial class FrmDictionaryBatchData : FrmEditBase
    {
        public FrmDictionaryBatchData()
        {
            InitializeComponent();
        }

        public FrmDictionaryBatchData(DictionaryDataBatchEditModel model) : base(model)
        {
            InitializeComponent();

            tllueTypeTreeList.CustomDrawNodeImages += new CustomDrawNodeImagesEventHandler(TllueTypeTreeList_CustomDrawNodeImages);
        }

        public DictionaryDataBatchEditModel Model { get { return GetEditModel<DictionaryDataBatchEditModel>(); } }

        protected override void InitializeData()
        {
            if (Model == null)
                return;

            tllueType.DataBindings.Add("EditValue", Model, "TypeId");
            rgMode.DataBindings.Add("EditValue", Model, "Mode");
            meData.DataBindings.Add("Text", Model, "Data");
        }

        protected override async Task InitializeEditorsAsync()
        {
            await EditorHelper.CreateDictionaryTypeTreeListLookUpEdit(tllueType.Properties, null);
        }

        protected override void InitializeValidation()
        {
            base.InitializeValidation();
        }

        protected override async Task SaveDataAsync()
        {
            string content = GetSerializeObject(Model);

            await PostAsync("dictionaries", "bulk_add_data", content);
        }

        private void TllueTypeTreeList_CustomDrawNodeImages(object sender, CustomDrawNodeImagesEventArgs e)
        {
            e.SelectImageIndex = e.Node.Level;
        }
    }
}