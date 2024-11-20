using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Bus_PhieuNhapXuatCT
    {
        QLPKEntities db = null;
        public Bus_PhieuNhapXuatCT()
        {
            db = new QLPKEntities();
        }
        public InventoryTransactionDetail getItem(Guid khoact)
        {
            return db.InventoryTransactionDetails.FirstOrDefault(x => x.TransactionDetailId == khoact);
        }

        public List<InventoryTransactionDetail> getList(Guid khoa)
        {
            return db.InventoryTransactionDetails.Where(x => x.TransactionDetailId == khoa).OrderBy(x => x.LineNumber).ToList();
        }

        //public List<ChungTuCTDTO> getListBySCT(int lct, string sct)
        //{
        //    var ctu = db.ChungTus.FirstOrDefault(x => x.Sct == sct && x.Lct == lct);
        //    List<ChungTu_CT> lst = new List<ChungTu_CT>();
        //    if (ctu != null)
        //    {
        //        lst = db.ChungTu_CT.Where(x => x.Khoa == ctu.Khoa).ToList();
        //    }
        //    List<ChungTuCTDTO> lsCT = new List<ChungTuCTDTO>();
        //    ChungTuCTDTO obj;
        //    foreach (var item in lst)
        //    {
        //        obj = new ChungTuCTDTO();
        //        obj.Khoa = item.Khoa;
        //        obj.KhoaCT = item.KhoaCT;
        //        obj.MaHang = item.MaHang;
        //        var h = db.HangHoas.FirstOrDefault(x => x.MaHang == item.MaHang);
        //        obj.TenHang = h.TenHang;
        //        obj.SoLuong = item.SoLuong;
        //        obj.DonGia = item.DonGia;
        //        obj.ThanhTien = item.ThanhTien;
        //        obj.TinhTrang = item.TinhTrang;
        //        obj.Ngay = item.Ngay;
        //        obj.SoTon = item.SoTon;
        //        obj.SoLuongChenhLech = item.SoLuongChenhLech;
        //        obj.ThanhTienChenhLech = item.ThanhTienChenhLech;
        //        obj.MaDVT = h.MaDVT;
        //        var dvt = db.DonViTinhs.FirstOrDefault(x => x.MaDVT == item.MaDVT);
        //        obj.TenDVT = dvt.TenDVT;
        //        obj.Stt = item.Stt;
        //        obj.GhiChu = item.GhiChu;
        //        lsCT.Add(obj);
        //    }
        //    return lsCT;

        //}
        //public List<ChungTuCTDTO> getListByKhoaFull(Guid khoa)
        //{
        //    var lst = db.ChungTu_CT.Where(x => x.Khoa == khoa).ToList();
        //    List<ChungTuCTDTO> lsCT = new List<ChungTuCTDTO>();
        //    ChungTuCTDTO obj;
        //    foreach (var item in lst)
        //    {
        //        obj = new ChungTuCTDTO();
        //        obj.Khoa = item.Khoa;
        //        obj.KhoaCT = item.KhoaCT;
        //        obj.MaHang = item.MaHang;
        //        var h = db.HangHoas.FirstOrDefault(x => x.MaHang == item.MaHang);
        //        obj.TenHang = h.TenHang;
        //        obj.SoLuong = item.SoLuong;
        //        obj.DonGia = item.DonGia;
        //        obj.ThanhTien = item.ThanhTien;
        //        obj.TinhTrang = item.TinhTrang;
        //        obj.Ngay = item.Ngay;
        //        obj.SoTon = item.SoTon;
        //        obj.SoLuongChenhLech = item.SoLuongChenhLech;
        //        obj.ThanhTienChenhLech = item.ThanhTienChenhLech;
        //        obj.MaDVT = h.MaDVT;
        //        var dvt = db.DonViTinhs.FirstOrDefault(x => x.MaDVT == item.MaDVT);
        //        obj.TenDVT = dvt.TenDVT;
        //        obj.Stt = item.Stt;
        //        obj.GhiChu = item.GhiChu;
        //        lsCT.Add(obj);

        //    }
        //    return lsCT.OrderBy(x => x.Stt).ToList();
        //}
        public InventoryTransactionDetail add(InventoryTransactionDetail ChungTu_CT)
        {
            try
            {
                db.InventoryTransactionDetails.Add(ChungTu_CT);
                db.SaveChanges();
                return ChungTu_CT;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public InventoryTransactionDetail update(InventoryTransactionDetail chungtuct)
        {
            var ct = db.InventoryTransactionDetails.FirstOrDefault(x => x.TransactionDetailId == chungtuct.TransactionDetailId);
            ct.GoldCode = chungtuct.GoldCode;
            ct.Quantity = chungtuct.Quantity;
            ct.UnitCode = chungtuct.UnitCode;
            ct.Notes = chungtuct.Notes;
            ct.ProductCategoryId = chungtuct.ProductCategoryId;           
            try
            {
                db.SaveChanges();
                return ct;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void deleteAll(Guid khoa)
        {
            List<InventoryTransactionDetail> lst = db.InventoryTransactionDetails.Where(x => x.TransactionDetailId == khoa).ToList();

            try
            {
                db.InventoryTransactionDetails.RemoveRange(lst);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
