namespace TP.Client.WinForm.Common.Controls
{
    partial class ButtonLabel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lcText = new DevExpress.XtraEditors.LabelControl();
            this.labelButton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lcText
            // 
            this.lcText.Location = new System.Drawing.Point(29, 6);
            this.lcText.Name = "lcText";
            this.lcText.Size = new System.Drawing.Size(66, 14);
            this.lcText.TabIndex = 0;
            this.lcText.Text = "ButtonLabel";
            // 
            // labelButton
            // 
            this.labelButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelButton.Location = new System.Drawing.Point(3, 3);
            this.labelButton.Name = "labelButton";
            this.labelButton.Size = new System.Drawing.Size(20, 20);
            this.labelButton.TabIndex = 1;
            this.labelButton.Text = "...";
            // 
            // ButtonLabel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.Controls.Add(this.labelButton);
            this.Controls.Add(this.lcText);
            this.Name = "ButtonLabel";
            this.Size = new System.Drawing.Size(100, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lcText;
        private DevExpress.XtraEditors.SimpleButton labelButton;
    }
}
