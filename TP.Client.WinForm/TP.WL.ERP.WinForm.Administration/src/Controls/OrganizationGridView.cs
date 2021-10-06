using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP.Client.WinForm.Common.Controls;
using TP.Client.WinForm.Common.Helpers;
using TP.Infrastructure.Common.Enums;
using TP.Infrastructure.Common.Extensions;
using TP.WL.ERP.Model.Administration;
using TP.WL.ERP.WinForm.Administration.Forms;

namespace TP.WL.ERP.WinForm.Administration.Controls
{
    public partial class OrganizationGridView : GridTreeListViewBase
    {
        public OrganizationGridView()
        {
            InitializeComponent();
        }

        protected override string TreeCaption => "組織機構管理";

        protected override ImageCollection TreeSelectImages => ImagesHelper.Current.OrganizationImages;

        protected override GridControl Grid => gridOrganization;

        protected override GridView MainView => gvOrganization;

        protected override ColumnView CurrentView => gridOrganization.MainView.As<ColumnView>();
        
        protected override async Task RefreshTreeDataAsync()
        {
            await RefreshTreeAndGrid();
        }

        protected override async Task RefreshGridDataAsync()
        {
            await RefreshTreeAndGrid();

            if (CurrentTreeModel != null)
            {
                var ctlm = CurrentTreeModel.As<OrganizationListModel>();

                lcTreeName.Text = ctlm.DisplayName;
                BindingGridModels = GetItems(ctlm.Id);
            }
        }

        private async Task RefreshTreeAndGrid()
        {
            BindingTreeModels = await GetDeserializeObjectAsync<OrganizationListModel>("organizations");
        }

        private void AddForm()
        {
            ShowFormDialog(new FrmOrganization(GetCurrentGridEditModel<OrganizationEditModel>()));
        }

        private void EditForm()
        {
            ShowFormDialog(new FrmOrganization(GetCurrentGridEditModel<OrganizationEditModel>()));
        }

        protected override void Add()
        {
            base.Add();
            AddForm();
        }

        protected override void Edit()
        {
            base.Edit();

            var listModel = CurrentGridListModel.As<OrganizationListModel>();

            SetCurrentGridEditModel(new OrganizationEditModel()
            {
                Id = listModel.Id,
                ParentId = listModel.ParentId,
                Number = listModel.Number,
                DisplayName = listModel.DisplayName,
                Category = listModel.Category,
                SubsidiaryId = listModel.SubsidiaryId,
                ListOrder = listModel.ListOrder,
                IsEnabled = listModel.IsEnabled,
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

        protected override void TreeList_CustomDrawNodeImages(object sender, CustomDrawNodeImagesEventArgs e)
        {
            e.SelectImageIndex = e.Node.GetValue("Category").ToString() == OrganizationCategory.Department.ToString() ? 2 : e.Node.Level;
        }

        protected override void TreeList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            base.TreeList_MouseDoubleClick(sender, e);

            var treeModel = CurrentTreeModel.As<OrganizationListModel>();

            var editModel = new OrganizationEditModel()
            {
                Id = treeModel.Id,
                ParentId = treeModel.ParentId,
                Number = treeModel.Number,
                DisplayName = treeModel.DisplayName,
                Category = treeModel.Category,
                SubsidiaryId = treeModel.SubsidiaryId,
                ListOrder = treeModel.ListOrder,
                IsEnabled = treeModel.IsEnabled,
            };

            ShowFormDialog(new FrmOrganization(editModel));
        }

        private IEnumerable<OrganizationListModel> GetItems(long parentId)
        {
            var items = new List<OrganizationListModel>();
            var children = BindingTreeModels.As<IEnumerable<OrganizationListModel>>().Where(x => x.ParentId == parentId);
            foreach (var child in children)
            {
                items.Add(child);
                items.AddRange(GetItems(child.Id));
            }
            return items;
        }
    }
}
