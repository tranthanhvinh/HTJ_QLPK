using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class Bus_PhieuChotGia
    {
        QLPKEntities db = null;
        public Bus_PhieuChotGia()
        {
            db = new QLPKEntities();
        }
        public ProvisionalOrder getItem(Guid khoa)
        {
            return db.ProvisionalOrders.FirstOrDefault(x => x.POId == khoa);
        }
        public ProvisionalOrder getItemBySCT(Guid sct)
        {
            return db.ProvisionalOrders.FirstOrDefault(x => x.POId == sct);
        }
        public List<ProvisionalOrder> getList()
        {
            return db.ProvisionalOrders.ToList();
        }
        public List<ProvisionalOrder> getList(int lct, DateTime tungay, DateTime denngay, string MADONVI)
        {
            return db.ProvisionalOrders.Where(x => x.ShopId == MADONVI && x.PODate >= tungay && x.PODate < denngay && x.TransactionTypeId == lct).OrderBy(x => x.POId).ToList();
        }
        public List<ProvisionalOrder> getListDeleted(int lct, DateTime tungay, DateTime denngay, string MADONVI)
        {
            return db.ProvisionalOrders.Where(x => x.ShopId == MADONVI && x.PODate >= tungay && x.PODate < denngay && x.TransactionTypeId == lct && x.DeletedBy != null).OrderBy(x => x.POId).ToList();

        }
        public List<ProvisionalOrder> getListByDonViNhap(int lct, DateTime tungay, DateTime denngay, string MADONVI)
        {
            return db.ProvisionalOrders.Where(x => x.ShopId == MADONVI && x.PODate >= tungay && x.PODate < denngay && x.TransactionTypeId == lct).OrderBy(x => x.POId).ToList();
        }

        public ProvisionalOrder add(ProvisionalOrder chungtu)
        {
            try
            {
                db.ProvisionalOrders.Add(chungtu);
                db.SaveChanges();
                return chungtu;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public ProvisionalOrder update(ProvisionalOrder chungtu)
        {
            var ct = db.ProvisionalOrders.FirstOrDefault(x => x.POId == chungtu.POId);
            ct.TransactionTypeId = chungtu.TransactionTypeId;
            ct.TotalWeight = chungtu.TotalWeight;            
            ct.TotalAmount = chungtu.TotalAmount;            
            ct.PODate = chungtu.PODate;
            ct.PONumber = chungtu.PONumber;           
            ct.Notes = ct.Notes;
            ct.Status = chungtu.Status;
            ct.ModifiedBy = chungtu.ModifiedBy;
            ct.ModifiedDate = chungtu.ModifiedDate;
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
        public ProvisionalOrder delete(Guid khoa, int uId)
        {
            var ct = db.ProvisionalOrders.FirstOrDefault(x => x.POId == khoa);
            ct.DeletedBy = 1;
            ct.DeletedDate = DateTime.Now;
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
    }
}
