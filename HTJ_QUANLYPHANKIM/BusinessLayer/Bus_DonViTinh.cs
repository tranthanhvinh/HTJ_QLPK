using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Bus_DonViTinh
    {
        QLPKEntities db = new QLPKEntities();
        public Unit GetById(string Id)
        {
            return db.Units.FirstOrDefault(x => x.UnitCode == Id);
        }
        public List<Unit> GetList()
        {
            return db.Units.ToList();
        }
        public Unit Add(Unit dvt)
        {
            try
            {
                db.Units.Add(dvt);
                db.SaveChanges();
                return dvt;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public Unit Update(Unit dvt)
        {
            try
            {
                var _dvt = GetById(dvt.UnitCode);
                _dvt.UnitName = dvt.UnitName;
                _dvt.Status = dvt.Status;
                db.SaveChanges();
                return dvt;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
