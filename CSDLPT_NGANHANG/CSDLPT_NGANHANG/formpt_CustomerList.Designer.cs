
namespace CSDLPT_NGANHANG
{
    partial class formpt_CustomerList
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbChinhanh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btPreview = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbCN = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liệt kê khách hàng";
            // 
            // cbbChinhanh
            // 
            this.cbbChinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChinhanh.FormattingEnabled = true;
            this.cbbChinhanh.Items.AddRange(new object[] {
            "BENTHANH",
            "TANDINH"});
            this.cbbChinhanh.Location = new System.Drawing.Point(117, 23);
            this.cbbChinhanh.Name = "cbbChinhanh";
            this.cbbChinhanh.Size = new System.Drawing.Size(250, 24);
            this.cbbChinhanh.TabIndex = 1;
            this.cbbChinhanh.SelectedIndexChanged += new System.EventHandler(this.cbbChinhanh_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chi nhánh:";
            // 
            // btPreview
            // 
            this.btPreview.Location = new System.Drawing.Point(616, 45);
            this.btPreview.Name = "btPreview";
            this.btPreview.Size = new System.Drawing.Size(138, 54);
            this.btPreview.TabIndex = 3;
            this.btPreview.Text = "Preview";
            this.btPreview.UseVisualStyleBackColor = true;
            this.btPreview.Click += new System.EventHandler(this.btPreview_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(616, 119);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(138, 54);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chi nhánh liệt kê: ";
            // 
            // cbbCN
            // 
            this.cbbCN.FormattingEnabled = true;
            this.cbbCN.Items.AddRange(new object[] {
            "BENTHANH",
            "TANDINH"});
            this.cbbCN.Location = new System.Drawing.Point(317, 135);
            this.cbbCN.Name = "cbbCN";
            this.cbbCN.Size = new System.Drawing.Size(192, 24);
            this.cbbCN.TabIndex = 6;
            // 
            // formpt_CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 194);
            this.Controls.Add(this.cbbCN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btPreview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbChinhanh);
            this.Controls.Add(this.label1);
            this.Name = "formpt_CustomerList";
            this.Text = "formpt_CustomerList";
            this.Load += new System.EventHandler(this.formpt_CustomerList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbChinhanh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btPreview;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbCN;
    }
}