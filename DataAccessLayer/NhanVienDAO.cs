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
        PBL3Entities pbl = new PBL3Entities();
        public List<NhanVien> GetData()
        {
            var li = pbl.NhanViens.Select(p => p).ToList();
            return li;
        }
        public DataTable GetData(string query)
        {
            return db.GetData(query);
        }
        public int Insert(NhanVien nv)
        {
            try
            {
                pbl.NhanViens.Add(nv);
                pbl.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public int Delete(string id)
        {
            try
            {
                var nv = pbl.NhanViens.Where(p => p.IDNhanVien == id).FirstOrDefault();
                pbl.NhanViens.Remove(nv);
                pbl.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public int Update( NhanVien nv)
        {
            try
            {
                var nhanVien = pbl.NhanViens.Where(p => p.IDNhanVien == nv.IDNhanVien).FirstOrDefault();
                if (nhanVien != null)
                {
                    nhanVien.TenNhanVien = nv.TenNhanVien;
                    nhanVien.DiaChi = nv.DiaChi;
                    nhanVien.CCCD = nv.CCCD;
                    nhanVien.Email = nv.Email;
                    nhanVien.MucLuong = nv.MucLuong;
                    nhanVien.Nam = nv.Nam;
                    nhanVien.NgaySinh = nv.NgaySinh;
                    nhanVien.SoDienThoai = nv.SoDienThoai;
                    pbl.SaveChanges();
                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
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
