
namespace CSDLPT_NGANHANG
{
    partial class formTrade
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
            System.Windows.Forms.Label lOAIGDLabel;
            System.Windows.Forms.Label nGAYGDLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label sOTIENLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTrade));
            this.dSm = new CSDLPT_NGANHANG.DSm();
            this.bdsGR = new System.Windows.Forms.BindingSource(this.components);
            this.gD_GOIRUTTableAdapter = new CSDLPT_NGANHANG.DSmTableAdapters.GD_GOIRUTTableAdapter();
            this.tableAdapterManager = new CSDLPT_NGANHANG.DSmTableAdapters.TableAdapterManager();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btUdo = new DevExpress.XtraBars.BarButtonItem();
            this.btGui = new DevExpress.XtraBars.BarButtonItem();
            this.btRut = new DevExpress.XtraBars.BarButtonItem();
            this.btReload = new DevExpress.XtraBars.BarButtonItem();
            this.btExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btDel = new DevExpress.XtraBars.BarButtonItem();
            this.btRes = new DevExpress.XtraBars.BarButtonItem();
            this.btNote = new DevExpress.XtraBars.BarButtonItem();
            this.gcGR = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAIGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnTT = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbChinhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.sotkToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.sotkToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sP_CHECK_SODUGridControl = new DevExpress.XtraGrid.GridControl();
            this.sP_CHECK_SODUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSOTIEN = new System.Windows.Forms.TextBox();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.dtNGAYGD = new DevExpress.XtraEditors.DateEdit();
            this.txtLOAIGD = new System.Windows.Forms.TextBox();
            this.txtSOTK = new System.Windows.Forms.TextBox();
            this.sP_CHECK_SODUTableAdapter = new CSDLPT_NGANHANG.DSmTableAdapters.SP_CHECK_SODUTableAdapter();
            sOTKLabel = new System.Windows.Forms.Label();
            lOAIGDLabel = new System.Windows.Forms.Label();
            nGAYGDLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            sOTIENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnTT)).BeginInit();
            this.pnTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_CHECK_SODUGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_CHECK_SODUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNGAYGD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNGAYGD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Location = new System.Drawing.Point(67, 87);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(47, 17);
            sOTKLabel.TabIndex = 0;
            sOTKLabel.Text = "SOTK:";
            // 
            // lOAIGDLabel
            // 
            lOAIGDLabel.AutoSize = true;
            lOAIGDLabel.Location = new System.Drawing.Point(53, 211);
            lOAIGDLabel.Name = "lOAIGDLabel";
            lOAIGDLabel.Size = new System.Drawing.Size(61, 17);
            lOAIGDLabel.TabIndex = 2;
            lOAIGDLabel.Text = "LOAIGD:";
            lOAIGDLabel.Visible = false;
            // 
            // nGAYGDLabel
            // 
            nGAYGDLabel.AutoSize = true;
            nGAYGDLabel.Location = new System.Drawing.Point(287, 144);
            nGAYGDLabel.Name = "nGAYGDLabel";
            nGAYGDLabel.Size = new System.Drawing.Size(66, 17);
            nGAYGDLabel.TabIndex = 4;
            nGAYGDLabel.Text = "NGAYGD:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(305, 88);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(48, 17);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "MANV:";
            // 
            // sOTIENLabel
            // 
            sOTIENLabel.AutoSize = true;
            sOTIENLabel.Location = new System.Drawing.Point(54, 143);
            sOTIENLabel.Name = "sOTIENLabel";
            sOTIENLabel.Size = new System.Drawing.Size(60, 17);
            sOTIENLabel.TabIndex = 8;
            sOTIENLabel.Text = "SOTIEN:";
            // 
            // dSm
            // 
            this.dSm.DataSetName = "DSm";
            this.dSm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsGR
            // 
            this.bdsGR.DataMember = "GD_GOIRUT";
            this.bdsGR.DataSource = this.dSm;
            // 
            // gD_GOIRUTTableAdapter
            // 
            this.gD_GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = this.gD_GOIRUTTableAdapter;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT_NGANHANG.DSmTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.btRut,
            this.btRes,
            this.btNote,
            this.btReload,
            this.btExit,
            this.btGui,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btGui, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btRut, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btAdd
            // 
            this.btAdd.Caption = "Tạo giao dịch";
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
            // btGui
            // 
            this.btGui.Caption = "Gửi";
            this.btGui.Id = 9;
            this.btGui.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btGui.ImageOptions.Image")));
            this.btGui.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btGui.ImageOptions.LargeImage")));
            this.btGui.Name = "btGui";
            this.btGui.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btGui_ItemClick);
            // 
            // btRut
            // 
            this.btRut.Caption = "Rút";
            this.btRut.Id = 2;
            this.btRut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btRut.ImageOptions.Image")));
            this.btRut.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btRut.ImageOptions.LargeImage")));
            this.btRut.Name = "btRut";
            this.btRut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btRut_ItemClick);
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
            this.btExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btExit_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1035, 57);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 612);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1035, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 57);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 555);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1035, 57);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 555);
            // 
            // btDel
            // 
            this.btDel.Caption = "Xóa";
            this.btDel.Id = 1;
            this.btDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btDel.ImageOptions.Image")));
            this.btDel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btDel.ImageOptions.LargeImage")));
            this.btDel.Name = "btDel";
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
            // gcGR
            // 
            this.gcGR.DataSource = this.bdsGR;
            this.gcGR.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcGR.Location = new System.Drawing.Point(0, 57);
            this.gcGR.MainView = this.gridView1;
            this.gcGR.MenuManager = this.barManager1;
            this.gcGR.Name = "gcGR";
            this.gcGR.Size = new System.Drawing.Size(1035, 269);
            this.gcGR.TabIndex = 4;
            this.gcGR.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGD,
            this.colSOTK,
            this.colLOAIGD,
            this.colNGAYGD,
            this.colSOTIEN,
            this.colMANV});
            this.gridView1.GridControl = this.gcGR;
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
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 25;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 1;
            this.colSOTK.Width = 94;
            // 
            // colLOAIGD
            // 
            this.colLOAIGD.FieldName = "LOAIGD";
            this.colLOAIGD.MinWidth = 25;
            this.colLOAIGD.Name = "colLOAIGD";
            this.colLOAIGD.Visible = true;
            this.colLOAIGD.VisibleIndex = 2;
            this.colLOAIGD.Width = 94;
            // 
            // colNGAYGD
            // 
            this.colNGAYGD.FieldName = "NGAYGD";
            this.colNGAYGD.MinWidth = 25;
            this.colNGAYGD.Name = "colNGAYGD";
            this.colNGAYGD.Visible = true;
            this.colNGAYGD.VisibleIndex = 3;
            this.colNGAYGD.Width = 94;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.MinWidth = 25;
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 4;
            this.colSOTIEN.Width = 94;
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
            // pnTT
            // 
            this.pnTT.Controls.Add(this.panelControl1);
            this.pnTT.Controls.Add(this.fillToolStrip);
            this.pnTT.Controls.Add(this.sP_CHECK_SODUGridControl);
            this.pnTT.Controls.Add(sOTIENLabel);
            this.pnTT.Controls.Add(this.txtSOTIEN);
            this.pnTT.Controls.Add(mANVLabel);
            this.pnTT.Controls.Add(this.txtMANV);
            this.pnTT.Controls.Add(nGAYGDLabel);
            this.pnTT.Controls.Add(this.dtNGAYGD);
            this.pnTT.Controls.Add(lOAIGDLabel);
            this.pnTT.Controls.Add(this.txtLOAIGD);
            this.pnTT.Controls.Add(sOTKLabel);
            this.pnTT.Controls.Add(this.txtSOTK);
            this.pnTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTT.Location = new System.Drawing.Point(0, 326);
            this.pnTT.Name = "pnTT";
            this.pnTT.Size = new System.Drawing.Size(1035, 286);
            this.pnTT.TabIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbbChinhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(2, 184);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(506, 100);
            this.panelControl1.TabIndex = 11;
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
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sotkToolStripLabel,
            this.sotkToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(2, 2);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(506, 27);
            this.fillToolStrip.TabIndex = 10;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // sotkToolStripLabel
            // 
            this.sotkToolStripLabel.Name = "sotkToolStripLabel";
            this.sotkToolStripLabel.Size = new System.Drawing.Size(94, 24);
            this.sotkToolStripLabel.Text = "Số tài khoản:";
            // 
            // sotkToolStripTextBox
            // 
            this.sotkToolStripTextBox.Name = "sotkToolStripTextBox";
            this.sotkToolStripTextBox.Size = new System.Drawing.Size(98, 27);
            this.sotkToolStripTextBox.Click += new System.EventHandler(this.sotkToolStripTextBox_Click);
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
            this.sP_CHECK_SODUGridControl.Location = new System.Drawing.Point(508, 2);
            this.sP_CHECK_SODUGridControl.MainView = this.gridView2;
            this.sP_CHECK_SODUGridControl.MenuManager = this.barManager1;
            this.sP_CHECK_SODUGridControl.Name = "sP_CHECK_SODUGridControl";
            this.sP_CHECK_SODUGridControl.Size = new System.Drawing.Size(525, 282);
            this.sP_CHECK_SODUGridControl.TabIndex = 10;
            this.sP_CHECK_SODUGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // sP_CHECK_SODUBindingSource
            // 
            this.sP_CHECK_SODUBindingSource.DataMember = "SP_CHECK_SODU";
            this.sP_CHECK_SODUBindingSource.DataSource = this.dSm;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK1,
            this.colSODU});
            this.gridView2.GridControl = this.sP_CHECK_SODUGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colSOTK1
            // 
            this.colSOTK1.FieldName = "SOTK";
            this.colSOTK1.MinWidth = 25;
            this.colSOTK1.Name = "colSOTK1";
            this.colSOTK1.Visible = true;
            this.colSOTK1.VisibleIndex = 0;
            this.colSOTK1.Width = 94;
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
            // txtSOTIEN
            // 
            this.txtSOTIEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGR, "SOTIEN", true));
            this.txtSOTIEN.Location = new System.Drawing.Point(120, 140);
            this.txtSOTIEN.Name = "txtSOTIEN";
            this.txtSOTIEN.Size = new System.Drawing.Size(100, 23);
            this.txtSOTIEN.TabIndex = 9;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGR, "MANV", true));
            this.txtMANV.Enabled = false;
            this.txtMANV.Location = new System.Drawing.Point(359, 85);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(100, 23);
            this.txtMANV.TabIndex = 7;
            // 
            // dtNGAYGD
            // 
            this.dtNGAYGD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGR, "NGAYGD", true));
            this.dtNGAYGD.EditValue = null;
            this.dtNGAYGD.Enabled = false;
            this.dtNGAYGD.Location = new System.Drawing.Point(359, 141);
            this.dtNGAYGD.MenuManager = this.barManager1;
            this.dtNGAYGD.Name = "dtNGAYGD";
            this.dtNGAYGD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNGAYGD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNGAYGD.Size = new System.Drawing.Size(125, 22);
            this.dtNGAYGD.TabIndex = 5;
            // 
            // txtLOAIGD
            // 
            this.txtLOAIGD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGR, "LOAIGD", true));
            this.txtLOAIGD.Location = new System.Drawing.Point(120, 208);
            this.txtLOAIGD.Name = "txtLOAIGD";
            this.txtLOAIGD.Size = new System.Drawing.Size(100, 23);
            this.txtLOAIGD.TabIndex = 3;
            this.txtLOAIGD.Visible = false;
            // 
            // txtSOTK
            // 
            this.txtSOTK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGR, "SOTK", true));
            this.txtSOTK.Location = new System.Drawing.Point(120, 84);
            this.txtSOTK.Name = "txtSOTK";
            this.txtSOTK.Size = new System.Drawing.Size(100, 23);
            this.txtSOTK.TabIndex = 1;
            // 
            // sP_CHECK_SODUTableAdapter
            // 
            this.sP_CHECK_SODUTableAdapter.ClearBeforeFill = true;
            // 
            // formTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 636);
            this.Controls.Add(this.pnTT);
            this.Controls.Add(this.gcGR);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "formTrade";
            this.Text = "formTrade";
            this.Load += new System.EventHandler(this.formTrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnTT)).EndInit();
            this.pnTT.ResumeLayout(false);
            this.pnTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_CHECK_SODUGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_CHECK_SODUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNGAYGD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNGAYGD.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSm dSm;
        private System.Windows.Forms.BindingSource bdsGR;
        private DSmTableAdapters.GD_GOIRUTTableAdapter gD_GOIRUTTableAdapter;
        private DSmTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btAdd;
        private DevExpress.XtraBars.BarButtonItem btUdo;
        private DevExpress.XtraBars.BarButtonItem btGui;
        private DevExpress.XtraBars.BarButtonItem btRut;
        private DevExpress.XtraBars.BarButtonItem btDel;
        private DevExpress.XtraBars.BarButtonItem btReload;
        private DevExpress.XtraBars.BarButtonItem btExit;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl pnTT;
        private System.Windows.Forms.TextBox txtSOTIEN;
        private System.Windows.Forms.TextBox txtMANV;
        private DevExpress.XtraEditors.DateEdit dtNGAYGD;
        private System.Windows.Forms.TextBox txtLOAIGD;
        private System.Windows.Forms.TextBox txtSOTK;
        private DevExpress.XtraGrid.GridControl gcGR;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAIGD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraBars.BarButtonItem btRes;
        private DevExpress.XtraBars.BarButtonItem btNote;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel sotkToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox sotkToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.BindingSource sP_CHECK_SODUBindingSource;
        private DSmTableAdapters.SP_CHECK_SODUTableAdapter sP_CHECK_SODUTableAdapter;
        private DevExpress.XtraGrid.GridControl sP_CHECK_SODUGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK1;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbChinhanh;
        private System.Windows.Forms.Label label1;
    }
}