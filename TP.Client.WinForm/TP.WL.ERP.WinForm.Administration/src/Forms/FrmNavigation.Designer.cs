namespace TP.WL.ERP.WinForm.Administration.Forms
{
    partial class FrmNavigation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNavigation));
            this.lciParentId = new DevExpress.XtraLayout.LayoutControlItem();
            this.tllueParent = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.tllueParentTreeList = new DevExpress.XtraTreeList.TreeList();
            this.tlcDisplayName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.teDisplayName = new DevExpress.XtraEditors.TextEdit();
            this.lciDisplayName = new DevExpress.XtraLayout.LayoutControlItem();
            this.teViewName = new DevExpress.XtraEditors.TextEdit();
            this.lciViewName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciListOrder = new DevExpress.XtraLayout.LayoutControlItem();
            this.seListOrder = new DevExpress.XtraEditors.SpinEdit();
            this.lciIsEnabled = new DevExpress.XtraLayout.LayoutControlItem();
            this.rgIsEnabled = new DevExpress.XtraEditors.RadioGroup();
            this.lciDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.meDescription = new DevExpress.XtraEditors.MemoEdit();
            this.peIconSource = new DevExpress.XtraEditors.PictureEdit();
            this.lciIconImage = new DevExpress.XtraLayout.LayoutControlItem();
            this.rgIsGroup = new DevExpress.XtraEditors.RadioGroup();
            this.lciIsGroup = new DevExpress.XtraLayout.LayoutControlItem();
            this.teNumber = new DevExpress.XtraEditors.TextEdit();
            this.lciNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.beIconSource = new DevExpress.XtraEditors.ButtonEdit();
            this.lciIconSource = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcButton)).BeginInit();
            this.lcButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSaveAndNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciParentId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueParent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueParentTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDisplayName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDisplayName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teViewName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciViewName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciListOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seListOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIsEnabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgIsEnabled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peIconSource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIconImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgIsGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIsGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beIconSource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIconSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // pcMain
            // 
            this.pcMain.Size = new System.Drawing.Size(484, 265);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.beIconSource);
            this.lcMain.Controls.Add(this.teNumber);
            this.lcMain.Controls.Add(this.rgIsGroup);
            this.lcMain.Controls.Add(this.peIconSource);
            this.lcMain.Controls.Add(this.teViewName);
            this.lcMain.Controls.Add(this.teDisplayName);
            this.lcMain.Controls.Add(this.meDescription);
            this.lcMain.Controls.Add(this.rgIsEnabled);
            this.lcMain.Controls.Add(this.seListOrder);
            this.lcMain.Controls.Add(this.tllueParent);
            this.lcMain.Size = new System.Drawing.Size(480, 261);
            // 
            // lcgM
            // 
            this.lcgM.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDisplayName,
            this.lciListOrder,
            this.lciIsEnabled,
            this.lciDescription,
            this.lciIconImage,
            this.lciIsGroup,
            this.lciParentId,
            this.lciNumber,
            this.lciIconSource,
            this.lciViewName,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.lcgM.Size = new System.Drawing.Size(480, 261);
            // 
            // pcButton
            // 
            this.pcButton.Location = new System.Drawing.Point(0, 265);
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
            // lciParentId
            // 
            this.lciParentId.Control = this.tllueParent;
            this.lciParentId.Location = new System.Drawing.Point(0, 48);
            this.lciParentId.Name = "lciParentId";
            this.lciParentId.Size = new System.Drawing.Size(320, 27);
            this.lciParentId.Text = "上級菜單";
            this.lciParentId.TextSize = new System.Drawing.Size(48, 14);
            // 
            // tllueParent
            // 
            this.tllueParent.Location = new System.Drawing.Point(64, 60);
            this.tllueParent.Name = "tllueParent";
            this.tllueParent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tllueParent.Properties.NullText = "";
            this.tllueParent.Properties.TreeList = this.tllueParentTreeList;
            this.tllueParent.Size = new System.Drawing.Size(264, 20);
            this.tllueParent.StyleController = this.lcMain;
            this.tllueParent.TabIndex = 4;
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
            this.tlcDisplayName.Caption = "菜單名稱";
            this.tlcDisplayName.FieldName = "DisplayName";
            this.tlcDisplayName.Name = "tlcDisplayName";
            this.tlcDisplayName.Visible = true;
            this.tlcDisplayName.VisibleIndex = 0;
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
            this.lciDisplayName.Text = "顯示名稱";
            this.lciDisplayName.TextSize = new System.Drawing.Size(48, 14);
            // 
            // teViewName
            // 
            this.teViewName.Location = new System.Drawing.Point(64, 87);
            this.teViewName.Name = "teViewName";
            this.teViewName.Size = new System.Drawing.Size(404, 20);
            this.teViewName.StyleController = this.lcMain;
            this.teViewName.TabIndex = 6;
            // 
            // lciViewName
            // 
            this.lciViewName.Control = this.teViewName;
            this.lciViewName.Location = new System.Drawing.Point(0, 75);
            this.lciViewName.Name = "lciViewName";
            this.lciViewName.Size = new System.Drawing.Size(460, 24);
            this.lciViewName.Text = "頁面名稱";
            this.lciViewName.TextSize = new System.Drawing.Size(48, 14);
            // 
            // lciListOrder
            // 
            this.lciListOrder.Control = this.seListOrder;
            this.lciListOrder.Location = new System.Drawing.Point(0, 99);
            this.lciListOrder.Name = "lciListOrder";
            this.lciListOrder.Size = new System.Drawing.Size(320, 24);
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
            this.seListOrder.Location = new System.Drawing.Point(64, 111);
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
            this.seListOrder.Size = new System.Drawing.Size(264, 20);
            this.seListOrder.StyleController = this.lcMain;
            this.seListOrder.TabIndex = 7;
            // 
            // lciIsEnabled
            // 
            this.lciIsEnabled.Control = this.rgIsEnabled;
            this.lciIsEnabled.Location = new System.Drawing.Point(0, 147);
            this.lciIsEnabled.Name = "lciIsEnabled";
            this.lciIsEnabled.Size = new System.Drawing.Size(320, 27);
            this.lciIsEnabled.Text = "狀態";
            this.lciIsEnabled.TextSize = new System.Drawing.Size(48, 14);
            // 
            // rgIsEnabled
            // 
            this.rgIsEnabled.Location = new System.Drawing.Point(64, 159);
            this.rgIsEnabled.Name = "rgIsEnabled";
            this.rgIsEnabled.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgIsEnabled.Properties.Appearance.Options.UseBackColor = true;
            this.rgIsEnabled.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgIsEnabled.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "啟用"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "禁用")});
            this.rgIsEnabled.Size = new System.Drawing.Size(264, 23);
            this.rgIsEnabled.StyleController = this.lcMain;
            this.rgIsEnabled.TabIndex = 8;
            // 
            // lciDescription
            // 
            this.lciDescription.Control = this.meDescription;
            this.lciDescription.Location = new System.Drawing.Point(0, 174);
            this.lciDescription.Name = "lciDescription";
            this.lciDescription.Size = new System.Drawing.Size(460, 67);
            this.lciDescription.Text = "說明";
            this.lciDescription.TextSize = new System.Drawing.Size(48, 14);
            // 
            // meDescription
            // 
            this.meDescription.Location = new System.Drawing.Point(64, 186);
            this.meDescription.Name = "meDescription";
            this.meDescription.Size = new System.Drawing.Size(404, 63);
            this.meDescription.StyleController = this.lcMain;
            this.meDescription.TabIndex = 9;
            // 
            // peIconSource
            // 
            this.peIconSource.Cursor = System.Windows.Forms.Cursors.Default;
            this.peIconSource.Location = new System.Drawing.Point(368, 115);
            this.peIconSource.Name = "peIconSource";
            this.peIconSource.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peIconSource.Properties.ShowMenu = false;
            this.peIconSource.Size = new System.Drawing.Size(64, 64);
            this.peIconSource.StyleController = this.lcMain;
            this.peIconSource.TabIndex = 10;
            // 
            // lciIconImage
            // 
            this.lciIconImage.Control = this.peIconSource;
            this.lciIconImage.Location = new System.Drawing.Point(350, 99);
            this.lciIconImage.Name = "lciIconImage";
            this.lciIconImage.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 6, 5);
            this.lciIconImage.Size = new System.Drawing.Size(80, 75);
            this.lciIconImage.TextSize = new System.Drawing.Size(0, 0);
            this.lciIconImage.TextVisible = false;
            // 
            // rgIsGroup
            // 
            this.rgIsGroup.Location = new System.Drawing.Point(384, 60);
            this.rgIsGroup.Name = "rgIsGroup";
            this.rgIsGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgIsGroup.Properties.Appearance.Options.UseBackColor = true;
            this.rgIsGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgIsGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "是"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "否")});
            this.rgIsGroup.Size = new System.Drawing.Size(84, 23);
            this.rgIsGroup.StyleController = this.lcMain;
            this.rgIsGroup.TabIndex = 11;
            // 
            // lciIsGroup
            // 
            this.lciIsGroup.Control = this.rgIsGroup;
            this.lciIsGroup.Location = new System.Drawing.Point(320, 48);
            this.lciIsGroup.Name = "lciIsGroup";
            this.lciIsGroup.Size = new System.Drawing.Size(140, 27);
            this.lciIsGroup.Text = "分組導航";
            this.lciIsGroup.TextSize = new System.Drawing.Size(48, 14);
            // 
            // teNumber
            // 
            this.teNumber.Location = new System.Drawing.Point(64, 12);
            this.teNumber.Name = "teNumber";
            this.teNumber.Size = new System.Drawing.Size(404, 20);
            this.teNumber.StyleController = this.lcMain;
            this.teNumber.TabIndex = 12;
            // 
            // lciNumber
            // 
            this.lciNumber.Control = this.teNumber;
            this.lciNumber.Location = new System.Drawing.Point(0, 0);
            this.lciNumber.Name = "lciNumber";
            this.lciNumber.Size = new System.Drawing.Size(460, 24);
            this.lciNumber.Text = "菜單編號";
            this.lciNumber.TextSize = new System.Drawing.Size(48, 14);
            // 
            // beIconSource
            // 
            this.beIconSource.Location = new System.Drawing.Point(64, 135);
            this.beIconSource.Name = "beIconSource";
            this.beIconSource.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beIconSource.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.beIconSource.Size = new System.Drawing.Size(264, 20);
            this.beIconSource.StyleController = this.lcMain;
            this.beIconSource.TabIndex = 13;
            // 
            // lciIconSource
            // 
            this.lciIconSource.Control = this.beIconSource;
            this.lciIconSource.Location = new System.Drawing.Point(0, 123);
            this.lciIconSource.Name = "lciIconSource";
            this.lciIconSource.Size = new System.Drawing.Size(320, 24);
            this.lciIconSource.Text = "圖標";
            this.lciIconSource.TextSize = new System.Drawing.Size(48, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(320, 99);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(30, 0);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(30, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(30, 75);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(430, 99);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(30, 0);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(30, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(30, 75);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FrmNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNavigation";
            this.Text = "菜單";
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
            ((System.ComponentModel.ISupportInitialize)(this.lciParentId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueParent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueParentTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDisplayName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDisplayName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teViewName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciViewName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciListOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seListOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIsEnabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgIsEnabled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peIconSource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIconImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgIsGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIsGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beIconSource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIconSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit teViewName;
        private DevExpress.XtraEditors.TextEdit teDisplayName;
        private DevExpress.XtraLayout.LayoutControlItem lciParentId;
        private DevExpress.XtraLayout.LayoutControlItem lciDisplayName;
        private DevExpress.XtraLayout.LayoutControlItem lciViewName;
        private DevExpress.XtraLayout.LayoutControlItem lciListOrder;
        private DevExpress.XtraLayout.LayoutControlItem lciIsEnabled;
        private DevExpress.XtraLayout.LayoutControlItem lciDescription;
        private DevExpress.XtraEditors.MemoEdit meDescription;
        private DevExpress.XtraEditors.RadioGroup rgIsEnabled;
        private DevExpress.XtraEditors.SpinEdit seListOrder;
        private DevExpress.XtraEditors.TreeListLookUpEdit tllueParent;
        private DevExpress.XtraTreeList.TreeList tllueParentTreeList;
        private DevExpress.XtraEditors.PictureEdit peIconSource;
        private DevExpress.XtraLayout.LayoutControlItem lciIconImage;
        private DevExpress.XtraEditors.RadioGroup rgIsGroup;
        private DevExpress.XtraLayout.LayoutControlItem lciIsGroup;
        private DevExpress.XtraEditors.TextEdit teNumber;
        private DevExpress.XtraLayout.LayoutControlItem lciNumber;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcDisplayName;
        private DevExpress.XtraEditors.ButtonEdit beIconSource;
        private DevExpress.XtraLayout.LayoutControlItem lciIconSource;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}