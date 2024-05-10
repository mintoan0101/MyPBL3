using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DataAccessLayer
{
    public class HoaDonDAO
    {
        DBConnection db = new DBConnection();

        private static HoaDonDAO _Instance;
        public static HoaDonDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new HoaDonDAO();
                }
                return _Instance;
            }
            private set { }
        }
        private HoaDonDAO()
        {

        }
        public DataTable GetData()
        {
            return db.GetData("select * from hoadon");
        }

        public DataTable GetData(string query)
        {
            return db.GetData(query);
        }

        public int Insert(HoaDon hd)
        {
            string query = "INSERT INTO HOADON (IDHoaDon, IDNhanVien, NgayTaoHoaDon, IDKhachHang, ChietKhau, TongTien) " +
                           "VALUES ('" + hd.IDHoaDon + "', '" + hd.IDNhanVien + "', '" + hd.NgayTaoHoaDon.ToString("yyyy-MM-dd") + "', '" +
                           hd.IDKhachHang + "', '" + hd.ChietKhau + "', '" + hd.TongTien + "')";
            //foreach (ChiTietHoaDon chitiethoadon in hd.listChiTietHoaDon)
            //{
            //    ChiTietHoaDonDAO.Instance.Insert(chitiethoadon, hd.IDHoaDon);
            //}

            return db.ExcuteData(query);
        }

        public string GetLastID()
        {
            return db.GetLastId("Select * from HOADON");
        }
    }
}
