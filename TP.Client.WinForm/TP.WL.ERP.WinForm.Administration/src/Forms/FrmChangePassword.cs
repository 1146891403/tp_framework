using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP.Client.WinForm.Common.Forms;
using TP.Client.WinForm.Common.Helpers;
using TP.WL.ERP.Model.Administration;

namespace TP.WL.ERP.WinForm.Administration.Forms
{
    public partial class FrmChangePassword : FrmEditBase
    {
        public FrmChangePassword()
        {
            InitializeComponent();
            
            //lciOldPassword.DataBindings.Add("Text", Model, "OldPassword");
            //lciNewpassword1.DataBindings.Add("Text", Model, "Newpassword");
        }

        public FrmChangePassword(UserEditModel model) : base(model)
        {
            InitializeComponent();

            InitValidation();
        }
        
        public UserEditModel Model { get { return GetEditModel<UserEditModel>(); } }
        //public UserEditModel Model { get; set; } = new UserEditModel();

        public void InitValidation()
        {
            dxValidationProvider.SetIconAlignment(teOldPassword, ErrorIconAlignment.MiddleRight);
            dxValidationProvider.SetIconAlignment(teNewPassword, ErrorIconAlignment.MiddleRight);
            dxValidationProvider.SetIconAlignment(teNewPassword1, ErrorIconAlignment.MiddleRight);

            dxValidationProvider.SetValidationRule(teOldPassword, ValidationRulesHelper.RulePassword);
            dxValidationProvider.SetValidationRule(teNewPassword, ValidationRulesHelper.RulePassword);
        } 

        protected override void InitializeData()
        {
            if (Model == null)
                return;

            teOldPassword.DataBindings.Add("Text", Model, "OldPassword");
            teNewPassword.DataBindings.Add("Text", Model, "NewPassword");
        }


        protected override async Task SaveDataAsync()
        {
            string content = GetSerializeObject(Model);
            await PutAsync("users", "update_password", content);
        }
    }
}
