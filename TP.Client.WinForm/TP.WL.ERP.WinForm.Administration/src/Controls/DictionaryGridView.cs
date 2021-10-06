using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP.Client.WinForm.Common.Controls;
using TP.Client.WinForm.Common.Helpers;
using TP.Infrastructure.Common.Extensions;
using TP.WL.ERP.Model.Utilities;
using TP.WL.ERP.WinForm.Administration.Forms;

namespace TP.WL.ERP.WinForm.Administration.Controls
{
    public partial class DictionaryGridView : GridTreeListViewBase
    {
        public DictionaryGridView()
        {
            InitializeComponent();

            lcgTreeList.CustomButtonClick += new BaseButtonEventHandler(LcgTreeList_CustomButtonClick);
            btnNewBulk.Click += new EventHandler(BtnNewBulk_Click);
        }

        protected override string TreeCaption => "數據字典類型";

        protected override GridControl Grid { get { return gridDictionary; } }

        protected override GridView MainView { get { return gvDictionary; } }

        protected override ColumnView CurrentView { get { return gridDictionary.MainView.As<ColumnView>(); } }

        protected override ImageCollection TreeSelectImages => ImagesHelper.Current.DictionaryImages;

        protected override async Task RefreshTreeDataAsync()
        {
            BindingTreeModels = await GetDeserializeObjectAsync<DictionaryTypeListModel>("dictionaries", "get_types");
        }

        protected override async Task RefreshGridDataAsync()
        {
            if (CurrentTreeModel != null)
            {
                var ctlm = CurrentTreeModel.As<DictionaryTypeListModel>();

                lcTreeName.Text = ctlm.DisplayName;

                await SetBindingGridModelsAsync<DictionaryDataListModel>("dictionaries", "get_datas", $"typeId={ctlm.Id}");
            }
        }

        private void AddForm()
        {
            ShowFormDialog(new FrmDictionaryData(GetCurrentGridEditModel<DictionaryDataEditModel>()));
        }

        private void EditForm()
        {
            ShowFormDialog(new FrmDictionaryData(GetCurrentGridEditModel<DictionaryDataEditModel>()));
        }

        protected override void Add()
        {
            base.Add();
            AddForm();
        }

        protected override void Edit()
        {
            base.Edit();

            var listModel = CurrentGridListModel.As<DictionaryDataListModel>();

            SetCurrentGridEditModel(new DictionaryDataEditModel()
            {
                Id = listModel.Id,
                TypeId = listModel.TypeId,
                DisplayName = listModel.DisplayName,
                Value = listModel.Value,
                ListOrder = listModel.ListOrder,
                IsEnabled = listModel.IsEnabled,
                Remark = listModel.Remark
            });

            EditForm();
        }

        protected override async void TreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (e.Node != null)
            {
                await RefreshGridDataAsync();
            }

            base.TreeList_FocusedNodeChanged(sender, e);
        }

        protected override void TreeList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            base.TreeList_MouseDoubleClick(sender, e);
        }

        private async void LcgTreeList_CustomButtonClick(object sender, BaseButtonEventArgs e)
        {
            if(e.Button.Properties.Caption == "New")
            {
                FrmDictionaryType frm = new FrmDictionaryType(new DictionaryTypeEditModel());
                frm.ShowDialog();
            }

            if (e.Button.Properties.Caption == "Refresh")
                await RefreshTreeDataAsync();
        }
        
        private void BtnNewBulk_Click(object sender, EventArgs e)
        {
            FrmDictionaryBatchData frmBatch = new FrmDictionaryBatchData(new DictionaryDataBatchEditModel());
            frmBatch.ShowDialog();
        }
    }
}
