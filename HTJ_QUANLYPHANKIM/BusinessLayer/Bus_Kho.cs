using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Bus_Kho
    {
        QLPKEntities db = new QLPKEntities();
        public Stock GetById(string Id)
        {
            return db.Stocks.FirstOrDefault(x => x.StockCode == Id);
        }
        public List<Stock> GetList()
        {
            return db.Stocks.ToList();
        }
        public Stock Add(Stock st)
        {
            try
            {
                db.Stocks.Add(st);
                db.SaveChanges();
                return st;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public Stock Update(Stock st)
        {
            try
            {
                var _st = GetById(st.StockCode);
                _st.StockName = st.StockName;
                _st.ShopId = st.ShopId;
                _st.Status = st.Status;         
                db.SaveChanges();
                return st;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
