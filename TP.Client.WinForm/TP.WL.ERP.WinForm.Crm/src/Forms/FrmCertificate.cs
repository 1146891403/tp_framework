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
using TP.WL.ERP.Model.Crm;

namespace TP.WL.ERP.WinForm.Crm.Forms
{
    public partial class FrmCertificate : FrmEditBase
    {
        public FrmCertificate()
        {
            InitializeComponent();
        }

        public FrmCertificate(CertificateEditModel model) : base(model)
        {
            InitializeComponent();
        }
    }
}