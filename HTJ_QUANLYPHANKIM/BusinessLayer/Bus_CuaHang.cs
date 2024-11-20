using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class Bus_CuaHang
    {
        QLPKEntities db = new QLPKEntities();
        public Shop GetById(string Id)
        {
            return db.Shops.FirstOrDefault(x => x.ShopCode == Id);
        }
        public List<Shop> GetList()
        {
            return db.Shops.ToList();
        }
        public Shop Add(Shop shop)
        {
            try
            {
                db.Shops.Add(shop);
                db.SaveChanges();
                return shop;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public Shop Update(Shop shop)
        {
            try
            {
                var _shop = GetById(shop.ShopCode);
                _shop.ShopName = shop.ShopName;
                _shop.Status = shop.Status;
                db.SaveChanges();
                return shop;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
