
namespace CSDLPT_NGANHANG
{
    partial class formpt_AccountList
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
            this.dtTN = new DevExpress.XtraEditors.DateEdit();
            this.dtDN = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btPreview = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbChinhanh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtTN.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDN.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtTN
            // 
            this.dtTN.EditValue = null;
            this.dtTN.Location = new System.Drawing.Point(156, 143);
            this.dtTN.Name = "dtTN";
            this.dtTN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTN.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTN.Size = new System.Drawing.Size(125, 22);
            this.dtTN.TabIndex = 0;
            // 
            // dtDN
            // 
            this.dtDN.EditValue = null;
            this.dtDN.Location = new System.Drawing.Point(423, 143);
            this.dtDN.Name = "dtDN";
            this.dtDN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDN.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDN.Size = new System.Drawing.Size(125, 22);
            this.dtDN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến ngày: ";
            // 
            // btPreview
            // 
            this.btPreview.Location = new System.Drawing.Point(615, 132);
            this.btPreview.Name = "btPreview";
            this.btPreview.Size = new System.Drawing.Size(138, 45);
            this.btPreview.TabIndex = 6;
            this.btPreview.Text = "Preview";
            this.btPreview.UseVisualStyleBackColor = true;
            this.btPreview.Click += new System.EventHandler(this.btPreview_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(786, 132);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(138, 45);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Liệt kê tài khoản";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbbChinhanh);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1003, 81);
            this.panelControl1.TabIndex = 9;
            // 
            // cbbChinhanh
            // 
            this.cbbChinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChinhanh.FormattingEnabled = true;
            this.cbbChinhanh.Location = new System.Drawing.Point(152, 31);
            this.cbbChinhanh.Name = "cbbChinhanh";
            this.cbbChinhanh.Size = new System.Drawing.Size(256, 24);
            this.cbbChinhanh.TabIndex = 1;
            this.cbbChinhanh.SelectedIndexChanged += new System.EventHandler(this.cbbChinhanh_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chi nhánh";
            // 
            // formpt_AccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 242);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btPreview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDN);
            this.Controls.Add(this.dtTN);
            this.Name = "formpt_AccountList";
            this.Text = "formpt";
            this.Load += new System.EventHandler(this.formpt_AccountList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtTN.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDN.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtTN;
        private DevExpress.XtraEditors.DateEdit dtDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btPreview;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbChinhanh;
        private System.Windows.Forms.Label label5;
    }
}