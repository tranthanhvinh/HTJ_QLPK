using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHANKIM.Libs
{

    public class PrimaryKeyGenerator
    {
        private static PrimaryKeyGenerator _instance;

        public static PrimaryKeyGenerator Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PrimaryKeyGenerator();
                }
                return _instance;
            }
            private set { _instance = value; }
        }

        private PrimaryKeyGenerator() { }

        private static string KeyGanerator(string orgKey, string start)
        {
            string result = "";

            try
            {
                string str = orgKey.Substring(start.Length);
                int num = Convert.ToInt32(str) + 1;

                for (int i = 0; i < str.Length - num.ToString().Length; i++)
                {
                    result += "0";
                }
                result = start + result + num;

                return result;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public string NormalKey(string key, string preFix)
        {
            string fKey;

            if (key.Length > 0)
            {
                fKey = key;
                fKey = preFix + KeyGanerator(fKey.Substring(2), "");
            }
            else
            {
                fKey = preFix + KeyGanerator("000", "");
            }

            return fKey;
        }

        public string NormalKeyForNCC(string key, string preFix)
        {
            string fKey;

            if (key.Length > 0)
            {
                fKey = key;
                fKey = preFix + KeyGanerator(fKey.Substring(3), "");
            }
            else
            {
                fKey = preFix + KeyGanerator("000", "");
            }

            return fKey;
        }
        public string NormalKeyForKH(string key, string preFix)
        {
            string fKey;

            if (key.Length > 0)
            {
                fKey = key;
                fKey = preFix + KeyGanerator(fKey.Substring(2), "");
            }
            else
            {
                fKey = preFix + KeyGanerator("0000", "");
            }

            return fKey;
        }
        public string NormalKeyForDoiTac(string key, string preFix)
        {
            string fKey;

            if (key.Length > 0)
            {
                fKey = key;
                fKey = preFix + KeyGanerator(fKey.Substring(2), "");
            }
            else
            {
                fKey = preFix + KeyGanerator("0000", "");
            }

            return fKey;
        }
        public string NormalKeyForCongNo(string key, string preFix)
        {
            string fKey;

            if (key.Length > 0)
            {
                fKey = key;
                fKey = preFix + KeyGanerator(fKey.Substring(2), "");
            }
            else
            {
                fKey = preFix + KeyGanerator("000000", "");
            }

            return fKey;
        }
        public string KeyForProduct(string key, string preFix)
        {
            string fKey;

            if (key.Length > 0)
            {
                fKey = key;
                fKey = preFix + KeyGanerator(fKey.Substring(2), "");
            }
            else
            {
                fKey = preFix + KeyGanerator("0000", "");
            }

            return fKey;
        }
        public string KeyWithFourPrefix(string key, string preFix)
        {
            string fKey;

            if (key.Length > 0)
            {
                fKey = key;
                fKey = preFix + KeyGanerator(fKey.Substring(4), "");
            }
            else
            {
                fKey = preFix + KeyGanerator("000", "");
            }

            return fKey;
        }
    }

}
