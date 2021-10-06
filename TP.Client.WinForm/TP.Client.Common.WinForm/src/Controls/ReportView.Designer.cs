namespace TP.Client.WinForm.Common.Controls
{
    partial class ReportView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportView));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barAction = new DevExpress.XtraBars.Bar();
            this.barBtnEdit = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBtnDelete = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBtnApprove = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBtnReject = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBtnPrev = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBtnNext = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBtnPrint = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBottom = new DevExpress.XtraBars.Bar();
            this.beiZoomLevel = new DevExpress.XtraBars.BarEditItem();
            this.zoomLevelTrackBar = new DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar();
            this.bsiZoomText = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lcReportViewer = new DevExpress.XtraLayout.LayoutControl();
            this.documentViewer = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.lcgReportViewer = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciReportViewer = new DevExpress.XtraLayout.LayoutControlItem();
            this.barBtnExportPdf = new DevExpress.XtraBars.BarLargeButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomLevelTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcReportViewer)).BeginInit();
            this.lcReportViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgReportViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReportViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barAction,
            this.barBottom});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnEdit,
            this.barBtnDelete,
            this.barBtnApprove,
            this.barBtnReject,
            this.barBtnPrint,
            this.barBtnPrev,
            this.barBtnNext,
            this.beiZoomLevel,
            this.bsiZoomText,
            this.barBtnExportPdf});
            this.barManager.MaxItemId = 31;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.zoomLevelTrackBar});
            this.barManager.StatusBar = this.barBottom;
            // 
            // barAction
            // 
            this.barAction.BarName = "Actions";
            this.barAction.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.barAction.DockCol = 0;
            this.barAction.DockRow = 0;
            this.barAction.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barAction.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnApprove),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnReject),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnPrev),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnNext),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnExportPdf)});
            this.barAction.OptionsBar.AllowQuickCustomization = false;
            this.barAction.OptionsBar.DrawBorder = false;
            this.barAction.OptionsBar.DrawDragBorder = false;
            this.barAction.OptionsBar.UseWholeRow = true;
            this.barAction.Text = "Actions";
            // 
            // barBtnEdit
            // 
            this.barBtnEdit.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.barBtnEdit.Caption = "編輯";
            this.barBtnEdit.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.barBtnEdit.Id = 8;
            this.barBtnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnEdit.ImageOptions.Image")));
            this.barBtnEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnEdit.ImageOptions.LargeImage")));
            this.barBtnEdit.Name = "barBtnEdit";
            this.barBtnEdit.ShowCaptionOnBar = false;
            // 
            // barBtnDelete
            // 
            this.barBtnDelete.Caption = "刪除";
            this.barBtnDelete.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.barBtnDelete.Id = 9;
            this.barBtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDelete.ImageOptions.Image")));
            this.barBtnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnDelete.ImageOptions.LargeImage")));
            this.barBtnDelete.Name = "barBtnDelete";
            this.barBtnDelete.ShowCaptionOnBar = false;
            // 
            // barBtnApprove
            // 
            this.barBtnApprove.Caption = "批准";
            this.barBtnApprove.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.barBtnApprove.Id = 10;
            this.barBtnApprove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnApprove.ImageOptions.Image")));
            this.barBtnApprove.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnApprove.ImageOptions.LargeImage")));
            this.barBtnApprove.Name = "barBtnApprove";
            this.barBtnApprove.ShowCaptionOnBar = false;
            // 
            // barBtnReject
            // 
            this.barBtnReject.Caption = "拒絕";
            this.barBtnReject.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.barBtnReject.Id = 11;
            this.barBtnReject.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnReject.ImageOptions.Image")));
            this.barBtnReject.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnReject.ImageOptions.LargeImage")));
            this.barBtnReject.Name = "barBtnReject";
            this.barBtnReject.ShowCaptionOnBar = false;
            // 
            // barBtnPrev
            // 
            this.barBtnPrev.Caption = "上一條";
            this.barBtnPrev.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.barBtnPrev.Id = 13;
            this.barBtnPrev.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnPrev.ImageOptions.Image")));
            this.barBtnPrev.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnPrev.ImageOptions.LargeImage")));
            this.barBtnPrev.Name = "barBtnPrev";
            this.barBtnPrev.ShowCaptionOnBar = false;
            // 
            // barBtnNext
            // 
            this.barBtnNext.Caption = "下一條";
            this.barBtnNext.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.barBtnNext.Id = 14;
            this.barBtnNext.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnNext.ImageOptions.Image")));
            this.barBtnNext.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnNext.ImageOptions.LargeImage")));
            this.barBtnNext.Name = "barBtnNext";
            this.barBtnNext.ShowCaptionOnBar = false;
            // 
            // barBtnPrint
            // 
            this.barBtnPrint.Caption = "打印";
            this.barBtnPrint.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.barBtnPrint.Id = 12;
            this.barBtnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnPrint.ImageOptions.Image")));
            this.barBtnPrint.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnPrint.ImageOptions.LargeImage")));
            this.barBtnPrint.Name = "barBtnPrint";
            this.barBtnPrint.ShowCaptionOnBar = false;
            // 
            // barBottom
            // 
            this.barBottom.BarName = "Zoom";
            this.barBottom.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.barBottom.DockCol = 0;
            this.barBottom.DockRow = 0;
            this.barBottom.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barBottom.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.beiZoomLevel),
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiZoomText)});
            this.barBottom.OptionsBar.AllowQuickCustomization = false;
            this.barBottom.OptionsBar.DrawBorder = false;
            this.barBottom.OptionsBar.DrawDragBorder = false;
            this.barBottom.OptionsBar.UseWholeRow = true;
            this.barBottom.Text = "Zoom";
            // 
            // beiZoomLevel
            // 
            this.beiZoomLevel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.beiZoomLevel.CaptionAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.beiZoomLevel.Edit = this.zoomLevelTrackBar;
            this.beiZoomLevel.EditValue = "10";
            this.beiZoomLevel.EditWidth = 150;
            this.beiZoomLevel.Id = 15;
            this.beiZoomLevel.Name = "beiZoomLevel";
            // 
            // zoomLevelTrackBar
            // 
            this.zoomLevelTrackBar.Alignment = DevExpress.Utils.VertAlignment.Center;
            this.zoomLevelTrackBar.AllowUseMiddleValue = true;
            this.zoomLevelTrackBar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.zoomLevelTrackBar.Maximum = 200;
            this.zoomLevelTrackBar.Middle = 100;
            this.zoomLevelTrackBar.Minimum = 10;
            this.zoomLevelTrackBar.Name = "zoomLevelTrackBar";
            // 
            // bsiZoomText
            // 
            this.bsiZoomText.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiZoomText.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None;
            this.bsiZoomText.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.bsiZoomText.Caption = "100%";
            this.bsiZoomText.Id = 19;
            this.bsiZoomText.Name = "bsiZoomText";
            this.bsiZoomText.Size = new System.Drawing.Size(50, 0);
            this.bsiZoomText.Width = 50;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(700, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 454);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(700, 26);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 407);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(700, 47);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 407);
            // 
            // lcReportViewer
            // 
            this.lcReportViewer.Controls.Add(this.documentViewer);
            this.lcReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcReportViewer.Location = new System.Drawing.Point(0, 47);
            this.lcReportViewer.Name = "lcReportViewer";
            this.lcReportViewer.Root = this.lcgReportViewer;
            this.lcReportViewer.Size = new System.Drawing.Size(700, 407);
            this.lcReportViewer.TabIndex = 5;
            this.lcReportViewer.Text = "layoutControl1";
            // 
            // documentViewer
            // 
            this.documentViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewer.IsMetric = true;
            this.documentViewer.Location = new System.Drawing.Point(2, 2);
            this.documentViewer.Name = "documentViewer";
            this.documentViewer.Size = new System.Drawing.Size(696, 398);
            this.documentViewer.TabIndex = 4;
            this.documentViewer.TabStop = false;
            // 
            // lcgReportViewer
            // 
            this.lcgReportViewer.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgReportViewer.GroupBordersVisible = false;
            this.lcgReportViewer.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciReportViewer});
            this.lcgReportViewer.Name = "lcgReportViewer";
            this.lcgReportViewer.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 5);
            this.lcgReportViewer.Size = new System.Drawing.Size(700, 407);
            this.lcgReportViewer.TextVisible = false;
            // 
            // lciReportViewer
            // 
            this.lciReportViewer.Control = this.documentViewer;
            this.lciReportViewer.Location = new System.Drawing.Point(0, 0);
            this.lciReportViewer.Name = "lciReportViewer";
            this.lciReportViewer.Size = new System.Drawing.Size(700, 402);
            this.lciReportViewer.TextSize = new System.Drawing.Size(0, 0);
            this.lciReportViewer.TextVisible = false;
            // 
            // barBtnExportPdf
            // 
            this.barBtnExportPdf.Caption = "導出到PDF";
            this.barBtnExportPdf.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.barBtnExportPdf.Id = 30;
            this.barBtnExportPdf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnExportPdf.ImageOptions.Image")));
            this.barBtnExportPdf.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnExportPdf.ImageOptions.LargeImage")));
            this.barBtnExportPdf.Name = "barBtnExportPdf";
            this.barBtnExportPdf.ShowCaptionOnBar = false;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcReportViewer);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ReportView";
            this.Size = new System.Drawing.Size(700, 480);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomLevelTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcReportViewer)).EndInit();
            this.lcReportViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgReportViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReportViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar barAction;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem barBtnEdit;
        private DevExpress.XtraBars.BarLargeButtonItem barBtnDelete;
        private DevExpress.XtraBars.BarLargeButtonItem barBtnApprove;
        private DevExpress.XtraBars.BarLargeButtonItem barBtnReject;
        private DevExpress.XtraBars.BarLargeButtonItem barBtnPrint;
        private DevExpress.XtraBars.BarLargeButtonItem barBtnPrev;
        private DevExpress.XtraBars.BarLargeButtonItem barBtnNext;
        private DevExpress.XtraLayout.LayoutControl lcReportViewer;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer;
        private DevExpress.XtraLayout.LayoutControlGroup lcgReportViewer;
        private DevExpress.XtraLayout.LayoutControlItem lciReportViewer;
        private DevExpress.XtraBars.Bar barBottom;
        private DevExpress.XtraBars.BarEditItem beiZoomLevel;
        private DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar zoomLevelTrackBar;
        private DevExpress.XtraBars.BarStaticItem bsiZoomText;
        private DevExpress.XtraBars.BarLargeButtonItem barBtnExportPdf;
    }
}
