namespace TP.WL.ERP.WinForm.Administration.Forms
{
    partial class FrmFunction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFunction));
            this.esiBottom = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciViewLink = new DevExpress.XtraLayout.LayoutControlItem();
            this.tllueViewLink = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.tllueViewLinkTreeList = new DevExpress.XtraTreeList.TreeList();
            this.teNumber = new DevExpress.XtraEditors.TextEdit();
            this.lciNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.teDisplayName = new DevExpress.XtraEditors.TextEdit();
            this.lciDisplayName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciListOrder = new DevExpress.XtraLayout.LayoutControlItem();
            this.seListOrder = new DevExpress.XtraEditors.SpinEdit();
            this.lciIsEnabled = new DevExpress.XtraLayout.LayoutControlItem();
            this.rgIsEnabled = new DevExpress.XtraEditors.RadioGroup();
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
            ((System.ComponentModel.ISupportInitialize)(this.esiBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciViewLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueViewLink.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueViewLinkTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDisplayName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDisplayName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciListOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seListOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIsEnabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgIsEnabled.Properties)).BeginInit();
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
            this.lcMain.Controls.Add(this.rgIsEnabled);
            this.lcMain.Controls.Add(this.seListOrder);
            this.lcMain.Controls.Add(this.tllueViewLink);
            this.lcMain.Size = new System.Drawing.Size(480, 211);
            // 
            // lcgM
            // 
            this.lcgM.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.esiBottom,
            this.lciViewLink,
            this.lciNumber,
            this.lciDisplayName,
            this.lciListOrder,
            this.lciIsEnabled});
            this.lcgM.Size = new System.Drawing.Size(480, 211);
            // 
            // pcButton
            // 
            this.pcButton.Size = new System.Drawing.Size(484, 46);
            // 
            // lcButton
            // 
            this.lcButton.Size = new System.Drawing.Size(480, 42);
            this.lcButton.Controls.SetChildIndex(this.btnPrint, 0);
            this.lcButton.Controls.SetChildIndex(this.btnDelete, 0);
            this.lcButton.Controls.SetChildIndex(this.btnSave, 0);
            this.lcButton.Controls.SetChildIndex(this.btnSaveAndNew, 0);
            this.lcButton.Controls.SetChildIndex(this.btnClose, 0);
            // 
            // lcgButton
            // 
            this.lcgButton.Size = new System.Drawing.Size(480, 42);
            // 
            // lciBtnSave
            // 
            this.lciBtnSave.Location = new System.Drawing.Point(170, 0);
            // 
            // lciBtnSaveAndNew
            // 
            this.lciBtnSaveAndNew.Location = new System.Drawing.Point(275, 0);
            // 
            // lciBtnClose
            // 
            this.lciBtnClose.Location = new System.Drawing.Point(380, 0);
            // 
            // esiButton
            // 
            this.esiButton.Location = new System.Drawing.Point(160, 0);
            this.esiButton.Size = new System.Drawing.Size(10, 36);
            // 
            // esiBottom
            // 
            this.esiBottom.AllowHotTrack = false;
            this.esiBottom.Location = new System.Drawing.Point(0, 130);
            this.esiBottom.Name = "esiBottom";
            this.esiBottom.Size = new System.Drawing.Size(460, 61);
            this.esiBottom.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciViewLink
            // 
            this.lciViewLink.Control = this.tllueViewLink;
            this.lciViewLink.Location = new System.Drawing.Point(0, 0);
            this.lciViewLink.Name = "lciViewLink";
            this.lciViewLink.Size = new System.Drawing.Size(460, 24);
            this.lciViewLink.Text = "所屬菜單";
            this.lciViewLink.TextSize = new System.Drawing.Size(48, 14);
            // 
            // tllueViewLink
            // 
            this.tllueViewLink.Location = new System.Drawing.Point(64, 12);
            this.tllueViewLink.Name = "tllueViewLink";
            this.tllueViewLink.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tllueViewLink.Properties.NullText = "";
            this.tllueViewLink.Properties.TreeList = this.tllueViewLinkTreeList;
            this.tllueViewLink.Size = new System.Drawing.Size(404, 20);
            this.tllueViewLink.StyleController = this.lcMain;
            this.tllueViewLink.TabIndex = 4;
            // 
            // tllueViewLinkTreeList
            // 
            this.tllueViewLinkTreeList.Location = new System.Drawing.Point(0, 0);
            this.tllueViewLinkTreeList.Name = "tllueViewLinkTreeList";
            this.tllueViewLinkTreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.tllueViewLinkTreeList.Size = new System.Drawing.Size(400, 200);
            this.tllueViewLinkTreeList.TabIndex = 0;
            // 
            // teNumber
            // 
            this.teNumber.Location = new System.Drawing.Point(64, 36);
            this.teNumber.Name = "teNumber";
            this.teNumber.Size = new System.Drawing.Size(404, 20);
            this.teNumber.StyleController = this.lcMain;
            this.teNumber.TabIndex = 5;
            // 
            // lciNumber
            // 
            this.lciNumber.Control = this.teNumber;
            this.lciNumber.Location = new System.Drawing.Point(0, 24);
            this.lciNumber.Name = "lciNumber";
            this.lciNumber.Size = new System.Drawing.Size(460, 24);
            this.lciNumber.Text = "功能編碼";
            this.lciNumber.TextSize = new System.Drawing.Size(48, 14);
            // 
            // teDisplayName
            // 
            this.teDisplayName.Location = new System.Drawing.Point(64, 60);
            this.teDisplayName.Name = "teDisplayName";
            this.teDisplayName.Size = new System.Drawing.Size(404, 20);
            this.teDisplayName.StyleController = this.lcMain;
            this.teDisplayName.TabIndex = 6;
            // 
            // lciDisplayName
            // 
            this.lciDisplayName.Control = this.teDisplayName;
            this.lciDisplayName.Location = new System.Drawing.Point(0, 48);
            this.lciDisplayName.Name = "lciDisplayName";
            this.lciDisplayName.Size = new System.Drawing.Size(460, 24);
            this.lciDisplayName.Text = "功能名稱";
            this.lciDisplayName.TextSize = new System.Drawing.Size(48, 14);
            // 
            // lciListOrder
            // 
            this.lciListOrder.Control = this.seListOrder;
            this.lciListOrder.Location = new System.Drawing.Point(0, 72);
            this.lciListOrder.Name = "lciListOrder";
            this.lciListOrder.Size = new System.Drawing.Size(460, 24);
            this.lciListOrder.Text = "排序";
            this.lciListOrder.TextSize = new System.Drawing.Size(48, 14);
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
            // lciIsEnabled
            // 
            this.lciIsEnabled.Control = this.rgIsEnabled;
            this.lciIsEnabled.Location = new System.Drawing.Point(0, 96);
            this.lciIsEnabled.Name = "lciIsEnabled";
            this.lciIsEnabled.Size = new System.Drawing.Size(460, 34);
            this.lciIsEnabled.Text = "狀態";
            this.lciIsEnabled.TextSize = new System.Drawing.Size(48, 14);
            // 
            // rgIsEnabled
            // 
            this.rgIsEnabled.Location = new System.Drawing.Point(64, 108);
            this.rgIsEnabled.Name = "rgIsEnabled";
            this.rgIsEnabled.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgIsEnabled.Properties.Appearance.Options.UseBackColor = true;
            this.rgIsEnabled.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgIsEnabled.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "啟用"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "禁用")});
            this.rgIsEnabled.Size = new System.Drawing.Size(404, 30);
            this.rgIsEnabled.StyleController = this.lcMain;
            this.rgIsEnabled.TabIndex = 8;
            // 
            // FrmFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFunction";
            this.Text = "菜單功能";
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
            ((System.ComponentModel.ISupportInitialize)(this.esiBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciViewLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueViewLink.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueViewLinkTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDisplayName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDisplayName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciListOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seListOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIsEnabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgIsEnabled.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.EmptySpaceItem esiBottom;
        private DevExpress.XtraLayout.LayoutControlItem lciViewLink;
        private DevExpress.XtraEditors.TextEdit teDisplayName;
        private DevExpress.XtraEditors.TextEdit teNumber;
        private DevExpress.XtraLayout.LayoutControlItem lciNumber;
        private DevExpress.XtraLayout.LayoutControlItem lciDisplayName;
        private DevExpress.XtraLayout.LayoutControlItem lciListOrder;
        private DevExpress.XtraLayout.LayoutControlItem lciIsEnabled;
        private DevExpress.XtraEditors.RadioGroup rgIsEnabled;
        private DevExpress.XtraEditors.SpinEdit seListOrder;
        private DevExpress.XtraEditors.TreeListLookUpEdit tllueViewLink;
        private DevExpress.XtraTreeList.TreeList tllueViewLinkTreeList;
    }
}