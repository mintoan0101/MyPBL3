using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
using pbl;

namespace BusinessLogicLayer
{
    public class SanPhamBUS
    {
        SanPhamDAO dao = new SanPhamDAO();
        public DataTable GetData()
        {
            return dao.GetData();
        }
        public DataTable GetData(string query)
        {
            return dao.GetData(query);
        }
        public DataTable GetDataByID(string id)
        {
            return dao.GetDataByID(id);
        }
        public HashSet<string> GetSeperatedDataByColumn(string comlumn)
        {
            return dao.GetSeparatedDataByColumn(comlumn);
        }
        public int Insert(SanPham sp )
        {
            return dao.Insert(sp);
        }
        public int Delete(SanPham sp)
        {
            return dao.Delete(sp);
        }
        public int Delete(string id)
        {
            return dao.Delete(id);
        }
        public int Update(SanPham sp)
        {
            return dao.Update(sp);
        }
        public List<string> GetList(string column)
        {
            return dao.GetList(column);
        }
        public string GetLastID(string phanloai)
        {
            return dao.GetLastID("select * from sanpham where PhanLoai = '"+phanloai+"'");
        }
    }
}
