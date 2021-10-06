namespace TP.WL.ERP.WinForm.Administration.Forms
{
    partial class test
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
            DevExpress.Utils.SimpleContextButton simpleContextButton2 = new DevExpress.Utils.SimpleContextButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Qing Lin (qinglin)");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Ren Li (renli)");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Test (test123)");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Qing Lin (qinglin)");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Ren Li (renli)");
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonLabel1 = new TP.Client.WinForm.Common.Controls.ButtonLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLabel3 = new TP.Client.WinForm.Common.Controls.ButtonLabel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.ColumnWidth = 100;
            simpleContextButton2.Id = new System.Guid("2eaead89-d166-40c4-9758-7d808da58432");
            simpleContextButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            simpleContextButton2.Name = "simpleContextButton1";
            simpleContextButton2.Visibility = DevExpress.Utils.ContextItemVisibility.Visible;
            simpleContextButton2.Width = 20;
            this.listBoxControl1.ContextButtons.Add(simpleContextButton2);
            this.listBoxControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxControl1.Items.AddRange(new object[] {
            "Qing Lin (qinglin)",
            "Ren Li (renli)",
            "Test (test123)",
            "Qing Lin (qinglin)",
            "Ren Li (renli)",
            "Test (test123)",
            "Qing Lin (qinglin)",
            "Ren Li (renli)",
            "Test (test123)"});
            this.listBoxControl1.Location = new System.Drawing.Point(86, 12);
            this.listBoxControl1.MultiColumn = true;
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(685, 75);
            this.listBoxControl1.TabIndex = 0;
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.EditValue = "111";
            this.buttonEdit1.Location = new System.Drawing.Point(86, 121);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.buttonEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.buttonEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.buttonEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.buttonEdit1.Size = new System.Drawing.Size(100, 18);
            this.buttonEdit1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(86, 195);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "labelControl1";
            // 
            // listView1
            // 
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.listView1.Location = new System.Drawing.Point(445, 93);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(326, 166);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            // 
            // buttonLabel1
            // 
            this.buttonLabel1.AutoSize = true;
            this.buttonLabel1.ButtonImage = null;
            this.buttonLabel1.ButtonName = null;
            this.buttonLabel1.Id = null;
            this.buttonLabel1.LabelText = "asdf";
            this.buttonLabel1.Location = new System.Drawing.Point(3, 3);
            this.buttonLabel1.Name = "buttonLabel1";
            this.buttonLabel1.Size = new System.Drawing.Size(55, 26);
            this.buttonLabel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonLabel1);
            this.flowLayoutPanel1.Controls.Add(this.buttonLabel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(153, 286);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(571, 200);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // buttonLabel3
            // 
            this.buttonLabel3.AutoSize = true;
            this.buttonLabel3.ButtonImage = null;
            this.buttonLabel3.ButtonName = null;
            this.buttonLabel3.Id = null;
            this.buttonLabel3.LabelText = "asdf";
            this.buttonLabel3.Location = new System.Drawing.Point(64, 3);
            this.buttonLabel3.Name = "buttonLabel3";
            this.buttonLabel3.Size = new System.Drawing.Size(55, 26);
            this.buttonLabel3.TabIndex = 6;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::TP.WL.ERP.WinForm.Administration.Properties.Resources.delete_16x16;
            this.simpleButton1.Location = new System.Drawing.Point(277, 176);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 534);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.buttonEdit1);
            this.Controls.Add(this.listBoxControl1);
            this.Name = "test";
            this.Text = "test";
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ListView listView1;
        private Client.WinForm.Common.Controls.ButtonLabel buttonLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Client.WinForm.Common.Controls.ButtonLabel buttonLabel3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}