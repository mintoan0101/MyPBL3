//using Mysqlx.Crud;
using ValueObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ChiTietSanPhamDAO
    {
        DBConnection db = new DBConnection();
        public DataTable GetData(string id)
        {
            return db.GetData("select IDChiTiet,TenNhaPhanPhoi,HanSuDung,SoLuong from chitietsanpham join nhaphanphoi on chitietsanpham.IDNhaPhanPhoi = nhaphanphoi.IDNhaPhanPhoi where IDSanPham = '" + id + "'");
        }
        public DataTable GetData2(string query)
        {
            return db.GetData(query);
        }
        public int Insert(ChiTietSanPham ctsp)
        {
            return db.ExcuteData("insert into chitietsanpham(IDChiTiet,IDSanPham,IDNhaPhanPhoi,HanSuDung, SoLuong) values " +
                "('" + ctsp.IDChiTiet + "','" + ctsp.IDSanPham + "','" + ctsp.IDNhaPhanPhoi + "','" + ctsp.HanSuDung + "',"+ctsp.SoLuong+")");
        }
        public int Delete(string id)
        {
            return db.ExcuteData("delete from CHITIETSANPHAM where IDChiTiet ='" + id + "'");
        }
        public int Update(string id, ChiTietSanPham ctsp)
        {
            return db.ExcuteData("update chitietsanpham set IDNhaPhanPhoi = '" + ctsp.IDNhaPhanPhoi + "',HanSuDung = '" + ctsp.HanSuDung + "',SoLuong = "+ctsp.SoLuong+" where IDChiTiet = '" + id + "'");
        }
        public ChiTietSanPham GetCTSP(string IDChiTiet)
        {
            ChiTietSanPham ct = new ChiTietSanPham();
            DataTable dt = db.GetData("select * from chitietsanpham where IDChiTiet ='" + IDChiTiet + "'");
            ct.IDChiTiet = dt.Rows[0][0].ToString();
            ct.IDSanPham = dt.Rows[0][1].ToString();
            ct.IDNhaPhanPhoi = dt.Rows[0][2].ToString();
            ct.HanSuDung = dt.Rows[0][3].ToString();
            return ct;
        }
        public int CountID(string f)
        {
            return db.CountRows("select * from chitietsanpham where IDChiTiet LIKE '%CT"+f+"%'");
        }

        public DataTable Search(string PhanLoai, string txt)
        {

            string query = string.Empty;

            if (PhanLoai == "ID Chi Tiết")
            {
                query = "SELECT " +
                        "chitietsanpham.IDChiTiet AS 'ID Chi Tiết', " +
                        "sanpham.Ten AS 'Tên Sản Phẩm', " +
                        "sanpham.PhanLoai AS 'Phân Loại', " +
                        "sanpham.GiaBan AS 'Giá Bán', " +
                        "chitietsanpham.SoLuong AS 'Số Lượng', " +
                        "chitietsanpham.HanSuDung AS 'Hạn Sử Dụng' " +
                        "FROM CHITIETSANPHAM " +
                        "JOIN SANPHAM ON CHITIETSANPHAM.IDSanPham = SANPHAM.IDSanPham " +
                        "WHERE CHITIETSANPHAM.IDChiTiet LIKE '%" + txt + "%';";
            }
            else if (PhanLoai == "Tên Sản Phẩm")
            {
                query = "SELECT " +
                        "chitietsanpham.IDChiTiet AS 'ID Chi Tiết', " +
                        "sanpham.Ten AS 'Tên Sản Phẩm', " +
                        "sanpham.PhanLoai AS 'Phân Loại', " +
                        "sanpham.GiaBan AS 'Giá Bán', " +
                        "chitietsanpham.SoLuong AS 'Số Lượng', " +
                        "chitietsanpham.HanSuDung AS 'Hạn Sử Dụng' " +
                        "FROM CHITIETSANPHAM " +
                        "JOIN SANPHAM ON CHITIETSANPHAM.IDSanPham = SANPHAM.IDSanPham " +
                        "WHERE SANPHAM.Ten LIKE '%" + txt + "%';";
            }

            DataTable dt = GetData2(query);
            return dt;

        }


    }
}