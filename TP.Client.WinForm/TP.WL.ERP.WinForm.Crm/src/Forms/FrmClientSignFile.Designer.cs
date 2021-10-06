namespace TP.WL.ERP.WinForm.Crm.Forms
{
    partial class FrmClientSignFile
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
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciType = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lciEffectiveDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lciBtnSignFile = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.peSignFile = new DevExpress.XtraEditors.PictureEdit();
            this.lciSignFileImage = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).BeginInit();
            this.pcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEffectiveDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSignFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peSignFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSignFileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pcMain
            // 
            this.pcMain.Size = new System.Drawing.Size(484, 215);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.peSignFile);
            this.lcMain.Controls.Add(this.simpleButton1);
            this.lcMain.Controls.Add(this.textEdit1);
            this.lcMain.Controls.Add(this.textEdit2);
            this.lcMain.Size = new System.Drawing.Size(480, 211);
            // 
            // lcgM
            // 
            this.lcgM.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciType,
            this.lciEffectiveDate,
            this.emptySpaceItem2,
            this.emptySpaceItem5,
            this.emptySpaceItem1,
            this.lciBtnSignFile,
            this.emptySpaceItem6,
            this.emptySpaceItem4,
            this.lciSignFileImage});
            this.lcgM.Size = new System.Drawing.Size(480, 211);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(260, 58);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(100, 80);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciType
            // 
            this.lciType.Control = this.textEdit1;
            this.lciType.Location = new System.Drawing.Point(0, 0);
            this.lciType.Name = "lciType";
            this.lciType.Size = new System.Drawing.Size(460, 24);
            this.lciType.Text = "文件類型";
            this.lciType.TextSize = new System.Drawing.Size(48, 14);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(64, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit1.Properties.Items.AddRange(new object[] {
            "營業執照複印件",
            "數期申請表",
            "稅務登記證",
            "銀行開票資料",
            "聯絡人資料",
            "賬務報表",
            "客戶資料表批核"});
            this.textEdit1.Size = new System.Drawing.Size(404, 20);
            this.textEdit1.StyleController = this.lcMain;
            this.textEdit1.TabIndex = 4;
            // 
            // lciEffectiveDate
            // 
            this.lciEffectiveDate.Control = this.textEdit2;
            this.lciEffectiveDate.Location = new System.Drawing.Point(0, 24);
            this.lciEffectiveDate.Name = "lciEffectiveDate";
            this.lciEffectiveDate.Size = new System.Drawing.Size(460, 24);
            this.lciEffectiveDate.Text = "有效日期";
            this.lciEffectiveDate.TextSize = new System.Drawing.Size(48, 14);
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = null;
            this.textEdit2.Location = new System.Drawing.Point(64, 36);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit2.Properties.DisplayFormat.FormatString = "";
            this.textEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.textEdit2.Properties.EditFormat.FormatString = "";
            this.textEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.textEdit2.Properties.Mask.EditMask = "";
            this.textEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.textEdit2.Size = new System.Drawing.Size(404, 20);
            this.textEdit2.StyleController = this.lcMain;
            this.textEdit2.TabIndex = 5;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 84);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(260, 54);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(440, 58);
            this.emptySpaceItem4.MaxSize = new System.Drawing.Size(20, 0);
            this.emptySpaceItem4.MinSize = new System.Drawing.Size(20, 24);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(20, 80);
            this.emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 138);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(460, 53);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 70);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(256, 22);
            this.simpleButton1.StyleController = this.lcMain;
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "上傳簽署文件";
            // 
            // lciBtnSignFile
            // 
            this.lciBtnSignFile.Control = this.simpleButton1;
            this.lciBtnSignFile.Location = new System.Drawing.Point(0, 58);
            this.lciBtnSignFile.MaxSize = new System.Drawing.Size(260, 26);
            this.lciBtnSignFile.MinSize = new System.Drawing.Size(260, 26);
            this.lciBtnSignFile.Name = "lciBtnSignFile";
            this.lciBtnSignFile.Size = new System.Drawing.Size(260, 26);
            this.lciBtnSignFile.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciBtnSignFile.TextSize = new System.Drawing.Size(0, 0);
            this.lciBtnSignFile.TextVisible = false;
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(460, 10);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // peSignFile
            // 
            this.peSignFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.peSignFile.Location = new System.Drawing.Point(372, 70);
            this.peSignFile.Name = "peSignFile";
            this.peSignFile.Properties.ShowMenu = false;
            this.peSignFile.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peSignFile.Properties.ZoomAccelerationFactor = 1D;
            this.peSignFile.Size = new System.Drawing.Size(76, 76);
            this.peSignFile.StyleController = this.lcMain;
            this.peSignFile.TabIndex = 7;
            // 
            // lciSignFileImage
            // 
            this.lciSignFileImage.Control = this.peSignFile;
            this.lciSignFileImage.Location = new System.Drawing.Point(360, 58);
            this.lciSignFileImage.MaxSize = new System.Drawing.Size(80, 80);
            this.lciSignFileImage.MinSize = new System.Drawing.Size(80, 80);
            this.lciSignFileImage.Name = "lciSignFileImage";
            this.lciSignFileImage.Size = new System.Drawing.Size(80, 80);
            this.lciSignFileImage.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciSignFileImage.TextSize = new System.Drawing.Size(0, 0);
            this.lciSignFileImage.TextVisible = false;
            // 
            // FrmClientSignFile2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClientSignFile";
            this.Text = "簽署文件";
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).EndInit();
            this.pcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEffectiveDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSignFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peSignFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSignFileImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciType;
        private DevExpress.XtraEditors.ComboBoxEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem lciEffectiveDate;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DateEdit textEdit2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.LayoutControlItem lciBtnSignFile;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.PictureEdit peSignFile;
        private DevExpress.XtraLayout.LayoutControlItem lciSignFileImage;
    }
}