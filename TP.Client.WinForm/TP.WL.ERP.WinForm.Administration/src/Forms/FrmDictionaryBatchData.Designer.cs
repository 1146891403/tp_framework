namespace TP.WL.ERP.WinForm.Administration.Forms
{
    partial class FrmDictionaryBatchData
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
            this.lciTypeId = new DevExpress.XtraLayout.LayoutControlItem();
            this.tllueType = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.tllueTypeTreeList = new DevExpress.XtraTreeList.TreeList();
            this.tlcDisplayName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.lciMode = new DevExpress.XtraLayout.LayoutControlItem();
            this.rgMode = new DevExpress.XtraEditors.RadioGroup();
            this.lciData = new DevExpress.XtraLayout.LayoutControlItem();
            this.meData = new DevExpress.XtraEditors.MemoEdit();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).BeginInit();
            this.pcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueTypeTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcMain
            // 
            this.pcMain.Size = new System.Drawing.Size(584, 315);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.meData);
            this.lcMain.Controls.Add(this.rgMode);
            this.lcMain.Controls.Add(this.tllueType);
            this.lcMain.Size = new System.Drawing.Size(580, 311);
            // 
            // lcgM
            // 
            this.lcgM.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciTypeId,
            this.lciMode,
            this.lciData,
            this.emptySpaceItem1});
            this.lcgM.Size = new System.Drawing.Size(580, 311);
            // 
            // lciTypeId
            // 
            this.lciTypeId.Control = this.tllueType;
            this.lciTypeId.Location = new System.Drawing.Point(0, 0);
            this.lciTypeId.MinSize = new System.Drawing.Size(50, 25);
            this.lciTypeId.Name = "lciTypeId";
            this.lciTypeId.Size = new System.Drawing.Size(280, 25);
            this.lciTypeId.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTypeId.Text = "字典大類";
            this.lciTypeId.TextSize = new System.Drawing.Size(72, 14);
            // 
            // tllueType
            // 
            this.tllueType.Location = new System.Drawing.Point(88, 12);
            this.tllueType.Name = "tllueType";
            this.tllueType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tllueType.Properties.NullText = "";
            this.tllueType.Properties.TreeList = this.tllueTypeTreeList;
            this.tllueType.Size = new System.Drawing.Size(200, 20);
            this.tllueType.StyleController = this.lcMain;
            this.tllueType.TabIndex = 4;
            // 
            // tllueTypeTreeList
            // 
            this.tllueTypeTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcDisplayName});
            this.tllueTypeTreeList.Location = new System.Drawing.Point(0, 0);
            this.tllueTypeTreeList.Name = "tllueTypeTreeList";
            this.tllueTypeTreeList.OptionsBehavior.EnableFiltering = true;
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
            // lciMode
            // 
            this.lciMode.Control = this.rgMode;
            this.lciMode.Location = new System.Drawing.Point(0, 25);
            this.lciMode.Name = "lciMode";
            this.lciMode.Size = new System.Drawing.Size(560, 49);
            this.lciMode.Text = "數據分開方式";
            this.lciMode.TextSize = new System.Drawing.Size(72, 14);
            // 
            // rgMode
            // 
            this.rgMode.Location = new System.Drawing.Point(88, 37);
            this.rgMode.Name = "rgMode";
            this.rgMode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgMode.Properties.Appearance.Options.UseBackColor = true;
            this.rgMode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgMode.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Delimiter", "分隔符模式，多個數據中英文逗號，分號，斜杠或頓號【,，;；/、】"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Enter", "一行一個記錄模式，忽略所有分隔符")});
            this.rgMode.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow;
            this.rgMode.Size = new System.Drawing.Size(480, 45);
            this.rgMode.StyleController = this.lcMain;
            this.rgMode.TabIndex = 5;
            // 
            // lciData
            // 
            this.lciData.Control = this.meData;
            this.lciData.Location = new System.Drawing.Point(0, 74);
            this.lciData.Name = "lciData";
            this.lciData.Size = new System.Drawing.Size(560, 217);
            this.lciData.Text = "字典數據";
            this.lciData.TextSize = new System.Drawing.Size(72, 14);
            // 
            // meData
            // 
            this.meData.Location = new System.Drawing.Point(88, 86);
            this.meData.Name = "meData";
            this.meData.Size = new System.Drawing.Size(480, 213);
            this.meData.StyleController = this.lcMain;
            this.meData.TabIndex = 6;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(280, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(280, 25);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FrmDictionaryBatchData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDictionaryBatchData";
            this.Text = "批量添加字典數據";
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).EndInit();
            this.pcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tllueTypeTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControlItem lciTypeId;
        private DevExpress.XtraLayout.LayoutControlItem lciMode;
        private DevExpress.XtraLayout.LayoutControlItem lciData;
        private DevExpress.XtraEditors.MemoEdit meData;
        private DevExpress.XtraEditors.RadioGroup rgMode;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TreeListLookUpEdit tllueType;
        private DevExpress.XtraTreeList.TreeList tllueTypeTreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcDisplayName;
    }
}