
namespace CSDLPT_NGANHANG
{
    partial class formTransfer
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
            System.Windows.Forms.Label sOTK_CHUYENLabel;
            System.Windows.Forms.Label sOTK_NHANLabel;
            System.Windows.Forms.Label sOTIENLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label nGAYGDLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbChinhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dSm = new CSDLPT_NGANHANG.DSm();
            this.bdsCT = new System.Windows.Forms.BindingSource(this.components);
            this.gD_CHUYENTIENTableAdapter = new CSDLPT_NGANHANG.DSmTableAdapters.GD_CHUYENTIENTableAdapter();
            this.tableAdapterManager = new CSDLPT_NGANHANG.DSmTableAdapters.TableAdapterManager();
            this.gcCT = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK_CHUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK_NHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_CHECK_SODUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_CHECK_SODUTableAdapter = new CSDLPT_NGANHANG.DSmTableAdapters.SP_CHECK_SODUTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.sotkToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.sotkToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sP_CHECK_SODUGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnTT = new DevExpress.XtraEditors.PanelControl();
            this.dtNGAYGD = new DevExpress.XtraEditors.DateEdit();
            this.ctExit = new System.Windows.Forms.Button();
            this.btCT = new System.Windows.Forms.Button();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.txtSOTIEN = new System.Windows.Forms.TextBox();
            this.txtSOTKN = new System.Windows.Forms.TextBox();
            this.txtSOTKC = new System.Windows.Forms.TextBox();
            this.btGD = new System.Windows.Forms.Button();
            this.btUdo = new System.Windows.Forms.Button();
            sOTK_CHUYENLabel = new System.Windows.Forms.Label();
            sOTK_NHANLabel = new System.Windows.Forms.Label();
            sOTIENLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            nGAYGDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_CHECK_SODUBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_CHECK_SODUGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnTT)).BeginInit();
            this.pnTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNGAYGD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNGAYGD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTK_CHUYENLabel
            // 
            sOTK_CHUYENLabel.AutoSize = true;
            sOTK_CHUYENLabel.Location = new System.Drawing.Point(87, 61);
            sOTK_CHUYENLabel.Name = "sOTK_CHUYENLabel";
            sOTK_CHUYENLabel.Size = new System.Drawing.Size(103, 17);
            sOTK_CHUYENLabel.TabIndex = 0;
            sOTK_CHUYENLabel.Text = "SOTK CHUYEN:";
            // 
            // sOTK_NHANLabel
            // 
            sOTK_NHANLabel.AutoSize = true;
            sOTK_NHANLabel.Location = new System.Drawing.Point(104, 111);
            sOTK_NHANLabel.Name = "sOTK_NHANLabel";
            sOTK_NHANLabel.Size = new System.Drawing.Size(86, 17);
            sOTK_NHANLabel.TabIndex = 2;
            sOTK_NHANLabel.Text = "SOTK NHAN:";
            // 
            // sOTIENLabel
            // 
            sOTIENLabel.AutoSize = true;
            sOTIENLabel.Location = new System.Drawing.Point(130, 166);
            sOTIENLabel.Name = "sOTIENLabel";
            sOTIENLabel.Size = new System.Drawing.Size(60, 17);
            sOTIENLabel.TabIndex = 4;
            sOTIENLabel.Text = "SOTIEN:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(142, 217);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(48, 17);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "MANV:";
            // 
            // nGAYGDLabel
            // 
            nGAYGDLabel.AutoSize = true;
            nGAYGDLabel.Location = new System.Drawing.Point(124, 271);
            nGAYGDLabel.Name = "nGAYGDLabel";
            nGAYGDLabel.Size = new System.Drawing.Size(66, 17);
            nGAYGDLabel.TabIndex = 10;
            nGAYGDLabel.Text = "NGAYGD:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbbChinhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1080, 91);
            this.panelControl1.TabIndex = 12;
            // 
            // cbbChinhanh
            // 
            this.cbbChinhanh.FormattingEnabled = true;
            this.cbbChinhanh.Location = new System.Drawing.Point(152, 31);
            this.cbbChinhanh.Name = "cbbChinhanh";
            this.cbbChinhanh.Size = new System.Drawing.Size(256, 24);
            this.cbbChinhanh.TabIndex = 1;
            this.cbbChinhanh.SelectedIndexChanged += new System.EventHandler(this.cbbChinhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh";
            // 
            // dSm
            // 
            this.dSm.DataSetName = "DSm";
            this.dSm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsCT
            // 
            this.bdsCT.DataMember = "GD_CHUYENTIEN";
            this.bdsCT.DataSource = this.dSm;
            // 
            // gD_CHUYENTIENTableAdapter
            // 
            this.gD_CHUYENTIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = this.gD_CHUYENTIENTableAdapter;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT_NGANHANG.DSmTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcCT
            // 
            this.gcCT.DataSource = this.bdsCT;
            this.gcCT.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcCT.Location = new System.Drawing.Point(0, 91);
            this.gcCT.MainView = this.gridView1;
            this.gcCT.Name = "gcCT";
            this.gcCT.Size = new System.Drawing.Size(1080, 247);
            this.gcCT.TabIndex = 13;
            this.gcCT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGD,
            this.colSOTK_CHUYEN,
            this.colNGAYGD,
            this.colSOTIEN,
            this.colSOTK_NHAN,
            this.colMANV});
            this.gridView1.GridControl = this.gcCT;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGD
            // 
            this.colMAGD.FieldName = "MAGD";
            this.colMAGD.MinWidth = 25;
            this.colMAGD.Name = "colMAGD";
            this.colMAGD.Visible = true;
            this.colMAGD.VisibleIndex = 0;
            this.colMAGD.Width = 94;
            // 
            // colSOTK_CHUYEN
            // 
            this.colSOTK_CHUYEN.FieldName = "SOTK_CHUYEN";
            this.colSOTK_CHUYEN.MinWidth = 25;
            this.colSOTK_CHUYEN.Name = "colSOTK_CHUYEN";
            this.colSOTK_CHUYEN.Visible = true;
            this.colSOTK_CHUYEN.VisibleIndex = 1;
            this.colSOTK_CHUYEN.Width = 94;
            // 
            // colNGAYGD
            // 
            this.colNGAYGD.FieldName = "NGAYGD";
            this.colNGAYGD.MinWidth = 25;
            this.colNGAYGD.Name = "colNGAYGD";
            this.colNGAYGD.Visible = true;
            this.colNGAYGD.VisibleIndex = 2;
            this.colNGAYGD.Width = 94;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.MinWidth = 25;
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 3;
            this.colSOTIEN.Width = 94;
            // 
            // colSOTK_NHAN
            // 
            this.colSOTK_NHAN.FieldName = "SOTK_NHAN";
            this.colSOTK_NHAN.MinWidth = 25;
            this.colSOTK_NHAN.Name = "colSOTK_NHAN";
            this.colSOTK_NHAN.Visible = true;
            this.colSOTK_NHAN.VisibleIndex = 4;
            this.colSOTK_NHAN.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 5;
            this.colMANV.Width = 94;
            // 
            // sP_CHECK_SODUBindingSource
            // 
            this.sP_CHECK_SODUBindingSource.DataMember = "SP_CHECK_SODU";
            this.sP_CHECK_SODUBindingSource.DataSource = this.dSm;
            // 
            // sP_CHECK_SODUTableAdapter
            // 
            this.sP_CHECK_SODUTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sotkToolStripLabel,
            this.sotkToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 338);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1080, 27);
            this.fillToolStrip.TabIndex = 14;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // sotkToolStripLabel
            // 
            this.sotkToolStripLabel.Name = "sotkToolStripLabel";
            this.sotkToolStripLabel.Size = new System.Drawing.Size(98, 24);
            this.sotkToolStripLabel.Text = "Số tài khoản: ";
            // 
            // sotkToolStripTextBox
            // 
            this.sotkToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sotkToolStripTextBox.Name = "sotkToolStripTextBox";
            this.sotkToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(91, 24);
            this.fillToolStripButton.Text = "check số dư";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // sP_CHECK_SODUGridControl
            // 
            this.sP_CHECK_SODUGridControl.DataSource = this.sP_CHECK_SODUBindingSource;
            this.sP_CHECK_SODUGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.sP_CHECK_SODUGridControl.Location = new System.Drawing.Point(566, 365);
            this.sP_CHECK_SODUGridControl.MainView = this.gridView2;
            this.sP_CHECK_SODUGridControl.Name = "sP_CHECK_SODUGridControl";
            this.sP_CHECK_SODUGridControl.Size = new System.Drawing.Size(514, 323);
            this.sP_CHECK_SODUGridControl.TabIndex = 14;
            this.sP_CHECK_SODUGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colSODU});
            this.gridView2.GridControl = this.sP_CHECK_SODUGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 25;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 94;
            // 
            // colSODU
            // 
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 25;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 1;
            this.colSODU.Width = 94;
            // 
            // pnTT
            // 
            this.pnTT.Controls.Add(this.btUdo);
            this.pnTT.Controls.Add(this.btGD);
            this.pnTT.Controls.Add(nGAYGDLabel);
            this.pnTT.Controls.Add(this.dtNGAYGD);
            this.pnTT.Controls.Add(this.ctExit);
            this.pnTT.Controls.Add(this.btCT);
            this.pnTT.Controls.Add(mANVLabel);
            this.pnTT.Controls.Add(this.txtMANV);
            this.pnTT.Controls.Add(sOTIENLabel);
            this.pnTT.Controls.Add(this.txtSOTIEN);
            this.pnTT.Controls.Add(sOTK_NHANLabel);
            this.pnTT.Controls.Add(this.txtSOTKN);
            this.pnTT.Controls.Add(sOTK_CHUYENLabel);
            this.pnTT.Controls.Add(this.txtSOTKC);
            this.pnTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTT.Location = new System.Drawing.Point(0, 365);
            this.pnTT.Name = "pnTT";
            this.pnTT.Size = new System.Drawing.Size(566, 323);
            this.pnTT.TabIndex = 15;
            // 
            // dtNGAYGD
            // 
            this.dtNGAYGD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT, "NGAYGD", true));
            this.dtNGAYGD.EditValue = null;
            this.dtNGAYGD.Enabled = false;
            this.dtNGAYGD.Location = new System.Drawing.Point(196, 268);
            this.dtNGAYGD.Name = "dtNGAYGD";
            this.dtNGAYGD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNGAYGD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNGAYGD.Size = new System.Drawing.Size(125, 22);
            this.dtNGAYGD.TabIndex = 11;
            // 
            // ctExit
            // 
            this.ctExit.Location = new System.Drawing.Point(439, 238);
            this.ctExit.Name = "ctExit";
            this.ctExit.Size = new System.Drawing.Size(121, 50);
            this.ctExit.TabIndex = 9;
            this.ctExit.Text = "Thoát";
            this.ctExit.UseVisualStyleBackColor = true;
            this.ctExit.Click += new System.EventHandler(this.ctExit_Click);
            // 
            // btCT
            // 
            this.btCT.Location = new System.Drawing.Point(439, 163);
            this.btCT.Name = "btCT";
            this.btCT.Size = new System.Drawing.Size(121, 50);
            this.btCT.TabIndex = 8;
            this.btCT.Text = "Chuyển tiền";
            this.btCT.UseVisualStyleBackColor = true;
            this.btCT.Click += new System.EventHandler(this.btCT_Click);
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCT, "MANV", true));
            this.txtMANV.Enabled = false;
            this.txtMANV.Location = new System.Drawing.Point(196, 214);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(100, 23);
            this.txtMANV.TabIndex = 7;
            // 
            // txtSOTIEN
            // 
            this.txtSOTIEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCT, "SOTIEN", true));
            this.txtSOTIEN.Location = new System.Drawing.Point(196, 163);
            this.txtSOTIEN.Name = "txtSOTIEN";
            this.txtSOTIEN.Size = new System.Drawing.Size(100, 23);
            this.txtSOTIEN.TabIndex = 5;
            // 
            // txtSOTKN
            // 
            this.txtSOTKN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCT, "SOTK_NHAN", true));
            this.txtSOTKN.Location = new System.Drawing.Point(196, 108);
            this.txtSOTKN.Name = "txtSOTKN";
            this.txtSOTKN.Size = new System.Drawing.Size(100, 23);
            this.txtSOTKN.TabIndex = 3;
            // 
            // txtSOTKC
            // 
            this.txtSOTKC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCT, "SOTK_CHUYEN", true));
            this.txtSOTKC.Location = new System.Drawing.Point(196, 58);
            this.txtSOTKC.Name = "txtSOTKC";
            this.txtSOTKC.Size = new System.Drawing.Size(100, 23);
            this.txtSOTKC.TabIndex = 1;
            // 
            // btGD
            // 
            this.btGD.Location = new System.Drawing.Point(439, 28);
            this.btGD.Name = "btGD";
            this.btGD.Size = new System.Drawing.Size(121, 50);
            this.btGD.TabIndex = 12;
            this.btGD.Text = "Tạo giao dịch";
            this.btGD.UseVisualStyleBackColor = true;
            this.btGD.Click += new System.EventHandler(this.btGD_Click);
            // 
            // btUdo
            // 
            this.btUdo.Location = new System.Drawing.Point(439, 94);
            this.btUdo.Name = "btUdo";
            this.btUdo.Size = new System.Drawing.Size(121, 50);
            this.btUdo.TabIndex = 13;
            this.btUdo.Text = "Trở lại";
            this.btUdo.UseVisualStyleBackColor = true;
            this.btUdo.Click += new System.EventHandler(this.btUdo_Click);
            // 
            // formTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 688);
            this.Controls.Add(this.pnTT);
            this.Controls.Add(this.sP_CHECK_SODUGridControl);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.gcCT);
            this.Controls.Add(this.panelControl1);
            this.Name = "formTransfer";
            this.Text = "formTransfer";
            this.Load += new System.EventHandler(this.formTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_CHECK_SODUBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_CHECK_SODUGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnTT)).EndInit();
            this.pnTT.ResumeLayout(false);
            this.pnTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNGAYGD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNGAYGD.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbChinhanh;
        private System.Windows.Forms.Label label1;
        private DSm dSm;
        private System.Windows.Forms.BindingSource bdsCT;
        private DSmTableAdapters.GD_CHUYENTIENTableAdapter gD_CHUYENTIENTableAdapter;
        private DSmTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcCT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource sP_CHECK_SODUBindingSource;
        private DSmTableAdapters.SP_CHECK_SODUTableAdapter sP_CHECK_SODUTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel sotkToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox sotkToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private DevExpress.XtraGrid.GridControl sP_CHECK_SODUGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK_CHUYEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK_NHAN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraEditors.PanelControl pnTT;
        private System.Windows.Forms.Button ctExit;
        private System.Windows.Forms.Button btCT;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.TextBox txtSOTIEN;
        private System.Windows.Forms.TextBox txtSOTKN;
        private System.Windows.Forms.TextBox txtSOTKC;
        private DevExpress.XtraEditors.DateEdit dtNGAYGD;
        private System.Windows.Forms.Button btGD;
        private System.Windows.Forms.Button btUdo;
    }
}