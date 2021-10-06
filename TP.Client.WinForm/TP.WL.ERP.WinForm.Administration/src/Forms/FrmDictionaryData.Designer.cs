namespace TP.WL.ERP.WinForm.Administration.Forms
{
    partial class FrmDictionaryData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDictionaryData));
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciTypeId = new DevExpress.XtraLayout.LayoutControlItem();
            this.tllueType = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.tllueTypeTreeList = new DevExpress.XtraTreeList.TreeList();
            this.tlcDisplayName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.teDisplayName = new DevExpress.XtraEditors.TextEdit();
            this.lciDisplayName = new DevExpress.XtraLayout.LayoutControlItem();
            this.teValue = new DevExpress.XtraEditors.TextEdit();
            this.lciValue = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciIsEnabled = new DevExpress.XtraLayout.LayoutControlItem();
            this.rgIsEnabled = new DevExpress.XtraEditors.RadioGroup();
            this.lciRemark = new DevExpress.XtraLayout.LayoutControlItem();
            this.meRemark = new DevExpress.XtraEditors.MemoEdit();
            this.lciLevel = new DevExpress.XtraLayout.LayoutControlItem();
            this.seListOrder = new DevExpress.XtraEditors.SpinEdit();
            this.labelAssignment = new DevExpress.XtraEditors.LabelControl();
            this.lciAssignment = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).BeginInit();
            this.pcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcButton)).BeginInit();
            this.pcButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueTypeTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDisplayName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDisplayName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIsEnabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgIsEnabled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seListOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAssignment)).BeginInit();
            this.SuspendLayout();
            // 
            // pcMain
            // 
            this.pcMain.Size = new System.Drawing.Size(484, 215);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.labelAssignment);
            this.lcMain.Controls.Add(this.teValue);
            this.lcMain.Controls.Add(this.teDisplayName);
            this.lcMain.Controls.Add(this.meRemark);
            this.lcMain.Controls.Add(this.rgIsEnabled);
            this.lcMain.Controls.Add(this.seListOrder);
            this.lcMain.Controls.Add(this.tllueType);
            this.lcMain.Size = new System.Drawing.Size(480, 211);
            // 
            // lcgM
            // 
            this.lcgM.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciTypeId,
            this.lciDisplayName,
            this.lciRemark,
            this.lciValue,
            this.lciLevel,
            this.lciAssignment,
            this.lciIsEnabled,
            this.emptySpaceItem2});
            this.lcgM.Size = new System.Drawing.Size(480, 211);
            // 
            // pcButton
            // 
            this.pcButton.Size = new System.Drawing.Size(484, 46);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(219, 72);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(241, 27);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciTypeId
            // 
            this.lciTypeId.Control = this.tllueType;
            this.lciTypeId.Location = new System.Drawing.Point(0, 0);
            this.lciTypeId.Name = "lciTypeId";
            this.lciTypeId.Size = new System.Drawing.Size(460, 24);
            this.lciTypeId.Text = "字典大類";
            this.lciTypeId.TextSize = new System.Drawing.Size(48, 14);
            // 
            // tllueType
            // 
            this.tllueType.Location = new System.Drawing.Point(64, 12);
            this.tllueType.Name = "tllueType";
            this.tllueType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tllueType.Properties.NullText = "";
            this.tllueType.Properties.TreeList = this.tllueTypeTreeList;
            this.tllueType.Size = new System.Drawing.Size(404, 20);
            this.tllueType.StyleController = this.lcMain;
            this.tllueType.TabIndex = 4;
            // 
            // tllueTypeTreeList
            // 
            this.tllueTypeTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcDisplayName});
            this.tllueTypeTreeList.Location = new System.Drawing.Point(0, 0);
            this.tllueTypeTreeList.Name = "tllueTypeTreeList";
            this.tllueTypeTreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.tllueTypeTreeList.Size = new System.Drawing.Size(400, 200);
            this.tllueTypeTreeList.TabIndex = 0;
            // 
            // tlcDisplayName
            // 
            this.tlcDisplayName.Caption = "大類名稱";
            this.tlcDisplayName.FieldName = "DisplayName";
            this.tlcDisplayName.Name = "tlcDisplayName";
            this.tlcDisplayName.Visible = true;
            this.tlcDisplayName.VisibleIndex = 0;
            // 
            // teDisplayName
            // 
            this.teDisplayName.Location = new System.Drawing.Point(64, 36);
            this.teDisplayName.Name = "teDisplayName";
            this.teDisplayName.Size = new System.Drawing.Size(163, 20);
            this.teDisplayName.StyleController = this.lcMain;
            this.teDisplayName.TabIndex = 5;
            // 
            // lciDisplayName
            // 
            this.lciDisplayName.Control = this.teDisplayName;
            this.lciDisplayName.Location = new System.Drawing.Point(0, 24);
            this.lciDisplayName.Name = "lciDisplayName";
            this.lciDisplayName.Size = new System.Drawing.Size(219, 24);
            this.lciDisplayName.Text = "項目名稱";
            this.lciDisplayName.TextSize = new System.Drawing.Size(48, 14);
            // 
            // teValue
            // 
            this.teValue.Location = new System.Drawing.Point(304, 36);
            this.teValue.Name = "teValue";
            this.teValue.Size = new System.Drawing.Size(164, 20);
            this.teValue.StyleController = this.lcMain;
            this.teValue.TabIndex = 6;
            // 
            // lciValue
            // 
            this.lciValue.Control = this.teValue;
            this.lciValue.Location = new System.Drawing.Point(240, 24);
            this.lciValue.Name = "lciValue";
            this.lciValue.Size = new System.Drawing.Size(220, 24);
            this.lciValue.Text = "項目值";
            this.lciValue.TextSize = new System.Drawing.Size(48, 14);
            // 
            // lciIsEnabled
            // 
            this.lciIsEnabled.Control = this.rgIsEnabled;
            this.lciIsEnabled.Location = new System.Drawing.Point(0, 72);
            this.lciIsEnabled.Name = "lciIsEnabled";
            this.lciIsEnabled.Size = new System.Drawing.Size(219, 27);
            this.lciIsEnabled.Text = "狀態";
            this.lciIsEnabled.TextSize = new System.Drawing.Size(48, 14);
            // 
            // rgIsEnabled
            // 
            this.rgIsEnabled.Location = new System.Drawing.Point(64, 84);
            this.rgIsEnabled.Name = "rgIsEnabled";
            this.rgIsEnabled.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgIsEnabled.Properties.Appearance.Options.UseBackColor = true;
            this.rgIsEnabled.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgIsEnabled.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "啟用"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "禁用")});
            this.rgIsEnabled.Size = new System.Drawing.Size(163, 23);
            this.rgIsEnabled.StyleController = this.lcMain;
            this.rgIsEnabled.TabIndex = 7;
            // 
            // lciRemark
            // 
            this.lciRemark.Control = this.meRemark;
            this.lciRemark.Location = new System.Drawing.Point(0, 99);
            this.lciRemark.Name = "lciRemark";
            this.lciRemark.Size = new System.Drawing.Size(460, 92);
            this.lciRemark.Text = "備註";
            this.lciRemark.TextSize = new System.Drawing.Size(48, 14);
            // 
            // meRemark
            // 
            this.meRemark.Location = new System.Drawing.Point(64, 111);
            this.meRemark.Name = "meRemark";
            this.meRemark.Size = new System.Drawing.Size(404, 88);
            this.meRemark.StyleController = this.lcMain;
            this.meRemark.TabIndex = 8;
            // 
            // lciLevel
            // 
            this.lciLevel.Control = this.seListOrder;
            this.lciLevel.Location = new System.Drawing.Point(0, 48);
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
            this.seListOrder.Location = new System.Drawing.Point(64, 60);
            this.seListOrder.Name = "seListOrder";
            this.seListOrder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seListOrder.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.seListOrder.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.seListOrder.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.seListOrder.Size = new System.Drawing.Size(404, 20);
            this.seListOrder.StyleController = this.lcMain;
            this.seListOrder.TabIndex = 9;
            // 
            // labelAssignment
            // 
            this.labelAssignment.Location = new System.Drawing.Point(231, 38);
            this.labelAssignment.Name = "labelAssignment";
            this.labelAssignment.Size = new System.Drawing.Size(17, 16);
            this.labelAssignment.StyleController = this.lcMain;
            this.labelAssignment.TabIndex = 10;
            this.labelAssignment.Text = " = ";
            // 
            // lciAssignment
            // 
            this.lciAssignment.Control = this.labelAssignment;
            this.lciAssignment.Location = new System.Drawing.Point(219, 24);
            this.lciAssignment.MaxSize = new System.Drawing.Size(21, 24);
            this.lciAssignment.MinSize = new System.Drawing.Size(21, 24);
            this.lciAssignment.Name = "lciAssignment";
            this.lciAssignment.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.lciAssignment.Size = new System.Drawing.Size(21, 24);
            this.lciAssignment.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciAssignment.TextSize = new System.Drawing.Size(0, 0);
            this.lciAssignment.TextVisible = false;
            // 
            // FrmDictionaryData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDictionaryData";
            this.Text = "字典項目";
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).EndInit();
            this.pcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcButton)).EndInit();
            this.pcButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueTypeTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDisplayName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDisplayName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIsEnabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgIsEnabled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seListOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAssignment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit teValue;
        private DevExpress.XtraEditors.TextEdit teDisplayName;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem lciTypeId;
        private DevExpress.XtraLayout.LayoutControlItem lciDisplayName;
        private DevExpress.XtraLayout.LayoutControlItem lciValue;
        private DevExpress.XtraLayout.LayoutControlItem lciIsEnabled;
        private DevExpress.XtraLayout.LayoutControlItem lciRemark;
        private DevExpress.XtraEditors.MemoEdit meRemark;
        private DevExpress.XtraEditors.RadioGroup rgIsEnabled;
        private DevExpress.XtraEditors.LabelControl labelAssignment;
        private DevExpress.XtraEditors.SpinEdit seListOrder;
        private DevExpress.XtraLayout.LayoutControlItem lciLevel;
        private DevExpress.XtraLayout.LayoutControlItem lciAssignment;
        private DevExpress.XtraEditors.TreeListLookUpEdit tllueType;
        private DevExpress.XtraTreeList.TreeList tllueTypeTreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcDisplayName;
    }
}