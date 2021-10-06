namespace TP.WL.ERP.WinForm.Administration.Controls
{
    partial class DictionaryGridView
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
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DictionaryGridView));
            this.gridDictionary = new DevExpress.XtraGrid.GridControl();
            this.gvDictionary = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcDisplayName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcListOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEmpty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lciGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitter = new DevExpress.XtraLayout.SplitterItem();
            this.lcTreeTitle = new DevExpress.XtraEditors.LabelControl();
            this.lciTreeTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcTreeName = new DevExpress.XtraEditors.LabelControl();
            this.lciTreeName = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnNewBulk = new DevExpress.XtraEditors.SimpleButton();
            this.lciBtnNewBulk = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPagination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDictionary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDictionary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTreeTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTreeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnNewBulk)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.btnNewBulk);
            this.lcMain.Controls.Add(this.lcTreeName);
            this.lcMain.Controls.Add(this.lcTreeTitle);
            this.lcMain.Controls.Add(this.gridDictionary);
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(847, 473, 650, 400);
            this.lcMain.Size = new System.Drawing.Size(1024, 768);
            this.lcMain.Controls.SetChildIndex(this.btnSearch, 0);
            this.lcMain.Controls.SetChildIndex(this.btnNew, 0);
            this.lcMain.Controls.SetChildIndex(this.gridDictionary, 0);
            this.lcMain.Controls.SetChildIndex(this.pagination, 0);
            this.lcMain.Controls.SetChildIndex(this.lcTreeTitle, 0);
            this.lcMain.Controls.SetChildIndex(this.lcTreeName, 0);
            this.lcMain.Controls.SetChildIndex(this.btnNewBulk, 0);
            // 
            // lcgMain
            // 
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciGrid,
            this.splitter});
            this.lcgMain.Name = "Root";
            this.lcgMain.Size = new System.Drawing.Size(1024, 768);
            // 
            // lcgTreeList
            // 
            buttonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions1.Image")));
            buttonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions2.Image")));
            this.lcgTreeList.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("New", false, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Refresh", false, buttonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1)});
            this.lcgTreeList.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.lcgTreeList.Size = new System.Drawing.Size(227, 748);
            // 
            // lcgSearch
            // 
            this.lcgSearch.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciTreeTitle,
            this.lciTreeName,
            this.lciBtnNewBulk});
            this.lcgSearch.Location = new System.Drawing.Point(232, 0);
            this.lcgSearch.Size = new System.Drawing.Size(772, 91);
            this.lcgSearch.Text = "字典大類";
            // 
            // esiLeft
            // 
            this.esiLeft.Location = new System.Drawing.Point(114, 0);
            this.esiLeft.Size = new System.Drawing.Size(354, 48);
            // 
            // pagination
            // 
            this.pagination.Location = new System.Drawing.Point(244, 718);
            this.pagination.Size = new System.Drawing.Size(768, 38);
            // 
            // lciPagination
            // 
            this.lciPagination.Location = new System.Drawing.Point(232, 706);
            this.lciPagination.Size = new System.Drawing.Size(772, 42);
            // 
            // lciTreeList
            // 
            this.lciTreeList.Size = new System.Drawing.Size(217, 711);
            // 
            // esiRight
            // 
            this.esiRight.Location = new System.Drawing.Point(728, 0);
            // 
            // lciBtnSearch
            // 
            this.lciBtnSearch.Location = new System.Drawing.Point(468, 0);
            // 
            // lciBtnNew
            // 
            this.lciBtnNew.Location = new System.Drawing.Point(648, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.Location = new System.Drawing.Point(726, 45);
            // 
            // btnNew
            // 
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.Location = new System.Drawing.Point(906, 45);
            // 
            // gridDictionary
            // 
            this.gridDictionary.Location = new System.Drawing.Point(244, 103);
            this.gridDictionary.MainView = this.gvDictionary;
            this.gridDictionary.Name = "gridDictionary";
            this.gridDictionary.Size = new System.Drawing.Size(768, 611);
            this.gridDictionary.TabIndex = 4;
            this.gridDictionary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDictionary});
            // 
            // gvDictionary
            // 
            this.gvDictionary.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcDisplayName,
            this.gcValue,
            this.gcListOrder,
            this.gcStatus,
            this.gcRemark,
            this.gcEmpty});
            this.gvDictionary.GridControl = this.gridDictionary;
            this.gvDictionary.Name = "gvDictionary";
            this.gvDictionary.OptionsView.ShowGroupPanel = false;
            // 
            // gcDisplayName
            // 
            this.gcDisplayName.Caption = "項目名稱";
            this.gcDisplayName.FieldName = "DisplayName";
            this.gcDisplayName.Name = "gcDisplayName";
            this.gcDisplayName.Visible = true;
            this.gcDisplayName.VisibleIndex = 0;
            // 
            // gcValue
            // 
            this.gcValue.Caption = "項目值";
            this.gcValue.FieldName = "Value";
            this.gcValue.Name = "gcValue";
            this.gcValue.Visible = true;
            this.gcValue.VisibleIndex = 1;
            // 
            // gcListOrder
            // 
            this.gcListOrder.Caption = "排序";
            this.gcListOrder.FieldName = "ListOrder";
            this.gcListOrder.Name = "gcListOrder";
            this.gcListOrder.Visible = true;
            this.gcListOrder.VisibleIndex = 2;
            // 
            // gcStatus
            // 
            this.gcStatus.Caption = "狀態";
            this.gcStatus.FieldName = "IsEnabled";
            this.gcStatus.Name = "gcStatus";
            this.gcStatus.Visible = true;
            this.gcStatus.VisibleIndex = 3;
            // 
            // gcRemark
            // 
            this.gcRemark.Caption = "備註";
            this.gcRemark.FieldName = "Remark";
            this.gcRemark.Name = "gcRemark";
            this.gcRemark.Visible = true;
            this.gcRemark.VisibleIndex = 4;
            // 
            // gcEmpty
            // 
            this.gcEmpty.Name = "gcEmpty";
            this.gcEmpty.Visible = true;
            this.gcEmpty.VisibleIndex = 5;
            // 
            // lciGrid
            // 
            this.lciGrid.Control = this.gridDictionary;
            this.lciGrid.Location = new System.Drawing.Point(232, 91);
            this.lciGrid.Name = "lciGrid";
            this.lciGrid.Size = new System.Drawing.Size(772, 615);
            this.lciGrid.TextSize = new System.Drawing.Size(0, 0);
            this.lciGrid.TextVisible = false;
            // 
            // splitter
            // 
            this.splitter.AllowHotTrack = true;
            this.splitter.Location = new System.Drawing.Point(227, 0);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(5, 748);
            // 
            // lcTreeTitle
            // 
            this.lcTreeTitle.Location = new System.Drawing.Point(266, 56);
            this.lcTreeTitle.Name = "lcTreeTitle";
            this.lcTreeTitle.Size = new System.Drawing.Size(60, 14);
            this.lcTreeTitle.StyleController = this.lcMain;
            this.lcTreeTitle.TabIndex = 8;
            this.lcTreeTitle.Text = "當前大類：";
            // 
            // lciTreeTitle
            // 
            this.lciTreeTitle.Control = this.lcTreeTitle;
            this.lciTreeTitle.Location = new System.Drawing.Point(0, 0);
            this.lciTreeTitle.Name = "lciTreeTitle";
            this.lciTreeTitle.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 2, 15, 2);
            this.lciTreeTitle.Size = new System.Drawing.Size(74, 48);
            this.lciTreeTitle.TextSize = new System.Drawing.Size(0, 0);
            this.lciTreeTitle.TextVisible = false;
            // 
            // lcTreeName
            // 
            this.lcTreeName.Location = new System.Drawing.Point(330, 56);
            this.lcTreeName.Name = "lcTreeName";
            this.lcTreeName.Size = new System.Drawing.Size(36, 14);
            this.lcTreeName.StyleController = this.lcMain;
            this.lcTreeName.TabIndex = 9;
            this.lcTreeName.Text = "默認值";
            // 
            // lciTreeName
            // 
            this.lciTreeName.Control = this.lcTreeName;
            this.lciTreeName.Location = new System.Drawing.Point(74, 0);
            this.lciTreeName.Name = "lciTreeName";
            this.lciTreeName.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 15, 2);
            this.lciTreeName.Size = new System.Drawing.Size(40, 48);
            this.lciTreeName.TextSize = new System.Drawing.Size(0, 0);
            this.lciTreeName.TextVisible = false;
            // 
            // btnNewBulk
            // 
            this.btnNewBulk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewBulk.ImageOptions.Image")));
            this.btnNewBulk.Location = new System.Drawing.Point(806, 45);
            this.btnNewBulk.Name = "btnNewBulk";
            this.btnNewBulk.Size = new System.Drawing.Size(92, 40);
            this.btnNewBulk.StyleController = this.lcMain;
            this.btnNewBulk.TabIndex = 10;
            this.btnNewBulk.Text = "批量添加";
            // 
            // lciBtnNewBulk
            // 
            this.lciBtnNewBulk.Control = this.btnNewBulk;
            this.lciBtnNewBulk.Location = new System.Drawing.Point(548, 0);
            this.lciBtnNewBulk.MaxSize = new System.Drawing.Size(100, 48);
            this.lciBtnNewBulk.MinSize = new System.Drawing.Size(100, 48);
            this.lciBtnNewBulk.Name = "lciBtnNewBulk";
            this.lciBtnNewBulk.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lciBtnNewBulk.Size = new System.Drawing.Size(100, 48);
            this.lciBtnNewBulk.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciBtnNewBulk.TextSize = new System.Drawing.Size(0, 0);
            this.lciBtnNewBulk.TextVisible = false;
            // 
            // DictionaryGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "DictionaryGridView";
            this.Size = new System.Drawing.Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            this.lcMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPagination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDictionary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDictionary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTreeTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTreeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnNewBulk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridDictionary;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDictionary;
        private DevExpress.XtraLayout.LayoutControlItem lciGrid;
        private DevExpress.XtraLayout.SplitterItem splitter;
        private DevExpress.XtraGrid.Columns.GridColumn gcDisplayName;
        private DevExpress.XtraGrid.Columns.GridColumn gcValue;
        private DevExpress.XtraGrid.Columns.GridColumn gcListOrder;
        private DevExpress.XtraGrid.Columns.GridColumn gcStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gcRemark;
        private DevExpress.XtraGrid.Columns.GridColumn gcEmpty;
        private DevExpress.XtraEditors.LabelControl lcTreeName;
        private DevExpress.XtraEditors.LabelControl lcTreeTitle;
        private DevExpress.XtraLayout.LayoutControlItem lciTreeTitle;
        private DevExpress.XtraLayout.LayoutControlItem lciTreeName;
        private DevExpress.XtraEditors.SimpleButton btnNewBulk;
        private DevExpress.XtraLayout.LayoutControlItem lciBtnNewBulk;
    }
}
