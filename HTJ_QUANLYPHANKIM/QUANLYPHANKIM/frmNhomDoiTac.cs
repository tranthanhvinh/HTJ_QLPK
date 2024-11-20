using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYPHANKIM
{
    public partial class frmNhomDoiTac : DevExpress.XtraEditors.XtraForm
    {
        public frmNhomDoiTac()
        {
            InitializeComponent();
        }
        bool _them = false;
        int _id;
        Bus_NhomDoiTac _NhomDoiTac;
        BindingSource bindingSource;
       
        void visibility(bool v)
        {
            btnThem.Enabled = v;
            btnSua.Enabled = v;
            btnXoa.Enabled = v;
            btnLuu.Enabled = !v;
            btnHuy.Enabled = !v;
            txtTenNhom.Enabled = !v;
            chkHoatDong.Enabled = !v;
        }
        bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }
        void LoadData()
        {
            bindingSource.DataSource = _NhomDoiTac.GetList();
            gcDanhSach.DataSource = bindingSource;
            gvDanhSach.OptionsBehavior.Editable = false;

            XuatThongTin();
        }
        void NhanThongTin(VendorGroup nh)
        {
            nh.GroupName = txtTenNhom.Text;
            
        }
        void SaveData()
        {
            VendorGroup ndt;
            if (_them)
            {
                ndt = new VendorGroup();
                //ndt.MaNhomNCC = int.Parse( txtMaNhom.Text;
                NhanThongTin(ndt);
                _NhomDoiTac.Add(ndt);
            }
            else
            {
                ndt = (VendorGroup)bindingSource.Current;
                NhanThongTin(ndt);
                _NhomDoiTac.Update(ndt);
            }
        }
        void XuatThongTin()
        {
            VendorGroup current = (VendorGroup)bindingSource.Current;
            if (current != null)            {
               
                txtTenNhom.Text = current.GroupName;                
            }
        }
        private void frmNhomDoiTac_Load(object sender, EventArgs e)
        {
            _NhomDoiTac = new Bus_NhomDoiTac();
            bindingSource = new BindingSource();
            visibility(true);
            LoadData();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            grTop.Text = "Thêm mới";
            visibility(false);
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            VendorGroup current = (VendorGroup)bindingSource.Current;
            if (current == null)
            {
                XtraMessageBox.Show("Chưa chọn nhóm cần chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            grTop.Text = "Cập nhật";
            _them = false;

            visibility(false);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            return;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn lưu dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SaveData();
                _them = false;
                visibility(true);
                LoadData();
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            visibility(true);
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void gvDanhSach_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvDanhSach.IsGroupRow(e.RowHandle))
            {
                if (e.Info.IsRowIndicator)
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1;
                        e.Info.DisplayText = (e.RowHandle + 1).ToString();
                    }
                    SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                    Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvDanhSach); }));
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1));
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvDanhSach); }));
            }
        }
    }
}