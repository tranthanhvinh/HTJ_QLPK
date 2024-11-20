using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using QUANLYPHANKIM.Libs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QUANLYPHANKIM
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
      
        private static MainForm _defaultInstance;
        public static MainForm Instance
        {

            get
            {
                if (_defaultInstance == null)
                {
                    _defaultInstance = new MainForm();
                }
                return _defaultInstance;
            }
            set => _defaultInstance = value;
        }
        public MainForm()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

            ribbon.SelectedPage = ribbonPageChucNang;
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }
        OverlayWindowOptions options = new OverlayWindowOptions(
       backColor: Color.Black,
       opacity: 0.5,
       fadeIn: false,
       fadeOut: false
       );
        IOverlaySplashScreenHandle ShowProgressPanel(Control control, OverlayWindowOptions optoin)
        {
            return SplashScreenManager.ShowOverlayForm(control, optoin);
        }
        void openForm(Type typeForm)
        {
            foreach (var frm in MdiChildren)
            {
                if (frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Library.handle = ShowProgressPanel(this, options);
            //frmLogin frm = new frmLogin();
            //frm.ShowDialog();
            openForm(typeof(frmMainInfo));

            foreach (SkinContainer container in SkinManager.Default.Skins)
            {
                BarButtonItem barItem = new BarButtonItem();
                barItem.Name = container.SkinName;
                barItem.Caption = container.SkinName;
                barItem.ImageOptions.Image = SkinCollectionHelper.GetSkinIcon(container.SkinName, DevExpress.Skins.SkinIconsSize.Small);
                barItem.ItemClick += BarItem_ItemClick;
                //btnGiaoDien.AddItem(barItem);
            }
        }
        private void BarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle(e.Item.Name);
        }
       
       
        private void btnNhomDoiTac_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmNhomDoiTac));
        }

        private void btnDoiTac_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmDoiTac));
        }

        private void btnKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmKho));
        }
       
        
        private void btnLoaiVang_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmLoaiVang));
        }
        private void btnBangGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmBangGia));
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnTraoDoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmTraoDoi));
        }

        private void btnBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmBan));
        }

        private void btnMua_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmMua));
        }

        private void btnChotGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmChotGia));
        }

        private void btnKho_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmKho));
        }

        private void btnQuayThuNgan_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmQuayThuNgan));
        }

        private void btnThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
