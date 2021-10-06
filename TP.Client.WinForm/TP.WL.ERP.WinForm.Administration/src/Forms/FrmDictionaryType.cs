using System.Threading.Tasks;
using TP.Client.WinForm.Common.Forms;
using TP.Client.WinForm.Common.Helpers;
using TP.WL.ERP.Model.Utilities;

namespace TP.WL.ERP.WinForm.Administration.Forms
{
    public partial class FrmDictionaryType : FrmEditBase
    {
        public FrmDictionaryType()
        {
            InitializeComponent();
        }

        public FrmDictionaryType(DictionaryTypeEditModel model) : base(model)
        {
            InitializeComponent();
        }

        public DictionaryTypeEditModel Model { get { return GetEditModel<DictionaryTypeEditModel>(); } }

        protected override void InitializeData()
        {
            if (Model == null)
                return;

            teNumber.DataBindings.Add("Text", Model, "Number");
            teDisplayName.DataBindings.Add("Text", Model, "DisplayName");
            lueParent.DataBindings.Add("EditValue", Model, "ParentId");
            seListOrder.DataBindings.Add("EditValue", Model, "ListOrder");
            meRemark.DataBindings.Add("Text", Model, "Remark");
        }

        protected override async Task InitializeEditorsAsync()
        {
            await EditorHelper.CreateDictionaryTypeLookUpEdit(lueParent.Properties, null);
        }

        protected override void InitializeValidation()
        {
            base.InitializeValidation();
        }

        protected override async Task SaveDataAsync()
        {
            string content = GetSerializeObject(Model);

            if (Model.Id <= 0)
                await PostAsync("dictionaries", "add_type", content);
            else
                await PutAsync("dictionaries", "update_type", content);
        }
    }
}