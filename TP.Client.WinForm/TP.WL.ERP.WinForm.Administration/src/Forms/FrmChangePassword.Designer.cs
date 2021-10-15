namespace TP.WL.ERP.WinForm.Administration.Forms
{
    partial class FrmChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangePassword));
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            this.teOldPassword = new DevExpress.XtraEditors.TextEdit();
            this.teNewPassword = new DevExpress.XtraEditors.TextEdit();
            this.teNewPassword1 = new DevExpress.XtraEditors.TextEdit();
            this.lciOldPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNewpassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNewpassword1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).BeginInit();
            this.pcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcButton)).BeginInit();
            this.pcButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcButton)).BeginInit();
            this.lcButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSaveAndNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teOldPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNewPassword1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOldPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNewpassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNewpassword1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // pcMain
            // 
            this.pcMain.Size = new System.Drawing.Size(443, 195);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.teOldPassword);
            this.lcMain.Controls.Add(this.teNewPassword);
            this.lcMain.Controls.Add(this.teNewPassword1);
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(753, 220, 650, 400);
            this.lcMain.Size = new System.Drawing.Size(439, 191);
            // 
            // lcgM
            // 
            this.lcgM.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciOldPassword,
            this.lciNewpassword1,
            this.lciNewpassword,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4});
            this.lcgM.Name = "Root";
            this.lcgM.Size = new System.Drawing.Size(439, 191);
            // 
            // pcButton
            // 
            this.pcButton.Location = new System.Drawing.Point(0, 195);
            this.pcButton.Size = new System.Drawing.Size(443, 46);
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(351, 5);
            // 
            // btnPrint
            // 
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAndNew.ImageOptions.Image")));
            this.btnSaveAndNew.Location = new System.Drawing.Point(271, 5);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(191, 5);
            // 
            // lcButton
            // 
            this.lcButton.Size = new System.Drawing.Size(439, 42);
            this.lcButton.Controls.SetChildIndex(this.btnPrint, 0);
            this.lcButton.Controls.SetChildIndex(this.btnDelete, 0);
            this.lcButton.Controls.SetChildIndex(this.btnSave, 0);
            this.lcButton.Controls.SetChildIndex(this.btnSaveAndNew, 0);
            this.lcButton.Controls.SetChildIndex(this.btnClose, 0);
            // 
            // lcgButton
            // 
            this.lcgButton.Size = new System.Drawing.Size(439, 42);
            // 
            // lciBtnSave
            // 
            this.lciBtnSave.Location = new System.Drawing.Point(179, 0);
            // 
            // lciBtnSaveAndNew
            // 
            this.lciBtnSaveAndNew.Location = new System.Drawing.Point(259, 0);
            // 
            // lciBtnClose
            // 
            this.lciBtnClose.Location = new System.Drawing.Point(339, 0);
            // 
            // esiButton
            // 
            this.esiButton.Location = new System.Drawing.Point(160, 0);
            this.esiButton.Size = new System.Drawing.Size(19, 36);
            // 
            // teOldPassword
            // 
            this.teOldPassword.EditValue = "";
            this.teOldPassword.Location = new System.Drawing.Point(105, 53);
            this.teOldPassword.Name = "teOldPassword";
            this.teOldPassword.Properties.UseSystemPasswordChar = true;
            this.teOldPassword.Size = new System.Drawing.Size(222, 20);
            this.teOldPassword.StyleController = this.lcMain;
            this.teOldPassword.TabIndex = 4;
            // 
            // teNewPassword
            // 
            this.teNewPassword.Location = new System.Drawing.Point(105, 94);
            this.teNewPassword.Name = "teNewPassword";
            this.teNewPassword.Properties.UseSystemPasswordChar = true;
            this.teNewPassword.Size = new System.Drawing.Size(222, 20);
            this.teNewPassword.StyleController = this.lcMain;
            this.teNewPassword.TabIndex = 5;
            // 
            // teNewPassword1
            // 
            this.teNewPassword1.Location = new System.Drawing.Point(105, 135);
            this.teNewPassword1.Name = "teNewPassword1";
            this.teNewPassword1.Properties.UseSystemPasswordChar = true;
            this.teNewPassword1.Size = new System.Drawing.Size(222, 20);
            this.teNewPassword1.StyleController = this.lcMain;
            this.teNewPassword1.TabIndex = 6;
            compareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.Equals;
            compareAgainstControlValidationRule1.Control = this.teNewPassword;
            compareAgainstControlValidationRule1.ErrorText = "两次密码输入不一致!";
            this.dxValidationProvider.SetValidationRule(this.teNewPassword1, compareAgainstControlValidationRule1);
            // 
            // lciOldPassword
            // 
            this.lciOldPassword.Control = this.teOldPassword;
            this.lciOldPassword.Location = new System.Drawing.Point(93, 24);
            this.lciOldPassword.Name = "lciOldPassword";
            this.lciOldPassword.Size = new System.Drawing.Size(226, 41);
            this.lciOldPassword.Text = "旧密码:";
            this.lciOldPassword.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciOldPassword.TextSize = new System.Drawing.Size(88, 14);
            // 
            // lciNewpassword
            // 
            this.lciNewpassword.Control = this.teNewPassword;
            this.lciNewpassword.Location = new System.Drawing.Point(93, 65);
            this.lciNewpassword.Name = "lciNewpassword";
            this.lciNewpassword.OptionsTableLayoutItem.ColumnIndex = 1;
            this.lciNewpassword.Size = new System.Drawing.Size(226, 41);
            this.lciNewpassword.Text = "新密码:";
            this.lciNewpassword.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciNewpassword.TextSize = new System.Drawing.Size(88, 14);
            // 
            // lciNewpassword1
            // 
            this.lciNewpassword1.Control = this.teNewPassword1;
            this.lciNewpassword1.Location = new System.Drawing.Point(93, 106);
            this.lciNewpassword1.Name = "lciNewpassword1";
            this.lciNewpassword1.OptionsTableLayoutItem.RowIndex = 1;
            this.lciNewpassword1.Size = new System.Drawing.Size(226, 41);
            this.lciNewpassword1.Text = "再次输入新密码:";
            this.lciNewpassword1.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciNewpassword1.TextSize = new System.Drawing.Size(88, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(93, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(226, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(93, 171);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(319, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(100, 171);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(93, 147);
            this.emptySpaceItem4.MinSize = new System.Drawing.Size(104, 24);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(226, 24);
            this.emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 241);
            this.Name = "FrmChangePassword";
            this.Text = "密码修改";
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).EndInit();
            this.pcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcButton)).EndInit();
            this.pcButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcButton)).EndInit();
            this.lcButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSaveAndNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teOldPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNewPassword1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOldPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNewpassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNewpassword1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teNewPassword1;
        private DevExpress.XtraEditors.TextEdit teNewPassword;
        private DevExpress.XtraEditors.TextEdit teOldPassword;
        private DevExpress.XtraLayout.LayoutControlItem lciOldPassword;
        private DevExpress.XtraLayout.LayoutControlItem lciNewpassword1;
        private DevExpress.XtraLayout.LayoutControlItem lciNewpassword;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
    }
}