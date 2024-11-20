namespace QUANLYPHANKIM
{
    partial class MainForm
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnChotGia = new DevExpress.XtraBars.BarButtonItem();
            this.btnTraoDoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnBan = new DevExpress.XtraBars.BarButtonItem();
            this.btnMua = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhomDoiTac = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiTac = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnCongNo = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuThu = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuChi = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiVang = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangGia = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuayThuNgan = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenQuay = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnTonKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnKho = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongTin = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnNguoiDung = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.lblFullname = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPageChucNang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupCatGia = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupGiaoDich = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupThuChi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupKho = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupDoiTac = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupLoaiVang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupThuNgan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupQLKho = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupNguoiDung = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupThoat = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnChotGia,
            this.btnTraoDoi,
            this.btnBan,
            this.btnMua,
            this.btnNhomDoiTac,
            this.btnDoiTac,
            this.barButtonItem1,
            this.btnCongNo,
            this.btnPhieuThu,
            this.btnPhieuChi,
            this.btnLoaiVang,
            this.btnBangGia,
            this.btnQuayThuNgan,
            this.btnChuyenQuay,
            this.btnChuyenKho,
            this.btnTonKho,
            this.btnKho,
            this.barButtonItem2,
            this.btnThongTin,
            this.btnDoiMatKhau,
            this.btnNguoiDung,
            this.btnThoat,
            this.lblFullname});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 32;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 385;
            this.ribbon.PageHeaderItemLinks.Add(this.lblFullname);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageChucNang,
            this.ribbonPageDanhMuc,
            this.ribbonPageHeThong});
            this.ribbon.Size = new System.Drawing.Size(1573, 193);
            // 
            // btnChotGia
            // 
            this.btnChotGia.Caption = "Chốt giá";
            this.btnChotGia.Id = 1;
            this.btnChotGia.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.chartchangestyle_32x32;
            this.btnChotGia.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.chartchangestyle_32x32;
            this.btnChotGia.Name = "btnChotGia";
            this.btnChotGia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChotGia_ItemClick);
            // 
            // btnTraoDoi
            // 
            this.btnTraoDoi.Caption = "Trao đổi";
            this.btnTraoDoi.Id = 3;
            this.btnTraoDoi.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.convert_32x32;
            this.btnTraoDoi.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.convert_32x32;
            this.btnTraoDoi.Name = "btnTraoDoi";
            this.btnTraoDoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTraoDoi_ItemClick);
            // 
            // btnBan
            // 
            this.btnBan.Caption = "Bán";
            this.btnBan.Id = 4;
            this.btnBan.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.costanalysis_32x32;
            this.btnBan.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.costanalysis_32x32;
            this.btnBan.Name = "btnBan";
            this.btnBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBan_ItemClick);
            // 
            // btnMua
            // 
            this.btnMua.Caption = "Mua";
            this.btnMua.Id = 5;
            this.btnMua.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.buy_32x32;
            this.btnMua.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.buy_32x32;
            this.btnMua.Name = "btnMua";
            this.btnMua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMua_ItemClick);
            // 
            // btnNhomDoiTac
            // 
            this.btnNhomDoiTac.Caption = "Nhóm đối tác";
            this.btnNhomDoiTac.Id = 6;
            this.btnNhomDoiTac.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.groupbydate_32x32;
            this.btnNhomDoiTac.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.groupbydate_32x32;
            this.btnNhomDoiTac.Name = "btnNhomDoiTac";
            this.btnNhomDoiTac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhomDoiTac_ItemClick);
            // 
            // btnDoiTac
            // 
            this.btnDoiTac.Caption = "Đối tác";
            this.btnDoiTac.Id = 7;
            this.btnDoiTac.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.groupbyresource_32x32;
            this.btnDoiTac.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.groupbyresource_32x32;
            this.btnDoiTac.Name = "btnDoiTac";
            this.btnDoiTac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiTac_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnCongNo
            // 
            this.btnCongNo.Caption = "Công nợ";
            this.btnCongNo.Id = 9;
            this.btnCongNo.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.projectdirectory_32x32;
            this.btnCongNo.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.projectdirectory_32x32;
            this.btnCongNo.Name = "btnCongNo";
            // 
            // btnPhieuThu
            // 
            this.btnPhieuThu.Caption = "Phiếu thu";
            this.btnPhieuThu.Id = 11;
            this.btnPhieuThu.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.currency_32x32;
            this.btnPhieuThu.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.currency_32x32;
            this.btnPhieuThu.Name = "btnPhieuThu";
            // 
            // btnPhieuChi
            // 
            this.btnPhieuChi.Caption = "Phiếu chi";
            this.btnPhieuChi.Id = 12;
            this.btnPhieuChi.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.currency_32x321;
            this.btnPhieuChi.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.currency_32x321;
            this.btnPhieuChi.Name = "btnPhieuChi";
            // 
            // btnLoaiVang
            // 
            this.btnLoaiVang.Caption = "Loại vàng";
            this.btnLoaiVang.Id = 13;
            this.btnLoaiVang.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.boproduct_32x32;
            this.btnLoaiVang.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.boproduct_32x32;
            this.btnLoaiVang.Name = "btnLoaiVang";
            this.btnLoaiVang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoaiVang_ItemClick);
            // 
            // btnBangGia
            // 
            this.btnBangGia.Caption = "Bảng giá";
            this.btnBangGia.Id = 14;
            this.btnBangGia.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.opportunities_32x32;
            this.btnBangGia.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.opportunities_32x32;
            this.btnBangGia.Name = "btnBangGia";
            this.btnBangGia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangGia_ItemClick);
            // 
            // btnQuayThuNgan
            // 
            this.btnQuayThuNgan.Caption = "Quầy thu ngân";
            this.btnQuayThuNgan.Id = 16;
            this.btnQuayThuNgan.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.financial_32x32;
            this.btnQuayThuNgan.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.financial_32x32;
            this.btnQuayThuNgan.Name = "btnQuayThuNgan";
            this.btnQuayThuNgan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuayThuNgan_ItemClick);
            // 
            // btnChuyenQuay
            // 
            this.btnChuyenQuay.Caption = "Chuyển quầy";
            this.btnChuyenQuay.Id = 17;
            this.btnChuyenQuay.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.functionsmore_32x32;
            this.btnChuyenQuay.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.functionsmore_32x32;
            this.btnChuyenQuay.Name = "btnChuyenQuay";
            // 
            // btnChuyenKho
            // 
            this.btnChuyenKho.Caption = "Chuyển kho";
            this.btnChuyenKho.Id = 18;
            this.btnChuyenKho.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.sortgroupfooter_32x32;
            this.btnChuyenKho.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.sortgroupfooter_32x32;
            this.btnChuyenKho.Name = "btnChuyenKho";
            // 
            // btnTonKho
            // 
            this.btnTonKho.Caption = "Tồn kho";
            this.btnTonKho.Id = 19;
            this.btnTonKho.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.cube_32x32;
            this.btnTonKho.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.cube_32x32;
            this.btnTonKho.Name = "btnTonKho";
            // 
            // btnKho
            // 
            this.btnKho.Caption = "Kho";
            this.btnKho.Id = 20;
            this.btnKho.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.home_32x32;
            this.btnKho.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.home_32x32;
            this.btnKho.Name = "btnKho";
            this.btnKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKho_ItemClick_1);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 21;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnThongTin
            // 
            this.btnThongTin.Caption = "Thông tin";
            this.btnThongTin.Id = 27;
            this.btnThongTin.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.bocontact2_32x32;
            this.btnThongTin.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.bocontact2_32x32;
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongTin_ItemClick);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi mật khẩu";
            this.btnDoiMatKhau.Id = 28;
            this.btnDoiMatKhau.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.encrypt_32x32;
            this.btnDoiMatKhau.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.encrypt_32x32;
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiMatKhau_ItemClick);
            // 
            // btnNguoiDung
            // 
            this.btnNguoiDung.Caption = "Người dùng";
            this.btnNguoiDung.Id = 29;
            this.btnNguoiDung.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.user_32x32;
            this.btnNguoiDung.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.user_32x32;
            this.btnNguoiDung.Name = "btnNguoiDung";
            this.btnNguoiDung.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNguoiDung_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 30;
            this.btnThoat.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.close_32x32;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // lblFullname
            // 
            this.lblFullname.Caption = "FullName";
            this.lblFullname.Id = 31;
            this.lblFullname.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.user_32x321;
            this.lblFullname.ImageOptions.LargeImage = global::QUANLYPHANKIM.Properties.Resources.user_32x321;
            this.lblFullname.Name = "lblFullname";
            // 
            // ribbonPageChucNang
            // 
            this.ribbonPageChucNang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupCatGia,
            this.ribbonPageGroupGiaoDich,
            this.ribbonPageGroupThuChi,
            this.ribbonPageGroupKho});
            this.ribbonPageChucNang.Name = "ribbonPageChucNang";
            this.ribbonPageChucNang.Text = "Chức năng";
            // 
            // ribbonPageGroupCatGia
            // 
            this.ribbonPageGroupCatGia.ItemLinks.Add(this.btnChotGia);
            this.ribbonPageGroupCatGia.Name = "ribbonPageGroupCatGia";
            // 
            // ribbonPageGroupGiaoDich
            // 
            this.ribbonPageGroupGiaoDich.ItemLinks.Add(this.btnTraoDoi);
            this.ribbonPageGroupGiaoDich.ItemLinks.Add(this.btnBan);
            this.ribbonPageGroupGiaoDich.ItemLinks.Add(this.btnMua);
            this.ribbonPageGroupGiaoDich.Name = "ribbonPageGroupGiaoDich";
            // 
            // ribbonPageGroupThuChi
            // 
            this.ribbonPageGroupThuChi.ItemLinks.Add(this.btnPhieuThu);
            this.ribbonPageGroupThuChi.ItemLinks.Add(this.btnPhieuChi);
            this.ribbonPageGroupThuChi.ItemLinks.Add(this.btnChuyenQuay);
            this.ribbonPageGroupThuChi.Name = "ribbonPageGroupThuChi";
            // 
            // ribbonPageGroupKho
            // 
            this.ribbonPageGroupKho.ItemLinks.Add(this.btnChuyenKho);
            this.ribbonPageGroupKho.ItemLinks.Add(this.btnTonKho);
            this.ribbonPageGroupKho.Name = "ribbonPageGroupKho";
            // 
            // ribbonPageDanhMuc
            // 
            this.ribbonPageDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupDoiTac,
            this.ribbonPageGroupLoaiVang,
            this.ribbonPageGroupThuNgan,
            this.ribbonPageGroupQLKho});
            this.ribbonPageDanhMuc.Name = "ribbonPageDanhMuc";
            this.ribbonPageDanhMuc.Text = "Danh mục";
            // 
            // ribbonPageGroupDoiTac
            // 
            this.ribbonPageGroupDoiTac.ItemLinks.Add(this.btnNhomDoiTac);
            this.ribbonPageGroupDoiTac.ItemLinks.Add(this.btnDoiTac);
            this.ribbonPageGroupDoiTac.ItemLinks.Add(this.btnCongNo);
            this.ribbonPageGroupDoiTac.Name = "ribbonPageGroupDoiTac";
            // 
            // ribbonPageGroupLoaiVang
            // 
            this.ribbonPageGroupLoaiVang.ItemLinks.Add(this.btnLoaiVang);
            this.ribbonPageGroupLoaiVang.ItemLinks.Add(this.btnBangGia);
            this.ribbonPageGroupLoaiVang.Name = "ribbonPageGroupLoaiVang";
            // 
            // ribbonPageGroupThuNgan
            // 
            this.ribbonPageGroupThuNgan.ItemLinks.Add(this.btnQuayThuNgan);
            this.ribbonPageGroupThuNgan.Name = "ribbonPageGroupThuNgan";
            // 
            // ribbonPageGroupQLKho
            // 
            this.ribbonPageGroupQLKho.ItemLinks.Add(this.btnKho);
            this.ribbonPageGroupQLKho.Name = "ribbonPageGroupQLKho";
            // 
            // ribbonPageHeThong
            // 
            this.ribbonPageHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupNguoiDung,
            this.ribbonPageGroupThoat});
            this.ribbonPageHeThong.Name = "ribbonPageHeThong";
            this.ribbonPageHeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroupNguoiDung
            // 
            this.ribbonPageGroupNguoiDung.ItemLinks.Add(this.btnThongTin);
            this.ribbonPageGroupNguoiDung.ItemLinks.Add(this.btnDoiMatKhau);
            this.ribbonPageGroupNguoiDung.ItemLinks.Add(this.btnNguoiDung);
            this.ribbonPageGroupNguoiDung.Name = "ribbonPageGroupNguoiDung";
            // 
            // ribbonPageGroupThoat
            // 
            this.ribbonPageGroupThoat.ItemLinks.Add(this.btnThoat);
            this.ribbonPageGroupThoat.Name = "ribbonPageGroupThoat";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1573, 981);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.Text = "QUẢN LÝ PHÂN KIM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageChucNang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCatGia;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem btnChotGia;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupDoiTac;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupGiaoDich;
        private DevExpress.XtraBars.BarButtonItem btnTraoDoi;
        private DevExpress.XtraBars.BarButtonItem btnBan;
        private DevExpress.XtraBars.BarButtonItem btnMua;
        private DevExpress.XtraBars.BarButtonItem btnNhomDoiTac;
        private DevExpress.XtraBars.BarButtonItem btnDoiTac;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnCongNo;        
        private DevExpress.XtraBars.BarButtonItem btnPhieuThu;
        private DevExpress.XtraBars.BarButtonItem btnPhieuChi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupThuChi;
        private DevExpress.XtraBars.BarButtonItem btnLoaiVang;
        private DevExpress.XtraBars.BarButtonItem btnBangGia;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupLoaiVang;      
        private DevExpress.XtraBars.BarButtonItem btnQuayThuNgan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupThuNgan;
        private DevExpress.XtraBars.BarButtonItem btnChuyenQuay;
        private DevExpress.XtraBars.BarButtonItem btnChuyenKho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupKho;
        private DevExpress.XtraBars.BarButtonItem btnTonKho;
        private DevExpress.XtraBars.BarButtonItem btnKho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupQLKho;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnThongTin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupNguoiDung;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem btnNguoiDung;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupThoat;
        public DevExpress.XtraBars.BarStaticItem lblFullname;
    }
}

