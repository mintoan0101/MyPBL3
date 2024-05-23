using ValueObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;

namespace DataAccessLayer
{
    public class NhanVienDAO
    {
        DBConnection db = new DBConnection();
        public DataTable GetData()
        {
            return db.GetData("select * from nhanvien");
        }
        public DataTable GetData(string query)
        {
            return db.GetData(query);
        }
        public int Insert(NhanVien nv)
        {
            //return db.ExcuteData("insert into nhanvien(IDNhanVien,IDTaiKhoan,TenNhanVien,NgaySinh,Nam,ViTri,Email,CCCD,SoDienThoai,MucLuong,DiaChi) values" +
            //    " ('" + nv.IDNhanVien+"','" +
            //    ""+nv.IDTaiKhoan+"','" +
            //    ""+nv.TenNhanVien+"','" +
            //    ""+nv.SetDinhDangNgaySinh()+"'," +
            //    ""+nv.GioiTinh+",'"+nv.ViTri+"','" +
            //    ""+nv.Email+"','" +
            //    ""+nv.CCCD+"','" +
            //    ""+nv.SoDienThoai+"','" +
            //    ""+nv.MucLuong+"','" +
            //    ""+nv.DiaChi+"') ");
            return 0;
        }
        public int Delete(string id)
        {
            return db.ExcuteData("delete from nhanvien where IDNhanVien = '"+id+"'");
        }
        public int Update( NhanVien nv)
        {
            //return db.ExcuteData("update nhanvien set TenNhanVien = '" + nv.TenNhanVien + "'," +
            //    " NgaySinh = '" + nv.SetDinhDangNgaySinh() + "'," +
            //    " Nam = " + nv.GioiTinh +", " +
            //    " ViTri = '"+nv.ViTri+"'," +
            //    " SoDienThoai = '"+nv.SoDienThoai+"', " +
            //    " DiaChi = '"+nv.DiaChi+"'," +
            //    " Email = '"+nv.Email+"', " +
            //    " CCCD = '"+nv.CCCD+"'," +
            //    " MucLuong = "+nv.MucLuong+" WHERE IDNhanVien = '"+nv.IDNhanVien+"'");
            return 0;
        }
        public int UpdateByNhanVien(NhanVien nv)
        {
            //return db.ExcuteData("update nhanvien set TenNhanVien = '" + nv.TenNhanVien + "'," +
            //    " NgaySinh = '" + nv.SetDinhDangNgaySinh() + "'," +
            //    " SoDienThoai = '" + nv.SoDienThoai + "', " +
            //    " DiaChi = '" + nv.DiaChi + "'," +
            //    " Email = '" + nv.Email + "', " +
            //    " CCCD = '" + nv.CCCD + "'"+
            //  " WHERE IDNhanVien = '" + nv.IDNhanVien + "'");
            return 0;
        }
        public HashSet<string> GetSeperatedData(string column)
        {
            return db.GetSeperatedDataByColumn("nhanvien", column);

        }
        public List<string> GetNameColumns()
        {
            return db.getNameColumns("nhanvien");
        }
        public string GetLastID()
        {
            return db.GetLastId("Select * from nhanvien");
        }
        public string GetID(string txt)
        {
            string s = "SELECT IDNhanVien FROM NHANVIEN JOIN TAIKHOAN ON NHANVIEN.IDTaiKhoan = TAIKHOAN.IDTaiKhoan WHERE TAIKHOAN.TenTaiKhoan = '" + txt + "'";
            return db.GetStringDataCellByQueryCommand(s);
        }
        
    }
}
