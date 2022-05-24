
namespace CSDLPT_NGANHANG
{
    partial class formpt_Statement
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
            this.txtSOTK = new System.Windows.Forms.TextBox();
            this.dtTN = new DevExpress.XtraEditors.DateEdit();
            this.dtDN = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btPreview = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtTN.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDN.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDN.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSOTK
            // 
            this.txtSOTK.Location = new System.Drawing.Point(137, 93);
            this.txtSOTK.Name = "txtSOTK";
            this.txtSOTK.Size = new System.Drawing.Size(100, 22);
            this.txtSOTK.TabIndex = 0;
            // 
            // dtTN
            // 
            this.dtTN.EditValue = null;
            this.dtTN.Location = new System.Drawing.Point(353, 93);
            this.dtTN.Name = "dtTN";
            this.dtTN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTN.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTN.Size = new System.Drawing.Size(125, 22);
            this.dtTN.TabIndex = 1;
            // 
            // dtDN
            // 
            this.dtDN.EditValue = null;
            this.dtDN.Location = new System.Drawing.Point(610, 93);
            this.dtDN.Name = "dtDN";
            this.dtDN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDN.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDN.Size = new System.Drawing.Size(125, 22);
            this.dtDN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Từ ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đến ngày:";
            // 
            // btPreview
            // 
            this.btPreview.Location = new System.Drawing.Point(788, 80);
            this.btPreview.Name = "btPreview";
            this.btPreview.Size = new System.Drawing.Size(122, 48);
            this.btPreview.TabIndex = 6;
            this.btPreview.Text = "Preview";
            this.btPreview.UseVisualStyleBackColor = true;
            this.btPreview.Click += new System.EventHandler(this.btPreview_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(954, 80);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(122, 48);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sao kê";
            // 
            // formpt_Statement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 163);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btPreview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDN);
            this.Controls.Add(this.dtTN);
            this.Controls.Add(this.txtSOTK);
            this.Name = "formpt_Statement";
            this.Text = "formpt_Statement";
            ((System.ComponentModel.ISupportInitialize)(this.dtTN.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDN.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDN.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSOTK;
        private DevExpress.XtraEditors.DateEdit dtTN;
        private DevExpress.XtraEditors.DateEdit dtDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btPreview;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label4;
    }
}