using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraTreeList;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP.Client.WinForm.Common;
using TP.Client.WinForm.Common.Controls;
using TP.Client.WinForm.Common.Extensions;
using TP.Client.WinForm.Common.Helpers;
using TP.Infrastructure.Common.Dependency;
using TP.Infrastructure.Common.Extensions;
using TP.WL.ERP.Model.Administration;
using TP.WL.ERP.WinForm.Administration.Forms;

namespace TP.WL.ERP.WinForm.Administration.Controls
{
    public partial class PermissionGridView : GridTreeListViewBase
    {
        public PermissionGridView()
        {
            InitializeComponent();

            tcgRole.SelectedPageChanged += new LayoutTabPageChangedEventHandler(TcgRole_SelectedPageChanged);
            btnTabRefreshUser.Click += new EventHandler(BtnTabRefreshUser_Click);
            btnTabNewUser.Click += new EventHandler(BtnTabNewUser_Click);
            btnTabRefreshNav.Click += new EventHandler(BtnTabRefreshNav_Click);
            btnTabSaveNav.Click += new EventHandler(BtnTabSaveNav_Click);
            btnTabRefreshFunc.Click += new EventHandler(BtnTabRefreshFunc_Click);
            btnTabSaveFunc.Click += new EventHandler(BtnTabSaveFunc_Click);
            btnTabRefreshOrg.Click += new EventHandler(BtnTabRefreshOrg_Click);
            btnTabSaveOrg.Click += new EventHandler(BtnTabSaveOrg_Click);
        }
        
        protected override string TreeCaption => "角色列表";

        protected override ImageCollection TreeSelectImages => ImagesHelper.Current.RoleImages;

        protected override GridControl Grid => gridUser;

        protected override GridView MainView => gvUser;

        protected override ColumnView CurrentView => gridUser.MainView.As<ColumnView>();

        protected virtual IEnumerable<UserListModel> BindingUserModels { get; set; }

        protected virtual IEnumerable<ViewLinkListModel> BindingNavigationModels { get; set; }

        protected virtual IEnumerable<FunctionListModel> BindingFunctionModels { get; set; }

        protected virtual IEnumerable<OrganizationListModel> BindingOrganizationModels { get; set; }

        protected virtual IEnumerable<string> RoleNavigationModels { get; set; }

        protected virtual IEnumerable<string> RoleFunctionModels { get; set; }

        protected virtual IEnumerable<string> RoleOrganizationModels { get; set; }

        protected virtual long SelectRoleId { get; set; }

        protected virtual string SelectRoleNumber { get; set; }

        private bool dirtyNavigation = false;
        protected virtual bool DirtyNavigation
        {
            get { return dirtyNavigation; }
            set
            {
                if(dirtyNavigation != value)
                {
                    dirtyNavigation = value;
                    SetTabPageText(value);
                }
            }
        }

        private bool dirtyfunction = false;
        protected virtual bool DirtyFunction
        {
            get { return dirtyfunction; }
            set
            {
                if(dirtyfunction != value)
                {
                    dirtyfunction = value;
                    SetTabPageText(value);
                }
            }
        }

        private bool dirtyOrganization = false;
        protected virtual bool DirtyOrganization
        {
            get { return dirtyOrganization; }
            set
            {
                if(dirtyOrganization != value)
                {
                    dirtyOrganization = value;
                    SetTabPageText(value);
                }
            }
        }

        private bool isSelectedRole = false;
        protected virtual bool IsSelectedRole
        {
            get { return isSelectedRole; }
            set
            {
                if(isSelectedRole != value)
                {
                    isSelectedRole = value;
                    SetTabButtonEnabled(value);
                }
            }
        }

        protected override async Task RefreshTreeDataAsync()
        {
            await RefreshRoleListModelsAsync();

            SetTabButtonEnabled(false);
        }

        protected override async Task RefreshGridDataAsync()
        {
            await SetBindingGridModelsAsync<UserListModel>("users", "get_users_by_role", $"id={CurrentTreeModel?.As<RoleListModel>().Id}");
        }

        private void AddForm()
        {
            ShowFormDialog(new FrmRole(GetCurrentGridEditModel<RoleEditModel>()));
        }
        
        protected override void Add()
        {
            base.Add();
            AddForm();
        }
        
        private async Task RefreshRoleListModelsAsync()
        {
            BindingTreeModels = await GetDeserializeObjectAsync<RoleListModel>("permissions", "get_roles");
        }
        
        private async Task RefreshNavigationListModelsAsync()
        {
            BindingNavigationModels = await GetDeserializeObjectAsync<ViewLinkListModel>("navs", "get_all_enabled");
        }

        private async Task RefreshFunctionListModelsAsync()
        {
            BindingFunctionModels = RoleNavigationModels != null && RoleNavigationModels.Count() > 0
                ? await GetDeserializeObjectAsync<FunctionListModel>("navs", "get_functions", $"linkIds={string.Join(",", RoleNavigationModels)}")
                : await GetDeserializeObjectAsync<FunctionListModel>("navs", "get_functions");
        }

