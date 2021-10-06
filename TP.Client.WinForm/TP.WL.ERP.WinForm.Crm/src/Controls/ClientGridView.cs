﻿using System;
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
using TP.WL.ERP.WinForm.Crm.Forms;

namespace TP.WL.ERP.WinForm.Crm.Controls
{
    public partial class ClientGridView : GridReportViewBase
    {
        public ClientGridView()
        {
            InitializeComponent();
        }

        protected override void Add()
        {
            FrmClient frm = new FrmClient();
            frm.ShowDialog();
        }
    }
}
