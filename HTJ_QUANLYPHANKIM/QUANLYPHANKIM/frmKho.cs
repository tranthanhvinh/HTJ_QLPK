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
    public partial class frmKho : DevExpress.XtraEditors.XtraForm
    {
        public frmKho()
        {
            InitializeComponent();
        }
        bool _them = false;
        int _id;
        Bus_Kho _Kho;
        BindingSource bindingSource;
        private void frmKho_Load(object sender, EventArgs e)
        {
            _Kho = new Bus_Kho();
            bindingSource = new BindingSource();
            visibility(true);
            LoadCuaHang();
            LoadData();
            bindingSource.PositionChanged += BindingSource_PositionChanged; 
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (!_them)
            {
                XuatThongTin();
            }
        }
        // Ẩn hiện các controls
        void visibility(bool v)
        {
            btnThem.Enabled = v;
            btnSua.Enabled = v;
            btnXoa.Enabled = v;
            btnLuu.Enabled = !v;
            btnHuy.Enabled = !v;           
            txtMaKho.Enabled = !v;
            txtTenKho.Enabled = !v;
            txtDiaChi.Enabled = !v;
            lkCuaHang.Enabled = !v;
        }
        void LoadCuaHang()
        {
            Bus_Shop _cuahang = new Bus_Shop();
            lkCuaHang.Properties.DataSource = _cuahang.GetList();
            lkCuaHang.Properties.DisplayMember = "ShopName";
            lkCuaHang.Properties.ValueMember = "Id";
        }

        void reset()
        {
            txtMaKho.Text = "";
            txtTenKho.Text = "";
            chkHoatDong.EditValue = true;

        }
        bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }
        void LoadData()
        {
            _Kho = new Bus_Kho();
            bindingSource.DataSource = _Kho.GetList();
            gcDanhSach.DataSource = bindingSource;
            gvDanhSach.OptionsBehavior.Editable = false;

            XuatThongTin();
        }
        void NhanThongTin(Stock st)
        {
            st.StockCode = txtMaKho.Text;
            st.StockName = txtTenKho.Text;
            st.ShopId = lkCuaHang.EditValue.ToString();
            st.Status = chkHoatDong.Checked;
        }
        void SaveData()
        {
            Stock st;
            if (_them)
            {
                st = new Stock();
                _Kho = new Bus_Kho();

                List<Stock> lst = _Kho.GetList();

                st.StockCode = txtMaKho.Text;
                NhanThongTin(st);
                var result = _Kho.Add(st);
                bindingSource.Add(result);
                bindingSource.MoveLast();
            }
            else
            {
                st = (Stock)bindingSource.Current;
                NhanThongTin(st);
                var result = _Kho.Update(st);

                gvDanhSach.ClearSorting();
                gvDanhSach.RefreshData();
                var obj = bindingSource.List.OfType<Stock>().ToList().Find(c => c.StockCode == result.StockCode);
                bindingSource.Position = bindingSource.IndexOf(obj);
            }
        }
        void XuatThongTin()
        {
            Stock current = (Stock)bindingSource.Current;
            if (current != null)
            {
                txtMaKho.Text = current.StockCode;
                txtTenKho.Text = current.StockName;
                lkCuaHang.EditValue = current.ShopId;
                chkHoatDong.EditValue = current.Status;
            }
        }

        private void gvDanhSach_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grTop.Text = "Thêm mới";
            _them = true;
            reset();
            visibility(false);
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Stock current = (Stock)bindingSource.Current;
            if (current == null)
            {
                XtraMessageBox.Show("Chưa chọn Kho cần chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (lkCuaHang.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn Cửa hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
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

        private void btnChuyenKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

       
    }
}