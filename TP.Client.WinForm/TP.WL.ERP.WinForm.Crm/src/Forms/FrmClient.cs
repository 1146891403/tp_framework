using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TP.Client.WinForm.Common.Forms;

namespace TP.WL.ERP.WinForm.Crm.Forms
{
    public partial class FrmClient : FrmEditBase
    {
        public FrmClient()
        {
            InitializeComponent();

            btnNewCertGroup.Click += new EventHandler(BtnNewCertGroup_Click);
            btnNewCert.Click += new EventHandler(BtnNewCert_Click);
            btnNewBrand.Click += new EventHandler(BtnNewBrand_Click);
            btnNewSignFile.Click += new EventHandler(BtnNewSignFile_Click);
            btnNewContact.Click += new EventHandler(BtnNewContact_Click);
            btnNewExpress.Click += new EventHandler(BtnNewExpress_Click);
        }

        private void BtnNewCertGroup_Click(object sender, EventArgs e)
        {
            FrmClientCertificateGroup frm = new FrmClientCertificateGroup();
            frm.ShowDialog();
        }

        private void BtnNewCert_Click(object sender, EventArgs e)
        {
            FrmCertificate frm = new FrmCertificate();
            frm.ShowDialog();
        }

        private void BtnNewBrand_Click(object sender, EventArgs e)
        {
            FrmClientBrand frm = new FrmClientBrand();
            frm.ShowDialog();
        }

        private void BtnNewSignFile_Click(object sender, EventArgs e)
        {
            FrmClientSignFile frm = new FrmClientSignFile();
            frm.ShowDialog();
        }

        private void BtnNewContact_Click(object sender, EventArgs e)
        {
            FrmClientContact frm = new FrmClientContact();
            frm.ShowDialog();
        }

        private void BtnNewExpress_Click(object sender, EventArgs e)
        {
            FrmClientExpress frm = new FrmClientExpress();
            frm.ShowDialog();
        }
    }
}