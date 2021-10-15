using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TP.Client.WinForm.Common.Helpers;

namespace TP.WL.ERP.WinForm
{
    public partial class FrmLogin : XtraForm
    {
        private string strUserName = "用戶名";
        private string strPassword = "密碼";
        private string strError = "錯誤：";

        private Point mPoint = new Point();

        public FrmLogin()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(FrmLogin_KeyDown);
            btnLogin.Click += new EventHandler(BtnLogin_Click);

            InitTextComponent();

            InitValidation();
        }

        public FrmLogin(string username, string error) : this()
        {
            if (!string.IsNullOrWhiteSpace(error))
                lcError.Text = $"{strError}{error}";
            else
                lcError.Text = string.Empty;

            teUserName.Text = username;

            teUserName.Text = "userzz";
            tePassword.Text = "qweqwe";
        }

        public string UserName { get; set; }

        public string Password { get; set; }

        private void InitTextComponent()
        {
            teUserName.Text = strUserName;
            tePassword.Text = strPassword;
            tePassword.ForeColor = Color.LightGray;

            teUserName.Enter += new EventHandler(TeUserName_Enter);
            teUserName.Leave += new EventHandler(TeUserName_Leave);
            tePassword.Enter += new EventHandler(TePassword_Enter);
            tePassword.Leave += new EventHandler(TePassword_Leave);
        }

        private void InitValidation()
        {
            dxValidationProvider.SetIconAlignment(teUserName, ErrorIconAlignment.MiddleRight);
            dxValidationProvider.SetIconAlignment(tePassword, ErrorIconAlignment.MiddleRight);

            dxValidationProvider.SetValidationRule(teUserName, ValidationRulesHelper.RuleUserName);
            dxValidationProvider.SetValidationRule(tePassword, ValidationRulesHelper.RulePassword);
        }

        public void Login()
        {
            if (dxValidationProvider.Validate())
            {
                UserName = teUserName.Text;
                Password = tePassword.Text;

                this.Dispose();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Login();
        }
        
        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint.X = e.X;
            mPoint.Y = e.Y;
        }

        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-mPoint.X, -mPoint.Y);
                Location = myPosittion;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e) => Login();

        private void TeUserName_Enter(object sender, EventArgs e)
        {
            if (teUserName.Text == strUserName)
                teUserName.Text = string.Empty;

            teUserName.ForeColor = Color.Black;
        }

        private void TeUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(teUserName.Text))
            {
                teUserName.Text = strUserName;
                teUserName.ForeColor = Color.LightGray;
            }
        }

        private void TePassword_Enter(object sender, EventArgs e)
        {
            if (tePassword.Text == strPassword)
                tePassword.Text = string.Empty;
            
            tePassword.ForeColor = Color.Black;
            tePassword.Properties.UseSystemPasswordChar = true;
        }

        private void TePassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tePassword.Text))
            {
                tePassword.Text = strPassword;
                tePassword.ForeColor = Color.LightGray;
                tePassword.Properties.UseSystemPasswordChar = false;
            }
        }
    }
}