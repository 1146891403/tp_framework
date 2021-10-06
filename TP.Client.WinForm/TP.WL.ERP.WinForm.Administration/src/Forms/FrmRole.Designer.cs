namespace TP.WL.ERP.WinForm.Administration.Forms
{
    partial class FrmRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRole));
            this.teDisplayName = new DevExpress.XtraEditors.TextEdit();
            this.lciDisplayName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSubsidiary = new DevExpress.XtraLayout.LayoutControlItem();
            this.tllueSubsidiary = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.tllueSubsidiaryTreeList = new DevExpress.XtraTreeList.TreeList();
            this.tlcDisplayName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.lciIsEnabled = new DevExpress.XtraLayout.LayoutControlItem();
            this.rgIsEnabled = new DevExpress.XtraEditors.RadioGroup();
            this.lciDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.meDescription = new DevExpress.XtraEditors.MemoEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.lciSubsidiary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueSubsidiary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueSubsidiaryTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIsEnabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgIsEnabled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pcMain
            // 
            this.pcMain.Size = new System.Drawing.Size(484, 215);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.teDisplayName);
            this.lcMain.Controls.Add(this.meDescription);
            this.lcMain.Controls.Add(this.rgIsEnabled);
            this.lcMain.Controls.Add(this.tllueSubsidiary);
            this.lcMain.Size = new System.Drawing.Size(480, 211);
            // 
            // lcgM
            // 
            this.lcgM.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDisplayName,
            this.lciSubsidiary,
            this.lciIsEnabled,
            this.lciDescription});
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
            // teDisplayName
            // 
            this.teDisplayName.Location = new System.Drawing.Point(64, 12);
            this.teDisplayName.Name = "teDisplayName";
            this.teDisplayName.Size = new System.Drawing.Size(404, 20);
            this.teDisplayName.StyleController = this.lcMain;
            this.teDisplayName.TabIndex = 4;
            // 
            // lciDisplayName
            // 
            this.lciDisplayName.Control = this.teDisplayName;
            this.lciDisplayName.Location = new System.Drawing.Point(0, 0);
            this.lciDisplayName.Name = "lciDisplayName";
            this.lciDisplayName.Size = new System.Drawing.Size(460, 24);
            this.lciDisplayName.Text = "名稱";
            this.lciDisplayName.TextSize = new System.Drawing.Size(48, 14);
            // 
            // lciSubsidiary
            // 
            this.lciSubsidiary.Control = this.tllueSubsidiary;
            this.lciSubsidiary.Location = new System.Drawing.Point(0, 24);
            this.lciSubsidiary.Name = "lciSubsidiary";
            this.lciSubsidiary.Size = new System.Drawing.Size(460, 24);
            this.lciSubsidiary.Text = "所屬公司";
            this.lciSubsidiary.TextSize = new System.Drawing.Size(48, 14);
            // 
            // tllueSubsidiary
            // 
            this.tllueSubsidiary.Location = new System.Drawing.Point(64, 36);
            this.tllueSubsidiary.Name = "tllueSubsidiary";
            this.tllueSubsidiary.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tllueSubsidiary.Properties.NullText = "";
            this.tllueSubsidiary.Properties.TreeList = this.tllueSubsidiaryTreeList;
            this.tllueSubsidiary.Size = new System.Drawing.Size(404, 20);
            this.tllueSubsidiary.StyleController = this.lcMain;
            this.tllueSubsidiary.TabIndex = 5;
            // 
            // tllueSubsidiaryTreeList
            // 
            this.tllueSubsidiaryTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcDisplayName});
            this.tllueSubsidiaryTreeList.Location = new System.Drawing.Point(0, 0);
            this.tllueSubsidiaryTreeList.Name = "tllueSubsidiaryTreeList";
            this.tllueSubsidiaryTreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.tllueSubsidiaryTreeList.Size = new System.Drawing.Size(400, 200);
            this.tllueSubsidiaryTreeList.TabIndex = 0;
            // 
            // tlcDisplayName
            // 
            this.tlcDisplayName.Caption = "公司名稱";
            this.tlcDisplayName.FieldName = "DisplayName";
            this.tlcDisplayName.Name = "tlcDisplayName";
            this.tlcDisplayName.Visible = true;
            this.tlcDisplayName.VisibleIndex = 0;
            // 
            // lciIsEnabled
            // 
            this.lciIsEnabled.Control = this.rgIsEnabled;
            this.lciIsEnabled.Location = new System.Drawing.Point(0, 48);
            this.lciIsEnabled.Name = "lciIsEnabled";
            this.lciIsEnabled.Size = new System.Drawing.Size(460, 40);
            this.lciIsEnabled.Text = "狀態";
            this.lciIsEnabled.TextSize = new System.Drawing.Size(48, 14);
            // 
            // rgIsEnabled
            // 
            this.rgIsEnabled.Location = new System.Drawing.Point(64, 60);
            this.rgIsEnabled.Name = "rgIsEnabled";
            this.rgIsEnabled.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgIsEnabled.Properties.Appearance.Options.UseBackColor = true;
            this.rgIsEnabled.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgIsEnabled.Properties.Columns = 2;
            this.rgIsEnabled.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "啟用"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "禁用")});
            this.rgIsEnabled.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Column;
            this.rgIsEnabled.Size = new System.Drawing.Size(404, 36);
            this.rgIsEnabled.StyleController = this.lcMain;
            this.rgIsEnabled.TabIndex = 6;
            // 
            // lciDescription
            // 
            this.lciDescription.Control = this.meDescription;
            this.lciDescription.Location = new System.Drawing.Point(0, 88);
            this.lciDescription.Name = "lciDescription";
            this.lciDescription.Size = new System.Drawing.Size(460, 103);
            this.lciDescription.Text = "描述";
            this.lciDescription.TextSize = new System.Drawing.Size(48, 14);
            // 
            // meDescription
            // 
            this.meDescription.Location = new System.Drawing.Point(64, 100);
            this.meDescription.Name = "meDescription";
            this.meDescription.Size = new System.Drawing.Size(404, 99);
            this.meDescription.StyleController = this.lcMain;
            this.meDescription.TabIndex = 7;
            // 
            // FrmRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRole";
            this.Text = "角色";
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
            ((System.ComponentModel.ISupportInitialize)(this.lciSubsidiary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueSubsidiary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueSubsidiaryTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIsEnabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgIsEnabled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teDisplayName;
        private DevExpress.XtraEditors.MemoEdit meDescription;
        private DevExpress.XtraEditors.RadioGroup rgIsEnabled;
        private DevExpress.XtraEditors.TreeListLookUpEdit tllueSubsidiary;
        private DevExpress.XtraTreeList.TreeList tllueSubsidiaryTreeList;
        private DevExpress.XtraLayout.LayoutControlItem lciDisplayName;
        private DevExpress.XtraLayout.LayoutControlItem lciSubsidiary;
        private DevExpress.XtraLayout.LayoutControlItem lciIsEnabled;
        private DevExpress.XtraLayout.LayoutControlItem lciDescription;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcDisplayName;
    }
}