namespace QUANLYPHANKIM
{
    partial class frmLoaiVang
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
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.grTop = new DevExpress.XtraEditors.GroupControl();
            this.chkHoatDong = new DevExpress.XtraEditors.CheckEdit();
            this.txtMaLoaiVang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenLoaiVang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GoldCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GoldName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GoldAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinTuoiPho = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTop)).BeginInit();
            this.grTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkHoatDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoaiVang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiVang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTuoiPho.Properties)).BeginInit();
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
            this.barButtonItem6,
            this.btnDong});
            this.barManager1.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(176, 165);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Offset = 7;
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
            this.btnDong.Id = 6;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1249, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 582);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1249, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 552);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1249, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 552);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Đóng";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // grTop
            // 
            this.grTop.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.grTop.Appearance.Options.UseBackColor = true;
            this.grTop.Controls.Add(this.labelControl3);
            this.grTop.Controls.Add(this.spinTuoiPho);
            this.grTop.Controls.Add(this.chkHoatDong);
            this.grTop.Controls.Add(this.txtMaLoaiVang);
            this.grTop.Controls.Add(this.labelControl2);
            this.grTop.Controls.Add(this.txtTenLoaiVang);
            this.grTop.Controls.Add(this.labelControl1);
            this.grTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.grTop.Location = new System.Drawing.Point(0, 30);
            this.grTop.Margin = new System.Windows.Forms.Padding(4);
            this.grTop.Name = "grTop";
            this.grTop.Size = new System.Drawing.Size(1249, 74);
            this.grTop.TabIndex = 8;
            this.grTop.Text = "Thông tin chung";
            // 
            // chkHoatDong
            // 
            this.chkHoatDong.Location = new System.Drawing.Point(987, 38);
            this.chkHoatDong.MenuManager = this.barManager1;
            this.chkHoatDong.Name = "chkHoatDong";
            this.chkHoatDong.Properties.Caption = "Hoạt động";
            this.chkHoatDong.Size = new System.Drawing.Size(110, 24);
            this.chkHoatDong.TabIndex = 9;
            // 
            // txtMaLoaiVang
            // 
            this.txtMaLoaiVang.Location = new System.Drawing.Point(93, 39);
            this.txtMaLoaiVang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLoaiVang.MenuManager = this.barManager1;
            this.txtMaLoaiVang.Name = "txtMaLoaiVang";
            this.txtMaLoaiVang.Size = new System.Drawing.Size(177, 22);
            this.txtMaLoaiVang.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 42);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Mã loại vàng";
            // 
            // txtTenLoaiVang
            // 
            this.txtTenLoaiVang.Location = new System.Drawing.Point(390, 39);
            this.txtTenLoaiVang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLoaiVang.MenuManager = this.barManager1;
            this.txtTenLoaiVang.Name = "txtTenLoaiVang";
            this.txtTenLoaiVang.Size = new System.Drawing.Size(346, 22);
            this.txtTenLoaiVang.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(305, 42);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tên loại vàng";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 104);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1249, 478);
            this.gcDanhSach.TabIndex = 9;
            this.gcDanhSach.UseEmbeddedNavigator = true;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GoldCode,
            this.GoldName,
            this.GoldAge,
            this.Status});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            // 
            // GoldCode
            // 
            this.GoldCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.GoldCode.AppearanceHeader.Options.UseFont = true;
            this.GoldCode.Caption = "Mã loại";
            this.GoldCode.FieldName = "GoldCode";
            this.GoldCode.MinWidth = 25;
            this.GoldCode.Name = "GoldCode";
            this.GoldCode.Visible = true;
            this.GoldCode.VisibleIndex = 0;
            this.GoldCode.Width = 94;
            // 
            // GoldName
            // 
            this.GoldName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.GoldName.AppearanceHeader.Options.UseFont = true;
            this.GoldName.Caption = "Tên loại";
            this.GoldName.FieldName = "GoldName";
            this.GoldName.MinWidth = 25;
            this.GoldName.Name = "GoldName";
            this.GoldName.Visible = true;
            this.GoldName.VisibleIndex = 1;
            this.GoldName.Width = 94;
            // 
            // GoldAge
            // 
            this.GoldAge.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.GoldAge.AppearanceHeader.Options.UseFont = true;
            this.GoldAge.Caption = "Tuổi phổ";
            this.GoldAge.FieldName = "GoldAge";
            this.GoldAge.MinWidth = 25;
            this.GoldAge.Name = "GoldAge";
            this.GoldAge.Visible = true;
            this.GoldAge.VisibleIndex = 2;
            this.GoldAge.Width = 94;
            // 
            // Status
            // 
            this.Status.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.Status.AppearanceHeader.Options.UseFont = true;
            this.Status.Caption = "Trạng thái";
            this.Status.FieldName = "Status";
            this.Status.MinWidth = 25;
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 3;
            this.Status.Width = 94;
            // 
            // spinTuoiPho
            // 
            this.spinTuoiPho.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTuoiPho.Location = new System.Drawing.Point(837, 38);
            this.spinTuoiPho.MenuManager = this.barManager1;
            this.spinTuoiPho.Name = "spinTuoiPho";
            this.spinTuoiPho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinTuoiPho.Size = new System.Drawing.Size(125, 24);
            this.spinTuoiPho.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(769, 41);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 16);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Tuổi phổ";
            // 
            // frmLoaiVang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 582);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.grTop);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmLoaiVang";
            this.Text = "Loại vàng";
            this.Load += new System.EventHandler(this.frmLoaiVang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTop)).EndInit();
            this.grTop.ResumeLayout(false);
            this.grTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkHoatDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoaiVang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiVang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTuoiPho.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraEditors.GroupControl grTop;
        private DevExpress.XtraEditors.CheckEdit chkHoatDong;
        private DevExpress.XtraEditors.TextEdit txtMaLoaiVang;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenLoaiVang;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn GoldCode;
        private DevExpress.XtraGrid.Columns.GridColumn GoldName;
        private DevExpress.XtraGrid.Columns.GridColumn GoldAge;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SpinEdit spinTuoiPho;
    }
}