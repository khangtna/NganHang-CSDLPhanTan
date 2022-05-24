
namespace CSDLPT_NGANHANG
{
    partial class formAccount
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
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label sODULabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label nGAYMOTKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAccount));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btUdo = new DevExpress.XtraBars.BarButtonItem();
            this.btSave = new DevExpress.XtraBars.BarButtonItem();
            this.btDel = new DevExpress.XtraBars.BarButtonItem();
            this.btFix = new DevExpress.XtraBars.BarButtonItem();
            this.btReload = new DevExpress.XtraBars.BarButtonItem();
            this.btExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btRes = new DevExpress.XtraBars.BarButtonItem();
            this.btNote = new DevExpress.XtraBars.BarButtonItem();
            this.dSm = new CSDLPT_NGANHANG.DSm();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new CSDLPT_NGANHANG.DSmTableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new CSDLPT_NGANHANG.DSmTableAdapters.TableAdapterManager();
            this.gD_GOIRUTTableAdapter = new CSDLPT_NGANHANG.DSmTableAdapters.GD_GOIRUTTableAdapter();
            this.gcTK = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnTT = new DevExpress.XtraEditors.PanelControl();
            this.dtNGAY = new DevExpress.XtraEditors.DateEdit();
            this.txtMACN = new System.Windows.Forms.TextBox();
            this.txtSODU = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtSOTK = new System.Windows.Forms.TextBox();
            this.bdsGR = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbbChinhanh = new System.Windows.Forms.ComboBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            sOTKLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            sODULabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            nGAYMOTKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnTT)).BeginInit();
            this.pnTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNGAY.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNGAY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Location = new System.Drawing.Point(47, 42);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(47, 17);
            sOTKLabel.TabIndex = 0;
            sOTKLabel.Text = "SOTK:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(43, 94);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(51, 17);
            cMNDLabel.TabIndex = 2;
            cMNDLabel.Text = "CMND:";
            // 
            // sODULabel
            // 
            sODULabel.AutoSize = true;
            sODULabel.Location = new System.Drawing.Point(44, 146);
            sODULabel.Name = "sODULabel";
            sODULabel.Size = new System.Drawing.Size(50, 17);
            sODULabel.TabIndex = 4;
            sODULabel.Text = "SODU:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(375, 91);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(49, 17);
            mACNLabel.TabIndex = 6;
            mACNLabel.Text = "MACN:";
            // 
            // nGAYMOTKLabel
            // 
            nGAYMOTKLabel.AutoSize = true;
            nGAYMOTKLabel.Location = new System.Drawing.Point(341, 43);
            nGAYMOTKLabel.Name = "nGAYMOTKLabel";
            nGAYMOTKLabel.Size = new System.Drawing.Size(83, 17);
            nGAYMOTKLabel.TabIndex = 8;
            nGAYMOTKLabel.Text = "NGAYMOTK:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btAdd,
            this.btDel,
            this.btFix,
            this.btRes,
            this.btNote,
            this.btReload,
            this.btExit,
            this.btSave,
            this.btUdo});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 11;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btUdo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btDel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btFix, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btAdd
            // 
            this.btAdd.Caption = "Tạo";
            this.btAdd.Id = 0;
            this.btAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.ImageOptions.Image")));
            this.btAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btAdd.ImageOptions.LargeImage")));
            this.btAdd.Name = "btAdd";
            this.btAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btAdd_ItemClick);
            // 
            // btUdo
            // 
            this.btUdo.Caption = "Khôi phục";
            this.btUdo.Id = 10;
            this.btUdo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btUdo.ImageOptions.Image")));
            this.btUdo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btUdo.ImageOptions.LargeImage")));
            this.btUdo.Name = "btUdo";
            this.btUdo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btUdo_ItemClick);
            // 
            // btSave
            // 
            this.btSave.Caption = "Save";
            this.btSave.Id = 9;
            this.btSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btSave.ImageOptions.Image")));
            this.btSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btSave.ImageOptions.LargeImage")));
            this.btSave.Name = "btSave";
            this.btSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btSave_ItemClick);
            // 
            // btDel
            // 
            this.btDel.Caption = "Xóa";
            this.btDel.Id = 1;
            this.btDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btDel.ImageOptions.Image")));
            this.btDel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btDel.ImageOptions.LargeImage")));
            this.btDel.Name = "btDel";
            this.btDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btDel_ItemClick);
            // 
            // btFix
            // 
            this.btFix.Caption = "Sửa";
            this.btFix.Id = 2;
            this.btFix.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btFix.ImageOptions.Image")));
            this.btFix.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btFix.ImageOptions.LargeImage")));
            this.btFix.Name = "btFix";
            this.btFix.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btFix_ItemClick);
            // 
            // btReload
            // 
            this.btReload.Caption = "Reload";
            this.btReload.Id = 6;
            this.btReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btReload.ImageOptions.Image")));
            this.btReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btReload.ImageOptions.LargeImage")));
            this.btReload.Name = "btReload";
            this.btReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btReload_ItemClick);
            // 
            // btExit
            // 
            this.btExit.Caption = "Thoát";
            this.btExit.Id = 7;
            this.btExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btExit.ImageOptions.Image")));
            this.btExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btExit.ImageOptions.LargeImage")));
            this.btExit.Name = "btExit";
            this.btExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btExit_ItemClick_1);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(894, 57);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 589);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(894, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 57);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 532);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(894, 57);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 532);
            // 
            // btRes
            // 
            this.btRes.Caption = "Khôi phục";
            this.btRes.Id = 4;
            this.btRes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btRes.ImageOptions.Image")));
            this.btRes.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btRes.ImageOptions.LargeImage")));
            this.btRes.Name = "btRes";
            // 
            // btNote
            // 
            this.btNote.Caption = "Ghi";
            this.btNote.Id = 5;
            this.btNote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btNote.ImageOptions.Image")));
            this.btNote.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btNote.ImageOptions.LargeImage")));
            this.btNote.Name = "btNote";
            // 
            // dSm
            // 
            this.dSm.DataSetName = "DSm";
            this.dSm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "TaiKhoan";
            this.bdsTK.DataSource = this.dSm;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = this.gD_GOIRUTTableAdapter;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = CSDLPT_NGANHANG.DSmTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gD_GOIRUTTableAdapter
            // 
            this.gD_GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // gcTK
            // 
            this.gcTK.DataSource = this.bdsTK;
            this.gcTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcTK.Location = new System.Drawing.Point(0, 121);
            this.gcTK.MainView = this.gridView1;
            this.gcTK.MenuManager = this.barManager1;
            this.gcTK.Name = "gcTK";
            this.gcTK.Size = new System.Drawing.Size(894, 282);
            this.gcTK.TabIndex = 6;
            this.gcTK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcTK.Click += new System.EventHandler(this.taiKhoanGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND,
            this.colSODU,
            this.colMACN,
            this.colNGAYMOTK});
            this.gridView1.GridControl = this.gcTK;
            this.gridView1.Name = "gridView1";
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
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 1;
            this.colCMND.Width = 94;
            // 
            // colSODU
            // 
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 25;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            this.colSODU.Width = 94;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            this.colMACN.Width = 94;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.MinWidth = 25;
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            this.colNGAYMOTK.Width = 94;
            // 
            // pnTT
            // 
            this.pnTT.Controls.Add(nGAYMOTKLabel);
            this.pnTT.Controls.Add(this.dtNGAY);
            this.pnTT.Controls.Add(mACNLabel);
            this.pnTT.Controls.Add(this.txtMACN);
            this.pnTT.Controls.Add(sODULabel);
            this.pnTT.Controls.Add(this.txtSODU);
            this.pnTT.Controls.Add(cMNDLabel);
            this.pnTT.Controls.Add(this.txtCMND);
            this.pnTT.Controls.Add(sOTKLabel);
            this.pnTT.Controls.Add(this.txtSOTK);
            this.pnTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTT.Location = new System.Drawing.Point(0, 403);
            this.pnTT.Name = "pnTT";
            this.pnTT.Size = new System.Drawing.Size(894, 186);
            this.pnTT.TabIndex = 7;
            // 
            // dtNGAY
            // 
            this.dtNGAY.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "NGAYMOTK", true));
            this.dtNGAY.EditValue = null;
            this.dtNGAY.Enabled = false;
            this.dtNGAY.Location = new System.Drawing.Point(430, 40);
            this.dtNGAY.MenuManager = this.barManager1;
            this.dtNGAY.Name = "dtNGAY";
            this.dtNGAY.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNGAY.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNGAY.Size = new System.Drawing.Size(125, 22);
            this.dtNGAY.TabIndex = 9;
            // 
            // txtMACN
            // 
            this.txtMACN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "MACN", true));
            this.txtMACN.Enabled = false;
            this.txtMACN.Location = new System.Drawing.Point(430, 88);
            this.txtMACN.Name = "txtMACN";
            this.txtMACN.Size = new System.Drawing.Size(100, 23);
            this.txtMACN.TabIndex = 7;
            // 
            // txtSODU
            // 
            this.txtSODU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "SODU", true));
            this.txtSODU.Location = new System.Drawing.Point(100, 143);
            this.txtSODU.Name = "txtSODU";
            this.txtSODU.Size = new System.Drawing.Size(100, 23);
            this.txtSODU.TabIndex = 5;
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "CMND", true));
            this.txtCMND.Location = new System.Drawing.Point(100, 91);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(100, 23);
            this.txtCMND.TabIndex = 3;
            // 
            // txtSOTK
            // 
            this.txtSOTK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "SOTK", true));
            this.txtSOTK.Location = new System.Drawing.Point(100, 39);
            this.txtSOTK.Name = "txtSOTK";
            this.txtSOTK.Size = new System.Drawing.Size(100, 23);
            this.txtSOTK.TabIndex = 1;
            // 
            // bdsGR
            // 
            this.bdsGR.DataMember = "FK_GD_GOIRUT_TaiKhoan";
            this.bdsGR.DataSource = this.bdsTK;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh:";
            // 
            // cbbChinhanh
            // 
            this.cbbChinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChinhanh.FormattingEnabled = true;
            this.cbbChinhanh.Location = new System.Drawing.Point(163, 16);
            this.cbbChinhanh.Name = "cbbChinhanh";
            this.cbbChinhanh.Size = new System.Drawing.Size(332, 24);
            this.cbbChinhanh.TabIndex = 1;
            this.cbbChinhanh.SelectedIndexChanged += new System.EventHandler(this.cbbChinhanh_SelectedIndexChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbbChinhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 57);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(894, 64);
            this.panelControl1.TabIndex = 4;
            // 
            // formAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 613);
            this.Controls.Add(this.pnTT);
            this.Controls.Add(this.gcTK);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "formAccount";
            this.Text = "formAccount";
            this.Load += new System.EventHandler(this.formAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnTT)).EndInit();
            this.pnTT.ResumeLayout(false);
            this.pnTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNGAY.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNGAY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btAdd;
        private DevExpress.XtraBars.BarButtonItem btDel;
        private DevExpress.XtraBars.BarButtonItem btFix;
        private DevExpress.XtraBars.BarButtonItem btRes;
        private DevExpress.XtraBars.BarButtonItem btNote;
        private DevExpress.XtraBars.BarButtonItem btReload;
        private DevExpress.XtraBars.BarButtonItem btExit;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsTK;
        private DSm dSm;
        private DSmTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private DSmTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl pnTT;
        private DevExpress.XtraEditors.DateEdit dtNGAY;
        private System.Windows.Forms.TextBox txtMACN;
        private System.Windows.Forms.TextBox txtSODU;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtSOTK;
        private DevExpress.XtraGrid.GridControl gcTK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private DSmTableAdapters.GD_GOIRUTTableAdapter gD_GOIRUTTableAdapter;
        private System.Windows.Forms.BindingSource bdsGR;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbChinhanh;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem btSave;
        private DevExpress.XtraBars.BarButtonItem btUdo;
    }
}