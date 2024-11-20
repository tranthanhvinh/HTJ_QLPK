using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer.DTO;

namespace BusinessLayer
{
    public class Bus_PhieuChotGiaCT
    {
        QLPKEntities db = null;
        public Bus_PhieuChotGiaCT()
        {
            db = new QLPKEntities();
        }
        public ProvisionalOrderDetail getItem(Guid khoact)
        {
            return db.ProvisionalOrderDetails.FirstOrDefault(x => x.PODetailId == khoact);
        }

        public List<ProvisionalOrderDetail> getList(Guid khoa)
        {
            return db.ProvisionalOrderDetails.Where(x => x.ProvisionalOrderId == khoa).OrderBy(x => x.LineNumber).ToList();
        }

        public List<ProvisionalOrderDetailDTO> getListBySCT(int lct, Guid sct)
        {
            var ctu = db.ProvisionalOrders.FirstOrDefault(x => x.POId == sct && x.TransactionTypeId == lct);
            List<ProvisionalOrderDetail> lst = new List<ProvisionalOrderDetail>();
            if (ctu != null)
            {
                lst = db.ProvisionalOrderDetails.Where(x => x.ProvisionalOrderId == ctu.POId).ToList();
            }
            List<ProvisionalOrderDetailDTO> lsCT = new List<ProvisionalOrderDetailDTO>();
            ProvisionalOrderDetailDTO obj;
            foreach (var item in lst)
            {
                obj = new ProvisionalOrderDetailDTO();
                obj.ProvisionalOrderId = item.ProvisionalOrderId;
                obj.PODetailId = item.PODetailId;
                obj.GoldCode = item.GoldCode;
                var h = db.Golds.FirstOrDefault(x => x.GoldCode == item.GoldCode);
                obj.GoldName = h.GoldName;
                obj.TotalGoldWeight = item.TotalGoldWeight;
                obj.Price = item.Price;
                obj.Amount = item.Amount;
                obj.LineNumber = item.LineNumber;
                
                lsCT.Add(obj);
            }
            return lsCT;

        }
        public List<ProvisionalOrderDetailDTO> getListByKhoaFull(Guid khoa)
        {
            var lst = db.ProvisionalOrderDetails.Where(x => x.ProvisionalOrderId == khoa).ToList();
            List<ProvisionalOrderDetailDTO> lsCT = new List<ProvisionalOrderDetailDTO>();
            ProvisionalOrderDetailDTO obj;
            foreach (var item in lst)
            {
                obj = new ProvisionalOrderDetailDTO();
                obj.ProvisionalOrderId = item.ProvisionalOrderId;
                obj.PODetailId = item.PODetailId;
                obj.GoldCode = item.GoldCode;
                var h = db.Golds.FirstOrDefault(x => x.GoldCode == item.GoldCode);
                obj.GoldName = h.GoldName;
                obj.TotalGoldWeight = item.TotalGoldWeight;
                obj.Price = item.Price;
                obj.Amount = item.Amount;
                obj.LineNumber = item.LineNumber;

                lsCT.Add(obj);

            }
            return lsCT.OrderBy(x => x.LineNumber).ToList();
        }
        public ProvisionalOrderDetail add(ProvisionalOrderDetail phieuchotgiact)
        {
            try
            {
                db.ProvisionalOrderDetails.Add(phieuchotgiact);
                db.SaveChanges();
                return phieuchotgiact;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public ProvisionalOrderDetail update(ProvisionalOrderDetail phieuchotgiact)
        {
            var ct = db.ProvisionalOrderDetails.FirstOrDefault(x => x.PODetailId == phieuchotgiact.PODetailId);
            ct.GoldCode = phieuchotgiact.GoldCode;
            ct.TotalGoldWeight = phieuchotgiact.TotalGoldWeight;
            ct.Price = phieuchotgiact.Price;
            ct.Amount = phieuchotgiact.Amount;           
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
            List<ProvisionalOrderDetail> lst = db.ProvisionalOrderDetails.Where(x => x.ProvisionalOrderId == khoa).ToList();

            try
            {
                db.ProvisionalOrderDetails.RemoveRange(lst);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
