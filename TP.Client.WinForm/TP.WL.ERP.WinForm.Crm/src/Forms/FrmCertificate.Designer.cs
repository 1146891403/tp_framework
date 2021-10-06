namespace TP.WL.ERP.WinForm.Crm.Forms
{
    partial class FrmCertificate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCertificate));
            this.teDisplayName = new DevExpress.XtraEditors.TextEdit();
            this.lciDisplayName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciStartDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.deStartDate = new DevExpress.XtraEditors.DateEdit();
            this.lciEndDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.deEndDate = new DevExpress.XtraEditors.DateEdit();
            this.lciIsGuarantee = new DevExpress.XtraLayout.LayoutControlItem();
            this.rgIsGuarantee = new DevExpress.XtraEditors.RadioGroup();
            this.lciIsTestReport = new DevExpress.XtraLayout.LayoutControlItem();
            this.rgIsTestReport = new DevExpress.XtraEditors.RadioGroup();
            this.lciIsGuaranteeOrReport = new DevExpress.XtraLayout.LayoutControlItem();
            this.rgIsGuaranteeOrReport = new DevExpress.XtraEditors.RadioGroup();
            this.lciLifetimeScope = new DevExpress.XtraLayout.LayoutControlItem();
            this.seLifetimeScope = new DevExpress.XtraEditors.SpinEdit();
            this.esiBottom = new DevExpress.XtraLayout.EmptySpaceItem();
            this.teNumber = new DevExpress.XtraEditors.TextEdit();
            this.lciNumber = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.teDisplayName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDisplayName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIsGuarantee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgIsGuarantee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIsTestReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgIsTestReport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIsGuaranteeOrReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgIsGuaranteeOrReport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLifetimeScope)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seLifetimeScope.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // pcMain
            // 
            this.pcMain.Size = new System.Drawing.Size(434, 265);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.teDisplayName);
            this.lcMain.Controls.Add(this.deStartDate);
            this.lcMain.Controls.Add(this.deEndDate);
            this.lcMain.Controls.Add(this.seLifetimeScope);
            this.lcMain.Controls.Add(this.rgIsGuaranteeOrReport);
            this.lcMain.Controls.Add(this.rgIsTestReport);
            this.lcMain.Controls.Add(this.rgIsGuarantee);
            this.lcMain.Controls.Add(this.teNumber);
            this.lcMain.Size = new System.Drawing.Size(430, 261);
            // 
            // lcgM
            // 
            this.lcgM.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDisplayName,
            this.lciStartDate,
            this.esiBottom,
            this.lciIsGuarantee,
            this.lciIsGuaranteeOrReport,
            this.lciNumber,
            this.lciIsTestReport,
            this.lciLifetimeScope,
            this.lciEndDate});
            this.lcgM.Size = new System.Drawing.Size(430, 261);
            // 
            // lcButton
            // 
            this.lcButton.Size = new System.Drawing.Size(430, 42);
            this.lcButton.Controls.SetChildIndex(this.btnPrint, 0);
            this.lcButton.Controls.SetChildIndex(this.btnDelete, 0);
            this.lcButton.Controls.SetChildIndex(this.btnSave, 0);
            this.lcButton.Controls.SetChildIndex(this.btnSaveAndNew, 0);
            this.lcButton.Controls.SetChildIndex(this.btnClose, 0);
            // 
            // lcgButton
            // 
            this.lcgButton.Size = new System.Drawing.Size(430, 42);
            // 
            // lciBtnSave
            // 
            this.lciBtnSave.Location = new System.Drawing.Point(170, 0);
            // 
            // lciBtnSaveAndNew
            // 
            this.lciBtnSaveAndNew.Location = new System.Drawing.Point(250, 0);
            // 
            // lciBtnClose
            // 
            this.lciBtnClose.Location = new System.Drawing.Point(330, 0);
            // 
            // esiButton
            // 
            this.esiButton.Location = new System.Drawing.Point(160, 0);
            this.esiButton.Size = new System.Drawing.Size(10, 36);
            // 
            // teDisplayName
            // 
            this.teDisplayName.Location = new System.Drawing.Point(81, 36);
            this.teDisplayName.Name = "teDisplayName";
            this.teDisplayName.Size = new System.Drawing.Size(337, 20);
            this.teDisplayName.StyleController = this.lcMain;
            this.teDisplayName.TabIndex = 4;
            // 
            // lciDisplayName
            // 
            this.lciDisplayName.Control = this.teDisplayName;
            this.lciDisplayName.Location = new System.Drawing.Point(0, 24);
            this.lciDisplayName.Name = "lciDisplayName";
            this.lciDisplayName.Size = new System.Drawing.Size(410, 24);
            this.lciDisplayName.Text = "認證名稱";
            this.lciDisplayName.TextSize = new System.Drawing.Size(65, 14);
            // 
            // lciStartDate
            // 
            this.lciStartDate.Control = this.deStartDate;
            this.lciStartDate.Location = new System.Drawing.Point(0, 156);
            this.lciStartDate.MaxSize = new System.Drawing.Size(0, 24);
            this.lciStartDate.MinSize = new System.Drawing.Size(280, 24);
            this.lciStartDate.Name = "lciStartDate";
            this.lciStartDate.Size = new System.Drawing.Size(410, 24);
            this.lciStartDate.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciStartDate.Text = "生效日期";
            this.lciStartDate.TextSize = new System.Drawing.Size(65, 14);
            // 
            // deStartDate
            // 
            this.deStartDate.EditValue = null;
            this.deStartDate.Location = new System.Drawing.Point(81, 168);
            this.deStartDate.Name = "deStartDate";
            this.deStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deStartDate.Properties.DisplayFormat.FormatString = "";
            this.deStartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deStartDate.Properties.EditFormat.FormatString = "";
            this.deStartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deStartDate.Properties.Mask.EditMask = "";
            this.deStartDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.deStartDate.Size = new System.Drawing.Size(337, 20);
            this.deStartDate.StyleController = this.lcMain;
            this.deStartDate.TabIndex = 5;
            // 
            // lciEndDate
            // 
            this.lciEndDate.Control = this.deEndDate;
            this.lciEndDate.Location = new System.Drawing.Point(0, 180);
            this.lciEndDate.MaxSize = new System.Drawing.Size(0, 24);
            this.lciEndDate.MinSize = new System.Drawing.Size(280, 24);
            this.lciEndDate.Name = "lciEndDate";
            this.lciEndDate.Size = new System.Drawing.Size(410, 24);
            this.lciEndDate.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciEndDate.Text = "最後限期";
            this.lciEndDate.TextSize = new System.Drawing.Size(65, 14);
            // 
            // deEndDate
            // 
            this.deEndDate.EditValue = null;
            this.deEndDate.Location = new System.Drawing.Point(81, 192);
            this.deEndDate.Name = "deEndDate";
            this.deEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deEndDate.Properties.DisplayFormat.FormatString = "";
            this.deEndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deEndDate.Properties.EditFormat.FormatString = "";
            this.deEndDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deEndDate.Properties.Mask.EditMask = "";
            this.deEndDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.deEndDate.Size = new System.Drawing.Size(337, 20);
            this.deEndDate.StyleController = this.lcMain;
            this.deEndDate.TabIndex = 6;
            // 
            // lciIsGuarantee
            // 
            this.lciIsGuarantee.Control = this.rgIsGuarantee;
            this.lciIsGuarantee.Location = new System.Drawing.Point(0, 48);
            this.lciIsGuarantee.MaxSize = new System.Drawing.Size(0, 27);
            this.lciIsGuarantee.MinSize = new System.Drawing.Size(280, 27);
            this.lciIsGuarantee.Name = "lciIsGuarantee";
            this.lciIsGuarantee.Size = new System.Drawing.Size(410, 27);
            this.lciIsGuarantee.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciIsGuarantee.Text = "保證書";
            this.lciIsGuarantee.TextSize = new System.Drawing.Size(65, 14);
            // 
            // rgIsGuarantee
            // 
            this.rgIsGuarantee.Location = new System.Drawing.Point(81, 60);
            this.rgIsGuarantee.Name = "rgIsGuarantee";
            this.rgIsGuarantee.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgIsGuarantee.Properties.Appearance.Options.UseBackColor = true;
            this.rgIsGuarantee.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgIsGuarantee.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "是"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "否")});
            this.rgIsGuarantee.Size = new System.Drawing.Size(337, 23);
            this.rgIsGuarantee.StyleController = this.lcMain;
            this.rgIsGuarantee.TabIndex = 7;
            // 
            // lciIsTestReport
            // 
            this.lciIsTestReport.Control = this.rgIsTestReport;
            this.lciIsTestReport.Location = new System.Drawing.Point(0, 75);
            this.lciIsTestReport.MaxSize = new System.Drawing.Size(0, 27);
            this.lciIsTestReport.MinSize = new System.Drawing.Size(280, 27);
            this.lciIsTestReport.Name = "lciIsTestReport";
            this.lciIsTestReport.Size = new System.Drawing.Size(410, 27);
            this.lciIsTestReport.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciIsTestReport.Text = "檢測報告";
            this.lciIsTestReport.TextSize = new System.Drawing.Size(65, 14);
            // 
            // rgIsTestReport
            // 
            this.rgIsTestReport.Location = new System.Drawing.Point(81, 87);
            this.rgIsTestReport.Name = "rgIsTestReport";
            this.rgIsTestReport.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgIsTestReport.Properties.Appearance.Options.UseBackColor = true;
            this.rgIsTestReport.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgIsTestReport.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "是"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "否")});
            this.rgIsTestReport.Size = new System.Drawing.Size(337, 23);
            this.rgIsTestReport.StyleController = this.lcMain;
            this.rgIsTestReport.TabIndex = 8;
            // 
            // lciIsGuaranteeOrReport
            // 
            this.lciIsGuaranteeOrReport.Control = this.rgIsGuaranteeOrReport;
            this.lciIsGuaranteeOrReport.Location = new System.Drawing.Point(0, 102);
            this.lciIsGuaranteeOrReport.MaxSize = new System.Drawing.Size(0, 27);
            this.lciIsGuaranteeOrReport.MinSize = new System.Drawing.Size(280, 27);
            this.lciIsGuaranteeOrReport.Name = "lciIsGuaranteeOrReport";
            this.lciIsGuaranteeOrReport.Size = new System.Drawing.Size(410, 27);
            this.lciIsGuaranteeOrReport.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciIsGuaranteeOrReport.Text = "保證書/報告";
            this.lciIsGuaranteeOrReport.TextSize = new System.Drawing.Size(65, 14);
            // 
            // rgIsGuaranteeOrReport
            // 
            this.rgIsGuaranteeOrReport.Location = new System.Drawing.Point(81, 114);
            this.rgIsGuaranteeOrReport.Name = "rgIsGuaranteeOrReport";
            this.rgIsGuaranteeOrReport.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgIsGuaranteeOrReport.Properties.Appearance.Options.UseBackColor = true;
            this.rgIsGuaranteeOrReport.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgIsGuaranteeOrReport.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "是"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "否")});
            this.rgIsGuaranteeOrReport.Size = new System.Drawing.Size(337, 23);
            this.rgIsGuaranteeOrReport.StyleController = this.lcMain;
            this.rgIsGuaranteeOrReport.TabIndex = 9;
            // 
            // lciLifetimeScope
            // 
            this.lciLifetimeScope.Control = this.seLifetimeScope;
            this.lciLifetimeScope.Location = new System.Drawing.Point(0, 129);
            this.lciLifetimeScope.MaxSize = new System.Drawing.Size(0, 27);
            this.lciLifetimeScope.MinSize = new System.Drawing.Size(280, 27);
            this.lciLifetimeScope.Name = "lciLifetimeScope";
            this.lciLifetimeScope.Size = new System.Drawing.Size(410, 27);
            this.lciLifetimeScope.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciLifetimeScope.Text = "年限";
            this.lciLifetimeScope.TextSize = new System.Drawing.Size(65, 14);
            // 
            // seLifetimeScope
            // 
            this.seLifetimeScope.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seLifetimeScope.Location = new System.Drawing.Point(81, 141);
            this.seLifetimeScope.Name = "seLifetimeScope";
            this.seLifetimeScope.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seLifetimeScope.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.seLifetimeScope.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.seLifetimeScope.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.seLifetimeScope.Size = new System.Drawing.Size(337, 20);
            this.seLifetimeScope.StyleController = this.lcMain;
            this.seLifetimeScope.TabIndex = 10;
            // 
            // esiBottom
            // 
            this.esiBottom.AllowHotTrack = false;
            this.esiBottom.Location = new System.Drawing.Point(0, 204);
            this.esiBottom.MinSize = new System.Drawing.Size(60, 8);
            this.esiBottom.Name = "esiBottom";
            this.esiBottom.Size = new System.Drawing.Size(410, 37);
            this.esiBottom.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.esiBottom.TextSize = new System.Drawing.Size(0, 0);
            // 
            // teNumber
            // 
            this.teNumber.Location = new System.Drawing.Point(81, 12);
            this.teNumber.Name = "teNumber";
            this.teNumber.Size = new System.Drawing.Size(337, 20);
            this.teNumber.StyleController = this.lcMain;
            this.teNumber.TabIndex = 11;
            // 
            // lciNumber
            // 
            this.lciNumber.Control = this.teNumber;
            this.lciNumber.Location = new System.Drawing.Point(0, 0);
            this.lciNumber.Name = "lciNumber";
            this.lciNumber.Size = new System.Drawing.Size(410, 24);
            this.lciNumber.Text = "編號";
            this.lciNumber.TextSize = new System.Drawing.Size(65, 14);
            // 
            // FrmCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCertificate";
            this.Text = "安規";
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
            ((System.ComponentModel.ISupportInitialize)(this.teDisplayName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDisplayName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIsGuarantee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgIsGuarantee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIsTestReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgIsTestReport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIsGuaranteeOrReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgIsGuaranteeOrReport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLifetimeScope)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seLifetimeScope.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit teDisplayName;
        private DevExpress.XtraLayout.LayoutControlItem lciDisplayName;
        private DevExpress.XtraLayout.LayoutControlItem lciStartDate;
        private DevExpress.XtraLayout.LayoutControlItem lciEndDate;
        private DevExpress.XtraEditors.DateEdit deStartDate;
        private DevExpress.XtraEditors.DateEdit deEndDate;
        private DevExpress.XtraLayout.LayoutControlItem lciIsGuarantee;
        private DevExpress.XtraLayout.LayoutControlItem lciIsTestReport;
        private DevExpress.XtraLayout.LayoutControlItem lciIsGuaranteeOrReport;
        private DevExpress.XtraLayout.LayoutControlItem lciLifetimeScope;
        private DevExpress.XtraEditors.SpinEdit seLifetimeScope;
        private DevExpress.XtraEditors.RadioGroup rgIsGuaranteeOrReport;
        private DevExpress.XtraEditors.RadioGroup rgIsTestReport;
        private DevExpress.XtraEditors.RadioGroup rgIsGuarantee;
        private DevExpress.XtraLayout.EmptySpaceItem esiBottom;
        private DevExpress.XtraEditors.TextEdit teNumber;
        private DevExpress.XtraLayout.LayoutControlItem lciNumber;
    }
}