using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP.Client.WinForm.Common.Controls;
using TP.Client.WinForm.Common.Helpers;
using TP.Infrastructure.Common.Extensions;
using TP.WL.ERP.Model.Administration;
using TP.WL.ERP.WinForm.Administration.Forms;
using TP.WL.ERP.WinForm.Administration.Reports;

namespace TP.WL.ERP.WinForm.Administration.Controls
{
    public partial class UserGridView : GridReportViewBase
    {
        public UserGridView()
        {
            InitializeComponent();
        }

        protected override GridControl Grid { get { return gridUser; } }

        protected override GridView MainView { get { return gvUser; } }

        protected override ColumnView CurrentView { get { return gridUser.MainView as ColumnView; } }

        protected override async Task InitializeEditorsAsync()
        {
            await base.InitializeEditorsAsync();

            EditorHelper.CreateGenderImageComboBox(riicbGender);
        }

        protected override void InitializeReportControl()
        {
            base.InitializeReportControl();

            ReportView reportView = new ReportView
            {
                CanEdit = true,
                CanDelete = true,
                CanApprove = true,
                Dock = DockStyle.Fill,
                Parent = pnlView
            };

            reportView.EditClick += new EventHandler(ReportView_EditClick);
            reportView.PreviousClick += new EventHandler(ReportView_PreviousClick);
            reportView.NextClick += new EventHandler(ReportView_NextClick);

            reportView.Activate(new UserReport());
        }

        private void AddUser()
        {
            ShowFormDialog(new FrmUserProfile(GetCurrentGridEditModel<UserEditModel>()));
        }

        private void EditUser()
        {
            ShowFormDialog(new FrmUserProfile(GetCurrentGridEditModel<UserEditModel>()));
        }

        protected override void Add()
        {
            base.Add();
            AddUser();
        }

        protected override async void Edit()
        {
            base.Edit();

            await SetCurrentGridEditModel<UserEditModel>("users", "get_single", $"id={CurrentGridListModel.As<UserListModel>().UserId}");

            EditUser();
        }

        protected override void AddModelToList()
        {
            base.AddModelToList();

            //BindingModels.Insert(0, new UserListModel()
            //{
            //});
        }

        protected override async Task RefreshGridDataAsync() => await SetBindingGridModelsAsync<UserListModel>("users");

        private void ReportView_PreviousClick(object sender, EventArgs e) => MainView.FocusedRowHandle--;

        private void ReportView_NextClick(object sender, EventArgs e) => MainView.FocusedRowHandle++;

        private void ReportView_EditClick(object sender, EventArgs e) => Edit();
    }
}
