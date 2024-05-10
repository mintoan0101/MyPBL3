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
        private KhachHangBUS()
        {

        }
        public DataTable GetData()
        {
            return KhachHangDAO.Instance.GetData();
        }
        public DataTable GetData(string query) {
          return KhachHangDAO.Instance.GetData(query);
        }
        public int Insert(KhachHang kh)
        {
            return KhachHangDAO.Instance.Insert(kh);
        }
        public int Delete(string id)
        {
            return KhachHangDAO.Instance.Delete(id);
        }
        public int Update(string id, KhachHang kh)
        {
            return KhachHangDAO.Instance.Update(id, kh);
        }

        public void DoiDiem(HoaDon hd, KhachHang kh)
        {
            int diemChietKhau = kh.Diem * 1000;
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

    }
}
