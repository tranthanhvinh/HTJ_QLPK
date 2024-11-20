using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Bus_Shop
    {
        QLPKEntities db = new QLPKEntities();
        public Shop GetById(string Id)
        {
            return db.Shops.FirstOrDefault(x => x.Id == Id);
        }
        public List<Shop> GetList()
        {
            return db.Shops.ToList();
        }       
    }
}
