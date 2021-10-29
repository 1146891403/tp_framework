namespace TP.WL.ERP.WinForm.Ship.Controls
{
    partial class CartonGridView
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JobNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescriptiveName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Edition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CopyRight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DeliveryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Consignee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Notify = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Notify1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Country = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Terms = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnTest = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(12, 38);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(880, 562);
            this.gridControl.TabIndex = 7;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.JobNumber,
            this.DescriptiveName,
            this.Edition,
            this.CopyRight,
            this.DeliveryDate,
            this.Consignee,
            this.Notify,
            this.Notify1,
            this.Country,
            this.Terms});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsSelection.MultiSelect = true;
            this.gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 91;
            // 
            // JobNumber
            // 
            this.JobNumber.Caption = "书号";
            this.JobNumber.FieldName = "JobNumber";
            this.JobNumber.Name = "JobNumber";
            this.JobNumber.Visible = true;
            this.JobNumber.VisibleIndex = 0;
            this.JobNumber.Width = 206;
            // 
            // DescriptiveName
            // 
            this.DescriptiveName.Caption = "书名";
            this.DescriptiveName.FieldName = "DescriptiveName";
            this.DescriptiveName.Name = "DescriptiveName";
            this.DescriptiveName.Visible = true;
            this.DescriptiveName.VisibleIndex = 1;
            this.DescriptiveName.Width = 249;
            // 
            // Edition
            // 
            this.Edition.Caption = "版本";
            this.Edition.FieldName = "Edition";
            this.Edition.Name = "Edition";
            this.Edition.Visible = true;
            this.Edition.VisibleIndex = 2;
            this.Edition.Width = 134;
            // 
            // CopyRight
            // 
            this.CopyRight.Caption = "版权";
            this.CopyRight.FieldName = "CopyRight";
            this.CopyRight.Name = "CopyRight";
            this.CopyRight.Visible = true;
            this.CopyRight.VisibleIndex = 3;
            this.CopyRight.Width = 153;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.Caption = "交货日期";
            this.DeliveryDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.DeliveryDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DeliveryDate.FieldName = "DeliveryDate";
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.Visible = true;
            this.DeliveryDate.VisibleIndex = 4;
            this.DeliveryDate.Width = 72;
            // 
            // Consignee
            // 
            this.Consignee.Caption = "收货人";
            this.Consignee.FieldName = "Consignee";
            this.Consignee.Name = "Consignee";
            this.Consignee.Visible = true;
            this.Consignee.VisibleIndex = 5;
            this.Consignee.Width = 72;
            // 
            // Notify
            // 
            this.Notify.Caption = "联系人";
            this.Notify.FieldName = "Notify";
            this.Notify.Name = "Notify";
            this.Notify.Visible = true;
            this.Notify.VisibleIndex = 6;
            this.Notify.Width = 107;
            // 
            // Notify1
            // 
            this.Notify1.Caption = "联系人1";
            this.Notify1.FieldName = "Notify1";
            this.Notify1.Name = "Notify1";
            this.Notify1.Visible = true;
            this.Notify1.VisibleIndex = 7;
            this.Notify1.Width = 103;
            // 
            // Country
            // 
            this.Country.Caption = "国家";
            this.Country.FieldName = "Country";
            this.Country.Name = "Country";
            this.Country.Visible = true;
            this.Country.VisibleIndex = 8;
            this.Country.Width = 72;
            // 
            // Terms
            // 
            this.Terms.Caption = "条款";
            this.Terms.FieldName = "Terms";
            this.Terms.Name = "Terms";
            this.Terms.Visible = true;
            this.Terms.VisibleIndex = 9;
            this.Terms.Width = 88;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(330, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(562, 22);
            this.btnTest.StyleController = this.layoutControl1;
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "测试";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSearch);
            this.layoutControl1.Controls.Add(this.btnNew);
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.btnTest);
            this.layoutControl1.Controls.Add(this.gridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(437, 239, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(904, 612);
            this.layoutControl1.TabIndex = 12;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(247, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 22);
            this.btnSearch.StyleController = this.layoutControl1;
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "查询";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(81, 22);
            this.btnNew.StyleController = this.layoutControl1;
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "新增";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(167, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 22);
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "删除";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(97, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 22);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "保存";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(904, 612);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(884, 566);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnTest;
            this.layoutControlItem2.Location = new System.Drawing.Point(318, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(566, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnNew;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(85, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnSave;
            this.layoutControlItem3.Location = new System.Drawing.Point(85, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(70, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnDelete;
            this.layoutControlItem4.Location = new System.Drawing.Point(155, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnSearch;
            this.layoutControlItem6.Location = new System.Drawing.Point(235, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(83, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // CartonGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "CartonGridView";
            this.Size = new System.Drawing.Size(904, 612);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn JobNumber;
        private DevExpress.XtraGrid.Columns.GridColumn DescriptiveName;
        private DevExpress.XtraGrid.Columns.GridColumn Edition;
        private DevExpress.XtraGrid.Columns.GridColumn CopyRight;
        private DevExpress.XtraGrid.Columns.GridColumn DeliveryDate;
        private DevExpress.XtraGrid.Columns.GridColumn Consignee;
        private DevExpress.XtraGrid.Columns.GridColumn Notify;
        private DevExpress.XtraGrid.Columns.GridColumn Notify1;
        private DevExpress.XtraGrid.Columns.GridColumn Country;
        private DevExpress.XtraGrid.Columns.GridColumn Terms;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnTest;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}
