using System;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;

namespace TP.Client.WinForm.Common.Controls
{
    public partial class ReportView : XtraUserControl
    {
        public ReportView()
        {
            InitializeComponent();

            barBtnEdit.ItemClick += new ItemClickEventHandler(BarBtnEdit_ItemClick);
            barBtnDelete.ItemClick += new ItemClickEventHandler(BarBtnDelete_ItemClick);
            barBtnApprove.ItemClick += new ItemClickEventHandler(BarBtnApprove_ItemClick);
            barBtnReject.ItemClick += new ItemClickEventHandler(BarBtnReject_ItemClick);
            barBtnPrev.ItemClick += new ItemClickEventHandler(BarBtnPrev_ItemClick);
            barBtnNext.ItemClick += new ItemClickEventHandler(BarBtnNext_ItemClick);
            barBtnPrint.ItemClick += new ItemClickEventHandler(BarBtnPrint_ItemClick);
            barBtnExportPdf.ItemClick += new ItemClickEventHandler(BarBtnExportPdf_ItemClick);
            documentViewer.ZoomChanged += new EventHandler(DocumentViewer_ZoomChanged);
            beiZoomLevel.EditValueChanged += new EventHandler(BeiZoomLevel_EditValueChanged);

            InitializeButton();
        }

        private bool _canEdit = false;
        public virtual bool CanEdit
        {
            get { return _canEdit; }
            set
            {
                if (_canEdit != value)
                    _canEdit = value;

                this.barBtnEdit.Visibility = value ? BarItemVisibility.Always : BarItemVisibility.Never;
            }
        }

        private bool _canDelete = false;
        public virtual bool CanDelete
        {
            get { return _canDelete; }
            set
            {
                if (_canDelete != value)
                    _canDelete = value;

                this.barBtnDelete.Visibility = value ? BarItemVisibility.Always : BarItemVisibility.Never;
            }
        }

        private bool _canApprove = false;
        public virtual bool CanApprove
        {
            get { return _canApprove; }
            set
            {
                if (_canApprove != value)
                    _canApprove = value;

                this.barBtnApprove.Visibility = value ? BarItemVisibility.Always : BarItemVisibility.Never;
                this.barBtnReject.Visibility = value ? BarItemVisibility.Always : BarItemVisibility.Never;
            }
        }

        private XtraReport _report;
        public virtual XtraReport Report
        {
            get { return _report; }
            set
            {
                if (_report != value)
                {
                    if (_report != null) _report.Dispose();

                    _report = value;

                    if (_report == null) return;

                    Invalidate();
                    Update();
                    this.documentViewer.PrintingSystem = _report.PrintingSystem;
                    _report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ClosePreview, DevExpress.XtraPrinting.CommandVisibility.None);
                }
            }
        }

        private int _zoomLevel = 10;
        public virtual int ZoomLevel
        {
            get { return _zoomLevel; }
            set
            {
                if (_zoomLevel != value)
                {
                    _zoomLevel = value;
                    OnZoomLevelChanged(value);
                }
            }
        }
        
        public virtual void InitializeButton()
        {
            this.CanEdit = false;
            this.CanDelete = false;
            this.CanApprove = false;
        }

        public virtual XtraReport CreateReport(XtraReport report) => report;

        public virtual void Activate(XtraReport report)
        {
            if (this.Report != null || DesignMode) return;

            this.Report = CreateReport(report);

            this.Report.ReportPrintOptions.DetailCountAtDesignTime = 0;

            foreach (XtraReportBase item in this.Report.AllControls<XtraReportBase>())
                item.ReportPrintOptions.DetailCountAtDesignTime = 0;

            this.Report.CreateDocument(true);

            this.ZoomLevel = 80;
        }

        private void OnZoomLevelChanged(int zoom)
        {
            if (Convert.ToInt32(beiZoomLevel.EditValue) != zoom) beiZoomLevel.EditValue = zoom;

            if (Convert.ToInt32(documentViewer.Zoom * 100) != zoom) documentViewer.Zoom = zoom / 100f;

            bsiZoomText.Caption = $"{zoom}%";
        }

        public event EventHandler EditClick;
        private void BarBtnEdit_ItemClick(object sender, ItemClickEventArgs e) => EditClick?.Invoke(sender, e);

        public event EventHandler DeleteClick;
        private void BarBtnDelete_ItemClick(object sender, ItemClickEventArgs e) => DeleteClick?.Invoke(sender, e);

        public event EventHandler ApproveClick;
        private void BarBtnApprove_ItemClick(object sender, ItemClickEventArgs e) => ApproveClick?.Invoke(sender, e);

        public event EventHandler RejectClick;
        private void BarBtnReject_ItemClick(object sender, ItemClickEventArgs e) => RejectClick?.Invoke(sender, e);

        public event EventHandler PreviousClick;
        private void BarBtnPrev_ItemClick(object sender, ItemClickEventArgs e) => PreviousClick?.Invoke(sender, e);

        public event EventHandler NextClick;
        private void BarBtnNext_ItemClick(object sender, ItemClickEventArgs e) => NextClick?.Invoke(sender, e);
        
        private void BarBtnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (ReportPrintTool printTool = new ReportPrintTool(this.Report))
            {
                printTool.PrintDialog();
            }
        }

        private void BarBtnExportPdf_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void BeiZoomLevel_EditValueChanged(object sender, EventArgs e)
        {
            this.ZoomLevel = Convert.ToInt32(beiZoomLevel.EditValue);
        }

        private void DocumentViewer_ZoomChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(documentViewer.Zoom * 100) > zoomLevelTrackBar.Maximum)
                this.ZoomLevel = zoomLevelTrackBar.Maximum;
            
            this.ZoomLevel = Convert.ToInt32(documentViewer.Zoom * 100);
        }
    }
}
