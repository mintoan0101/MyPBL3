using DataAccessLayer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BusinessLogicLayer
{
    public class KhachHangBUS
    {
        private static KhachHangBUS _Instance;
        public static KhachHangBUS Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new KhachHangBUS();
                }
                return _Instance;
            }
            private set { }
        }
        public KhachHangBUS()
        {

        }

        public KhachHang GetKhachHang(string sdt)
        {
            return KhachHangDAO.Instance.GetDataBySDT(sdt);
        }
        public List<KhachHang> GetData()
        {
            return KhachHangDAO.Instance.GetData();
        }
        public int Insert(KhachHang kh)
        {
            return KhachHangDAO.Instance.Insert(kh);
        }
        public int Delete(string id)
        {
            return KhachHangDAO.Instance.Delete(id);
        }
        public int Update( KhachHang kh)
        {
            return KhachHangDAO.Instance.Update( kh);
        }

        
        public void DoiDiem(HoaDon hd, KhachHang kh)
        {
            int diemChietKhau = kh.Diem;
            if (diemChietKhau >= hd.TongTien / 2)
            {
                int diemCanDung = Convert.ToInt32(hd.TongTien / 2000);
                kh.Diem -= diemCanDung;
                hd.ChietKhau = hd.TongTien / 2;
                hd.TongTien -= hd.ChietKhau;
            }
            else
            {
                hd.ChietKhau = diemChietKhau;
                hd.TongTien -= hd.ChietKhau;
                kh.Diem = 0;
            }
        }


        public KhachHang GetKhachHangBySDT(string SDT)
        {
            return KhachHangDAO.Instance.GetDataBySDT( SDT );
        }

        public string SetID()
        {
            string LastId_KH = HoaDonBUS.Instance.GetLastID();
            int l_KH = LastId_KH.Length;

            int num_KH = int.Parse(LastId_KH.Substring(l_KH - 2)) + 1;
            return ("KH" + Num_ID(num_KH));
        }

        public string Num_ID(int num)
        {
            if (num <= 9)
            {
                return "0" + num;
            }
            return num + "";
        }
        public string GetLastID()
        {
            return KhachHangDAO.Instance.GetLastID();
        }
        
        public List<KhachHang> Search (string txt, string PhanLoai, string BoLoc)
        {
            return KhachHangDAO.Instance.Search(txt, PhanLoai, BoLoc);
        }


    }

}

