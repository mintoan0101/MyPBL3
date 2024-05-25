using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
using ValueObject;

namespace BusinessLogicLayer
{
    public class SanPhamBUS
    {
        SanPhamDAO dao = new SanPhamDAO();
        public List<SanPham> GetData()
        {
            return dao.GetData();
        }
        public DataTable GetData(string query)
        {
            return dao.GetData(query);
        }
        public List<SanPham> GetDataByID(string id)
        {
            return dao.GetDataByID(id);
        }
        public List<string> GetSeperatedDataByColumn()
        {
            return dao.GetSeparatedDataByColumn();
        }
        public int Insert(SanPham sp )
        {
            return dao.Insert(sp);
        }
        public int Delete(string id)
        {
            return dao.Delete(id);
        }
        public int Update(SanPham sp)
        {
            return dao.Update(sp);
        }
        //public List<string> GetList(string column)
        //{
        //    return dao.GetList(column);
        //}
        public string GetLastID(string PhanLoai)
        {
            return dao.GetLastID(PhanLoai);
        }
        public List<SanPham> Search(string txt, string PhanLoai, string BoLoc)
        {
            return dao.Search(txt, PhanLoai, BoLoc);
        }
    }
}
