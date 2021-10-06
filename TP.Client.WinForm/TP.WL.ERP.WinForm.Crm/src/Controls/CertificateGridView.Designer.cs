namespace TP.WL.ERP.WinForm.Crm.Controls
{
    partial class CertificateGridView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CertificateGridView));
            this.gridCertificate = new DevExpress.XtraGrid.GridControl();
            this.gvCertificate = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lciGridCertificate = new DevExpress.XtraLayout.LayoutControlItem();
            this.gcNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDisplayName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcIsGuarantee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcIsTestReport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLifetimeScope = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcIsDefault = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPagination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCertificate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCertificate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridCertificate)).BeginInit();
            this.SuspendLayout();
            // 
            // lciPagination
            // 
            this.lciPagination.Location = new System.Drawing.Point(0, 538);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.gridCertificate);
            this.lcMain.Size = new System.Drawing.Size(800, 600);
            this.lcMain.Controls.SetChildIndex(this.pagination, 0);
            this.lcMain.Controls.SetChildIndex(this.btnSearch, 0);
            this.lcMain.Controls.SetChildIndex(this.btnNew, 0);
            this.lcMain.Controls.SetChildIndex(this.gridCertificate, 0);
            // 
            // lcgMain
            // 
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciGridCertificate});
            this.lcgMain.Size = new System.Drawing.Size(800, 600);
            // 
            // pagination
            // 
            this.pagination.Location = new System.Drawing.Point(12, 550);
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            // 
            // btnNew
            // 
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            // 
            // gridCertificate
            // 
            this.gridCertificate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCertificate.Location = new System.Drawing.Point(12, 103);
            this.gridCertificate.MainView = this.gvCertificate;
            this.gridCertificate.Name = "gridCertificate";
            this.gridCertificate.Size = new System.Drawing.Size(776, 443);
            this.gridCertificate.TabIndex = 7;
            this.gridCertificate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCertificate});
            // 
            // gvCertificate
            // 
            this.gvCertificate.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcNumber,
            this.gcDisplayName,
            this.gcIsGuarantee,
            this.gcIsTestReport,
            this.gcLifetimeScope,
            this.gcStartDate,
            this.gcEndDate,
            this.gcIsDefault});
            this.gvCertificate.GridControl = this.gridCertificate;
            this.gvCertificate.Name = "gvCertificate";
            this.gvCertificate.OptionsView.ShowGroupPanel = false;
            // 
            // lciGridCertificate
            // 
            this.lciGridCertificate.Control = this.gridCertificate;
            this.lciGridCertificate.Location = new System.Drawing.Point(0, 91);
            this.lciGridCertificate.Name = "lciGridCertificate";
            this.lciGridCertificate.Size = new System.Drawing.Size(780, 447);
            this.lciGridCertificate.TextSize = new System.Drawing.Size(0, 0);
            this.lciGridCertificate.TextVisible = false;
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
            this.gcDisplayName.Caption = "認證名稱";
            this.gcDisplayName.FieldName = "DisplayName";
            this.gcDisplayName.Name = "gcDisplayName";
            this.gcDisplayName.Visible = true;
            this.gcDisplayName.VisibleIndex = 1;
            // 
            // gcIsGuarantee
            // 
            this.gcIsGuarantee.Caption = "保證書";
            this.gcIsGuarantee.FieldName = "IsGuarantee";
            this.gcIsGuarantee.Name = "gcIsGuarantee";
            this.gcIsGuarantee.Visible = true;
            this.gcIsGuarantee.VisibleIndex = 2;
            // 
            // gcIsTestReport
            // 
            this.gcIsTestReport.Caption = "檢測報告";
            this.gcIsTestReport.FieldName = "IsTestReport";
            this.gcIsTestReport.Name = "gcIsTestReport";
            this.gcIsTestReport.Visible = true;
            this.gcIsTestReport.VisibleIndex = 3;
            // 
            // gcLifetimeScope
            // 
            this.gcLifetimeScope.Caption = "年限";
            this.gcLifetimeScope.FieldName = "LifetimeScope";
            this.gcLifetimeScope.Name = "gcLifetimeScope";
            this.gcLifetimeScope.Visible = true;
            this.gcLifetimeScope.VisibleIndex = 4;
            // 
            // gcStartDate
            // 
            this.gcStartDate.Caption = "生效日期";
            this.gcStartDate.FieldName = "StartDate";
            this.gcStartDate.Name = "gcStartDate";
            this.gcStartDate.Visible = true;
            this.gcStartDate.VisibleIndex = 5;
            // 
            // gcEndDate
            // 
            this.gcEndDate.Caption = "最後限期";
            this.gcEndDate.FieldName = "EndDate";
            this.gcEndDate.Name = "gcEndDate";
            this.gcEndDate.Visible = true;
            this.gcEndDate.VisibleIndex = 6;
            // 
            // gcIsDefault
            // 
            this.gcIsDefault.Caption = "默認";
            this.gcIsDefault.FieldName = "IsDefault";
            this.gcIsDefault.Name = "gcIsDefault";
            this.gcIsDefault.Visible = true;
            this.gcIsDefault.VisibleIndex = 7;
            // 
            // CertificateGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CertificateGridView";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.lciPagination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCertificate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCertificate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridCertificate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCertificate;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCertificate;
        private DevExpress.XtraLayout.LayoutControlItem lciGridCertificate;
        private DevExpress.XtraGrid.Columns.GridColumn gcNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gcDisplayName;
        private DevExpress.XtraGrid.Columns.GridColumn gcIsGuarantee;
        private DevExpress.XtraGrid.Columns.GridColumn gcIsTestReport;
        private DevExpress.XtraGrid.Columns.GridColumn gcLifetimeScope;
        private DevExpress.XtraGrid.Columns.GridColumn gcStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn gcEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn gcIsDefault;
    }
}
