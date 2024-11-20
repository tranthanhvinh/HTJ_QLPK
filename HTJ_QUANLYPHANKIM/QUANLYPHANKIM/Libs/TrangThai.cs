using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHANKIM.Libs
{
    public class TrangThai
    {
        public int _value { set; get; }
        public string _display { set; get; }
        public TrangThai()
        {

        }
        public TrangThai(int _val, string _dis)
        {
            this._value = _val;
            this._display = _dis;
        }
        public static List<TrangThai> getList()
        {
            List<TrangThai> lst = new List<TrangThai>();
            TrangThai[] collect = new TrangThai[2]
            {
                new TrangThai(1, "Chưa hoàn tất"),
                new TrangThai(2, "Đã hoàn tất")
            };
            lst.AddRange(collect);
            return lst;
        }
    }
}
