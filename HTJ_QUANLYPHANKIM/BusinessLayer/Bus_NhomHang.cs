using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Bus_NhomHang
    {
        QLKHOEntities db = new QLKHOEntities();
        public ProductCategory GetById(string Id)
        {
            return db.ProductCategories.FirstOrDefault(x => x.Id == Id);
        }
        public List<ProductCategory> GetList()
        {
            return db.ProductCategories.ToList();
        }
        public ProductCategory Add(ProductCategory pc)
        {
            try
            {
                db.ProductCategories.Add(pc);
                db.SaveChanges();
                return pc;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public ProductCategory Update(ProductCategory pc)
        {
            try
            {
                var _pc = GetById(pc.Id);
                _pc.GroupName = pc.GroupName;
                _pc.Status = pc.Status;
                db.SaveChanges();
                return pc;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
