using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Bus_QuayThuNgan
    {
        QLPKEntities db = new QLPKEntities();
        public CashierCounter GetById(string Id)
        {
            return db.CashierCounters.FirstOrDefault(x => x.CounterCode == Id);
        }
        public List<CashierCounter> GetList()
        {
            return db.CashierCounters.ToList();
        }
        public CashierCounter Add(CashierCounter ct)
        {
            try
            {
                db.CashierCounters.Add(ct);
                db.SaveChanges();
                return ct;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public CashierCounter Update(CashierCounter ct)
        {
            try
            {
                var _ct = GetById(ct.CounterCode);
                _ct.CounterName = ct.CounterName;
                _ct.ShopId = ct.ShopId;
                _ct.Status = ct.Status;
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
