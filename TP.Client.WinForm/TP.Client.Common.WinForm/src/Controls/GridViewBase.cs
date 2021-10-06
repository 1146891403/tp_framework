using System;

namespace TP.Client.WinForm.Common.Controls
{
    public partial class GridViewBase : ControlBase
    {
        public GridViewBase()
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
    }
}
