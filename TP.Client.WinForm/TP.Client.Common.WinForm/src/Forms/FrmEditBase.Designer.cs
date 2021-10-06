namespace TP.Client.WinForm.Common.Forms
{
    partial class FrmEditBase
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditBase));
            this.pcButton = new DevExpress.XtraEditors.PanelControl();
            this.lcButton = new DevExpress.XtraLayout.LayoutControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveAndNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.lcgButton = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciBtnPrint = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBtnDelete = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBtnSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBtnSaveAndNew = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBtnClose = new DevExpress.XtraLayout.LayoutControlItem();
            this.esiButton = new DevExpress.XtraLayout.EmptySpaceItem();
            this.pcMain = new DevExpress.XtraEditors.PanelControl();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.lcgM = new DevExpress.XtraLayout.LayoutControlGroup();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcButton)).BeginInit();
            this.pcButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcButton)).BeginInit();
            this.lcButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSaveAndNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).BeginInit();
            this.pcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pcButton
            // 
            this.pcButton.Controls.Add(this.lcButton);
            this.pcButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pcButton.Location = new System.Drawing.Point(0, 215);
            this.pcButton.Name = "pcButton";
            this.pcButton.Size = new System.Drawing.Size(584, 46);
            this.pcButton.TabIndex = 2000;
            // 
            // lcButton
            // 
            this.lcButton.Controls.Add(this.btnClose);
            this.lcButton.Controls.Add(this.btnSaveAndNew);
            this.lcButton.Controls.Add(this.btnSave);
            this.lcButton.Controls.Add(this.btnDelete);
            this.lcButton.Controls.Add(this.btnPrint);
            this.lcButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcButton.Location = new System.Drawing.Point(2, 2);
            this.lcButton.Name = "lcButton";
            this.lcButton.Root = this.lcgButton;
            this.lcButton.Size = new System.Drawing.Size(580, 42);
            this.lcButton.TabIndex = 2001;
            this.lcButton.Text = "layoutControl1";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(492, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 32);
            this.btnClose.StyleController = this.lcButton;
            this.btnClose.TabIndex = 2004;
            this.btnClose.Text = "關閉";
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAndNew.ImageOptions.Image")));
            this.btnSaveAndNew.Location = new System.Drawing.Point(412, 5);
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.Size = new System.Drawing.Size(76, 32);
            this.btnSaveAndNew.StyleController = this.lcButton;
            this.btnSaveAndNew.TabIndex = 2003;
            this.btnSaveAndNew.Text = "保存";
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(332, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 32);
            this.btnSave.StyleController = this.lcButton;
            this.btnSave.TabIndex = 2002;
            this.btnSave.Text = "提交";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(92, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 32);
            this.btnDelete.StyleController = this.lcButton;
            this.btnDelete.TabIndex = 2006;
            this.btnDelete.Text = "刪除";
            // 
            // btnPrint
            // 
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.Location = new System.Drawing.Point(12, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(76, 32);
            this.btnPrint.StyleController = this.lcButton;
            this.btnPrint.TabIndex = 2005;
            this.btnPrint.Text = "打印";
            // 
            // lcgButton
            // 
            this.lcgButton.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgButton.GroupBordersVisible = false;
            this.lcgButton.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciBtnPrint,
            this.lciBtnDelete,
            this.lciBtnSave,
            this.lciBtnSaveAndNew,
            this.lciBtnClose,
            this.esiButton});
            this.lcgButton.Name = "lcgButton";
            this.lcgButton.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 3, 3);
            this.lcgButton.Size = new System.Drawing.Size(580, 42);
            this.lcgButton.TextVisible = false;
            // 
            // lciBtnPrint
            // 
            this.lciBtnPrint.Control = this.btnPrint;
            this.lciBtnPrint.Location = new System.Drawing.Point(0, 0);
            this.lciBtnPrint.MaxSize = new System.Drawing.Size(80, 36);
            this.lciBtnPrint.MinSize = new System.Drawing.Size(80, 36);
            this.lciBtnPrint.Name = "lciBtnPrint";
            this.lciBtnPrint.Size = new System.Drawing.Size(80, 36);
            this.lciBtnPrint.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciBtnPrint.TextSize = new System.Drawing.Size(0, 0);
            this.lciBtnPrint.TextVisible = false;
            this.lciBtnPrint.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciBtnDelete
            // 
            this.lciBtnDelete.Control = this.btnDelete;
            this.lciBtnDelete.Location = new System.Drawing.Point(80, 0);
            this.lciBtnDelete.MaxSize = new System.Drawing.Size(80, 36);
            this.lciBtnDelete.MinSize = new System.Drawing.Size(80, 36);
            this.lciBtnDelete.Name = "lciBtnDelete";
            this.lciBtnDelete.Size = new System.Drawing.Size(80, 36);
            this.lciBtnDelete.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciBtnDelete.TextSize = new System.Drawing.Size(0, 0);
            this.lciBtnDelete.TextVisible = false;
            this.lciBtnDelete.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciBtnSave
            // 
            this.lciBtnSave.Control = this.btnSave;
            this.lciBtnSave.Location = new System.Drawing.Point(320, 0);
            this.lciBtnSave.MaxSize = new System.Drawing.Size(80, 36);
            this.lciBtnSave.MinSize = new System.Drawing.Size(80, 36);
            this.lciBtnSave.Name = "lciBtnSave";
            this.lciBtnSave.Size = new System.Drawing.Size(80, 36);
            this.lciBtnSave.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciBtnSave.TextSize = new System.Drawing.Size(0, 0);
            this.lciBtnSave.TextVisible = false;
            // 
            // lciBtnSaveAndNew
            // 
            this.lciBtnSaveAndNew.Control = this.btnSaveAndNew;
            this.lciBtnSaveAndNew.Location = new System.Drawing.Point(400, 0);
            this.lciBtnSaveAndNew.MaxSize = new System.Drawing.Size(80, 36);
            this.lciBtnSaveAndNew.MinSize = new System.Drawing.Size(80, 36);
            this.lciBtnSaveAndNew.Name = "lciBtnSaveAndNew";
            this.lciBtnSaveAndNew.Size = new System.Drawing.Size(80, 36);
            this.lciBtnSaveAndNew.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciBtnSaveAndNew.TextSize = new System.Drawing.Size(0, 0);
            this.lciBtnSaveAndNew.TextVisible = false;
            // 
            // lciBtnClose
            // 
            this.lciBtnClose.Control = this.btnClose;
            this.lciBtnClose.Location = new System.Drawing.Point(480, 0);
            this.lciBtnClose.MaxSize = new System.Drawing.Size(80, 36);
            this.lciBtnClose.MinSize = new System.Drawing.Size(80, 36);
            this.lciBtnClose.Name = "lciBtnClose";
            this.lciBtnClose.Size = new System.Drawing.Size(80, 36);
            this.lciBtnClose.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciBtnClose.TextSize = new System.Drawing.Size(0, 0);
            this.lciBtnClose.TextVisible = false;
            // 
            // esiButton
            // 
            this.esiButton.AllowHotTrack = false;
            this.esiButton.Location = new System.Drawing.Point(160, 0);
            this.esiButton.Name = "esiButton";
            this.esiButton.Size = new System.Drawing.Size(160, 36);
            this.esiButton.TextSize = new System.Drawing.Size(0, 0);
            // 
            // pcMain
            // 
            this.pcMain.Controls.Add(this.lcMain);
            this.pcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcMain.Location = new System.Drawing.Point(0, 0);
            this.pcMain.Name = "pcMain";
            this.pcMain.Size = new System.Drawing.Size(584, 215);
            this.pcMain.TabIndex = 1000;
            // 
            // lcMain
            // 
            this.lcMain.AllowCustomization = false;
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(2, 2);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lcgM;
            this.lcMain.Size = new System.Drawing.Size(580, 211);
            this.lcMain.TabIndex = 1001;
            this.lcMain.Text = "lcMain";
            // 
            // lcgM
            // 
            this.lcgM.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgM.GroupBordersVisible = false;
            this.lcgM.Name = "lcgM";
            this.lcgM.Size = new System.Drawing.Size(580, 211);
            this.lcgM.TextVisible = false;
            // 
            // dxValidationProvider
            // 
            this.dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // FrmEditBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.pcMain);
            this.Controls.Add(this.pcButton);
            this.Name = "FrmEditBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEditBase";
            ((System.ComponentModel.ISupportInitialize)(this.pcButton)).EndInit();
            this.pcButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcButton)).EndInit();
            this.lcButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSaveAndNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).EndInit();
            this.pcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected DevExpress.XtraEditors.PanelControl pcMain;
        protected DevExpress.XtraLayout.LayoutControl lcMain;
        protected DevExpress.XtraLayout.LayoutControlGroup lcgM;
        protected DevExpress.XtraEditors.PanelControl pcButton;
        protected DevExpress.XtraEditors.SimpleButton btnClose;
        protected DevExpress.XtraEditors.SimpleButton btnPrint;
        protected DevExpress.XtraEditors.SimpleButton btnDelete;
        protected DevExpress.XtraEditors.SimpleButton btnSaveAndNew;
        protected DevExpress.XtraEditors.SimpleButton btnSave;
        protected DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
        protected DevExpress.XtraLayout.LayoutControlItem lciBtnPrint;
        protected DevExpress.XtraLayout.LayoutControl lcButton;
        protected DevExpress.XtraLayout.LayoutControlItem lciBtnDelete;
        protected DevExpress.XtraLayout.LayoutControlGroup lcgButton;
        protected DevExpress.XtraLayout.LayoutControlItem lciBtnSave;
        protected DevExpress.XtraLayout.LayoutControlItem lciBtnSaveAndNew;
        protected DevExpress.XtraLayout.LayoutControlItem lciBtnClose;
        protected DevExpress.XtraLayout.EmptySpaceItem esiButton;
    }
}