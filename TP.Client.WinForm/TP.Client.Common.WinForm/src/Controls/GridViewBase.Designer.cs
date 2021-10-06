namespace TP.Client.WinForm.Common.Controls
{
    partial class GridViewBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridViewBase));
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.pagination = new TP.Client.WinForm.Common.Controls.Pagination();
            this.lciPagination = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgSearch = new DevExpress.XtraLayout.LayoutControlGroup();
            this.esiLeft = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lciBtnSearch = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.lciBtnNew = new DevExpress.XtraLayout.LayoutControlItem();
            this.esiRight = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPagination)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.btnNew);
            this.lcMain.Controls.Add(this.btnSearch);
            this.lcMain.Controls.Add(this.pagination);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(800, 153);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "lcMain";
            // 
            // lcgMain
            // 
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPagination,
            this.lcgSearch});
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Size = new System.Drawing.Size(800, 153);
            this.lcgMain.TextVisible = false;
            // 
            // lcgSearch
            // 
            this.lcgSearch.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.esiLeft,
            this.lciBtnSearch,
            this.lciBtnNew,
            this.esiRight});
            this.lcgSearch.Location = new System.Drawing.Point(0, 0);
            this.lcgSearch.Name = "lcgSearch";
            this.lcgSearch.Size = new System.Drawing.Size(780, 91);
            this.lcgSearch.Text = "高級查詢";
            // 
            // esiLeft
            // 
            this.esiLeft.AllowHotTrack = false;
            this.esiLeft.Location = new System.Drawing.Point(0, 0);
            this.esiLeft.Name = "esiLeft";
            this.esiLeft.Size = new System.Drawing.Size(576, 48);
            this.esiLeft.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.Location = new System.Drawing.Point(602, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 40);
            this.btnSearch.StyleController = this.lcMain;
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查詢";
            // 
            // lciBtnSearch
            // 
            this.lciBtnSearch.Control = this.btnSearch;
            this.lciBtnSearch.Location = new System.Drawing.Point(576, 0);
            this.lciBtnSearch.MaxSize = new System.Drawing.Size(80, 48);
            this.lciBtnSearch.MinSize = new System.Drawing.Size(80, 26);
            this.lciBtnSearch.Name = "lciBtnSearch";
            this.lciBtnSearch.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lciBtnSearch.Size = new System.Drawing.Size(80, 48);
            this.lciBtnSearch.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciBtnSearch.TextSize = new System.Drawing.Size(0, 0);
            this.lciBtnSearch.TextVisible = false;
            // 
            // btnNew
            // 
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnNew.Location = new System.Drawing.Point(682, 45);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(72, 40);
            this.btnNew.StyleController = this.lcMain;
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "新建";
            // 
            // lciBtnNew
            // 
            this.lciBtnNew.Control = this.btnNew;
            this.lciBtnNew.Location = new System.Drawing.Point(656, 0);
            this.lciBtnNew.MaxSize = new System.Drawing.Size(80, 48);
            this.lciBtnNew.MinSize = new System.Drawing.Size(80, 48);
            this.lciBtnNew.Name = "lciBtnNew";
            this.lciBtnNew.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lciBtnNew.Size = new System.Drawing.Size(80, 48);
            this.lciBtnNew.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciBtnNew.TextSize = new System.Drawing.Size(0, 0);
            this.lciBtnNew.TextVisible = false;
            // 
            // esiRight
            // 
            this.esiRight.AllowHotTrack = false;
            this.esiRight.Location = new System.Drawing.Point(736, 0);
            this.esiRight.MaxSize = new System.Drawing.Size(20, 0);
            this.esiRight.MinSize = new System.Drawing.Size(20, 48);
            this.esiRight.Name = "esiRight";
            this.esiRight.Size = new System.Drawing.Size(20, 48);
            this.esiRight.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.esiRight.TextSize = new System.Drawing.Size(0, 0);
            // 
            // pagination
            // 
            this.pagination.Location = new System.Drawing.Point(12, 103);
            this.pagination.Name = "pagination";
            this.pagination.PageIndex = 1;
            this.pagination.PageSize = 30;
            this.pagination.Size = new System.Drawing.Size(776, 38);
            this.pagination.TabIndex = 4;
            this.pagination.TotalRecords = 0;
            // 
            // lciPagination
            // 
            this.lciPagination.Control = this.pagination;
            this.lciPagination.Location = new System.Drawing.Point(0, 91);
            this.lciPagination.MaxSize = new System.Drawing.Size(0, 42);
            this.lciPagination.MinSize = new System.Drawing.Size(600, 42);
            this.lciPagination.Name = "lciPagination";
            this.lciPagination.Size = new System.Drawing.Size(780, 42);
            this.lciPagination.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciPagination.TextSize = new System.Drawing.Size(0, 0);
            this.lciPagination.TextVisible = false;
            // 
            // GridViewBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcMain);
            this.Name = "GridViewBase";
            this.Size = new System.Drawing.Size(800, 153);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPagination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected DevExpress.XtraLayout.LayoutControlItem lciPagination;
        protected DevExpress.XtraLayout.LayoutControlGroup lcgSearch;
        protected DevExpress.XtraLayout.LayoutControl lcMain;
        protected DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        protected Pagination pagination;
        protected DevExpress.XtraLayout.EmptySpaceItem esiRight;
        protected DevExpress.XtraLayout.LayoutControlItem lciBtnSearch;
        protected DevExpress.XtraEditors.SimpleButton btnSearch;
        protected DevExpress.XtraLayout.LayoutControlItem lciBtnNew;
        protected DevExpress.XtraEditors.SimpleButton btnNew;
        protected DevExpress.XtraLayout.EmptySpaceItem esiLeft;
    }
}
