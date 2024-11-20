using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Bus_Permission
    {
        QLPKEntities db = null;
        public Bus_Permission()
        {
            db = new QLPKEntities();
        }

        public Permission GetById(int userId, string permissionId)
        {
            return db.Permissions.FirstOrDefault(x => x.PermissionId == permissionId && x.UserId == userId);
        }
        public List<Permission> GetPermissionByUserId(int userId)
        {
            return db.Permissions.Where(x => x.UserId == userId).ToList();
        }
        public Permission Add(Permission permission)
        {
            try
            {
                db.Permissions.Add(permission);
                db.SaveChanges();
                return permission;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public Permission Update(Permission permission)
        {
            try
            {
                var pm = db.Permissions.FirstOrDefault(x => x.PermissionId == permission.PermissionId && x.UserId == permission.UserId);
                pm.View = permission.View;
                pm.Add = permission.Add;
                pm.Edit = permission.Edit;
                pm.Delete = permission.Delete;
                pm.Print = permission.Print;
                pm.Extract = permission.Extract;
                pm.ModifiedDate = permission.ModifiedDate;
                db.SaveChanges();
                return permission;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
