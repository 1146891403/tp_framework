using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TP.Client.WinForm.Common.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using TP.WL.ERP.WinForm.Crm.Forms;
using TP.WL.ERP.Model.Crm;

namespace TP.WL.ERP.WinForm.Crm.Controls
{
    public partial class CertificateGridView : GridViewBase
    {
        public CertificateGridView()
        {
            InitializeComponent();
        }

        protected override GridControl Grid { get { return gridCertificate; } }

        protected override GridView MainView { get { return gvCertificate; } }

        protected override ColumnView CurrentView { get { return gridCertificate.MainView as ColumnView; } }

        private void AddCertificate()
        {
            ShowFormDialog(new FrmCertificate(GetCurrentGridEditModel<CertificateEditModel>()));
        }

        private void EditCertificate()
        {
            ShowFormDialog(new FrmCertificate(GetCurrentGridEditModel<CertificateEditModel>()));
        }

        protected override void Add()
        {
            base.Add();
            AddCertificate();
        }

        protected override void Edit()
        {
            base.Edit();

            EditCertificate();
        }

        protected override async Task RefreshGridDataAsync() => await SetBindingGridModelsAsync<CertificateListModel>("certificates");
    }
}
