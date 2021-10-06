namespace TP.WL.ERP.WinForm.Administration.Forms
{
    partial class FrmUserInRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserInRole));
            this.treeOrganization = new DevExpress.XtraTreeList.TreeList();
            this.lciTreeOrganization = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridUser = new DevExpress.XtraGrid.GridControl();
            this.gvUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAlias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDesignation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lciGridUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.sliContent = new DevExpress.XtraLayout.SimpleLabelItem();
            this.splitter = new DevExpress.XtraLayout.SplitterItem();
            this.pcCheckedUser = new DevExpress.XtraEditors.PanelControl();
            this.flpCheckedUser = new System.Windows.Forms.FlowLayoutPanel();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).BeginInit();
            this.pcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcButton)).BeginInit();
            this.pcButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcButton)).BeginInit();
            this.lcButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSaveAndNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeOrganization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTreeOrganization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCheckedUser)).BeginInit();
            this.pcCheckedUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcMain
            // 
            this.pcMain.Size = new System.Drawing.Size(784, 615);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.pcCheckedUser);
            this.lcMain.Controls.Add(this.gridUser);
            this.lcMain.Controls.Add(this.treeOrganization);
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(838, 370, 650, 400);
            this.lcMain.Size = new System.Drawing.Size(780, 611);
            // 
            // lcgM
            // 
            this.lcgM.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciTreeOrganization,
            this.lciGridUser,
            this.sliContent,
            this.splitter,
            this.layoutControlItem1});
            this.lcgM.Name = "Root";
            this.lcgM.Size = new System.Drawing.Size(780, 611);
            // 
            // pcButton
            // 
            this.pcButton.Location = new System.Drawing.Point(0, 615);
            this.pcButton.Size = new System.Drawing.Size(784, 46);
            // 
            // lcButton
            // 
            this.lcButton.Size = new System.Drawing.Size(780, 42);
            this.lcButton.Controls.SetChildIndex(this.btnPrint, 0);
            this.lcButton.Controls.SetChildIndex(this.btnDelete, 0);
            this.lcButton.Controls.SetChildIndex(this.btnSave, 0);
            this.lcButton.Controls.SetChildIndex(this.btnSaveAndNew, 0);
            this.lcButton.Controls.SetChildIndex(this.btnClose, 0);
            // 
            // lcgButton
            // 
            this.lcgButton.Size = new System.Drawing.Size(780, 42);
            // 
            // lciBtnSave
            // 
            this.lciBtnSave.Location = new System.Drawing.Point(470, 0);
            // 
            // lciBtnSaveAndNew
            // 
            this.lciBtnSaveAndNew.Location = new System.Drawing.Point(575, 0);
            // 
            // lciBtnClose
            // 
            this.lciBtnClose.Location = new System.Drawing.Point(680, 0);
            // 
            // esiButton
            // 
            this.esiButton.Location = new System.Drawing.Point(160, 0);
            this.esiButton.Size = new System.Drawing.Size(310, 36);
            // 
            // treeOrganization
            // 
            this.treeOrganization.Location = new System.Drawing.Point(12, 12);
            this.treeOrganization.Name = "treeOrganization";
            this.treeOrganization.Size = new System.Drawing.Size(196, 485);
            this.treeOrganization.TabIndex = 4;
            // 
            // lciTreeOrganization
            // 
            this.lciTreeOrganization.Control = this.treeOrganization;
            this.lciTreeOrganization.Location = new System.Drawing.Point(0, 0);
            this.lciTreeOrganization.MaxSize = new System.Drawing.Size(400, 0);
            this.lciTreeOrganization.MinSize = new System.Drawing.Size(200, 24);
            this.lciTreeOrganization.Name = "lciTreeOrganization";
            this.lciTreeOrganization.Size = new System.Drawing.Size(200, 489);
            this.lciTreeOrganization.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTreeOrganization.TextSize = new System.Drawing.Size(0, 0);
            this.lciTreeOrganization.TextVisible = false;
            // 
            // gridUser
            // 
            this.gridUser.Location = new System.Drawing.Point(217, 12);
            this.gridUser.MainView = this.gvUser;
            this.gridUser.Name = "gridUser";
            this.gridUser.Size = new System.Drawing.Size(551, 485);
            this.gridUser.TabIndex = 6;
            this.gridUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUser});
            // 
            // gvUser
            // 
            this.gvUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcUserName,
            this.gcFullName,
            this.gcAlias,
            this.gcDesignation});
            this.gvUser.GridControl = this.gridUser;
            this.gvUser.Name = "gvUser";
            this.gvUser.OptionsBehavior.Editable = false;
            this.gvUser.OptionsSelection.MultiSelect = true;
            this.gvUser.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvUser.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.gvUser.OptionsView.ShowGroupPanel = false;
            // 
            // gcUserName
            // 
            this.gcUserName.Caption = "用戶名";
            this.gcUserName.FieldName = "UserName";
            this.gcUserName.Name = "gcUserName";
            this.gcUserName.Visible = true;
            this.gcUserName.VisibleIndex = 1;
            // 
            // gcFullName
            // 
            this.gcFullName.Caption = "中文名";
            this.gcFullName.FieldName = "FullName";
            this.gcFullName.Name = "gcFullName";
            this.gcFullName.Visible = true;
            this.gcFullName.VisibleIndex = 2;
            // 
            // gcAlias
            // 
            this.gcAlias.Caption = "英文名";
            this.gcAlias.FieldName = "Alias";
            this.gcAlias.Name = "gcAlias";
            this.gcAlias.Visible = true;
            this.gcAlias.VisibleIndex = 3;
            // 
            // gcDesignation
            // 
            this.gcDesignation.Caption = "職位名稱";
            this.gcDesignation.FieldName = "Designation";
            this.gcDesignation.Name = "gcDesignation";
            this.gcDesignation.Visible = true;
            this.gcDesignation.VisibleIndex = 4;
            // 
            // lciGridUser
            // 
            this.lciGridUser.Control = this.gridUser;
            this.lciGridUser.Location = new System.Drawing.Point(205, 0);
            this.lciGridUser.Name = "lciGridUser";
            this.lciGridUser.Size = new System.Drawing.Size(555, 489);
            this.lciGridUser.TextSize = new System.Drawing.Size(0, 0);
            this.lciGridUser.TextVisible = false;
            // 
            // sliContent
            // 
            this.sliContent.AllowHotTrack = false;
            this.sliContent.Location = new System.Drawing.Point(0, 569);
            this.sliContent.Name = "sliContent";
            this.sliContent.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 6, 2);
            this.sliContent.Size = new System.Drawing.Size(760, 22);
            this.sliContent.Text = "當前選擇【0】項";
            this.sliContent.TextSize = new System.Drawing.Size(91, 14);
            // 
            // splitter
            // 
            this.splitter.AllowHotTrack = true;
            this.splitter.Location = new System.Drawing.Point(200, 0);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(5, 489);
            // 
            // pcCheckedUser
            // 
            this.pcCheckedUser.Controls.Add(this.flpCheckedUser);
            this.pcCheckedUser.Location = new System.Drawing.Point(12, 501);
            this.pcCheckedUser.Name = "pcCheckedUser";
            this.pcCheckedUser.Size = new System.Drawing.Size(756, 76);
            this.pcCheckedUser.TabIndex = 7;
            // 
            // flpCheckedUser
            // 
            this.flpCheckedUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCheckedUser.Location = new System.Drawing.Point(2, 2);
            this.flpCheckedUser.Name = "flpCheckedUser";
            this.flpCheckedUser.Size = new System.Drawing.Size(752, 72);
            this.flpCheckedUser.TabIndex = 0;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.pcCheckedUser;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 489);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(760, 80);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // FrmUserInRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Name = "FrmUserInRole";
            this.Text = "添加用戶到角色";
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).EndInit();
            this.pcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcButton)).EndInit();
            this.pcButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcButton)).EndInit();
            this.lcButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSaveAndNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeOrganization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTreeOrganization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCheckedUser)).EndInit();
            this.pcCheckedUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTreeList.TreeList treeOrganization;
        private DevExpress.XtraLayout.LayoutControlItem lciTreeOrganization;
        private DevExpress.XtraGrid.GridControl gridUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUser;
        private DevExpress.XtraGrid.Columns.GridColumn gcUserName;
        private DevExpress.XtraGrid.Columns.GridColumn gcFullName;
        private DevExpress.XtraGrid.Columns.GridColumn gcAlias;
        private DevExpress.XtraGrid.Columns.GridColumn gcDesignation;
        private DevExpress.XtraLayout.LayoutControlItem lciGridUser;
        private DevExpress.XtraLayout.SimpleLabelItem sliContent;
        private DevExpress.XtraLayout.SplitterItem splitter;
        private DevExpress.XtraEditors.PanelControl pcCheckedUser;
        private System.Windows.Forms.FlowLayoutPanel flpCheckedUser;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}