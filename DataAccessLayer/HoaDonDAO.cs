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

        public DataTable Search(string searchText, string selectedColumn, double minTotal, double maxTotal)
        {
            DataTable dt = new DataTable();
            string query = "SELECT Hoadon.IDHoaDon, Hoadon.NgayTaoHoaDon, Hoadon.TongTien, Hoadon.IDNhanVien, Hoadon.IDKhachHang " +
                           "FROM Hoadon " +
                           "INNER JOIN Nhanvien ON Hoadon.IDNhanVien = Nhanvien.IDNhanvien " +
                           "INNER JOIN Khachhang ON Hoadon.IDKhachHang = Khachhang.ID " +
                           "WHERE 1=1 ";

            switch (selectedColumn)
            {
                case "ID Hoá Đơn":
                    query += $"AND Hoadon.IDHoaDon like '%{searchText}%' ";
                    break;
                case "Ngày Tạo Hoá Đơn":
                    query += $"AND Hoadon.NgayTaoHoaDon like '%{searchText}%' ";
                    break;
                case "Nhân Viên":
                    query += $"AND (Nhanvien.IDNhanvien = '%{searchText}%' OR Nhanvien.TenNhanVien like '%{searchText}%') ";
                    break;
                case "Khách Hàng":
                    query += $"AND (Khachhang.ID like '%{searchText}%' OR Khachhang.Ten like '%{searchText}%') ";
                    break;
                default:
                    break;
            }

            if (minTotal != -1)
            {
                query += $" AND Hoadon.TongTien > {minTotal} ";
            }

            if (maxTotal != -1)
            {
                query += $" AND Hoadon.TongTien < {maxTotal} ";
            }

            dt = db.GetData(query);
            return dt;
        }

        public HoaDon GetHoaDonFromID(string id)
        {
            HoaDon hd = new HoaDon();
            return hd;
        }

       
    }
}