        private async Task RefreshOrganizationListModelsAsync()
        {
            BindingOrganizationModels = await GetDeserializeObjectAsync<OrganizationListModel>("organizations");
        }

        private async Task RefreshTreeNavigationAsync()
        {
            await RefreshNavigationListModelsAsync();

            treeNavigation.RefreshDataSource(BindingNavigationModels);

            SetCheckedNavigationNode();
        }

        private async Task RefreshTreeFunctionAsync()
        {
            await RefreshFunctionListModelsAsync();

            treeFunction.RefreshDataSource(BindingFunctionModels);

            SetCheckedFunctionNode();
        }

        private async Task GetRolePermissionsAsync(string roleId)
        {
            RoleNavigationModels = await GetDeserializeObjectAsync<string>("permissions", "get_views", $"roleId={roleId}");
            RoleFunctionModels = await GetDeserializeObjectAsync<string>("permissions", "get_functions", $"roleId={roleId}");
        }

        public IEnumerable<long> GetCheckedNavigations()
        {
            var checkedNavs = new List<long>();

            foreach(var node in treeNavigation.GetAllCheckedNodes())
            {
                if (!Convert.ToBoolean(node.GetValue("IsGroup")))
                    checkedNavs.Add(Convert.ToInt64(node.GetValue("Id")));
            }

            return checkedNavs;
        }

        public IEnumerable<long> GetCheckedFunctions()
        {
            var checkedFuncs = new List<long>();

            foreach(var node in treeFunction.GetAllCheckedNodes())
            {
                if (Convert.ToBoolean(node.GetValue("IsFunction")))
                    checkedFuncs.Add(Convert.ToInt64(node.GetValue("Id")));
            }

            return checkedFuncs;
        }

        public void SetCheckedNavigationNode()
        {
            foreach(var node in treeNavigation.GetNodeList())
            {
                if (RoleNavigationModels.Contains(node.GetValue("Id").ToString()))
                {
                    treeNavigation.SetNodeCheckState(node, CheckState.Checked);
                    treeNavigation.SetParentNodeCheckState(node.ParentNode);
                }
            }
        }

        public void SetCheckedFunctionNode()
        {
            foreach(var node in treeFunction.GetNodeList())
            {
                if (RoleFunctionModels.Contains(node.GetValue("Id").ToString()))
                {
                    treeFunction.SetNodeCheckState(node, CheckState.Checked);
                    treeFunction.SetParentNodeCheckState(node.ParentNode);
                }
            }
        }
        
        public void SetSearchPanelText(string subsidiaryName, string roleName)
        {
            if (!string.IsNullOrWhiteSpace(roleName))
                lcTreeName.Text = $"{subsidiaryName} - {roleName}";
            else
                lcTreeName.Text = subsidiaryName;
        }

        public void SetTabPageText(bool dirty)
        {
            tcgRole.SelectedTabPage.Text = $"{tcgRole.SelectedTabPage.Text}{(dirty ? "*" : string.Empty)}";
        }

        public void SetTabButtonEnabled(bool enabled)
        {
            btnTabRefreshUser.Enabled = enabled;
            btnTabNewUser.Enabled = enabled;

            lcgNavigation.Enabled = enabled;
            lcgFunction.Enabled = enabled;
            lcgOrganization.Enabled = enabled;
        }

        private void BtnTabRefreshUser_Click(object sender, EventArgs e) => IsRefreshGrid = true;

        private void BtnTabNewUser_Click(object sender, EventArgs e)
        {
            FrmUserInRole frm = new FrmUserInRole(
                new UserRoleEditModel()
                {
                    Id = SelectRoleId,
                    Number = SelectRoleNumber
                });

            frm.ShowDialog();
        }

        private async void BtnTabRefreshNav_Click(object sender, EventArgs e) => await RefreshTreeFunctionAsync();

        private async void BtnTabSaveNav_Click(object sender, EventArgs e)
        {
            var roleView = new Dictionary<string, IEnumerable<long>>
            {
                { CurrentTreeModel.As<RoleListModel>().Id.ToString(), GetCheckedNavigations() }
            };

            string content = GetSerializeObject(roleView);

            await ServiceLocator.Resolve<IDataService>().PostAsync("permissions", "add_views_in_role", content);
        }

        private async void BtnTabRefreshFunc_Click(object sender, EventArgs e) => await RefreshTreeNavigationAsync();

        private async void BtnTabSaveFunc_Click(object sender, EventArgs e)
        {
            var roleFunction = new Dictionary<string, IEnumerable<long>>
            {
                { CurrentTreeModel.As<RoleListModel>().Id.ToString(), GetCheckedFunctions() }
            };

            string content = GetSerializeObject(roleFunction);

            await ServiceLocator.Resolve<IDataService>().PostAsync("permissions", "add_functions_in_role", content);
        }

        private async void BtnTabRefreshOrg_Click(object sender, EventArgs e) => await RefreshOrganizationListModelsAsync();

        private void BtnTabSaveOrg_Click(object sender, EventArgs e) { }

        protected override async void TreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            var ctm = CurrentTreeModel?.As<RoleListModel>();

