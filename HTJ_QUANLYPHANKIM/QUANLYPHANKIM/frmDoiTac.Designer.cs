namespace QUANLYPHANKIM
{
    partial class frmDoiTac
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grTop = new DevExpress.XtraEditors.GroupControl();
            this.lkNhomDoiTac = new DevExpress.XtraEditors.LookUpEdit();
            this.txtMaSoThue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.chkHoatDong = new DevExpress.XtraEditors.CheckEdit();
            this.txtMaDoiTac = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDoiTac = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VendorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TaxCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VendorGroupId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Notes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTop)).BeginInit();
            this.grTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhomDoiTac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoThue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkHoatDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDoiTac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDoiTac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnHuy,
            this.btnDong});
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.add_16x16;
            this.btnThem.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.add_16x16;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.edit_16x16;
            this.btnSua.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.edit_16x16;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.deletelist_16x16;
            this.btnXoa.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.deletelist_16x16;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.save_16x16;
            this.btnLuu.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.save_16x16;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.undo_16x16;
            this.btnHuy.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.undo_16x16;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 5;
            this.btnDong.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.cancel_16x16;
            this.btnDong.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.cancel_16x16;
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1255, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 764);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1255, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 734);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1255, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 734);
            // 
            // grTop
            // 
            this.grTop.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.grTop.Appearance.Options.UseBackColor = true;
            this.grTop.Controls.Add(this.lkNhomDoiTac);
            this.grTop.Controls.Add(this.txtMaSoThue);
            this.grTop.Controls.Add(this.labelControl9);
            this.grTop.Controls.Add(this.labelControl7);
            this.grTop.Controls.Add(this.txtEmail);
            this.grTop.Controls.Add(this.labelControl6);
            this.grTop.Controls.Add(this.txtGhiChu);
            this.grTop.Controls.Add(this.labelControl4);
            this.grTop.Controls.Add(this.txtDiaChi);
            this.grTop.Controls.Add(this.labelControl5);
            this.grTop.Controls.Add(this.txtDienThoai);
            this.grTop.Controls.Add(this.labelControl10);
            this.grTop.Controls.Add(this.chkHoatDong);
            this.grTop.Controls.Add(this.txtMaDoiTac);
            this.grTop.Controls.Add(this.labelControl2);
            this.grTop.Controls.Add(this.txtTenDoiTac);
            this.grTop.Controls.Add(this.labelControl1);
            this.grTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.grTop.Location = new System.Drawing.Point(0, 30);
            this.grTop.Margin = new System.Windows.Forms.Padding(4);
            this.grTop.Name = "grTop";
            this.grTop.Size = new System.Drawing.Size(1255, 155);
            this.grTop.TabIndex = 8;
            this.grTop.Text = "Thông tin chung";
            // 
            // lkNhomDoiTac
            // 
            this.lkNhomDoiTac.Location = new System.Drawing.Point(622, 89);
            this.lkNhomDoiTac.MenuManager = this.barManager1;
            this.lkNhomDoiTac.Name = "lkNhomDoiTac";
            this.lkNhomDoiTac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkNhomDoiTac.Size = new System.Drawing.Size(323, 22);
            this.lkNhomDoiTac.TabIndex = 32;
            // 
            // txtMaSoThue
            // 
            this.txtMaSoThue.Location = new System.Drawing.Point(110, 120);
            this.txtMaSoThue.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSoThue.Name = "txtMaSoThue";
            this.txtMaSoThue.Size = new System.Drawing.Size(348, 22);
            this.txtMaSoThue.TabIndex = 21;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(13, 123);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(63, 16);
            this.labelControl9.TabIndex = 31;
            this.labelControl9.Text = "Mã số thuế";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(524, 95);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(75, 16);
            this.labelControl7.TabIndex = 29;
            this.labelControl7.Text = "Nhóm đối tác";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(622, 59);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(323, 22);
            this.txtEmail.TabIndex = 23;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(524, 63);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(31, 16);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "Email";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(622, 123);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(323, 22);
            this.txtGhiChu.TabIndex = 27;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(524, 124);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 16);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "Ghi chú";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(110, 90);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(348, 22);
            this.txtDiaChi.TabIndex = 19;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 93);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 16);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Địa chỉ";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(110, 61);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(348, 22);
            this.txtDienThoai.TabIndex = 18;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(13, 64);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(58, 16);
            this.labelControl10.TabIndex = 20;
            this.labelControl10.Text = "Điện thoại";
            // 
            // chkHoatDong
            // 
            this.chkHoatDong.Location = new System.Drawing.Point(966, 30);
            this.chkHoatDong.Name = "chkHoatDong";
            this.chkHoatDong.Properties.Caption = "Hoạt động";
            this.chkHoatDong.Size = new System.Drawing.Size(110, 24);
            this.chkHoatDong.TabIndex = 9;
            // 
            // txtMaDoiTac
            // 
            this.txtMaDoiTac.Location = new System.Drawing.Point(110, 32);
            this.txtMaDoiTac.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDoiTac.Name = "txtMaDoiTac";
            this.txtMaDoiTac.Size = new System.Drawing.Size(348, 22);
            this.txtMaDoiTac.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 35);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Mã đối tác";
            // 
            // txtTenDoiTac
            // 
            this.txtTenDoiTac.Location = new System.Drawing.Point(622, 31);
            this.txtTenDoiTac.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDoiTac.Name = "txtTenDoiTac";
            this.txtTenDoiTac.Size = new System.Drawing.Size(323, 22);
            this.txtTenDoiTac.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(524, 35);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tên đối tác";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 185);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1255, 579);
            this.gcDanhSach.TabIndex = 14;
            this.gcDanhSach.UseEmbeddedNavigator = true;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gvDanhSach.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.VendorName,
            this.Phone,
            this.Email,
            this.TaxCode,
            this.Address,
            this.VendorGroupId,
            this.Notes,
            this.Status});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            // 
            // Id
            // 
            this.Id.Caption = "ID";
            this.Id.FieldName = "Id";
            this.Id.MaxWidth = 103;
            this.Id.MinWidth = 103;
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            this.Id.Width = 103;
            // 
            // VendorName
            // 
            this.VendorName.Caption = "Tên đối tác";
            this.VendorName.FieldName = "VendorName";
            this.VendorName.MaxWidth = 300;
            this.VendorName.MinWidth = 300;
            this.VendorName.Name = "VendorName";
            this.VendorName.Visible = true;
            this.VendorName.VisibleIndex = 1;
            this.VendorName.Width = 300;
            // 
            // Phone
            // 
            this.Phone.Caption = "Điện thoại";
            this.Phone.FieldName = "Phone";
            this.Phone.MaxWidth = 150;
            this.Phone.MinWidth = 150;
            this.Phone.Name = "Phone";
            this.Phone.Visible = true;
            this.Phone.VisibleIndex = 2;
            this.Phone.Width = 150;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.MaxWidth = 120;
            this.Email.MinWidth = 120;
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 3;
            this.Email.Width = 120;
            // 
            // TaxCode
            // 
            this.TaxCode.Caption = "MST";
            this.TaxCode.FieldName = "TaxCode";
            this.TaxCode.MaxWidth = 100;
            this.TaxCode.MinWidth = 100;
            this.TaxCode.Name = "TaxCode";
            this.TaxCode.Visible = true;
            this.TaxCode.VisibleIndex = 4;
            this.TaxCode.Width = 100;
            // 
            // Address
            // 
            this.Address.Caption = "Địa chỉ";
            this.Address.FieldName = "Address";
            this.Address.MaxWidth = 250;
            this.Address.MinWidth = 250;
            this.Address.Name = "Address";
            this.Address.Visible = true;
            this.Address.VisibleIndex = 6;
            this.Address.Width = 250;
            // 
            // VendorGroupId
            // 
            this.VendorGroupId.Caption = "Nhóm đối tác";
            this.VendorGroupId.FieldName = "VendorGroupId";
            this.VendorGroupId.MaxWidth = 150;
            this.VendorGroupId.MinWidth = 150;
            this.VendorGroupId.Name = "VendorGroupId";
            this.VendorGroupId.Visible = true;
            this.VendorGroupId.VisibleIndex = 5;
            this.VendorGroupId.Width = 150;
            // 
            // Notes
            // 
            this.Notes.Caption = "Ghi chú";
            this.Notes.FieldName = "Notes";
            this.Notes.MaxWidth = 200;
            this.Notes.MinWidth = 200;
            this.Notes.Name = "Notes";
            this.Notes.Visible = true;
            this.Notes.VisibleIndex = 7;
            this.Notes.Width = 200;
            // 
            // Status
            // 
            this.Status.Caption = "Trạng thái";
            this.Status.FieldName = "Status";
            this.Status.MaxWidth = 100;
            this.Status.MinWidth = 100;
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 8;
            this.Status.Width = 100;
            // 
            // frmDoiTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 764);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.grTop);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDoiTac";
            this.Text = "Đối tác";
            this.Load += new System.EventHandler(this.frmDoiTac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTop)).EndInit();
            this.grTop.ResumeLayout(false);
            this.grTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhomDoiTac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoThue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkHoatDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDoiTac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDoiTac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl grTop;
        private DevExpress.XtraEditors.TextEdit txtMaSoThue;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtDienThoai;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.CheckEdit chkHoatDong;
        private DevExpress.XtraEditors.TextEdit txtMaDoiTac;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenDoiTac;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lkNhomDoiTac;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn VendorName;
        private DevExpress.XtraGrid.Columns.GridColumn Phone;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn TaxCode;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn VendorGroupId;
        private DevExpress.XtraGrid.Columns.GridColumn Notes;
    }
}