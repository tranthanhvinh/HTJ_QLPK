using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Bus_User
    {
        QLPKEntities db = null;
        public Bus_User()
        {
            db = new QLPKEntities();
        }
        public User GetById(int id)
        {
            return db.Users.FirstOrDefault(x => x.UserId == id);
        }
        public User Login(string username, string password)
        {
            return db.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
        }
        public List<User> GetList()
        {
            return db.Users.OrderByDescending(x => x.IsGroup).ThenBy(x => x.Username).ToList();
        }
        public bool CheckUsername(string username, string madonvi)
        {
            var check = db.Users.FirstOrDefault(x => x.Username == username && x.ShopId == madonvi);
            if (check != null)
                return true;
            else
                return false;
        }
        public User Add(User user)
        {
            try
            {
                db.Users.Add(user);
                db.SaveChanges();
                return user;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public User Update(User user)
        {
            try
            {
                var _user = GetById(user.UserId);
                _user.Fullname = user.Fullname;
                _user.Password = user.Password;
                _user.Status = user.Status;
                _user.DateModified = user.DateModified;
                db.SaveChanges();
                return user;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(int userId)
        {
            try
            {
                var _user = GetById(userId);
                _user.Status = false;
                _user.DateModified = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        //public List<View_User_In_Group> GetUserInGroup(string madvi, int groupId)
        //{
        //    return db.View_User_In_Group.AsNoTracking().Where(x => x.MaDonVi == madvi && x.GroupId == groupId && x.IsGroup == false && x.Status == true).ToList();
        //}
        //public List<View_User_Not_In_Group> GetUserNotInGroup(string madonvi)
        //{
        //    return db.View_User_Not_In_Group.Where(x => x.MaDonVi == madonvi && x.IsGroup == false && x.Status == true).ToList();
        //}
    }
}
