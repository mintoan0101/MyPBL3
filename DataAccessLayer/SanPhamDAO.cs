using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;
using ValueObject;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
namespace DataAccessLayer
{
    public class SanPhamDAO
    {
        DBConnection db = new DBConnection();
        PBL3Entities pbl = new PBL3Entities();
        public List<SanPham> GetData()
        {
            var li = pbl.SanPhams.ToList();
            return li;
        }
        public DataTable GetData(string query)
        {
            return db.GetData(query);
        }
        public List<SanPham> GetDataByID(string id)
        {
            var li = pbl.SanPhams.Where(p => p.IDSanPham == id);
            return li.ToList();
        }
        public List<string> GetSeparatedDataByColumn()
        {
            var li = pbl.SanPhams.Select(p => p.PhanLoai).Distinct().ToList();
            return li;
        }
        public int Insert(SanPham sp)
        {
            try
            {
                pbl.SanPhams.Add(sp);
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
                var sp = pbl.SanPhams.Where(p => p.IDSanPham == id).FirstOrDefault();
                pbl.SanPhams.Remove(sp);
                pbl.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public int Update(SanPham sp)
        {
            try
            {
                var sanPham = pbl.SanPhams.Where(p => p.IDSanPham == sp.IDSanPham).FirstOrDefault();
                if (sanPham != null)
                {
                    sanPham.Ten = sp.Ten;
                    sanPham.PhanLoai = sp.PhanLoai;
                    sanPham.GiaBan = sp.GiaBan;
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
        //public List<string> GetList(string column)
        //{ 
        //    return db.GetDataInColumn("sanpham", column); 
        //}
        public string GetLastID(string phanloai)
        {
            var li = pbl.SanPhams.Where(p => p.PhanLoai == phanloai)
                                 .OrderByDescending(p => p.IDSanPham)
                                 .FirstOrDefault();
            return li.IDSanPham;
        }
        
        public List<SanPham> Search(string txt, string PhanLoai, string BoLoc)
        {
            var list = pbl.SanPhams.Select(p => p);
            if (!string.IsNullOrEmpty(txt))
            {
                list = list.Where(p => p.Ten.Contains(txt));
            }

            if (PhanLoai != "Tất Cả")
            {
                list = list.Where(p => p.PhanLoai == PhanLoai);
            }

            if (BoLoc != "Tất cả")
            {
                switch(BoLoc)
                {
                    case "<30K":
                        list = list.Where(p => p.GiaBan < 30);
                        break;
                    case "30K - 100K":
                        list = list.Where(p => p.GiaBan >= 30 && p.GiaBan <= 100);
                        break;
                    case "100K - 200K":
                        list = list.Where(p => p.GiaBan >= 100 && p.GiaBan <= 200);
                        break;
                    case ">200K":
                        list = list.Where(p => p.GiaBan > 200);
                        break;
                    case "Giá giảm dần":
                        list = list.OrderByDescending(p => p.GiaBan);
                        break;
                    case "Giá tăng dần":
                        list = list.OrderBy(p => p.GiaBan);
                        break;
                }    
            }
            return list.ToList();
        }
    }
}
