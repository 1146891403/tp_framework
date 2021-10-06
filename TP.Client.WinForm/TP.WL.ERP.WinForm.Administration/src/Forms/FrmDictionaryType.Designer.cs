namespace TP.WL.ERP.WinForm.Administration.Forms
{
    partial class FrmDictionaryType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDictionaryType));
            this.teNumber = new DevExpress.XtraEditors.TextEdit();
            this.lciNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.teDisplayName = new DevExpress.XtraEditors.TextEdit();
            this.lciDisplayName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciParent = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueParent = new DevExpress.XtraEditors.LookUpEdit();
            this.lciLevel = new DevExpress.XtraLayout.LayoutControlItem();
            this.seListOrder = new DevExpress.XtraEditors.SpinEdit();
            this.lciRemark = new DevExpress.XtraLayout.LayoutControlItem();
            this.meRemark = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).BeginInit();
            this.pcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcButton)).BeginInit();
            this.pcButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDisplayName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDisplayName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueParent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seListOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meRemark.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pcMain
            // 
            this.pcMain.Size = new System.Drawing.Size(484, 215);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.teDisplayName);
            this.lcMain.Controls.Add(this.teNumber);
            this.lcMain.Controls.Add(this.meRemark);
            this.lcMain.Controls.Add(this.lueParent);
            this.lcMain.Controls.Add(this.seListOrder);
            this.lcMain.Size = new System.Drawing.Size(480, 211);
            // 
            // lcgM
            // 
            this.lcgM.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciNumber,
            this.lciDisplayName,
            this.lciParent,
            this.lciLevel,
            this.lciRemark});
            this.lcgM.Size = new System.Drawing.Size(480, 211);
            // 
            // pcButton
            // 
            this.pcButton.Size = new System.Drawing.Size(484, 46);
            // 
            // teNumber
            // 
            this.teNumber.Location = new System.Drawing.Point(64, 12);
            this.teNumber.Name = "teNumber";
            this.teNumber.Size = new System.Drawing.Size(404, 20);
            this.teNumber.StyleController = this.lcMain;
            this.teNumber.TabIndex = 4;
            // 
            // lciNumber
            // 
            this.lciNumber.Control = this.teNumber;
            this.lciNumber.Location = new System.Drawing.Point(0, 0);
            this.lciNumber.Name = "lciNumber";
            this.lciNumber.Size = new System.Drawing.Size(460, 24);
            this.lciNumber.Text = "類型編號";
            this.lciNumber.TextSize = new System.Drawing.Size(48, 14);
            // 
            // teDisplayName
            // 
            this.teDisplayName.Location = new System.Drawing.Point(64, 36);
            this.teDisplayName.Name = "teDisplayName";
            this.teDisplayName.Size = new System.Drawing.Size(404, 20);
            this.teDisplayName.StyleController = this.lcMain;
            this.teDisplayName.TabIndex = 5;
            // 
            // lciDisplayName
            // 
            this.lciDisplayName.Control = this.teDisplayName;
            this.lciDisplayName.Location = new System.Drawing.Point(0, 24);
            this.lciDisplayName.Name = "lciDisplayName";
            this.lciDisplayName.Size = new System.Drawing.Size(460, 24);
            this.lciDisplayName.Text = "類型名稱";
            this.lciDisplayName.TextSize = new System.Drawing.Size(48, 14);
            // 
            // lciParent
            // 
            this.lciParent.Control = this.lueParent;
            this.lciParent.Location = new System.Drawing.Point(0, 48);
            this.lciParent.Name = "lciParent";
            this.lciParent.Size = new System.Drawing.Size(460, 24);
            this.lciParent.Text = "上級類型";
            this.lciParent.TextSize = new System.Drawing.Size(48, 14);
            // 
            // lueParent
            // 
            this.lueParent.Location = new System.Drawing.Point(64, 60);
            this.lueParent.Name = "lueParent";
            this.lueParent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueParent.Properties.NullText = "";
            this.lueParent.Size = new System.Drawing.Size(404, 20);
            this.lueParent.StyleController = this.lcMain;
            this.lueParent.TabIndex = 6;
            // 
            // lciLevel
            // 
            this.lciLevel.Control = this.seListOrder;
            this.lciLevel.Location = new System.Drawing.Point(0, 72);
            this.lciLevel.Name = "lciLevel";
            this.lciLevel.Size = new System.Drawing.Size(460, 24);
            this.lciLevel.Text = "排序";
            this.lciLevel.TextSize = new System.Drawing.Size(48, 14);
            // 
            // seListOrder
            // 
            this.seListOrder.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seListOrder.Location = new System.Drawing.Point(64, 84);
            this.seListOrder.Name = "seListOrder";
            this.seListOrder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seListOrder.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.seListOrder.Properties.IsFloatValue = false;
            this.seListOrder.Properties.Mask.EditMask = "N00";
            this.seListOrder.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.seListOrder.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.seListOrder.Size = new System.Drawing.Size(404, 20);
            this.seListOrder.StyleController = this.lcMain;
            this.seListOrder.TabIndex = 7;
            // 
            // lciRemark
            // 
            this.lciRemark.Control = this.meRemark;
            this.lciRemark.Location = new System.Drawing.Point(0, 96);
            this.lciRemark.Name = "lciRemark";
            this.lciRemark.Size = new System.Drawing.Size(460, 95);
            this.lciRemark.Text = "備註";
            this.lciRemark.TextSize = new System.Drawing.Size(48, 14);
            // 
            // meRemark
            // 
            this.meRemark.Location = new System.Drawing.Point(64, 108);
            this.meRemark.Name = "meRemark";
            this.meRemark.Size = new System.Drawing.Size(404, 91);
            this.meRemark.StyleController = this.lcMain;
            this.meRemark.TabIndex = 8;
            // 
            // FrmDictionaryType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDictionaryType";
            this.Text = "字典類型";
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).EndInit();
            this.pcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcButton)).EndInit();
            this.pcButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDisplayName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDisplayName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciParent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueParent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seListOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meRemark.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit teDisplayName;
        private DevExpress.XtraEditors.TextEdit teNumber;
        private DevExpress.XtraLayout.LayoutControlItem lciNumber;
        private DevExpress.XtraLayout.LayoutControlItem lciDisplayName;
        private DevExpress.XtraLayout.LayoutControlItem lciParent;
        private DevExpress.XtraLayout.LayoutControlItem lciLevel;
        private DevExpress.XtraLayout.LayoutControlItem lciRemark;
        private DevExpress.XtraEditors.MemoEdit meRemark;
        private DevExpress.XtraEditors.LookUpEdit lueParent;
        private DevExpress.XtraEditors.SpinEdit seListOrder;
    }
}