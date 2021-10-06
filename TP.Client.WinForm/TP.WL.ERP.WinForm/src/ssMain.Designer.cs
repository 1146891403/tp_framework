namespace TP.WL.ERP.WinForm
{
    partial class ssMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ssMain));
            this.mpbcLoading = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.lcCopyright = new DevExpress.XtraEditors.LabelControl();
            this.lcStatus = new DevExpress.XtraEditors.LabelControl();
            this.peLoading = new DevExpress.XtraEditors.PictureEdit();
            this.peLogo = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.mpbcLoading.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peLoading.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mpbcLoading
            // 
            this.mpbcLoading.EditValue = 0;
            this.mpbcLoading.Location = new System.Drawing.Point(23, 213);
            this.mpbcLoading.Name = "mpbcLoading";
            this.mpbcLoading.Size = new System.Drawing.Size(404, 11);
            this.mpbcLoading.TabIndex = 5;
            // 
            // lcCopyright
            // 
            this.lcCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lcCopyright.Location = new System.Drawing.Point(23, 264);
            this.lcCopyright.Name = "lcCopyright";
            this.lcCopyright.Size = new System.Drawing.Size(131, 14);
            this.lcCopyright.TabIndex = 6;
            this.lcCopyright.Text = "Copyright © 1998-2013";
            // 
            // lcStatus
            // 
            this.lcStatus.Location = new System.Drawing.Point(23, 190);
            this.lcStatus.Name = "lcStatus";
            this.lcStatus.Size = new System.Drawing.Size(55, 14);
            this.lcStatus.TabIndex = 7;
            this.lcStatus.Text = "Starting...";
            // 
            // peLoading
            // 
            this.peLoading.Cursor = System.Windows.Forms.Cursors.Default;
            this.peLoading.EditValue = ((object)(resources.GetObject("peLoading.EditValue")));
            this.peLoading.Location = new System.Drawing.Point(12, 11);
            this.peLoading.Name = "peLoading";
            this.peLoading.Properties.AllowFocused = false;
            this.peLoading.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peLoading.Properties.Appearance.Options.UseBackColor = true;
            this.peLoading.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peLoading.Properties.ShowMenu = false;
            this.peLoading.Size = new System.Drawing.Size(426, 166);
            this.peLoading.TabIndex = 9;
            // 
            // peLogo
            // 
            this.peLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.peLogo.EditValue = ((object)(resources.GetObject("peLogo.EditValue")));
            this.peLogo.Location = new System.Drawing.Point(278, 246);
            this.peLogo.Name = "peLogo";
            this.peLogo.Properties.AllowFocused = false;
            this.peLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peLogo.Properties.Appearance.Options.UseBackColor = true;
            this.peLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peLogo.Properties.ShowMenu = false;
            this.peLogo.Size = new System.Drawing.Size(160, 44);
            this.peLogo.TabIndex = 8;
            // 
            // ssMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 295);
            this.Controls.Add(this.peLoading);
            this.Controls.Add(this.peLogo);
            this.Controls.Add(this.lcStatus);
            this.Controls.Add(this.lcCopyright);
            this.Controls.Add(this.mpbcLoading);
            this.Name = "ssMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mpbcLoading.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peLoading.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl mpbcLoading;
        private DevExpress.XtraEditors.LabelControl lcCopyright;
        private DevExpress.XtraEditors.LabelControl lcStatus;
        private DevExpress.XtraEditors.PictureEdit peLogo;
        private DevExpress.XtraEditors.PictureEdit peLoading;
    }
}
