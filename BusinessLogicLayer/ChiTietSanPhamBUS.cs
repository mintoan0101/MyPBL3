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

        public DataTable GetData(string id)
        {
            return dao.GetData(id);
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
        public int Update(string id, ChiTietSanPham ctsp)
        {
            return dao.Update(id, ctsp);
        }
        public ChiTietSanPham GetCTSP(string IDChiTiet)
        {
            return dao.GetCTSP(IDChiTiet);
        }
        public int CountID()
        {
            return dao.CountID();
        }
        public ChiTietSanPham GetChiTietSanPhamByDataRow(DataRow i)
        {
            return new ChiTietSanPham
            {
                IDChiTiet = i["IDChiTiet"].ToString(),
                IDSanPham = i["IDSanPham"].ToString(),
                IDNhaPhanPhoi = i["IDNhaPhanPhoi"].ToString(),
                HanSuDung = Convert.ToString(i["HanSuDung"]),
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

        public DataTable Search(string PhanLoai, string txt)
        {
            return dao.Search(PhanLoai, txt);
        }

    }
}
