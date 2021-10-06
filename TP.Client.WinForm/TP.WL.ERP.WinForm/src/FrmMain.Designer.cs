namespace TP.WL.ERP.WinForm
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rcMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager();
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView();
            ((System.ComponentModel.ISupportInitialize)(this.rcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            this.SuspendLayout();
            // 
            // rcMain
            // 
            this.rcMain.ExpandCollapseItem.Id = 0;
            this.rcMain.Location = new System.Drawing.Point(0, 0);
            this.rcMain.MaxItemId = 6;
            this.rcMain.Name = "rcMain";
            this.rcMain.Size = new System.Drawing.Size(1014, 50);
            // 
            // documentManager
            // 
            this.documentManager.ContainerControl = this;
            this.documentManager.MenuManager = this.rcMain;
            this.documentManager.View = this.tabbedView;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView});
            // 
            // tabbedView
            // 
            this.tabbedView.RootContainer.Element = null;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 763);
            this.Controls.Add(this.rcMain);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "frmMain";
            this.Ribbon = this.rcMain;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "東莞永生商標印刷有限公司";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.rcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rcMain;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
    }
}

