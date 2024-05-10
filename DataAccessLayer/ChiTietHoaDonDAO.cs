using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DataAccessLayer
{
    public class ChiTietHoaDonDAO
    {
        DBConnection db = new DBConnection();

        private static ChiTietHoaDonDAO _Instance;
        public static ChiTietHoaDonDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ChiTietHoaDonDAO();
                }
                return _Instance;
            }
            private set { }
        }
        private ChiTietHoaDonDAO()
        {

        }
        public int Insert(ChiTietHoaDon cthd, string idHoaDon)
        {
            string query = "INSERT INTO CHITIETHOADON (IDHoaDon, IDChiTiet, SoLuong) " +
                           "VALUES ('" + idHoaDon + "', '" + cthd.IDChiTiet + "', " + cthd.SoLuong + ")";

            return db.ExcuteData(query);
        }
        public DataTable GetData(string ID)
        {
            string query = "SELECT sanpham.Ten AS TenSanPham, chitiethoadon.SoLuong " +
                           "FROM CHITIETHOADON chitiethoadon " +
                           "JOIN CHITIETSANPHAM chitietsanpham ON chitiethoadon.IDChiTiet = chitietsanpham.IDChiTiet " +
                           "JOIN SANPHAM sanpham ON chitietsanpham.IDSanPham = sanpham.IDSanPham"
                           + "WHERE CHITIETHOADON.IDHoaDon = '" + ID + "';";

            return db.GetData(query);
        }

    }
}
