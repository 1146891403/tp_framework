namespace TP.WL.ERP.WinForm.Crm.Forms
{
    partial class FrmClientCertificateGroup
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
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.lciDisplayName = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.tlcId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcCertificateName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.lciCertificate = new DevExpress.XtraLayout.LayoutControlItem();
            this.treeList2 = new DevExpress.XtraTreeList.TreeList();
            this.tlcCertificateId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcCertificateName2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.lciAllCertificate = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnRemoveAll = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).BeginInit();
            this.pcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDisplayName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCertificate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAllCertificate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // pcMain
            // 
            this.pcMain.Size = new System.Drawing.Size(484, 315);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.btnRemoveAll);
            this.lcMain.Controls.Add(this.btnRemove);
            this.lcMain.Controls.Add(this.btnSelect);
            this.lcMain.Controls.Add(this.btnSelectAll);
            this.lcMain.Controls.Add(this.treeList2);
            this.lcMain.Controls.Add(this.treeList1);
            this.lcMain.Controls.Add(this.textEdit1);
            this.lcMain.Size = new System.Drawing.Size(480, 311);
            // 
            // lcgM
            // 
            this.lcgM.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDisplayName,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.lciCertificate,
            this.lciAllCertificate,
            this.layoutControlItem1,
            this.emptySpaceItem4,
            this.emptySpaceItem3,
            this.emptySpaceItem5,
            this.emptySpaceItem6,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.lcgM.Size = new System.Drawing.Size(480, 311);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(64, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(404, 20);
            this.textEdit1.StyleController = this.lcMain;
            this.textEdit1.TabIndex = 4;
            // 
            // lciDisplayName
            // 
            this.lciDisplayName.Control = this.textEdit1;
            this.lciDisplayName.Location = new System.Drawing.Point(0, 0);
            this.lciDisplayName.Name = "lciDisplayName";
            this.lciDisplayName.Size = new System.Drawing.Size(460, 24);
            this.lciDisplayName.Text = "組合名稱";
            this.lciDisplayName.TextSize = new System.Drawing.Size(48, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 9);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(460, 9);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(460, 9);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(200, 33);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(60, 45);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(60, 45);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcId,
            this.tlcCertificateName});
            this.treeList1.Location = new System.Drawing.Point(12, 45);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.ShowHorzLines = false;
            this.treeList1.OptionsView.ShowIndicator = false;
            this.treeList1.OptionsView.ShowVertLines = false;
            this.treeList1.Size = new System.Drawing.Size(196, 254);
            this.treeList1.TabIndex = 5;
            // 
            // tlcId
            // 
            this.tlcId.Caption = "ID";
            this.tlcId.FieldName = "Id";
            this.tlcId.Name = "tlcId";
            // 
            // tlcCertificateName
            // 
            this.tlcCertificateName.Caption = "安規";
            this.tlcCertificateName.FieldName = "DisplayName";
            this.tlcCertificateName.Name = "tlcCertificateName";
            this.tlcCertificateName.OptionsColumn.AllowEdit = false;
            this.tlcCertificateName.Visible = true;
            this.tlcCertificateName.VisibleIndex = 0;
            // 
            // lciCertificate
            // 
            this.lciCertificate.Control = this.treeList1;
            this.lciCertificate.Location = new System.Drawing.Point(0, 33);
            this.lciCertificate.MinSize = new System.Drawing.Size(200, 258);
            this.lciCertificate.Name = "lciCertificate";
            this.lciCertificate.Size = new System.Drawing.Size(200, 258);
            this.lciCertificate.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciCertificate.TextSize = new System.Drawing.Size(0, 0);
            this.lciCertificate.TextVisible = false;
            // 
            // treeList2
            // 
            this.treeList2.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcCertificateId,
            this.tlcCertificateName2});
            this.treeList2.Location = new System.Drawing.Point(272, 45);
            this.treeList2.Name = "treeList2";
            this.treeList2.OptionsView.ShowHorzLines = false;
            this.treeList2.OptionsView.ShowIndicator = false;
            this.treeList2.OptionsView.ShowVertLines = false;
            this.treeList2.Size = new System.Drawing.Size(196, 254);
            this.treeList2.TabIndex = 6;
            // 
            // tlcCertificateId
            // 
            this.tlcCertificateId.Caption = "ID";
            this.tlcCertificateId.FieldName = "Id";
            this.tlcCertificateId.Name = "tlcCertificateId";
            // 
            // tlcCertificateName2
            // 
            this.tlcCertificateName2.Caption = "選擇安規";
            this.tlcCertificateName2.FieldName = "DisplayName";
            this.tlcCertificateName2.Name = "tlcCertificateName2";
            this.tlcCertificateName2.OptionsColumn.AllowEdit = false;
            this.tlcCertificateName2.Visible = true;
            this.tlcCertificateName2.VisibleIndex = 0;
            // 
            // lciAllCertificate
            // 
            this.lciAllCertificate.Control = this.treeList2;
            this.lciAllCertificate.Location = new System.Drawing.Point(260, 33);
            this.lciAllCertificate.MinSize = new System.Drawing.Size(200, 258);
            this.lciAllCertificate.Name = "lciAllCertificate";
            this.lciAllCertificate.Size = new System.Drawing.Size(200, 258);
            this.lciAllCertificate.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciAllCertificate.TextSize = new System.Drawing.Size(0, 0);
            this.lciAllCertificate.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(200, 104);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(60, 16);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(60, 16);
            this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(200, 246);
            this.emptySpaceItem4.MinSize = new System.Drawing.Size(60, 45);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(60, 45);
            this.emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(200, 204);
            this.emptySpaceItem5.MinSize = new System.Drawing.Size(60, 16);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(60, 16);
            this.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(200, 146);
            this.emptySpaceItem6.MinSize = new System.Drawing.Size(60, 32);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(60, 32);
            this.emptySpaceItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnSelectAll;
            this.layoutControlItem1.Location = new System.Drawing.Point(200, 78);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(60, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(212, 90);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(56, 22);
            this.btnSelectAll.StyleController = this.lcMain;
            this.btnSelectAll.TabIndex = 7;
            this.btnSelectAll.Text = "<<";
            this.btnSelectAll.ToolTip = "全部選擇";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(212, 132);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(56, 22);
            this.btnSelect.StyleController = this.lcMain;
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "<";
            this.btnSelect.ToolTip = "選擇";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSelect;
            this.layoutControlItem2.Location = new System.Drawing.Point(200, 120);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(60, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(212, 190);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(56, 22);
            this.btnRemove.StyleController = this.lcMain;
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = ">";
            this.btnRemove.ToolTip = "移除";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnRemove;
            this.layoutControlItem3.Location = new System.Drawing.Point(200, 178);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(60, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(212, 232);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(56, 22);
            this.btnRemoveAll.StyleController = this.lcMain;
            this.btnRemoveAll.TabIndex = 10;
            this.btnRemoveAll.Text = ">>";
            this.btnRemoveAll.ToolTip = "全部移除";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnRemoveAll;
            this.layoutControlItem4.Location = new System.Drawing.Point(200, 220);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(60, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // FrmClientCertificateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClientCertificateGroup";
            this.Text = "安規組合";
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).EndInit();
            this.pcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDisplayName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCertificate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAllCertificate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem lciDisplayName;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraTreeList.TreeList treeList2;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcCertificateName;
        private DevExpress.XtraLayout.LayoutControlItem lciCertificate;
        private DevExpress.XtraLayout.LayoutControlItem lciAllCertificate;
        private DevExpress.XtraEditors.SimpleButton btnRemoveAll;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private DevExpress.XtraEditors.SimpleButton btnSelectAll;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcCertificateId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcCertificateName2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}