            IsSelectedRole = ctm.Id != ctm.SubsidiaryId;
            SelectRoleId = IsSelectedRole ? ctm.Id : 0;
            SelectRoleNumber = IsSelectedRole ? ctm.Number : string.Empty;

            var subsidiaryName = IsSelectedRole ? BindingTreeModels.FirstOrDefault(x => x.Id == ctm.SubsidiaryId).DisplayName : ctm.DisplayName;
            var roleName = IsSelectedRole ? ctm.DisplayName : string.Empty;

            SetSearchPanelText(subsidiaryName, roleName);

            if (IsSelectedRole)
            {
                await RefreshGridDataAsync();
                await GetRolePermissionsAsync(e.Node.GetValue("Id").ToString());
            }
            else
                tcgRole.SelectedTabPage = lcgUser;

            if (IsSelectedRole && BindingNavigationModels != null)
                await RefreshTreeNavigationAsync();

            if (IsSelectedRole && BindingFunctionModels != null)
                await RefreshTreeFunctionAsync();

            base.TreeList_FocusedNodeChanged(sender, e);
        }

        protected override void TreeList_CustomDrawNodeImages(object sender, CustomDrawNodeImagesEventArgs e)
        {
            e.SelectImageIndex = Convert.ToInt64(e.Node.GetValue("Id")) == Convert.ToInt64(e.Node.GetValue("SubsidiaryId")) ? e.Node.Level : 2;
        }

        protected override void TreeList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            base.TreeList_MouseDoubleClick(sender, e);

            var treeModel = CurrentTreeModel.As<RoleListModel>();

            var editModel = new RoleEditModel()
            {
                Id = treeModel.Id,
                Number = treeModel.Number,
                DisplayName = treeModel.DisplayName,
                Description = treeModel.Description,
                SubsidiaryId = treeModel.SubsidiaryId,
                IsEnabled = treeModel.IsEnabled,
            };

            ShowFormDialog(new FrmRole(editModel));
        }

        private void TcgRole_SelectedPageChanged(object sender, LayoutTabPageChangedEventArgs e)
        {
            if (!IsSelectedRole)
            {
                tcgRole.SelectedTabPage = lcgUser;
                return;
            }

            if (e.Page.Name == lcgNavigation.Name)
                InitTabTreeNavigation();
            else if (e.Page.Name == lcgFunction.Name)
                InitTabTreeFunctionAsync();
            else if (e.Page.Name == lcgOrganization.Name)
                InitTabTreeOrganizationAsync();
        }

        private async void InitTabTreeNavigation()
        {
            if (BindingNavigationModels == null)
            {
                await RefreshNavigationListModelsAsync();

                treeNavigation.Initialize("菜單列表", ImagesHelper.Current.NavigationImages, BindingNavigationModels, true);
                treeNavigation.CustomDrawNodeImages += new CustomDrawNodeImagesEventHandler(TabTreeList_CustomDrawNodeImages);
                treeNavigation.AfterCheckNode += new NodeEventHandler(TreeNavigation_AfterCheckNode);
            }

            SetCheckedNavigationNode();
        }

        private async void InitTabTreeFunctionAsync()
        {
            if (BindingFunctionModels == null)
            {
                await RefreshFunctionListModelsAsync();

                treeFunction.Initialize("功能列表", ImagesHelper.Current.FunctionImages, BindingFunctionModels, true);
                treeFunction.CustomDrawNodeImages += new CustomDrawNodeImagesEventHandler(TabTreeList_CustomDrawNodeImages);
                treeFunction.AfterCheckNode += new NodeEventHandler(TreeFunction_AfterCheckNode);
            }

            SetCheckedFunctionNode();
        }

        private async void InitTabTreeOrganizationAsync()
        {
            if (BindingOrganizationModels == null)
            {
                await RefreshOrganizationListModelsAsync();

                treeOrganization.Initialize("組織機構列表", ImagesHelper.Current.OrganizationImages, BindingOrganizationModels, true);
                treeOrganization.CustomDrawNodeImages += new CustomDrawNodeImagesEventHandler(TabTreeList_CustomDrawNodeImages);
            }
        }

        private void TabTreeList_CustomDrawNodeImages(object sender, CustomDrawNodeImagesEventArgs e)
        {
            e.SelectImageIndex = e.Node.Level;
        }
        
        private void TreeNavigation_AfterCheckNode(object sender, NodeEventArgs e)
        {
            DirtyNavigation = true;
        }

        private void TreeFunction_AfterCheckNode(object sender, NodeEventArgs e)
        {
            DirtyFunction = true;
        }

        private IEnumerable<OrganizationListModel> GetItems(long parentId)
        {
            var items = new List<OrganizationListModel>();
            var children = BindingTreeModels.As<IEnumerable<OrganizationListModel>>().Where(x => x.ParentId == parentId).ToList();
            for (int i = 0; i < children.Count(); i++)
            {
                items.Add(children[i]);
                items.AddRange(GetItems(children[i].Id));
            }
            return items;
        }
    }
}
