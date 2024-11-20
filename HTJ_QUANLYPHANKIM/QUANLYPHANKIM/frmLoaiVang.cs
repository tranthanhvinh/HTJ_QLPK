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
    public partial class frmLoaiVang : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiVang()
        {
            InitializeComponent();
        }
        bool _them = false;
        int _id;
        Bus_LoaiVang _loaiVang;
        BindingSource bindingSource;
        
        private void frmLoaiVang_Load(object sender, EventArgs e)
        {
            _loaiVang = new Bus_LoaiVang();
            bindingSource = new BindingSource();
            visibility(true);           
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
            txtMaLoaiVang.Enabled = !v;
            txtTenLoaiVang.Enabled = !v;
            spinTuoiPho.Enabled = !v;
            chkHoatDong.Enabled = !v;
        }

        void reset()
        {
            txtMaLoaiVang.Text = "";
            txtTenLoaiVang.Text = "";
            spinTuoiPho.Text = "";
            chkHoatDong.EditValue = true;

        }
        bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }
        void LoadData()
        {
            _loaiVang = new Bus_LoaiVang();
            bindingSource.DataSource = _loaiVang.GetList();
            gcDanhSach.DataSource = bindingSource;
            gvDanhSach.OptionsBehavior.Editable = false;

            XuatThongTin();
        }
        void NhanThongTin(Gold gold)
        {
            gold.GoldCode = txtMaLoaiVang.Text;
            gold.GoldName = txtTenLoaiVang.Text;
            gold.GoldAge = decimal.Parse(spinTuoiPho.Text);
            gold.Status = chkHoatDong.Checked;
        }
        void SaveData()
        {
            Gold gold;
            if (_them)
            {
                gold = new Gold();
                _loaiVang = new Bus_LoaiVang();

                List<Gold> lst = _loaiVang.GetList();

                gold.GoldCode = txtMaLoaiVang.Text;
                gold.GoldName = txtTenLoaiVang.Text;
                gold.GoldAge = decimal.Parse(spinTuoiPho.Text);
                gold.Status = chkHoatDong.Checked;
                NhanThongTin(gold);
                var result = _loaiVang.add(gold);
                bindingSource.Add(result);
                bindingSource.MoveLast();
            }
            else
            {
                gold = (Gold)bindingSource.Current;
                NhanThongTin(gold);
                var result = _loaiVang.update(gold);
                gvDanhSach.ClearSorting();
                gvDanhSach.RefreshData();
                var obj = bindingSource.List.OfType<Gold>().ToList().Find(c => c.GoldCode == result.GoldCode);
                bindingSource.Position = bindingSource.IndexOf(obj);
            }
        }
        void XuatThongTin()
        {
            Gold current = (Gold)bindingSource.Current;
            if (current != null)
            {
                txtMaLoaiVang.Text = current.GoldCode;
                txtTenLoaiVang.Text = current.GoldName;
                spinTuoiPho.Text = current.GoldAge.ToString();
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
            Gold current = (Gold)bindingSource.Current;
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

      
    }
}