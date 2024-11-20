using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Bus_LoaiVang
    {
        QLPKEntities db = null;
        public Bus_LoaiVang()
        {
            db = new QLPKEntities();
        }
        public List<Gold> GetList()
        {
            return db.Golds.ToList();
        }
        public Gold getItem(string goldCode)
        {
            return db.Golds.FirstOrDefault(x => x.GoldCode == goldCode);
        }
        public Gold GetById(string goldCode)
        {
            return db.Golds.FirstOrDefault(x => x.GoldCode == goldCode);
        }

        public Gold add(Gold gold)
        {
            try
            {
                db.Golds.Add(gold);
                db.SaveChanges();
                return gold;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public Gold update(Gold gold)
        {
            var seq = db.Golds.FirstOrDefault(x => x.GoldCode == gold.GoldCode);
            seq.GoldName = gold.GoldName;
            seq.GoldCode = gold.GoldCode;
            seq.GoldAge = gold.GoldAge;
            seq.Status = gold.Status;
            try
            {
                db.SaveChanges();
                return gold;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

    }
}
