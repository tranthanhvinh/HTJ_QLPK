using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QUANLYPHANKIM.Libs;
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
    public partial class frmDoiTac : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiTac()
        {
            InitializeComponent();
        }
        bool _them = false;
        string _id;
        Bus_DoiTac _DoiTac;
        BindingSource bindingSource;
        private void frmDoiTac_Load(object sender, EventArgs e)
        {
            _DoiTac = new Bus_DoiTac();
            bindingSource = new BindingSource();
            visibility(true);
            LoadNhomDoiTac();
            LoadData();
            bindingSource.PositionChanged += BindingSource_PositionChanged;
            //lkNhomDoiTac.Properties.Buttons[1].Click += FrmDoiTac_Click1;

            //lkNhomDoiTac.Properties.Buttons[2].Click += FrmDoiTac_Click;           

            //txtMaDoiTac.ReadOnly = true;
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (!_them)
            {
                XuatThongTin();
            }
        }



        //private void FrmDoiTac_Click1(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void FrmDoiTac_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}




        void LoadNhomDoiTac()
        {
            Bus_NhomDoiTac _nhomdoitac = new Bus_NhomDoiTac();
            lkNhomDoiTac.Properties.DataSource = _nhomdoitac.GetList();
            lkNhomDoiTac.Properties.DisplayMember = "GroupName";
            lkNhomDoiTac.Properties.ValueMember = "Id";
        }
        void visibility(bool v)
        {
            btnThem.Enabled = v;
            btnSua.Enabled = v;
            btnXoa.Enabled = v;
            btnLuu.Enabled = !v;
            btnHuy.Enabled = !v;           
            txtMaDoiTac.Enabled = !v;
            txtTenDoiTac.Enabled = !v;
            txtDienThoai.Enabled = !v;
            txtDiaChi.Enabled = !v;
            txtGhiChu.Enabled = !v;
            txtMaSoThue.Enabled = !v;
            txtEmail.Enabled = !v;
            lkNhomDoiTac.Enabled = !v;
            chkHoatDong.Enabled = !v;
        }
        void reset()
        {
            txtMaDoiTac.Text = "";
            txtTenDoiTac.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtGhiChu.Text = "";
            txtMaSoThue.Text = "";
            txtDiaChi.Text = "";
            chkHoatDong.EditValue = true;

        }
        bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }
        void LoadData()
        {
            _DoiTac = new Bus_DoiTac();
            bindingSource.DataSource = _DoiTac.GetList();
            gcDanhSach.DataSource = bindingSource;
            gvDanhSach.OptionsBehavior.Editable = false;

            XuatThongTin();
        }
        void NhanThongTin(Vendor dt)
        {
            dt.Id = txtMaDoiTac.Text;
            dt.VendorName = txtTenDoiTac.Text;
            dt.Phone = txtDienThoai.Text;
            dt.Address = txtDiaChi.Text;
            dt.Notes = txtGhiChu.Text;
            dt.Email = txtEmail.Text;
            dt.TaxCode = txtMaSoThue.Text;
            dt.VendorGroupId = int.Parse(lkNhomDoiTac.EditValue.ToString());
            dt.Status = chkHoatDong.Checked;
        }
        void SaveData()
        {
            Vendor dt;
            if (_them)
            {
                dt = new Vendor();
                _DoiTac = new Bus_DoiTac();
                //List<Vendor> lst = _DoiTac.GetList();
                //string id = (lst.Count == 0) ? PrimaryKeyGenerator.Instance.NormalKeyForDoiTac("", "DT") : PrimaryKeyGenerator.Instance.NormalKeyForDoiTac((lst[lst.Count - 1].Id).ToString(), "DT");                
                //dt.Id = txtMaDoiTac.Text;
                NhanThongTin(dt);
                var result = _DoiTac.Add(dt);
                bindingSource.Add(result);
                bindingSource.MoveLast();
            }
            else
            {
                dt = (Vendor)bindingSource.Current;
                NhanThongTin(dt);
                var result = _DoiTac.Update(dt);

                gvDanhSach.ClearSorting();
                gvDanhSach.RefreshData();
                var obj = bindingSource.List.OfType<Vendor>().ToList().Find(c => c.Id == result.Id);
                bindingSource.Position = bindingSource.IndexOf(obj);
            }
        }
       
        void XuatThongTin()
        {
            Vendor current = (Vendor)bindingSource.Current;
            if (current != null)
            {
                txtMaDoiTac.Text = current.Id;
                txtTenDoiTac.Text = current.VendorName;
                txtDienThoai.Text = current.Phone;
                txtDiaChi.Text = current.Address;
                txtEmail.Text = current.Email;
                txtMaSoThue.Text = current.TaxCode;
                txtGhiChu.Text = current.Notes;
                lkNhomDoiTac.EditValue = current.VendorGroupId;
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
            Vendor current = (Vendor)bindingSource.Current;
            if (current == null)
            {
                XtraMessageBox.Show("Chưa chọn Đối tác cần chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (lkNhomDoiTac.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn Nhóm đối tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}