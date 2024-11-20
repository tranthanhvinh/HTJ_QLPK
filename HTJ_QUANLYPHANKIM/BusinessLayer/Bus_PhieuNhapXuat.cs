using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Bus_PhieuNhapXuat
    {
        QLPKEntities db = null;
        public Bus_PhieuNhapXuat()
        {
            db = new QLPKEntities();
        }
        public InventoryTransaction getItem(Guid pnxId)
        {
            return db.InventoryTransactions.FirstOrDefault(x => x.TransactionId == pnxId);
        }
        public InventoryTransaction getItemBySCT(string sct)
        {
            return db.InventoryTransactions.FirstOrDefault(x => x.DocumentNumber == sct);
        }
        public List<InventoryTransaction> getList()
        {
            return db.InventoryTransactions.ToList();
        }
        public List<InventoryTransaction> getList(int loai, DateTime tuNgay, DateTime denNgay, string maCuaHang)
        {
            return db.InventoryTransactions.Where(x => x.ShopId == maCuaHang && x.TransactionDate >= tuNgay && x.TransactionDate < denNgay && x.TransactionTypeId == loai).OrderBy(x => x.DocumentNumber).ToList();
        }
        //public List<InventoryTransaction> getListDeleted(int loai, DateTime tuNgay, DateTime denNgay, string maCuaHang)
        //{
        //    return db.InventoryTransactions.Where(x => x.ShopId == maCuaHang && x.TransactionDate >= tuNgay && x.TransactionDate < denNgay && x.TransactionTypeId == loai && x.DeletedBy != null).OrderBy(x => x.DocumentNumber).ToList();

        //}
        //public List<InventoryTransaction> getListByDonViNhap(int lct, DateTime tungay, DateTime denngay, string MADONVI)
        //{
        //    return db.InventoryTransactions.Where(x => x.MaDonVi2 == MADONVI && x.Ngay >= tungay && x.Ngay < denngay && x.Lct == lct).OrderBy(x => x.Sct).ToList();
        //}

        public InventoryTransaction add(InventoryTransaction phieuNhapXuat)
        {
            try
            {
                db.InventoryTransactions.Add(phieuNhapXuat);
                db.SaveChanges();
                return phieuNhapXuat;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public InventoryTransaction update(InventoryTransaction phieuNhapXuat)
        {
            var pnx = db.InventoryTransactions.FirstOrDefault(x => x.TransactionId == phieuNhapXuat.TransactionId);
            pnx.TransactionDate = phieuNhapXuat.TransactionDate;
            pnx.DocumentNumber = phieuNhapXuat.DocumentNumber;
            pnx.TransactionTypeId = phieuNhapXuat.TransactionTypeId;
            pnx.VendorId = phieuNhapXuat.VendorId;
            pnx.EmployeeId = phieuNhapXuat.EmployeeId;
            pnx.Status = phieuNhapXuat.Status;
            pnx.ModifiedBy = phieuNhapXuat.ModifiedBy;
            pnx.DateModified = phieuNhapXuat.DateModified;            
            try
            {
                db.SaveChanges();
                return pnx;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public InventoryTransaction delete(Guid pnxId, int uId)
        {
            var pnx = db.InventoryTransactions.FirstOrDefault(x => x.TransactionId == pnxId);
            pnx.DeletedBy = uId;
            pnx.DateDeleted = DateTime.Now;
            try
            {
                db.SaveChanges();
                return pnx;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
