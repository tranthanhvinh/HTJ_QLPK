using BusinessLayer;
using DataLayer;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHANKIM.Libs
{
    public class Library
    {
        public static IOverlaySplashScreenHandle handle = null;
        public static User user = null;

        //public static List<ChungTu_CT> lstChungTuCT = new List<ChungTu_CT>();
        //public static List<KIEMKE_CT> lstKiemKeCT = new List<tb_KIEMKE_CT>();
        public static Permission PhanQuyen(int userId, string permissionId)
        {
            Bus_Permission _phanquyen = new Bus_Permission();
            return _phanquyen.GetById(userId, permissionId);
        }
        /// <summary>
        /// Kiểm tra quyền được truy cập
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="permissionId"></param>
        /// <returns></returns>
        public static bool ActionView(int userId, string permissionId)
        {
            Permission groupPermission;
            Permission userPermission;
            Bus_UserGroup _nhomnguoidung = new Bus_UserGroup();
            Bus_Permission _permission = new Bus_Permission();
            var group = _nhomnguoidung.GetGroupByUser(userId);
            if (group != null)
            {
                groupPermission = _permission.GetById(group.GroupId, permissionId);
                userPermission = Library.PhanQuyen(Library.user.UserId, permissionId);
                if (groupPermission != null)
                {
                    if (groupPermission.View == true)
                    {
                        return true;
                    }
                    else
                    {

                        if (userPermission != null && userPermission.View == true)
                            return true;
                    }
                }
            }
            else
            {
                userPermission = Library.PhanQuyen(Library.user.UserId, permissionId);
                if (userPermission != null)
                {
                    if (userPermission.View == true)
                        return true;

                }
                else
                    return false;
            }
            return false;
        }
        /// <summary>
        /// Kiểm tra quyền được thêm
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="permissionId"></param>
        /// <returns></returns>
        public static bool ActionAdd(int userId, string permissionId)
        {
            Permission groupPermission;
            Permission userPermission;
            Bus_UserGroup _nhomnguoidung = new Bus_UserGroup();
            Bus_Permission _permission = new Bus_Permission();
            var group = _nhomnguoidung.GetGroupByUser(userId);
            if (group != null)
            {
                groupPermission = _permission.GetById(group.GroupId, permissionId);
                userPermission = Library.PhanQuyen(Library.user.UserId, permissionId);
                if (groupPermission != null)
                {
                    if (groupPermission.Add == true)
                    {
                        return true;
                    }
                    else
                    {
                        if (userPermission != null && userPermission.Add == true)
                            return true;
                    }
                }
            }
            else
            {
                userPermission = Library.PhanQuyen(Library.user.UserId, permissionId);
                if (userPermission != null)
                {
                    if (userPermission.Add == true)
                        return true;

                }
                else
                    return false;
            }
            return false;
        }

        /// <summary>
        /// Kiểm tra quyền được chỉnh sửa
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="permissionId"></param>
        /// <returns></returns>
        public static bool ActionEdit(int userId, string permissionId)
        {
            Permission groupPermission;
            Permission userPermission;
            Bus_UserGroup _nhomnguoidung = new Bus_UserGroup();
            Bus_Permission _permission = new Bus_Permission();
            var group = _nhomnguoidung.GetGroupByUser(userId);
            if (group != null)
            {
                groupPermission = _permission.GetById(group.GroupId, permissionId);
                userPermission = Library.PhanQuyen(Library.user.UserId, permissionId);
                if (groupPermission != null)
                {
                    if (groupPermission.Edit == true)
                    {
                        return true;
                    }
                    else
                    {
                        if (userPermission != null && userPermission.Edit == true)
                            return true;
                    }
                }
            }
            else
            {
                userPermission = Library.PhanQuyen(Library.user.UserId, permissionId);
                if (userPermission != null)
                {
                    if (userPermission.Edit == true)
                        return true;

                }
                else
                    return false;
            }
            return false;
        }
        /// <summary>
        /// Kiểm tra quyền được xóa
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="permissionId"></param>
        /// <returns></returns>
        public static bool ActionDelete(int userId, string permissionId)
        {
            Permission groupPermission;
            Permission userPermission;
            Bus_UserGroup _nhomnguoidung = new Bus_UserGroup();
            Bus_Permission _permission = new Bus_Permission();
            var group = _nhomnguoidung.GetGroupByUser(userId);
            if (group != null)
            {
                groupPermission = _permission.GetById(group.GroupId, permissionId);
                userPermission = Library.PhanQuyen(Library.user.UserId, permissionId);
                if (groupPermission != null)
                {
                    if (groupPermission.Delete == true)
                    {
                        return true;
                    }
                    else
                    {
                        if (userPermission != null && userPermission.Delete == true)
                            return true;
                    }
                }
            }
            else
            {
                userPermission = Library.PhanQuyen(Library.user.UserId, permissionId);
                if (userPermission != null)
                {
                    if (userPermission.Delete == true)
                        return true;

                }
                else
                    return false;
            }
            return false;
        }
        /// <summary>
        /// Kiểm tra quyền được in
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="permissionId"></param>
        /// <returns></returns>
        public static bool ActionPrint(int userId, string permissionId)
        {
            Permission groupPermission;
            Permission userPermission;
            Bus_UserGroup _nhomnguoidung = new Bus_UserGroup();
            Bus_Permission _permission = new Bus_Permission();
            var group = _nhomnguoidung.GetGroupByUser(userId);
            if (group != null)
            {
                groupPermission = _permission.GetById(group.GroupId, permissionId);
                userPermission = Library.PhanQuyen(Library.user.UserId, permissionId);
                if (groupPermission != null)
                {
                    if (groupPermission.Print == true)
                    {
                        return true;
                    }
                    else
                    {
                        if (userPermission != null && userPermission.Print == true)
                            return true;
                    }
                }
            }
            else
            {
                userPermission = Library.PhanQuyen(Library.user.UserId, permissionId);
                if (userPermission != null)
                {
                    if (userPermission.Print == true)
                        return true;

                }
                else
                    return false;
            }
            return false;
        }
        /// <summary>
        /// Kiểm tra quyền được trích xuất dữ liệu
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="permissionId"></param>
        /// <returns></returns>
        public static bool ActionExtract(int userId, string permissionId)
        {
            Permission groupPermission;
            Permission userPermission;
            Bus_UserGroup _nhomnguoidung = new Bus_UserGroup();
            Bus_Permission _permission = new Bus_Permission();
            var group = _nhomnguoidung.GetGroupByUser(userId);
            if (group != null)
            {
                groupPermission = _permission.GetById(group.GroupId, permissionId);
                userPermission = Library.PhanQuyen(Library.user.UserId, permissionId);
                if (groupPermission != null)
                {
                    if (groupPermission.Extract == true)
                    {
                        return true;
                    }
                    else
                    {
                        if (userPermission != null && userPermission.Extract == true)
                            return true;
                    }
                }
            }
            else
            {
                userPermission = Library.PhanQuyen(Library.user.UserId, permissionId);
                if (userPermission != null)
                {
                    if (userPermission.Extract == true)
                        return true;

                }
                else
                    return false;
            }
            return false;
        }
        /// <summary>
        /// Đọc số tiền
        /// </summary>
        /// <param name="total"></param>
        /// <returns></returns>
        public static String NumberToTextVN(decimal total)
        {
            try
            {
                string rs = "";
                total = Math.Round(total, 0);
                string[] ch = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
                string[] rch = { "lẻ", "mốt", "", "", "", "lăm" };
                string[] u = { "", "mươi", "trăm", "ngàn", "", "", "triệu", "", "", "tỷ", "", "", "ngàn", "", "", "triệu" };
                string nstr = total.ToString();

                int[] n = new int[nstr.Length];
                int len = n.Length;
                for (int i = 0; i < len; i++)
                {
                    n[len - 1 - i] = Convert.ToInt32(nstr.Substring(i, 1));
                }

                for (int i = len - 1; i >= 0; i--)
                {
                    if (i % 3 == 2)// số 0 ở hàng trăm
                    {
                        if (n[i] == 0 && n[i - 1] == 0 && n[i - 2] == 0) continue;//nếu cả 3 số là 0 thì bỏ qua không đọc
                    }
                    else if (i % 3 == 1) // số ở hàng chục
                    {
                        if (n[i] == 0)
                        {
                            if (n[i - 1] == 0) { continue; }// nếu hàng chục và hàng đơn vị đều là 0 thì bỏ qua.
                            else
                            {
                                rs += " " + rch[n[i]]; continue;// hàng chục là 0 thì bỏ qua, đọc số hàng đơn vị
                            }
                        }
                        if (n[i] == 1)//nếu số hàng chục là 1 thì đọc là mười
                        {
                            rs += " mười"; continue;
                        }
                    }
                    else if (i != len - 1)// số ở hàng đơn vị (không phải là số đầu tiên)
                    {
                        if (n[i] == 0)// số hàng đơn vị là 0 thì chỉ đọc đơn vị
                        {
                            if (i + 2 <= len - 1 && n[i + 2] == 0 && n[i + 1] == 0) continue;
                            rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);
                            continue;
                        }
                        if (n[i] == 1)// nếu là 1 thì tùy vào số hàng chục mà đọc: 0,1: một / còn lại: mốt
                        {
                            rs += " " + ((n[i + 1] == 1 || n[i + 1] == 0) ? ch[n[i]] : rch[n[i]]);
                            rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);
                            continue;
                        }
                        if (n[i] == 5) // cách đọc số 5
                        {
                            if (n[i + 1] != 0) //nếu số hàng chục khác 0 thì đọc số 5 là lăm
                            {
                                rs += " " + rch[n[i]];// đọc số 
                                rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);// đọc đơn vị
                                continue;
                            }
                        }
                    }

                    rs += (rs == "" ? " " : ", ") + ch[n[i]];// đọc số
                    rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);// đọc đơn vị
                }
                if (rs[rs.Length - 1] != ' ')
                    rs += " đồng";
                else
                    rs += "đồng";

                if (rs.Length > 2)
                {
                    string rs1 = rs.Substring(0, 2);
                    rs1 = rs1.ToUpper();
                    rs = rs.Substring(2);
                    rs = rs1 + rs;
                }
                return rs.Trim().Replace("lẻ,", "lẻ").Replace("mươi,", "mươi").Replace("trăm,", "trăm").Replace("mười,", "mười").Replace("Mười,", "Mười");
            }
            catch
            {
                return "";
            }

        }
    }
}
