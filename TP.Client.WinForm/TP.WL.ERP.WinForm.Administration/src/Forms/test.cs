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

namespace TP.WL.ERP.WinForm.Administration.Forms
{
    public partial class test : XtraForm
    {
        public test()
        {
            InitializeComponent();

            listBoxControl1.ContextButtonClick += ListBoxControl1_ContextButtonClick;
            buttonEdit1.ButtonClick += ButtonEdit1_ButtonClick;
            listView1.DoubleClick += ListView1_DoubleClick;
        }
        
        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void ButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MessageBox.Show("111");
        }

        private void ListBoxControl1_ContextButtonClick(object sender, DevExpress.Utils.ContextItemClickEventArgs e)
        {
            MessageBox.Show(e.DataItem.ToString());
        }
    }
}