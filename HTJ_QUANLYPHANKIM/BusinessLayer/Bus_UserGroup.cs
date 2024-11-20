using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Bus_UserGroup
    {
        QLPKEntities db = null;
        public Bus_UserGroup()
        {
            db = new QLPKEntities();
        }
        public GroupUser GetGroupByUser(int userId)
        {
            return db.GroupUsers.FirstOrDefault(x => x.UserId == userId);
        }
        public GroupUser Add(GroupUser gr)
        {
            try
            {
                db.GroupUsers.Add(gr);
                db.SaveChanges();
                return gr;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(GroupUser gr)
        {
            try
            {
                var _gr = db.GroupUsers.FirstOrDefault(x => x.GroupId == gr.GroupId && x.UserId == gr.UserId);
                db.GroupUsers.Remove(_gr);
                db.SaveChanges();

            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }


        //public List<User> GetGroupByUser(string madonvi, int userId)
        //{
        //    List<User> lstGroup = new List<User>();
        //    List<View_User_In_Group> lst = db.View_User_In_Group.Where(x => x.UserId == userId && x.MaDonVi == madonvi).ToList();
        //    User u;
        //    foreach (var item in lst)
        //    {
        //        u = new User();
        //        u = db.Users.FirstOrDefault(x => x.UserId == item.GroupId);
        //        lstGroup.Add(u);
        //    }
        //    return lstGroup.Distinct().ToList();
        //}
        public List<User> GetGroupByDonVi(string madonvi)
        {
            return db.Users.Where(x => x.ShopId == madonvi && x.IsGroup == true).ToList();
        }
        public bool CheckGroupByUser(int userId, int groupId)
        {
            var gr = db.GroupUsers.FirstOrDefault(x => x.UserId == userId && x.GroupId == groupId);
            if (gr == null)
                return false;
            else
                return true;

        }
    }
}
