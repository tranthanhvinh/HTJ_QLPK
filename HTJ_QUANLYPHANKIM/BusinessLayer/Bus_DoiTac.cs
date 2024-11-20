using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class Bus_DoiTac
    {
        QLPKEntities db = new QLPKEntities();
        public Vendor GetById(string Id)
        {
            return db.Vendors.FirstOrDefault(x => x.Id == Id);
        }
        public List<Vendor> GetList()
        {
            return db.Vendors.ToList();
        }
        public Vendor Add(Vendor dt)
        {
            try
            {
                db.Vendors.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public Vendor Update(Vendor dt)
        {
            try
            {
                var _dt = GetById(dt.Id);
                _dt.VendorName = dt.VendorName;
                _dt.Phone = dt.Phone;
                _dt.Email = dt.Email;
                _dt.TaxCode = dt.TaxCode;
                _dt.Status = dt.Status;
                _dt.Address = dt.Address;
                _dt.Notes = dt.Notes;
                _dt.VendorGroupId = dt.VendorGroupId;
                _dt.CreatedBy = dt.CreatedBy;
                _dt.UpdatedBy = dt.UpdatedBy;
                _dt.DateModified = dt.DateModified;
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
