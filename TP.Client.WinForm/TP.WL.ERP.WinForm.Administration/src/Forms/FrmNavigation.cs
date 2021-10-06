using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTreeList;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP.Client.WinForm.Common.Forms;
using TP.Client.WinForm.Common.Helpers;
using TP.WL.ERP.Model.Administration;

namespace TP.WL.ERP.WinForm.Administration.Forms
{
    public partial class FrmNavigation : FrmEditBase
    {
        public FrmNavigation()
        {
            InitializeComponent();
        }

        public FrmNavigation(ViewLinkEditModel model) : base(model)
        {
            InitializeComponent();

            tllueParentTreeList.CustomDrawNodeImages += new CustomDrawNodeImagesEventHandler(TllueParentTreeList_CustomDrawNodeImages);
            rgIsGroup.EditValueChanging += new ChangingEventHandler(RgisGroup_EditValueChanging);
            beIconSource.Click += new EventHandler(BeIconSource_Click);
        }

        public ViewLinkEditModel Model { get { return GetEditModel<ViewLinkEditModel>(); } }

        protected override void InitializeData()
        {
            if (Model == null)
                return;
            
            teNumber.DataBindings.Add("Text", Model, "Number");
            tllueParent.DataBindings.Add("EditValue", Model, "ParentId");
            teDisplayName.DataBindings.Add("Text", Model, "DisplayName");
            teViewName.DataBindings.Add("Text", Model, "ViewName");
            //peIconSource.DataBindings.Add("", Model, "");
            seListOrder.DataBindings.Add("EditValue", Model, "ListOrder");
            rgIsEnabled.DataBindings.Add("EditValue", Model, "IsEnabled");
            rgIsGroup.DataBindings.Add("EditValue", Model, "IsGroup");
            meDescription.DataBindings.Add("Text", Model, "Description");
        }

        protected override async Task InitializeEditorsAsync()
        {
            await EditorHelper.CreateNavigationTreeListLookUpEdit(tllueParent.Properties, null);
        }

        protected override void InitializeValidation()
        {
            //base.InitValidation();
        }

        protected override async Task SaveDataAsync()
        {
            string content = GetSerializeObject(Model);

            if (Model.Id <= 0)
                await PostAsync("navs", "add_link", content);
            else
                await PutAsync("navs", "update_link", content);
        }

        private void RgisGroup_EditValueChanging(object sender, ChangingEventArgs e)
        {
            if (Convert.ToBoolean(e.NewValue))
            {
                teViewName.Enabled = false;
                Model.ViewName = teViewName.Text = string.Empty;
            }
            else
                teViewName.Enabled = true;
        }

        private void TllueParentTreeList_CustomDrawNodeImages(object sender, CustomDrawNodeImagesEventArgs e)
        {
            e.SelectImageIndex = e.Node.Level;
        }

        private void BeIconSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageDialog = new OpenFileDialog
            {
                Filter = "Image Files (*.bmp;*.jpg;*.png;*.gif)|*.bmp;*.jpg;*.png;*.gif",
                Multiselect = false
            };

            if (imageDialog.ShowDialog() == DialogResult.OK)
            {
                beIconSource.Text = imageDialog.SafeFileName;
                beIconSource.ToolTip = imageDialog.FileName;

                peIconSource.Properties.SizeMode = PictureSizeMode.Squeeze;
                peIconSource.Image = Image.FromFile(imageDialog.FileName);
            }; 
        }
    }
}