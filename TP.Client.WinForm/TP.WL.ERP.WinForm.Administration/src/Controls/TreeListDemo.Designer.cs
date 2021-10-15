namespace TP.WL.ERP.WinForm.Administration.Controls
{
    partial class TreeListDemo
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeListDemo));
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.DisplayName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ListOrder = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Number = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Id = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ParentId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lciPagination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // lciPagination
            // 
            this.lciPagination.Size = new System.Drawing.Size(735, 42);
            // 
            // lcgSearch
            // 
            this.lcgSearch.Size = new System.Drawing.Size(735, 93);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.treeList1);
            this.lcMain.Size = new System.Drawing.Size(755, 449);
            this.lcMain.Controls.SetChildIndex(this.pagination, 0);
            this.lcMain.Controls.SetChildIndex(this.btnSearch, 0);
            this.lcMain.Controls.SetChildIndex(this.btnNew, 0);
            this.lcMain.Controls.SetChildIndex(this.treeList1, 0);
            // 
            // lcgMain
            // 
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.lcgMain.Size = new System.Drawing.Size(755, 449);
            // 
            // pagination
            // 
            this.pagination.Size = new System.Drawing.Size(731, 38);
            // 
            // esiRight
            // 
            this.esiRight.Location = new System.Drawing.Point(691, 0);
            // 
            // lciBtnSearch
            // 
            this.lciBtnSearch.Location = new System.Drawing.Point(531, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.Location = new System.Drawing.Point(557, 47);
            // 
            // lciBtnNew
            // 
            this.lciBtnNew.Location = new System.Drawing.Point(611, 0);
            // 
            // btnNew
            // 
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.Location = new System.Drawing.Point(637, 47);
            // 
            // esiLeft
            // 
            this.esiLeft.Size = new System.Drawing.Size(531, 48);
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.DisplayName,
            this.ListOrder,
            this.Number,
            this.Id,
            this.ParentId});
            this.treeList1.Location = new System.Drawing.Point(12, 147);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(731, 290);
            this.treeList1.TabIndex = 5;
            // 
            // DisplayName
            // 
            this.DisplayName.Caption = "显示名称";
            this.DisplayName.FieldName = "DisplayName";
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.OptionsColumn.AllowSort = true;
            this.DisplayName.Visible = true;
            this.DisplayName.VisibleIndex = 0;
            // 
            // ListOrder
            // 
            this.ListOrder.Caption = "排序";
            this.ListOrder.FieldName = "ListOrder";
            this.ListOrder.Name = "ListOrder";
            this.ListOrder.OptionsColumn.AllowSort = true;
            this.ListOrder.Visible = true;
            this.ListOrder.VisibleIndex = 1;
            // 
            // Number
            // 
            this.Number.Caption = "Number";
            this.Number.FieldName = "Number";
            this.Number.Name = "Number";
            this.Number.OptionsColumn.AllowSort = true;
            this.Number.Visible = true;
            this.Number.VisibleIndex = 2;
            // 
            // Id
            // 
            this.Id.Caption = "ID";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.OptionsColumn.AllowSort = true;
            this.Id.Visible = true;
            this.Id.VisibleIndex = 3;
            // 
            // ParentId
            // 
            this.ParentId.Caption = "ParentID";
            this.ParentId.FieldName = "ParentId";
            this.ParentId.Name = "ParentId";
            this.ParentId.OptionsColumn.AllowSort = true;
            this.ParentId.Visible = true;
            this.ParentId.VisibleIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.treeList1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 135);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(735, 294);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // TreeListDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TreeListDemo";
            this.Size = new System.Drawing.Size(755, 449);
            this.Load += new System.EventHandler(this.TreeListDemo_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.lciPagination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Id;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ParentId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn DisplayName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ListOrder;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Number;
    }
}
