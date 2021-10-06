using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP.Client.WinForm.Common.Controls;
using TP.Client.WinForm.Common.Helpers;
using TP.Infrastructure.Common.Extensions;
using TP.WL.ERP.Model.Administration;
using TP.WL.ERP.WinForm.Administration.Forms;

namespace TP.WL.ERP.WinForm.Administration.Controls
{
    public partial class NavigationGridView : GridTreeListViewBase
    {
        public NavigationGridView()
        {
            InitializeComponent();

            btnNewFunc.Click += new EventHandler(BtnNewFunc_Click);
            btnNewFuncBulk.Click += new EventHandler(BtnNewFuncBulk_Click);
            btnSearchFunc.Click += new EventHandler(BtnSearchFunc_Click);
            gridFunction.MouseDoubleClick += new MouseEventHandler(GridFunction_MouseDoubleClick);
            gvFunction.OptionsBehavior.Editable = false;
        }

        protected override string TreeCaption => "菜單管理";

        protected override ImageCollection TreeSelectImages => ImagesHelper.Current.NavigationImages;

        protected override GridControl Grid => gridNavigation;

        protected override GridView MainView => gvNavigation;

        protected override ColumnView CurrentView => gridNavigation.MainView.As<ColumnView>();
        
        protected override async Task RefreshTreeDataAsync()
        {
            BindingTreeModels = await GetDeserializeObjectAsync<ViewLinkListModel>("navs");
        }

        protected override async Task RefreshGridDataAsync()
        {
            await base.RefreshGridDataAsync();

            if (CurrentTreeModel != null)
            {
                var ctlm = CurrentTreeModel.As<ViewLinkListModel>();

                lcTreeName.Text = ctlm.DisplayName;
                lcFuncTreeName.Text = ctlm.DisplayName;
                BindingGridModels = GetViewItems(ctlm.Id);
                //BindingGridModels = await GetDeserializeObjectAsync<ViewLinkListModel>("navs", "get_links", $"?directoryId={ctlm.Id}");
            }
        }

        private void AddForm()
        {
            ShowFormDialog(new FrmNavigation(GetCurrentGridEditModel<ViewLinkEditModel>()));
        }

        private void EditForm()
        {
            ShowFormDialog(new FrmNavigation(GetCurrentGridEditModel<ViewLinkEditModel>()));
        }

        protected override void Add()
        {
            base.Add();
            AddForm();
        }

        protected override void Edit()
        {
            base.Edit();

            var listModel = CurrentGridListModel.As<ViewLinkListModel>();

            SetCurrentGridEditModel(new ViewLinkEditModel()
            {
                Id = listModel.Id,
                ParentId = listModel.ParentId,
                Number = listModel.Number,
                DisplayName = listModel.DisplayName,
                ViewName = listModel.ViewName,
                Description = listModel.Description,
                IconSource = listModel.IconSource,
                ListOrder = listModel.ListOrder,
                IsEnabled = listModel.IsEnabled,
                IsGroup = string.IsNullOrWhiteSpace(listModel.ViewName)
            });

            EditForm();
        }

        protected override async void TreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (e.Node != null)
            {
                await RefreshGridDataAsync();

                await RefreshGridFunctionDataSourceAsync();
            }

            base.TreeList_FocusedNodeChanged(sender, e);
        }

        protected override void TreeList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            base.TreeList_MouseDoubleClick(sender, e);

            var treeModel = CurrentTreeModel.As<ViewLinkListModel>();

            var editModel = new ViewLinkEditModel()
            {
                Id = treeModel.Id,
                ParentId = treeModel.ParentId,
                Number = treeModel.Number,
                DisplayName = treeModel.DisplayName,
                ViewName = treeModel.ViewName,
                Description = treeModel.Description,
                IconSource = treeModel.IconSource,
                ListOrder = treeModel.ListOrder,
                IsEnabled = treeModel.IsEnabled,
                IsGroup = string.IsNullOrWhiteSpace(treeModel.ViewName)
            };

            ShowFormDialog(new FrmNavigation(editModel));
        }

        private void BtnNewFunc_Click(object sender, EventArgs e)
        {
            ShowFunctionDialog(new FunctionEditModel());
        }

        private void BtnNewFuncBulk_Click(object sender, EventArgs e)
        {
            FrmFunctionBatch funcBatch = new FrmFunctionBatch(new FunctionBatchEditModel());
            funcBatch.ShowDialog();
        }

        private async void BtnSearchFunc_Click(object sender, EventArgs e)
        {
            await RefreshGridFunctionDataSourceAsync();
        }

        private void GridFunction_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridFunction.MainView != null)
            {
                var functionView = gridFunction.MainView.As<ColumnView>();

                var funcListModel = functionView.GetRow(functionView.FocusedRowHandle).As<FunctionListModel>();

                var funcEditModel = new FunctionEditModel()
                {
                    Id = funcListModel.Id,
                    Number = funcListModel.Number,
                    ViewLinkId = funcListModel.ParentId,
                    DisplayName = funcListModel.DisplayName,
                    ListOrder = funcListModel.ListOrder,
                    IsEnabled = funcListModel.IsEnabled
                };

                ShowFunctionDialog(funcEditModel);
            }
        }

        private async Task RefreshGridFunctionDataSourceAsync()
        {
            var ctlm = CurrentTreeModel.As<ViewLinkListModel>();

            if (ctlm != null)
            {
                gridFunction.DataSource = await GetFunctions(ctlm.Id);
            }
        }

        private async Task<IEnumerable<FunctionListModel>> GetFunctions(long linkId)
        {
            return await GetDeserializeObjectAsync<FunctionListModel>("navs", "get_functions", $"linkId={linkId}");
        }

        private IEnumerable<ViewLinkListModel> GetViewItems(long parentId)
        {
            var items = new List<ViewLinkListModel>();
            var children = BindingTreeModels.As<IEnumerable<ViewLinkListModel>>().Where(x => x.ParentId == parentId);
            foreach (var child in children)
            {
                items.Add(child);
                items.AddRange(GetViewItems(child.Id));
            }

            return items;
        }

        private void ShowFunctionDialog(FunctionEditModel model)
        {
            FrmFunction function = new FrmFunction(model);
            function.ShowDialog();
        }
    }
}
