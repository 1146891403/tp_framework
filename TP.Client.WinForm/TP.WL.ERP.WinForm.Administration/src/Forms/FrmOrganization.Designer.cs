namespace TP.WL.ERP.WinForm.Administration.Forms
{
    partial class FrmOrganization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrganization));
            this.teNumber = new DevExpress.XtraEditors.TextEdit();
            this.lciNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.teDisplayName = new DevExpress.XtraEditors.TextEdit();
            this.lciDisplayName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCategory = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.lciParent = new DevExpress.XtraLayout.LayoutControlItem();
            this.tllueParent = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.tllueParentTreeList = new DevExpress.XtraTreeList.TreeList();
            this.tlcDisplayName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.lciListOrder = new DevExpress.XtraLayout.LayoutControlItem();
            this.seListOrder = new DevExpress.XtraEditors.SpinEdit();
            this.lciIsEnabled = new DevExpress.XtraLayout.LayoutControlItem();
            this.rgIsEnabled = new DevExpress.XtraEditors.RadioGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.lciCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueParent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueParentTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciListOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seListOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIsEnabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgIsEnabled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
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
            this.lcMain.Controls.Add(this.tllueParent);
            this.lcMain.Controls.Add(this.lueCategory);
            this.lcMain.Size = new System.Drawing.Size(480, 211);
            // 
            // lcgM
            // 
            this.lcgM.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciNumber,
            this.lciDisplayName,
            this.lciCategory,
            this.lciListOrder,
            this.emptySpaceItem1,
            this.lciIsEnabled,
            this.emptySpaceItem2,
            this.lciParent});
            this.lcgM.Size = new System.Drawing.Size(480, 211);
            // 
            // pcButton
            // 
            this.pcButton.Size = new System.Drawing.Size(484, 46);
            // 
            // teNumber
            // 
            this.teNumber.Location = new System.Drawing.Point(64, 36);
            this.teNumber.Name = "teNumber";
            this.teNumber.Size = new System.Drawing.Size(404, 20);
            this.teNumber.StyleController = this.lcMain;
            this.teNumber.TabIndex = 1;
            // 
            // lciNumber
            // 
            this.lciNumber.Control = this.teNumber;
            this.lciNumber.Location = new System.Drawing.Point(0, 24);
            this.lciNumber.Name = "lciNumber";
            this.lciNumber.Size = new System.Drawing.Size(460, 24);
            this.lciNumber.Text = "機構編號";
            this.lciNumber.TextSize = new System.Drawing.Size(48, 14);
            // 
            // teDisplayName
            // 
            this.teDisplayName.Location = new System.Drawing.Point(64, 60);
            this.teDisplayName.Name = "teDisplayName";
            this.teDisplayName.Size = new System.Drawing.Size(404, 20);
            this.teDisplayName.StyleController = this.lcMain;
            this.teDisplayName.TabIndex = 2;
            // 
            // lciDisplayName
            // 
            this.lciDisplayName.Control = this.teDisplayName;
            this.lciDisplayName.Location = new System.Drawing.Point(0, 48);
            this.lciDisplayName.Name = "lciDisplayName";
            this.lciDisplayName.Size = new System.Drawing.Size(460, 24);
            this.lciDisplayName.Text = "顯示名稱";
            this.lciDisplayName.TextSize = new System.Drawing.Size(48, 14);
            // 
            // lciCategory
            // 
            this.lciCategory.Control = this.lueCategory;
            this.lciCategory.Location = new System.Drawing.Point(0, 72);
            this.lciCategory.Name = "lciCategory";
            this.lciCategory.Size = new System.Drawing.Size(460, 24);
            this.lciCategory.Text = "機構類型";
            this.lciCategory.TextSize = new System.Drawing.Size(48, 14);
            // 
            // lueCategory
            // 
            this.lueCategory.Location = new System.Drawing.Point(64, 84);
            this.lueCategory.Name = "lueCategory";
            this.lueCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCategory.Properties.NullText = "";
            this.lueCategory.Properties.PopupSizeable = false;
            this.lueCategory.Size = new System.Drawing.Size(404, 20);
            this.lueCategory.StyleController = this.lcMain;
            this.lueCategory.TabIndex = 3;
            // 
            // lciParent
            // 
            this.lciParent.Control = this.tllueParent;
            this.lciParent.Location = new System.Drawing.Point(0, 0);
            this.lciParent.Name = "lciParent";
            this.lciParent.Size = new System.Drawing.Size(460, 24);
            this.lciParent.Text = "上級機構";
            this.lciParent.TextSize = new System.Drawing.Size(48, 14);
            // 
            // tllueParent
            // 
            this.tllueParent.Location = new System.Drawing.Point(64, 12);
            this.tllueParent.Name = "tllueParent";
            this.tllueParent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tllueParent.Properties.NullText = "";
            this.tllueParent.Properties.TreeList = this.tllueParentTreeList;
            this.tllueParent.Size = new System.Drawing.Size(404, 20);
            this.tllueParent.StyleController = this.lcMain;
            this.tllueParent.TabIndex = 0;
            // 
            // tllueParentTreeList
            // 
            this.tllueParentTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcDisplayName});
            this.tllueParentTreeList.Location = new System.Drawing.Point(0, 0);
            this.tllueParentTreeList.Name = "tllueParentTreeList";
            this.tllueParentTreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.tllueParentTreeList.Size = new System.Drawing.Size(400, 200);
            this.tllueParentTreeList.TabIndex = 0;
            // 
            // tlcDisplayName
            // 
            this.tlcDisplayName.Caption = "機構名稱";
            this.tlcDisplayName.FieldName = "DisplayName";
            this.tlcDisplayName.Name = "tlcDisplayName";
            this.tlcDisplayName.Visible = true;
            this.tlcDisplayName.VisibleIndex = 0;
            // 
            // lciListOrder
            // 
            this.lciListOrder.Control = this.seListOrder;
            this.lciListOrder.Location = new System.Drawing.Point(0, 96);
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
            this.seListOrder.Location = new System.Drawing.Point(64, 108);
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
            this.seListOrder.TabIndex = 4;
            // 
            // lciIsEnabled
            // 
            this.lciIsEnabled.Control = this.rgIsEnabled;
            this.lciIsEnabled.Location = new System.Drawing.Point(0, 120);
            this.lciIsEnabled.Name = "lciIsEnabled";
            this.lciIsEnabled.Size = new System.Drawing.Size(230, 27);
            this.lciIsEnabled.Text = "狀態";
            this.lciIsEnabled.TextSize = new System.Drawing.Size(48, 14);
            // 
            // rgIsEnabled
            // 
            this.rgIsEnabled.Location = new System.Drawing.Point(64, 132);
            this.rgIsEnabled.Name = "rgIsEnabled";
            this.rgIsEnabled.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgIsEnabled.Properties.Appearance.Options.UseBackColor = true;
            this.rgIsEnabled.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgIsEnabled.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "啟用"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "禁用")});
            this.rgIsEnabled.Size = new System.Drawing.Size(174, 23);
            this.rgIsEnabled.StyleController = this.lcMain;
            this.rgIsEnabled.TabIndex = 5;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 147);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(460, 44);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(230, 120);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(230, 27);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FrmOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrganization";
            this.Text = "組織機構";
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
            ((System.ComponentModel.ISupportInitialize)(this.lciCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciParent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueParent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueParentTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciListOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seListOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIsEnabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgIsEnabled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teDisplayName;
        private DevExpress.XtraEditors.TextEdit teNumber;
        private DevExpress.XtraEditors.RadioGroup rgIsEnabled;
        private DevExpress.XtraEditors.SpinEdit seListOrder;
        private DevExpress.XtraEditors.TreeListLookUpEdit tllueParent;
        private DevExpress.XtraTreeList.TreeList tllueParentTreeList;
        private DevExpress.XtraLayout.LayoutControlItem lciNumber;
        private DevExpress.XtraLayout.LayoutControlItem lciDisplayName;
        private DevExpress.XtraLayout.LayoutControlItem lciCategory;
        private DevExpress.XtraLayout.LayoutControlItem lciParent;
        private DevExpress.XtraLayout.LayoutControlItem lciListOrder;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciIsEnabled;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcDisplayName;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.LookUpEdit lueCategory;
    }
}