using DevExpress.XtraTreeList;
using System.Threading.Tasks;
using TP.Client.WinForm.Common.Forms;
using TP.Client.WinForm.Common.Helpers;
using TP.WL.ERP.Model.Utilities;

namespace TP.WL.ERP.WinForm.Administration.Forms
{
    public partial class FrmDictionaryData : FrmEditBase
    {
        public FrmDictionaryData()
        {
            InitializeComponent();
        }

        public FrmDictionaryData(DictionaryDataEditModel model) : base(model)
        {
            InitializeComponent();

            tllueTypeTreeList.CustomDrawNodeImages += new CustomDrawNodeImagesEventHandler(TllueTypeTreeList_CustomDrawNodeImages);
        }

        public DictionaryDataEditModel Model { get { return GetEditModel<DictionaryDataEditModel>(); } }

        protected override void InitializeData()
        {
            if (Model == null)
                return;

            tllueType.DataBindings.Add("EditValue", Model, "TypeId");
            teDisplayName.DataBindings.Add("Text", Model, "DisplayName");
            teValue.DataBindings.Add("Text", Model, "Value");
            seListOrder.DataBindings.Add("EditValue", Model, "ListOrder");
            rgIsEnabled.DataBindings.Add("EditValue", Model, "IsEnabled");
            meRemark.DataBindings.Add("Text", Model, "Remark");
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

            if (Model.Id <= 0)
                await PostAsync("dictionaries", "add_data", content);
            else
                await PutAsync("dictionaries", "update_data", content);
        }

        private void TllueTypeTreeList_CustomDrawNodeImages(object sender, CustomDrawNodeImagesEventArgs e)
        {
            e.SelectImageIndex = e.Node.Level;
        }
    }
}