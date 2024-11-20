using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYPHANKIM.Libs;

namespace QUANLYPHANKIM.Popups
{
    public partial class frmDoiTac_Popup : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiTac_Popup()
        {
            InitializeComponent();
        }
        public frmDoiTac_Popup(Vendor dt, bool them)
        {
            InitializeComponent();
            this._them = them;
            this._dt = dt;
        }
        bool _them;
        public int _manhomdt;
        public Vendor _dt;
        Bus_NhomDoiTac _nhomdt;
        Bus_DoiTac _doitac;
        private void frmDoiTac_Popup_Load(object sender, EventArgs e)
        {
            _nhomdt = new Bus_NhomDoiTac();
            _doitac = new Bus_DoiTac();

            cboNhom.DataSource = _nhomdt.GetList();
            cboNhom.ValueMember = "Id";
            cboNhom.DisplayMember = "GroupName";           

            if (_dt != null && _them == false)
            {
                txtMa.Text = _dt.Id;
                txtTen.Text = _dt.VendorName;
                txtDienThoai.Text = _dt.Phone;
                txtEmail.Text = _dt.Email;
                txtDiaChi.Text = _dt.Address;
                txtMaSoThue.Text = _dt.TaxCode;
                txtGhiChu.Text = _dt.Notes;
                //spinChietKhau.EditValue = _dt.ChietKhau;
                cboNhom.SelectedValue = _dt.VendorGroupId;
            }
            txtMa.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Add
            if (_dt == null && _them == true)
            {
                Vendor dt = new Vendor();
                _doitac = new Bus_DoiTac();

                List<Vendor> lst = _doitac.GetList();
                string id = (lst.Count == 0) ? PrimaryKeyGenerator.Instance.NormalKey("", "DT") : PrimaryKeyGenerator.Instance.NormalKey((lst[lst.Count - 1].Id).ToString(), "DT");
                dt.Id = id;
                dt.VendorName = txtTen.Text;
                dt.Phone = txtDienThoai.Text;
                dt.Email = txtEmail.Text;
                dt.Address = txtDiaChi.Text;
                dt.TaxCode = txtMaSoThue.Text;
                dt.Notes = txtGhiChu.Text;
                //dt.ChietKhau = Convert.ToDouble(spinChietKhau.EditValue);
                dt.VendorGroupId = int.Parse(cboNhom.SelectedValue.ToString());
                _dt = _doitac.Add(dt);
            }
            else
            {
                var dt = _doitac.GetById(_dt.Id);
                dt.VendorName = txtTen.Text;
                dt.Phone = txtDienThoai.Text;
                dt.Email = txtEmail.Text;
                dt.Address = txtDiaChi.Text;
                dt.TaxCode = txtMaSoThue.Text;
                dt.Notes = txtGhiChu.Text;
                //dt.ChietKhau = Convert.ToDouble(spinChietKhau.EditValue);
                dt.VendorGroupId = int.Parse(cboNhom.SelectedValue.ToString());
                _dt = _doitac.Update(dt);
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}