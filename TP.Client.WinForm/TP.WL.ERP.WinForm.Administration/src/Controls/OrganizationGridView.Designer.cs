namespace TP.WL.ERP.WinForm.Administration.Controls
{
    partial class OrganizationGridView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizationGridView));
            this.colDisplayName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.gridOrganization = new DevExpress.XtraGrid.GridControl();
            this.gvOrganization = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lciGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.gcNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDisplayName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcListOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEmpty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lcTreeTitle = new DevExpress.XtraEditors.LabelControl();
            this.lciTreeTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcTreeName = new DevExpress.XtraEditors.LabelControl();
            this.lciTreeName = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrganization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrganization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTreeTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTreeName)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.lcTreeName);
            this.lcMain.Controls.Add(this.lcTreeTitle);
            this.lcMain.Controls.Add(this.gridOrganization);
            this.lcMain.Size = new System.Drawing.Size(1024, 768);
            this.lcMain.Controls.SetChildIndex(this.btnNew, 0);
            this.lcMain.Controls.SetChildIndex(this.btnSearch, 0);
            this.lcMain.Controls.SetChildIndex(this.pagination, 0);
            this.lcMain.Controls.SetChildIndex(this.gridOrganization, 0);
            this.lcMain.Controls.SetChildIndex(this.lcTreeTitle, 0);
            this.lcMain.Controls.SetChildIndex(this.lcTreeName, 0);
            // 
            // lcgMain
            // 
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.splitterItem1,
            this.lciGrid});
            this.lcgMain.Size = new System.Drawing.Size(1024, 768);
            // 
            // lcgTreeList
            // 
            this.lcgTreeList.Size = new System.Drawing.Size(228, 748);
            // 
            // lcgSearch
            // 
            this.lcgSearch.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciTreeTitle,
            this.lciTreeName});
            this.lcgSearch.Location = new System.Drawing.Point(233, 0);
            this.lcgSearch.Size = new System.Drawing.Size(771, 91);
            this.lcgSearch.Text = "組織機構";
            // 
            // esiLeft
            // 
            this.esiLeft.Location = new System.Drawing.Point(114, 0);
            this.esiLeft.Size = new System.Drawing.Size(453, 48);
            // 
            // pagination
            // 
            this.pagination.Location = new System.Drawing.Point(245, 718);
            this.pagination.Size = new System.Drawing.Size(767, 38);
            // 
            // lciPagination
            // 
            this.lciPagination.Location = new System.Drawing.Point(233, 706);
            this.lciPagination.Size = new System.Drawing.Size(771, 42);
            // 
            // lciTreeList
            // 
            this.lciTreeList.Size = new System.Drawing.Size(218, 719);
            // 
            // esiRight
            // 
            this.esiRight.Location = new System.Drawing.Point(727, 0);
            // 
            // lciBtnSearch
            // 
            this.lciBtnSearch.Location = new System.Drawing.Point(567, 0);
            // 
            // lciBtnNew
            // 
            this.lciBtnNew.Location = new System.Drawing.Point(647, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.Location = new System.Drawing.Point(826, 45);
            // 
            // btnNew
            // 
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.Location = new System.Drawing.Point(906, 45);
            // 
            // colDisplayName
            // 
            this.colDisplayName.FieldName = "DisplayName";
            this.colDisplayName.Name = "colDisplayName";
            this.colDisplayName.OptionsColumn.AllowSort = false;
            this.colDisplayName.Visible = true;
            this.colDisplayName.VisibleIndex = 0;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(228, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 748);
            // 
            // gridOrganization
            // 
            this.gridOrganization.Location = new System.Drawing.Point(245, 103);
            this.gridOrganization.MainView = this.gvOrganization;
            this.gridOrganization.Name = "gridOrganization";
            this.gridOrganization.Size = new System.Drawing.Size(767, 611);
            this.gridOrganization.TabIndex = 8;
            this.gridOrganization.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrganization});
            // 
            // gvOrganization
            // 
            this.gvOrganization.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcNumber,
            this.gcDisplayName,
            this.gcCategory,
            this.gcListOrder,
            this.gcStatus,
            this.gcEmpty});
            this.gvOrganization.GridControl = this.gridOrganization;
            this.gvOrganization.Name = "gvOrganization";
            this.gvOrganization.OptionsView.ShowGroupPanel = false;
            // 
            // lciGrid
            // 
            this.lciGrid.Control = this.gridOrganization;
            this.lciGrid.Location = new System.Drawing.Point(233, 91);
            this.lciGrid.Name = "lciGrid";
            this.lciGrid.Size = new System.Drawing.Size(771, 615);
            this.lciGrid.TextSize = new System.Drawing.Size(0, 0);
            this.lciGrid.TextVisible = false;
            // 
            // gcNumber
            // 
            this.gcNumber.Caption = "編號";
            this.gcNumber.FieldName = "Number";
            this.gcNumber.Name = "gcNumber";
            this.gcNumber.Visible = true;
            this.gcNumber.VisibleIndex = 0;
            // 
            // gcDisplayName
            // 
            this.gcDisplayName.Caption = "名稱";
            this.gcDisplayName.FieldName = "DisplayName";
            this.gcDisplayName.Name = "gcDisplayName";
            this.gcDisplayName.Visible = true;
            this.gcDisplayName.VisibleIndex = 1;
            // 
            // gcCategory
            // 
            this.gcCategory.Caption = "類型";
            this.gcCategory.FieldName = "Category";
            this.gcCategory.Name = "gcCategory";
            this.gcCategory.Visible = true;
            this.gcCategory.VisibleIndex = 2;
            // 
            // gcListOrder
            // 
            this.gcListOrder.Caption = "排序";
            this.gcListOrder.FieldName = "ListOrder";
            this.gcListOrder.Name = "gcListOrder";
            this.gcListOrder.Visible = true;
            this.gcListOrder.VisibleIndex = 3;
            // 
            // gcStatus
            // 
            this.gcStatus.Caption = "狀態";
            this.gcStatus.FieldName = "IsEnabled";
            this.gcStatus.Name = "gcStatus";
            this.gcStatus.Visible = true;
            this.gcStatus.VisibleIndex = 4;
            // 
            // gcEmpty
            // 
            this.gcEmpty.Name = "gcEmpty";
            this.gcEmpty.Visible = true;
            this.gcEmpty.VisibleIndex = 5;
            // 
            // lcTreeTitle
            // 
            this.lcTreeTitle.Location = new System.Drawing.Point(267, 56);
            this.lcTreeTitle.Name = "lcTreeTitle";
            this.lcTreeTitle.Size = new System.Drawing.Size(60, 14);
            this.lcTreeTitle.StyleController = this.lcMain;
            this.lcTreeTitle.TabIndex = 9;
            this.lcTreeTitle.Text = "當前機構：";
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
            this.lcTreeName.Location = new System.Drawing.Point(331, 56);
            this.lcTreeName.Name = "lcTreeName";
            this.lcTreeName.Size = new System.Drawing.Size(36, 14);
            this.lcTreeName.StyleController = this.lcMain;
            this.lcTreeName.TabIndex = 10;
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
            // OrganizationGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "OrganizationGridView";
            this.Size = new System.Drawing.Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPagination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrganization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrganization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTreeTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTreeName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.Columns.TreeListColumn colDisplayName;
        private DevExpress.XtraGrid.GridControl gridOrganization;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrganization;
        private DevExpress.XtraGrid.Columns.GridColumn gcNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gcDisplayName;
        private DevExpress.XtraGrid.Columns.GridColumn gcCategory;
        private DevExpress.XtraGrid.Columns.GridColumn gcListOrder;
        private DevExpress.XtraGrid.Columns.GridColumn gcStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gcEmpty;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciGrid;
        private DevExpress.XtraEditors.LabelControl lcTreeName;
        private DevExpress.XtraEditors.LabelControl lcTreeTitle;
        private DevExpress.XtraLayout.LayoutControlItem lciTreeTitle;
        private DevExpress.XtraLayout.LayoutControlItem lciTreeName;
    }
}
