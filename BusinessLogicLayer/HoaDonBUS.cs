using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BusinessLogicLayer
{
    public class HoaDonBUS
    {
        private static HoaDonBUS _Instance;
        public static HoaDonBUS Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new HoaDonBUS();
                }
                return _Instance;
            }
            private set { }
        }
        private HoaDonBUS()
        {

        }

        public List<HoaDon> GetData()
        {
            return HoaDonDAO.Instance.GetData();
        }

        public DataTable GetData(string query)
        {
            return HoaDonDAO.Instance.GetData(query);
        }

        public int Insert(HoaDon hd) 
        {
            return HoaDonDAO.Instance.Insert(hd);
        }

        public List<HoaDon> Search(string txt, string phanloai, string boloc)
        {
            return HoaDonDAO.Instance.Search(txt, phanloai, boloc);
        }

        public string GetLastID()
        {
            return HoaDonDAO.Instance.GetLastID();
        }

        public string SetID()
        {
            string LastId_HD = HoaDonBUS.Instance.GetLastID();
            int l_hd = LastId_HD.Length;

            int num_hd = int.Parse(LastId_HD.Substring(l_hd - 2)) + 1;
            return ("HD" + Num_ID(num_hd));
        }

        public string Num_ID(int num)
        {
            if (num <= 9)
            {
                return "0" + num;
            }
            return num + "";
        }
    }
}
