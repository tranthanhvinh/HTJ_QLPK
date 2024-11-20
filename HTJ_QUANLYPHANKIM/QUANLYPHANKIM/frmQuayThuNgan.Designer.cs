namespace QUANLYPHANKIM
{
    partial class frmQuayThuNgan
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
            this.lkCuaHang = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaQuay = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkHoatDong = new DevExpress.XtraEditors.CheckEdit();
            this.txtTenQuay = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CounterCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CounterName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ShopId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTop)).BeginInit();
            this.grTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkCuaHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaQuay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkHoatDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenQuay.Properties)).BeginInit();
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
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.edit_16x16;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.deletelist_16x16;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.save_16x16;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.undo_16x16;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 5;
            this.btnDong.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.cancel_16x16;
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1153, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 482);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1153, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 452);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1153, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 452);
            // 
            // grTop
            // 
            this.grTop.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.grTop.Appearance.Options.UseBackColor = true;
            this.grTop.Controls.Add(this.lkCuaHang);
            this.grTop.Controls.Add(this.labelControl7);
            this.grTop.Controls.Add(this.txtMaQuay);
            this.grTop.Controls.Add(this.labelControl1);
            this.grTop.Controls.Add(this.chkHoatDong);
            this.grTop.Controls.Add(this.txtTenQuay);
            this.grTop.Controls.Add(this.labelControl2);
            this.grTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.grTop.Location = new System.Drawing.Point(0, 30);
            this.grTop.Margin = new System.Windows.Forms.Padding(4);
            this.grTop.Name = "grTop";
            this.grTop.Size = new System.Drawing.Size(1153, 74);
            this.grTop.TabIndex = 10;
            this.grTop.Text = "Thông tin chung";
            // 
            // lkCuaHang
            // 
            this.lkCuaHang.EditValue = "Chọn cửa hàng";
            this.lkCuaHang.Location = new System.Drawing.Point(674, 37);
            this.lkCuaHang.Name = "lkCuaHang";
            this.lkCuaHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkCuaHang.Size = new System.Drawing.Size(284, 22);
            this.lkCuaHang.TabIndex = 34;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(598, 42);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(55, 16);
            this.labelControl7.TabIndex = 33;
            this.labelControl7.Text = "Cửa hàng";
            // 
            // txtMaQuay
            // 
            this.txtMaQuay.Location = new System.Drawing.Point(79, 37);
            this.txtMaQuay.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaQuay.Name = "txtMaQuay";
            this.txtMaQuay.Size = new System.Drawing.Size(123, 22);
            this.txtMaQuay.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 42);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 16);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Mã quầy";
            // 
            // chkHoatDong
            // 
            this.chkHoatDong.Location = new System.Drawing.Point(964, 37);
            this.chkHoatDong.Name = "chkHoatDong";
            this.chkHoatDong.Properties.Caption = "Hoạt động";
            this.chkHoatDong.Size = new System.Drawing.Size(110, 24);
            this.chkHoatDong.TabIndex = 9;
            // 
            // txtTenQuay
            // 
            this.txtTenQuay.Location = new System.Drawing.Point(286, 37);
            this.txtTenQuay.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenQuay.Name = "txtTenQuay";
            this.txtTenQuay.Size = new System.Drawing.Size(298, 22);
            this.txtTenQuay.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(220, 42);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Tên quầy";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 104);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1153, 378);
            this.gcDanhSach.TabIndex = 11;
            this.gcDanhSach.UseEmbeddedNavigator = true;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gvDanhSach.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CounterCode,
            this.CounterName,
            this.ShopId,
            this.Status});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            // 
            // CounterCode
            // 
            this.CounterCode.Caption = "Mã quầy";
            this.CounterCode.FieldName = "CounterCode";
            this.CounterCode.MaxWidth = 103;
            this.CounterCode.MinWidth = 103;
            this.CounterCode.Name = "CounterCode";
            this.CounterCode.Visible = true;
            this.CounterCode.VisibleIndex = 0;
            this.CounterCode.Width = 103;
            // 
            // CounterName
            // 
            this.CounterName.Caption = "Tên quầy";
            this.CounterName.FieldName = "CounterName";
            this.CounterName.MaxWidth = 350;
            this.CounterName.MinWidth = 350;
            this.CounterName.Name = "CounterName";
            this.CounterName.Visible = true;
            this.CounterName.VisibleIndex = 1;
            this.CounterName.Width = 350;
            // 
            // Status
            // 
            this.Status.Caption = "Trạng thái";
            this.Status.FieldName = "Status";
            this.Status.MaxWidth = 120;
            this.Status.MinWidth = 120;
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 3;
            this.Status.Width = 120;
            // 
            // ShopId
            // 
            this.ShopId.Caption = "Cửa hàng";
            this.ShopId.FieldName = "ShopId";
            this.ShopId.MinWidth = 25;
            this.ShopId.Name = "ShopId";
            this.ShopId.Visible = true;
            this.ShopId.VisibleIndex = 2;
            this.ShopId.Width = 94;
            // 
            // frmQuayThuNgan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 482);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.grTop);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmQuayThuNgan";
            this.Text = "Quầy thu ngân";
            this.Load += new System.EventHandler(this.frmQuayThuNgan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTop)).EndInit();
            this.grTop.ResumeLayout(false);
            this.grTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkCuaHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaQuay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkHoatDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenQuay.Properties)).EndInit();
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
        private DevExpress.XtraEditors.CheckEdit chkHoatDong;
        private DevExpress.XtraEditors.TextEdit txtTenQuay;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn CounterCode;
        private DevExpress.XtraGrid.Columns.GridColumn CounterName;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraEditors.TextEdit txtMaQuay;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraEditors.LookUpEdit lkCuaHang;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn ShopId;
    }
}