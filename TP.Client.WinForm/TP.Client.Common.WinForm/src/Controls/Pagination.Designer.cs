namespace TP.Client.WinForm.Common.Controls
{
    partial class Pagination
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagination));
            this.pcPagination = new DevExpress.XtraEditors.PanelControl();
            this.lcPageInfo4 = new DevExpress.XtraEditors.LabelControl();
            this.lcPageCount = new DevExpress.XtraEditors.LabelControl();
            this.lcPageInfo2 = new DevExpress.XtraEditors.LabelControl();
            this.lcTotalRecords = new DevExpress.XtraEditors.LabelControl();
            this.lcPageInfo3 = new DevExpress.XtraEditors.LabelControl();
            this.lcPageInfo1 = new DevExpress.XtraEditors.LabelControl();
            this.cbePageSize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.tePageIndex = new DevExpress.XtraEditors.TextEdit();
            this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcPagination)).BeginInit();
            this.pcPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbePageSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePageIndex.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pcPagination
            // 
            this.pcPagination.Controls.Add(this.btnExport);
            this.pcPagination.Controls.Add(this.btnLast);
            this.pcPagination.Controls.Add(this.btnNext);
            this.pcPagination.Controls.Add(this.tePageIndex);
            this.pcPagination.Controls.Add(this.btnPrev);
            this.pcPagination.Controls.Add(this.btnFirst);
            this.pcPagination.Controls.Add(this.lcPageInfo4);
            this.pcPagination.Controls.Add(this.lcPageCount);
            this.pcPagination.Controls.Add(this.lcPageInfo2);
            this.pcPagination.Controls.Add(this.lcTotalRecords);
            this.pcPagination.Controls.Add(this.lcPageInfo3);
            this.pcPagination.Controls.Add(this.lcPageInfo1);
            this.pcPagination.Controls.Add(this.cbePageSize);
            this.pcPagination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcPagination.Location = new System.Drawing.Point(0, 0);
            this.pcPagination.Name = "pcPagination";
            this.pcPagination.Size = new System.Drawing.Size(600, 38);
            this.pcPagination.TabIndex = 0;
            // 
            // lcPageInfo4
            // 
            this.lcPageInfo4.Location = new System.Drawing.Point(259, 12);
            this.lcPageInfo4.Name = "lcPageInfo4";
            this.lcPageInfo4.Size = new System.Drawing.Size(12, 14);
            this.lcPageInfo4.TabIndex = 33;
            this.lcPageInfo4.Text = "頁";
            // 
            // lcPageCount
            // 
            this.lcPageCount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lcPageCount.Location = new System.Drawing.Point(246, 12);
            this.lcPageCount.Name = "lcPageCount";
            this.lcPageCount.Size = new System.Drawing.Size(7, 14);
            this.lcPageCount.TabIndex = 32;
            this.lcPageCount.Text = "0";
            // 
            // lcPageInfo2
            // 
            this.lcPageInfo2.Location = new System.Drawing.Point(71, 12);
            this.lcPageInfo2.Name = "lcPageInfo2";
            this.lcPageInfo2.Size = new System.Drawing.Size(76, 14);
            this.lcPageInfo2.TabIndex = 31;
            this.lcPageInfo2.Text = "條記錄，每頁 ";
            // 
            // lcTotalRecords
            // 
            this.lcTotalRecords.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lcTotalRecords.Location = new System.Drawing.Point(58, 12);
            this.lcTotalRecords.Name = "lcTotalRecords";
            this.lcTotalRecords.Size = new System.Drawing.Size(7, 14);
            this.lcTotalRecords.TabIndex = 30;
            this.lcTotalRecords.Text = "0";
            // 
            // lcPageInfo3
            // 
            this.lcPageInfo3.Location = new System.Drawing.Point(204, 12);
            this.lcPageInfo3.Name = "lcPageInfo3";
            this.lcPageInfo3.Size = new System.Drawing.Size(36, 14);
            this.lcPageInfo3.TabIndex = 29;
            this.lcPageInfo3.Text = "條，共";
            // 
            // lcPageInfo1
            // 
            this.lcPageInfo1.Location = new System.Drawing.Point(40, 12);
            this.lcPageInfo1.Name = "lcPageInfo1";
            this.lcPageInfo1.Size = new System.Drawing.Size(12, 14);
            this.lcPageInfo1.TabIndex = 27;
            this.lcPageInfo1.Text = "共";
            // 
            // cbePageSize
            // 
            this.cbePageSize.EditValue = "";
            this.cbePageSize.Location = new System.Drawing.Point(153, 9);
            this.cbePageSize.Name = "cbePageSize";
            this.cbePageSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbePageSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbePageSize.Size = new System.Drawing.Size(45, 20);
            this.cbePageSize.TabIndex = 28;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.Image")));
            this.btnExport.Location = new System.Drawing.Point(480, 7);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 24);
            this.btnExport.TabIndex = 39;
            this.btnExport.Text = "導出數據";
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.ImageOptions.Image")));
            this.btnLast.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLast.Location = new System.Drawing.Point(444, 9);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(30, 20);
            this.btnLast.TabIndex = 38;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.ImageOptions.Image")));
            this.btnNext.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNext.Location = new System.Drawing.Point(408, 9);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 20);
            this.btnNext.TabIndex = 37;
            // 
            // tePageIndex
            // 
            this.tePageIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tePageIndex.EditValue = "";
            this.tePageIndex.Location = new System.Drawing.Point(367, 9);
            this.tePageIndex.Name = "tePageIndex";
            this.tePageIndex.Properties.Mask.EditMask = "[1-9]\\d*";
            this.tePageIndex.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tePageIndex.Size = new System.Drawing.Size(35, 20);
            this.tePageIndex.TabIndex = 36;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.ImageOptions.Image")));
            this.btnPrev.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPrev.Location = new System.Drawing.Point(331, 9);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(30, 20);
            this.btnPrev.TabIndex = 35;
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirst.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.ImageOptions.Image")));
            this.btnFirst.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFirst.Location = new System.Drawing.Point(295, 9);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(30, 20);
            this.btnFirst.TabIndex = 34;
            // 
            // Pagination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pcPagination);
            this.Name = "Pagination";
            this.Size = new System.Drawing.Size(600, 38);
            ((System.ComponentModel.ISupportInitialize)(this.pcPagination)).EndInit();
            this.pcPagination.ResumeLayout(false);
            this.pcPagination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbePageSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePageIndex.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pcPagination;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.TextEdit tePageIndex;
        private DevExpress.XtraEditors.SimpleButton btnPrev;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private DevExpress.XtraEditors.LabelControl lcPageInfo4;
        private DevExpress.XtraEditors.LabelControl lcPageCount;
        private DevExpress.XtraEditors.LabelControl lcPageInfo2;
        private DevExpress.XtraEditors.LabelControl lcTotalRecords;
        private DevExpress.XtraEditors.LabelControl lcPageInfo3;
        private DevExpress.XtraEditors.LabelControl lcPageInfo1;
        private DevExpress.XtraEditors.ComboBoxEdit cbePageSize;
    }
}
