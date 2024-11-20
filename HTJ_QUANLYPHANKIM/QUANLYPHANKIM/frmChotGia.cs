using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QUANLYPHANKIM.Libs;
using QUANLYPHANKIM.Popups;
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
    public partial class frmChotGia : DevExpress.XtraEditors.XtraForm
    {
        public frmChotGia()
        {
            InitializeComponent();
        }

        bool _them;
        Bus_LoaiVang _loaivang;
        Bus_DoiTac _doitac;
        Bus_LoaiGiaoDich _loaigiaodich;
        Bus_PhieuChotGia _phieuchotgia;
        Bus_PhieuChotGiaCT _phieuchotgiact;
        Bus_Sequence _sequence;
        Bus_CuaHang _cuaHang;
        BindingSource _bdPhieuChotGia;
        BindingSource _bdPhieuChotGiaCT;
        Guid poId;
        Sequence _seq;
        Guid podetailId;
        List<ProvisionalOrder> _lstPhieuChotGia;
        List<ProvisionalOrderDetail> _lstPhieuChotGiaCT;
        ProvisionalOrder _ctu;
        Shop _ch;
        private void frmChotGia_Load(object sender, EventArgs e)
        {
            _loaivang = new Bus_LoaiVang();

            dtDenNgay.EditValue = DateTime.Now;
            dtTuNgay.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);


            _doitac = new Bus_DoiTac();
            _sequence = new Bus_Sequence();
            _cuaHang = new Bus_CuaHang();
            _loaigiaodich = new Bus_LoaiGiaoDich();

            _phieuchotgia = new Bus_PhieuChotGia();
            _phieuchotgiact = new Bus_PhieuChotGiaCT();
            _bdPhieuChotGia = new BindingSource();
            _bdPhieuChotGiaCT = new BindingSource();

            tabMain.SelectedTabPage = tabDanhSach;
            tabChiTiet.PageEnabled = false;

            cboTrangThai.DataSource = Libs.TrangThai.getList();
            cboTrangThai.DisplayMember = "_display";
            cboTrangThai.ValueMember = "_value";

            
            LoadLoaiVang();
            loadData();
            loadCuaHang();
            loadLoaiGiaoDich();
            loadDoiTac();
            _showControl();
            dtTuNgay.EditValueChanged += DtTuNgay_EditValueChanged;
            dtDenNgay.EditValueChanged += DtDenNgay_EditValueChanged;

            //Bắt sự kiện change vị trí trên lưới để show dữ liệu
            _bdPhieuChotGia.PositionChanged += _bdPhieuChotGia_PositionChanged;

            lkDoiTac.EditValueChanged += LkDoiTac_EditValueChanged;
            lkDoiTac.Properties.Buttons[1].Click += FrmChotGia_Click;
            lkDoiTac.Properties.Buttons[2].Click += FrmChotGia_Click1;
            btnXoaCT.Click += BtnXoaCT_Click;

            visibility(true);
            _enable(false);

            //txtDiaChi.ReadOnly = true;
            //txtMaDoiTac.ReadOnly = true;
            //txtDienThoai.ReadOnly = true;
            //txtSoPhieu.ReadOnly = true;
            btnExcel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            spThanhTien.ReadOnly = true;
            spTongTL.ReadOnly = true;

        }

        private void BtnXoaCT_Click(object sender, EventArgs e)
        {
           
        }

        private void _bdPhieuChotGia_PositionChanged(object sender, EventArgs e)
        {
            if (!_them)
            {
                xuatThongTin();
            }

        }

        //Button Thêm Đối tác
        private void FrmChotGia_Click1(object sender, EventArgs e)
        {
            if (lkDoiTac.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn đối tác cần cập nhật thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (frmDoiTac_Popup frm = new frmDoiTac_Popup(_doitac.GetById(lkDoiTac.EditValue.ToString()), false))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    loadDoiTac();
                    lkDoiTac.EditValue = frm._dt.Id;
                }
            }
        }
        //Button Cập nhật Đối tác
        private void FrmChotGia_Click(object sender, EventArgs e)
        {
            using (frmDoiTac_Popup frm = new frmDoiTac_Popup(null, true))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    loadDoiTac();
                    lkDoiTac.EditValue = frm._dt.Id;
                }
            }
        }

        void _enable(bool t)
        {
            //contextMenuStrip1.Enabled = t;

            txtGhiChu.Enabled = t;
            lkDoiTac.Enabled = t;
            txtSoPhieu.Enabled = t;
            dtNgayChungTu.Enabled = t;
            cboTrangThai.Enabled = t;
            gvChiTiet.OptionsBehavior.Editable = t;
            spThanhTien.Enabled = t;
            spTongTL.Enabled = t;
            lkLoaiGiaoDich.Enabled = t;

        }
        //Ẩn hiện các button
        void visibility(bool v)
        {
            btnThem.Enabled = v;
            btnSua.Enabled = v;
            btnXoa.Enabled = v;
            btnLuu.Enabled = !v;
            btnHuy.Enabled = !v;
            btnIn.Enabled = v;
            txtGhiChu.Enabled = !v;
            //txtMaDoiTac.Enabled = !v;
            //txtDiaChi.Enabled = !v;
            //txtDienThoai.Enabled = !v;
            spThanhTien.Enabled = !v; 
            spTongTL.Enabled= v;
            lkLoaiGiaoDich.Enabled = !v;


        }
        //Lấy danh sách Loại vàng
        void LoadLoaiVang()
        {
            SearchLookUpLoaiVang.DataSource = _loaivang.GetList();
            SearchLookUpLoaiVang.DisplayMember = "GoldName";
            SearchLookUpLoaiVang.ValueMember = "GoldCode";
            SearchLookUpLoaiVang.NullText = "Chọn loại vàng";
        }
        //Lấy danh sách Cửa hàng
        void loadCuaHang()
        {
            resCuaHang.DataSource = _cuaHang.GetList();
            resCuaHang.DisplayMember = "ShopName";
            resCuaHang.ValueMember = "Id";
            lkCuaHang.EditValue = _cuaHang.GetList().First().Id;
        }
        //Lấy danh sách Đối tác
        void loadDoiTac()
        {
            _doitac = new Bus_DoiTac();
            lkDoiTac.Properties.DataSource = _doitac.GetList();
            lkDoiTac.Properties.DisplayMember = "VendorName";
            lkDoiTac.Properties.ValueMember = "Id";
            lkDoiTac.EditValue = _doitac.GetList().First().Id;
        }
        //Lấy danh sách Loại giao dịch
        void loadLoaiGiaoDich()
        {
            lkLoaiGiaoDich.Properties.DataSource = _loaigiaodich.GetList();
            lkLoaiGiaoDich.Properties.DisplayMember = "TransactionName";
            lkLoaiGiaoDich.Properties.ValueMember = "Id";
            lkLoaiGiaoDich.EditValue = _loaigiaodich.GetList().First().Id;
        }
        //Load Data lên gridcontrol Danh sách
        public void loadData()
        {
            //_lstPhieuChotGia = _phieuchotgia.getList(1, Convert.ToDateTime(dtTuNgay.EditValue), Convert.ToDateTime(dtDenNgay.EditValue).AddDays(1), lkCuaHang.EditValue.ToString());
            _lstPhieuChotGia = _phieuchotgia.getList();
            _bdPhieuChotGia.DataSource = _lstPhieuChotGia;
            gcDanhSach.DataSource = _bdPhieuChotGia;
            xuatThongTin();
        }
        //Load Data lên Gridview Chi tiết
        public void loadChiTiet(Guid khoa)
        {
            _bdPhieuChotGiaCT.DataSource = _phieuchotgiact.getList(khoa);
            gcChiTiet.DataSource = _bdPhieuChotGiaCT;
        }
        void _reset()
        {
            cboTrangThai.SelectedIndex = 0;
            txtSoPhieu.Text = "";
            txtGhiChu.Text = "";            
            dtNgayChungTu.Value = DateTime.Now;
            spThanhTien.EditValue = 0;
            spTongTL.EditValue = 0;
        }
        void _showControl()
        {
            tabChiTiet.PageEnabled = false;
            tabMain.SelectedTabPage = tabDanhSach;
            tabDanhSach.PageEnabled = true;
        }
        void _hideControl()
        {
            tabChiTiet.PageEnabled = true;
            tabMain.SelectedTabPage = tabChiTiet;
            tabDanhSach.PageEnabled = false;
        }
        bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }
        //Load thông tin Đối tác lên form
        private void LkDoiTac_EditValueChanged(object sender, EventArgs e)
        {
            //var dt = _doitac.GetById(lkDoiTac.EditValue.ToString());
            //txtMaDoiTac.Text = dt.Id;
            //txtDiaChi.Text = dt.Address;
            //txtDienThoai.Text = dt.Phone;
        }

        private void DtDenNgay_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtTuNgay.EditValue) > Convert.ToDateTime(dtDenNgay.EditValue))
            {
                XtraMessageBox.Show("Ngày được chọn không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            loadData();

        }

        private void DtTuNgay_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtTuNgay.EditValue) > Convert.ToDateTime(dtDenNgay.EditValue))
            {
                XtraMessageBox.Show("Ngày được chọn không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            loadData();
        }
        void ProvisionalOrder_Input(ProvisionalOrder po)
        {
            decimal _TONGCONG = 0;
            Shop ch = _cuaHang.GetById(lkCuaHang.EditValue.ToString());
            _seq = _sequence.getItem("CG@" + DateTime.Today.Year.ToString() + "@CH01");
            if (_seq == null)
            {
                _seq = new Sequence();
                _seq.Seqname = "CG@" + DateTime.Today.Year.ToString() + "@CH01";
                _seq.Seqvalue = 1;
                _sequence.add(_seq);
            }
            if (_them)
            {
                po.POId = Guid.NewGuid();
                po.PODate = dtNgayChungTu.Value;
                po.PONumber = DateTime.Today.Year.ToString().Substring(2, 2) + @"/CG/CH01";//_seq.Seqvalue.Value.ToString("000000") + @"/" + DateTime.Today.Year.ToString().Substring(2, 2) + @"/CG/CH01";
                po.CreatedBy = 1; //Library.user.UserId;
                po.CreatedDate = DateTime.Now;
            }
            po.TransactionTypeId = int.Parse(lkLoaiGiaoDich.EditValue.ToString());
            po.Status = int.Parse(cboTrangThai.SelectedValue.ToString());
            po.PODate = dtNgayChungTu.Value;
            po.PONumber = txtSoPhieu.Text;
            po.ShopId = lkCuaHang.EditValue.ToString();
            po.Notes = txtGhiChu.Text;


            po.TotalWeight = decimal.Parse(gvChiTiet.Columns["TotalGoldWeight"].SummaryItem.SummaryValue.ToString());
            po.TotalAmount = decimal.Parse(gvChiTiet.Columns["Amount"].SummaryItem.SummaryValue.ToString());

            po.CreatedBy = 1; //Library.user.UserId;
            po.CreatedDate = DateTime.Now;

            for (int i = 0; i < gvChiTiet.RowCount; i++)
            {
                if (gvChiTiet.GetRowCellValue(i, "GoldCode") == null)
                {
                    gvChiTiet.DeleteRow(i);
                    goto NEXT;
                }
                else
                {
                    _TONGCONG += decimal.Parse(gvChiTiet.GetRowCellValue(i, gvChiTiet.Columns["Amount"]).ToString());
                }
            }
        NEXT:
            po.TotalAmount = _TONGCONG;
            po.ModifiedBy = 1;
            po.ModifiedDate = DateTime.Now;
        }
        void ProvisionalOrderDetail_Input(ProvisionalOrder chungtu)
        {
            _phieuchotgiact.deleteAll(chungtu.POId);
            for (int i = 0; i < gvChiTiet.RowCount - 1; i++)
            {
                ProvisionalOrderDetail _ct = new ProvisionalOrderDetail();
                _ct.PODetailId = Guid.NewGuid();
                _ct.ProvisionalOrderId = chungtu.POId;
                _ct.LineNumber = i + 1; //int.Parse(gvChiTiet.GetRowCellValue(i, "STT").ToString());

                _ct.GoldCode = gvChiTiet.GetRowCellValue(i, "GoldCode").ToString();
                _ct.TotalGoldWeight = decimal.Parse(gvChiTiet.GetRowCellValue(i, "TotalGoldWeight").ToString());
                _ct.Price = int.Parse(gvChiTiet.GetRowCellValue(i, "Price").ToString());
                _ct.GoldAge = decimal.Parse(gvChiTiet.GetRowCellValue(i, "GoldAge").ToString());
                _ct.Amount = decimal.Parse(gvChiTiet.GetRowCellValue(i, "Amount").ToString());

                _phieuchotgiact.add(_ct);
            }
        }
        //Lưu data xuống DB
        private void SaveData()
        {

            ProvisionalOrder po;

            if (_them)
            {
                po = new ProvisionalOrder();
                ProvisionalOrder_Input(po);
                _ctu = _phieuchotgia.add(po);
                _sequence.update(_seq);
                txtSoPhieu.Text = _ctu.PONumber;
                ProvisionalOrderDetail_Input(_ctu);

                _bdPhieuChotGia.Add(_ctu);
                _bdPhieuChotGia.MoveLast();
            }
            else
            {
                po = (ProvisionalOrder)_bdPhieuChotGia.Current;
                po = _phieuchotgia.getItem(po.POId);
                ProvisionalOrder_Input(po);
                _ctu = _phieuchotgia.update(po);
                ProvisionalOrderDetail_Input(_ctu);

                _lstPhieuChotGia = null;
                //_lstPhieuChotGia = _phieuchotgia.getList(1, Convert.ToDateTime(dtTuNgay.EditValue), Convert.ToDateTime(dtDenNgay.EditValue).AddDays(1), lkCuaHang.EditValue.ToString());
                _lstPhieuChotGia = _phieuchotgia.getList();
                _bdPhieuChotGia.DataSource = _lstPhieuChotGia;
                gvDanhSach.ClearSorting();
                gvDanhSach.RefreshData();
                var obj = _bdPhieuChotGia.List.OfType<ProvisionalOrder>().ToList().Find(c => c.POId == _ctu.POId);
                _bdPhieuChotGia.Position = _bdPhieuChotGia.IndexOf(obj);
            }
            //Bus_TonKho _tonkho = new Bus_TonKho();
            //var tk = _tonkho.TinhTon(lkDonVi.EditValue.ToString(), DateTime.Now);
            xuatThongTin();
            _them = false;

        }
        void xuatThongTin()
        {
            //_bdPhieuChotGia = null;
            ProvisionalOrder current = (ProvisionalOrder)_bdPhieuChotGia.Current;
            if (current != null)
            {
                poId = current.POId;
                dtNgayChungTu.Value = current.PODate.Value;
                txtSoPhieu.Text = current.PONumber;
                dtNgayChungTu.Value = current.PODate.Value;
                spThanhTien.EditValue = current.TotalAmount;
                txtGhiChu.Text = current.Notes;
                cboTrangThai.SelectedValue = current.Status;
                lkDoiTac.EditValue = current.VendorId;
                _bdPhieuChotGiaCT.DataSource = _phieuchotgiact.getList(current.POId);
                gcChiTiet.DataSource = _bdPhieuChotGiaCT;
                _ctu = current;
                for (int i = 0; i < gvChiTiet.RowCount; i++)
                {
                    gvChiTiet.SetRowCellValue(i, "LineNumber", i + 1);
                }

            }
        }
        private void gvChiTiet_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //Chọn loại vàng
            if (e.Column.FieldName == "GoldCode")
            {
                var ma = gvChiTiet.GetFocusedRowCellValue("GoldCode").ToString();
                if (ma != null)
                {
                    var lv = _loaivang.GetById(ma);
                    gvChiTiet.SetFocusedRowCellValue("GoldAge", lv.GoldAge);
                    //gvChiTiet.SetFocusedRowCellValue("TotalGoldWeight", 0);
                    //gvChiTiet.SetFocusedRowCellValue("Price", 0);
                    
                    //gvChiTiet.SetFocusedRowCellValue("SoLuong", 1);
                    //gvChiTiet.SetFocusedRowCellValue("ThanhTien", hh.GiaNhap);
                    //var bd = _bdPhieuChotGiaCT.List.OfType<ProvisionalOrderDetail>().ToList().Find(x => x.GoldCode == ma);
                    //_bdPhieuChotGiaCT.Add(bd);
                }

            }
            // Nhập tổng trọng lượng tính thành tiền
            if (e.Column.FieldName == "TotalGoldWeight")
            {
                double _tongTL = double.Parse(e.Value.ToString());
                if (gvChiTiet.GetRowCellValue(gvChiTiet.FocusedRowHandle, "TotalGoldWeight") != null)
                {
                    double _dongia = double.Parse(gvChiTiet.GetRowCellValue(gvChiTiet.FocusedRowHandle, "Price").ToString());
                    var _thanhtien = _dongia * _tongTL;
                    gvChiTiet.SetFocusedRowCellValue("Amount", _thanhtien);

                    gvChiTiet.UpdateTotalSummary();
                    //var ii = gvChiTiet.GetFocusedRowCellValue("GoldCode").ToString();

                }
                else
                {
                    return;
                }
                gvChiTiet.RefreshData();
            }
            //Nhập đơn giá tính thành tiền
            if (e.Column.FieldName == "Price")
            {
                double _dongia = double.Parse(e.Value.ToString());
                if (gvChiTiet.GetRowCellValue(gvChiTiet.FocusedRowHandle, "Price") != null)
                {
                    double _tongTL = double.Parse(gvChiTiet.GetRowCellValue(gvChiTiet.FocusedRowHandle, "TotalGoldWeight").ToString());
                    var _thanhtien = _dongia * _tongTL;
                    gvChiTiet.SetFocusedRowCellValue("Amount", _thanhtien);

                    gvChiTiet.UpdateTotalSummary();
                    //var ii = gvChiTiet.GetFocusedRowCellValue("GoldCode").ToString();

                }
                else
                {
                    return;
                }
                gvChiTiet.RefreshData();
            }
        }

        private void gvChiTiet_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gvChiTiet.FocusedColumn.FieldName == "TotalGoldWeight")
            {
                double totalweight = 0;
                if (!Double.TryParse(e.Value as String, out totalweight))
                {
                    e.Valid = false;
                    e.ErrorText = "Chỉ được nhập số.";
                }
                else if (totalweight < 0)
                {
                    e.Valid = false;
                    e.ErrorText = "Tổng trọng lượng không được nhỏ hơn 0.";
                }

            }
            if (gvChiTiet.FocusedColumn.FieldName == "Price")
            {
                double price = 0;
                if (!Double.TryParse(e.Value as String, out price))
                {
                    e.Valid = false;
                    e.ErrorText = "Chỉ được nhập số.";
                }
                else if (price < 0)
                {
                    e.Valid = false;
                    e.ErrorText = "Đơn giá không được nhỏ hơn 0.";
                }

            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            loadChiTiet(new Guid());
            tabChiTiet.PageEnabled = true;
            tabMain.SelectedTabPage = tabChiTiet;
            tabDanhSach.PageEnabled = false;
            _hideControl();
            visibility(false);
            _reset();
            _enable(true);
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            ProvisionalOrder current = (ProvisionalOrder)_bdPhieuChotGia.Current;
            if (current == null)
            {
                XtraMessageBox.Show("Chưa chọn phiếu cần chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (current.Status == 2)
            {
                XtraMessageBox.Show("Phiếu đã hoàn tất không được chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            tabChiTiet.PageEnabled = true;
            tabMain.SelectedTabPage = tabChiTiet;
            tabDanhSach.PageEnabled = false;
            _hideControl();
            visibility(false);
            _enable(true);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (poId == null)
                {
                    XtraMessageBox.Show("Bạn chưa chọn phiếu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                _phieuchotgia.delete(poId, 1);
                var ct = _phieuchotgia.getItem(poId);
               
            }
            loadData();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lkDoiTac.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn Đối tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc chắn lưu dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SaveData();
                XtraMessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _them = false;
                visibility(true);
                loadData();
                _enable(false);
                _showControl();
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            //xuatThongTin();
            _showControl();
            _them = false;
            visibility(true);
            tabChiTiet.PageEnabled = false;
            tabDanhSach.PageEnabled = true;
            tabMain.SelectedTabPage = tabDanhSach;
            _enable(false);
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            tabChiTiet.PageEnabled = true;
            tabDanhSach.PageEnabled = true;
            tabMain.SelectedTabPage = tabChiTiet;
            _enable(false);
        }

        private void gvChiTiet_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvChiTiet.IsGroupRow(e.RowHandle))
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
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvChiTiet); }));
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1));
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvChiTiet); }));
            }
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

        private void gvChiTiet_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var ma = gvChiTiet.GetFocusedRowCellValue("GoldCode");
            if (ma != null)
            {
                var bd = _bdPhieuChotGiaCT.List.OfType<ProvisionalOrderDetail>().Where(y => y.GoldCode == ma.ToString()).ToList().Count();
                if (bd > 1)
                {
                    _bdPhieuChotGiaCT.RemoveCurrent();
                    var bdct = _bdPhieuChotGiaCT.List.OfType<ProvisionalOrderDetail>().ToList().Find(x => x.GoldCode == ma.ToString());
                    bdct.TotalGoldWeight += decimal.Parse(gvChiTiet.GetFocusedRowCellValue("TotalGoldWeight").ToString());
                    bdct.Amount = Convert.ToDecimal(bdct.TotalGoldWeight) * bdct.Price;

                }

            }

            gvChiTiet.ClearSorting();
            gvChiTiet.RefreshData();

            spThanhTien.EditValue = _bdPhieuChotGiaCT.List.OfType<ProvisionalOrderDetail>().ToList().Sum(x => x.Amount);
            spTongTL.EditValue = _bdPhieuChotGiaCT.List.OfType<ProvisionalOrderDetail>().ToList().Sum(x => x.TotalGoldWeight);
        }

        private void btnHoanTat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}