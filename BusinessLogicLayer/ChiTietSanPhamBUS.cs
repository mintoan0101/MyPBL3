using DataAccessLayer;
using ValueObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace BusinessLogicLayer
{
    public class ChiTietSanPhamBUS
    {
        ChiTietSanPhamDAO dao = new ChiTietSanPhamDAO();

        public List<ChiTietSanPham> GetData(string id)
        {
            return dao.GetData(id);
        }
        public List<ChiTietSanPham_View> GetData1()
        {
            return dao.GetData1();  
        }
        public DataTable GetData2(string query)
        {
            return dao.GetData2(query);
        }
        public int Insert(ChiTietSanPham ctsp)
        {
            return dao.Insert(ctsp);
        }
        public int Delete(string id)
        {
            return dao.Delete(id);
        }
        public int Update(ChiTietSanPham ctsp)
        {
            return dao.Update(ctsp);
        }
        public ChiTietSanPham GetCTSP(string IDChiTiet)
        {
            return dao.GetCTSP(IDChiTiet);
        }
        public int CountID(string f)
        {
            return dao.CountID(f);
        }
        public ChiTietSanPham GetChiTietSanPhamByDataRow(DataRow i)
        {
            return new ChiTietSanPham
            {
                IDChiTiet = i["IDChiTiet"].ToString(),
                IDSanPham = i["IDSanPham"].ToString(),
                IDNhaPhanPhoi = i["IDNhaPhanPhoi"].ToString(),
                HanSuDung = Convert.ToDateTime(i["HanSuDung"]),
            };
        }
        public List<ChiTietSanPham> GetChiTietSanPham(string query)
        {
            List<ChiTietSanPham> result = new List<ChiTietSanPham>();
            foreach (DataRow item in GetData2(query).Rows)
            {
                result.Add(GetChiTietSanPhamByDataRow(item));
            }
            return result;
        }

        public List<ChiTietSanPham_View> Search(string PhanLoai, string txt)
        {
            return dao.Search(PhanLoai, txt);
        }

        public List<SoLuongCTSP> GetSoLuongs() 
        { 
            return dao.GetSoLuongs();
        }

    }
}
