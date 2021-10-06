using System;

namespace TP.Client.WinForm.Common.Controls
{
    public partial class GridReportViewBase : ControlBase
    {
        public GridReportViewBase()
        {
            InitializeComponent();
            
            btnSearch.Click += new EventHandler(BtnSearch_Click);
            btnNew.Click += new EventHandler(BtnNew_Click);
            pagination.PageChanged += new PageChangedEventHandler(Pagination_PageChanged);
        }

        protected override void MainView_DataSourceChanged(object sender, EventArgs e)
        {
            base.MainView_DataSourceChanged(sender, e);

            pagination.InitPageInfo(TotalRecords);
        }

        protected override void OnLoad(EventArgs e)
        {
            splitter.X = Convert.ToInt32(this.Width * 0.6m);

            base.OnLoad(e);
        }

        protected override void InitializeControl()
        {
            base.InitializeControl();

            InitializeReportControl();
        }

        protected virtual void InitializeReportControl() { }
    }
}
