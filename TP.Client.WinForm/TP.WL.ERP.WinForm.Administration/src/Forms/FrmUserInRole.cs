using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP.Client.WinForm.Common;
using TP.Client.WinForm.Common.Controls;
using TP.Client.WinForm.Common.Extensions;
using TP.Client.WinForm.Common.Forms;
using TP.Client.WinForm.Common.Helpers;
using TP.Infrastructure.Common.Dependency;
using TP.Infrastructure.Common.Enums;
using TP.Infrastructure.Common.Extensions;
using TP.WL.ERP.Model.Administration;
using TP.WL.ERP.WinForm.Administration.Properties;

namespace TP.WL.ERP.WinForm.Administration.Forms
{
    public partial class FrmUserInRole : FrmEditBase
    {
        public FrmUserInRole()
        {
            InitializeComponent();
        }

        public FrmUserInRole(UserRoleEditModel model) : base(model)
        {
            InitializeComponent();

            treeOrganization.CustomDrawNodeImages += new CustomDrawNodeImagesEventHandler(TreeOrganization_CustomDrawNodeImages);
            treeOrganization.FocusedNodeChanged += new FocusedNodeChangedEventHandler(TreeOrganization_FocusedNodeChanged);
            gvUser.SelectionChanged += new SelectionChangedEventHandler(GvUser_SelectionChanged);
        }

        public override string FormText => "添加用戶到角色";

        public IEnumerable<OrganizationListModel> BindingOrganizationModels { get; set; }

        public IEnumerable<UserListModel> BindingUserModels { get; set; }

        public UserRoleEditModel Model => GetEditModel<UserRoleEditModel>();

        protected override async Task InitializeEditorsAsync()
        {
            BindingOrganizationModels = await ServiceLocator.Resolve<IDataService>().GetListAsync<OrganizationListModel>("organizations");
        }

        protected override void InitializeData()
        {
            treeOrganization.Initialize("部門列表", ImagesHelper.Current.OrganizationImages, BindingOrganizationModels);

            SetCheckedUsers(Model.Users);
        }
        
        public async Task RefreshUsersAsync(long organizationId, bool isDepartment)
        {
            var action = isDepartment ? "get_users_by_department" : "get_users_by_subsidiary";

            BindingUserModels = await ServiceLocator.Resolve<IDataService>().GetListAsync<UserListModel>("users", action, $"id={organizationId}&&roleid={Model.Id}");

            gridUser.DataSource = BindingUserModels;
        }

        public void SetCheckedUsers()
        {
            foreach(var rowHandle in gvUser.GetSelectedRows())
            {
                var checkedUser = gvUser.GetRow(rowHandle)?.As<UserListModel>();

                SetCheckedUser(checkedUser.UserId, checkedUser.UserName, checkedUser.FullName);
            }
        }

        public void SetCheckedUsers(IDictionary<string, string> users)
        {
            foreach (var us in users)
                SetCheckedUser(us.Key, us.Value);
        }

        public void SetCheckedUser(string id, string username, string fullname = "")
        {
            if (!flpCheckedUser.Controls.ContainsKey(username))
            {
                ButtonLabel bl = new ButtonLabel()
                {
                    Id = id,
                    Name = username,
                    ButtonName = username,
                    ButtonImage = Resources.delete_16x16,
                    LabelText = string.IsNullOrWhiteSpace(fullname) ? username : $"{fullname} ({username})"
                };
                bl.ButtonClick += new EventHandler(ButtonLabel_ButtonClick);

                flpCheckedUser.Controls.Add(bl);
            }
        }

        public void RemoveCheckedUsers()
        {
            foreach (var um in BindingUserModels)
                flpCheckedUser.Controls.RemoveByKey(um.UserName);
        }

        public void RemoveCheckedUser(string username)
        {
            if (flpCheckedUser.Controls.ContainsKey(username))
                flpCheckedUser.Controls.RemoveByKey(username);
        }

        public void SetSelectionGridRow()
        {
            foreach(Control ctrl in flpCheckedUser.Controls)
            {
                if (ctrl.Is<ButtonLabel>())
                {
                    for(var rowHandle = 0; rowHandle < gvUser.RowCount; rowHandle++)
                    {
                        if (ctrl.Name == gvUser.GetRow(rowHandle)?.As<UserListModel>().UserName)
                        {
                            gvUser.SelectRow(rowHandle);
                            break;
                        }
                    }
                }
            }
        }

        protected override async Task SaveDataAsync()
        {
            Model.Users.Clear();

            foreach (Control ctrl in flpCheckedUser.Controls)
            {
                if (ctrl.Is<ButtonLabel>())
                {
                    var bl = ctrl.As<ButtonLabel>();
                    Model.Users.Add(bl.Name, bl.Id);
                }
            }

            var content = GetSerializeObject(Model);

            await PostAsync("permissions", "add_users_in_role", content);
        }

        private void TreeOrganization_CustomDrawNodeImages(object sender, CustomDrawNodeImagesEventArgs e)
        {
            e.SelectImageIndex = e.Node.GetValue("Category").ToString() == OrganizationCategory.Department.ToString() ? 2 : e.Node.Level;
        }

        private async void TreeOrganization_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            await RefreshUsersAsync(Convert.ToInt64(e.Node.GetValue("Id")), !e.Node.GetValue("Id").Equals(e.Node.GetValue("SubsidiaryId")));

            SetSelectionGridRow();
        }
        
        private void GvUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var checkedUser = gvUser.GetRow(e.ControllerRow)?.As<UserListModel>();

            if (e.Action == CollectionChangeAction.Add)
                SetCheckedUser(checkedUser.UserId, checkedUser.UserName, checkedUser.FullName);
            else if (e.Action == CollectionChangeAction.Remove)
                RemoveCheckedUser(checkedUser.UserName);
            else if (gvUser.GetSelectedRows().Length > 0)
                SetCheckedUsers();
            else
                RemoveCheckedUsers();

            SetCheckedUserCount();
        }

        private void ButtonLabel_ButtonClick(object sender, EventArgs e)
        {
            var sBtn = sender.As<SimpleButton>();

            if (flpCheckedUser.Controls.ContainsKey(sBtn.Name))
                flpCheckedUser.Controls.RemoveByKey(sBtn.Name);

            foreach(var rowHandle in gvUser.GetSelectedRows())
            {
                if (sBtn.Name == gvUser.GetRow(rowHandle)?.As<UserListModel>().UserName)
                    gvUser.UnselectRow(rowHandle);
            }

            SetCheckedUserCount();
        }

        private void SetCheckedUserCount()
        {
            sliContent.Text = $"當前選擇【{flpCheckedUser.Controls.Count}】項";
        }
    }
}