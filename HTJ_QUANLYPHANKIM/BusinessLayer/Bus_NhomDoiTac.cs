using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class Bus_NhomDoiTac
    {
        QLPKEntities db = new QLPKEntities();
        public VendorGroup GetById(int Id)
        {
            return db.VendorGroups.FirstOrDefault(x => x.Id == Id);
        }
        public List<VendorGroup> GetList()
        {
            return db.VendorGroups.ToList();
        }
        public VendorGroup Add(VendorGroup nh)
        {
            try
            {
                db.VendorGroups.Add(nh);
                db.SaveChanges();
                return nh;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public VendorGroup Update(VendorGroup nh)
        {
            try
            {
                var _nh = GetById(nh.Id);
                _nh.GroupName = nh.GroupName;
                db.SaveChanges();
                return nh;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);

            }
        }
    }
}
