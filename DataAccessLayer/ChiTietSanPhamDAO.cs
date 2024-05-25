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
        PBL3Entities pbl = new PBL3Entities();
        public List<ChiTietSanPham> GetData(string id)
        {
            var li = pbl.ChiTietSanPhams.Where(p => p.IDSanPham == id).ToList();
            return li;
        }

        public List<dynamic> GetData1()
        {
            var li = pbl.ChiTietSanPhams.Select(p => new
            {
                p.IDChiTiet,
                p.SanPham.PhanLoai,
                p.SanPham.Ten,
                p.HanSuDung,
                p.SanPham.GiaBan,
                p.SoLuong,
                Check = false
            }).ToList<dynamic>();
            return li;
        }
        public DataTable GetData2(string query)
        {
            return db.GetData(query);
        }
        public int Insert(ChiTietSanPham ctsp)
        {
            try
            {
                pbl.ChiTietSanPhams.Add(ctsp);
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
                var ct = pbl.ChiTietSanPhams.Where(p => p.IDChiTiet == id).FirstOrDefault();
                pbl.ChiTietSanPhams.Remove(ct);
                pbl.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public int Update(ChiTietSanPham ctsp)
        {
            try
            {
                var sp = pbl.ChiTietSanPhams.Where(p => p.IDChiTiet == ctsp.IDChiTiet).FirstOrDefault();
                if (sp != null)
                {
                    sp.IDNhaPhanPhoi = ctsp.IDNhaPhanPhoi;
                    sp.IDSanPham = ctsp.IDSanPham;
                    sp.HanSuDung = ctsp.HanSuDung;
                    sp.SoLuong = ctsp.SoLuong; 
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
        public ChiTietSanPham GetCTSP(string IDChiTiet)
        {
            var ctsp = pbl.ChiTietSanPhams.Where(p => p.IDChiTiet == IDChiTiet).FirstOrDefault();   
            return ctsp;
        }
        public int CountID(string f)
        {
            var count = pbl.ChiTietSanPhams.Count(p => p.IDChiTiet.Contains("CT" + f));
            return count;
        }

        public List<dynamic> Search(string PhanLoai, string txt)
        {
            var list = GetData1();

            if (!string.IsNullOrEmpty(txt))
            {
                switch (PhanLoai)
                {
                    case "ID Chi Tiết":
                        list = list.Where(p => p.IDChiTiet.Contains(txt)).ToList();
                        break;
                    case "Tên Sản Phẩm":
                        list = list.Where(p => p.TenSanPham.Contains(txt)).ToList();
                        break;
                    case "Phân Loại":
                        list = list.Where(p => p.PhanLoai.Contains(txt)).ToList();
                        break;
                    default:
                        break;
                }
            }

            return list;
        }


    }
}