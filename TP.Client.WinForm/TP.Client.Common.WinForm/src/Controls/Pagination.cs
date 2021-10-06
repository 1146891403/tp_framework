using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TP.Client.WinForm.Common.Controls
{
    public delegate void PageChangedEventHandler(object sender, EventArgs e);

    public partial class Pagination : DevExpress.XtraEditors.XtraUserControl
    {
        public event PageChangedEventHandler PageChanged;

        private int pageIndex = 1;
        private int pageSize = 30;
        private int totalRecords = 0;

        private int lxInfo2;
        private int lxSize;
        private int lxInfo3;
        private int lxCount;
        private int lxInfo4;

        public Pagination()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            lxInfo2 = lcPageInfo2.Location.X;
            lxSize = cbePageSize.Location.X;
            lxInfo3 = lcPageInfo3.Location.X;
            lxCount = lcPageCount.Location.X;
            lxInfo4 = lcPageInfo4.Location.X;
            cbePageSize.Properties.Items.AddRange(GetPageSizes());
            InitPageInfo();
        }

        private void InitComponentEvent()
        {
            btnFirst.Click += new EventHandler(BtnFirst_Click);
            btnPrev.Click += new EventHandler(BtnPrev_Click);
            btnNext.Click += new EventHandler(BtnNext_Click);
            btnLast.Click += new EventHandler(BtnLast_Click);
            tePageIndex.KeyDown += new KeyEventHandler(TextCurrentPage_KeyDown);
            cbePageSize.SelectedValueChanged += new EventHandler(CbePageSize_SelectedValueChanged);
        }

        private void InitBindingModel()
        {
            cbePageSize.Text = pageSize.ToString();
            lcTotalRecords.Text = totalRecords.ToString();
            lcPageCount.Text = PageCount.ToString();
            tePageIndex.Text = pageIndex.ToString();

            Graphics graTotalRecords = Graphics.FromHwnd(lcTotalRecords.Handle);
            SizeF sizeTotalRecords = graTotalRecords.MeasureString(lcTotalRecords.Text, lcTotalRecords.Font);
            graTotalRecords.Dispose();

            Graphics graPageCount = Graphics.FromHwnd(lcPageCount.Handle);
            SizeF sizePageCount = graPageCount.MeasureString(lcPageCount.Text, lcPageCount.Font);
            graPageCount.Dispose();

            int lctrWidth = Convert.ToInt32(sizeTotalRecords.Width) - 10;
            int lcpcWidth = Convert.ToInt32(sizePageCount.Width) - 10;

            lcPageInfo2.Location = new Point(lxInfo2 + lctrWidth, lcPageInfo2.Location.Y);
            cbePageSize.Location = new Point(lxSize + lctrWidth, cbePageSize.Location.Y);
            lcPageInfo3.Location = new Point(lxInfo3 + lctrWidth, lcPageInfo3.Location.Y);
            lcPageCount.Location = new Point(lxCount + lctrWidth, lcPageCount.Location.Y);
            lcPageInfo4.Location = new Point(lxInfo4 + lctrWidth + lcpcWidth, lcPageInfo4.Location.Y);
        }

        private List<int> GetPageSizes()
        {
            return new List<int>() { 30, 50, 100 };
        }

        public int PageIndex
        {
            get { return pageIndex; }
            set { pageIndex = value; }
        }

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value; }
        }

        public int TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

        public int PageCount
        {
            get
            {
                return totalRecords % pageSize > 0 ? totalRecords / pageSize + 1 : totalRecords / pageSize;
            }
        }

        public void InitPageInfo(int totalRecords)
        {
            this.totalRecords = totalRecords;
            this.InitPageInfo();
        }

        public void InitPageInfo()
        {
            if (pageSize < 1)
                pageSize = 30;
            if (totalRecords < 0)
                totalRecords = 0;
            if (pageIndex > PageCount && PageCount > 0)
                pageIndex = PageCount;

            //setting button is enabled
            this.btnFirst.Enabled = pageIndex > 1;
            this.btnPrev.Enabled = pageIndex > 1;
            this.btnNext.Enabled = pageIndex < PageCount;
            this.btnLast.Enabled = pageIndex < PageCount;

            InitBindingModel();
        }

        public void RefreshData()
        {
            OnPageChanged(new EventArgs());
            InitPageInfo();
        }

        protected virtual void OnPageChanged(EventArgs e)
        {
            if (PageChanged != null)
            {
                PageChanged(this, e);
            }
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            pageIndex = 1;

            this.RefreshData();
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            pageIndex = pageIndex > 1 ? pageIndex - 1 : 1;

            this.RefreshData();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            pageIndex = pageIndex < PageCount ? pageIndex + 1 : pageIndex < 1 ? 1 : PageCount;

            this.RefreshData();
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            pageIndex = PageCount > 1 ? PageCount : 1;

            this.RefreshData();
        }

        private void TextCurrentPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    pageIndex = Convert.ToInt32(this.tePageIndex.Text);
                }
                catch
                {
                    pageIndex = 1;
                }

                if (pageIndex > PageCount)
                    pageIndex = PageCount;

                this.RefreshData();
            }
        }

        private void CbePageSize_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectValue = Convert.ToInt32(this.cbePageSize.Text);
            if (pageSize != selectValue)
            {
                pageSize = Convert.ToInt32(this.cbePageSize.Text);

                this.RefreshData();
            }
        }
    }
}
