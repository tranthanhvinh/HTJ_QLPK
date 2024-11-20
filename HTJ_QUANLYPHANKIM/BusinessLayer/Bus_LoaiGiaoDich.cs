using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Bus_LoaiGiaoDich
    {
        QLPKEntities db = new QLPKEntities();
        public TransactionType GetById(int Id)
        {
            return db.TransactionTypes.FirstOrDefault(x => x.Id == Id);
        }
        public List<TransactionType> GetList()
        {
            return db.TransactionTypes.ToList();
        }       
    }
}
