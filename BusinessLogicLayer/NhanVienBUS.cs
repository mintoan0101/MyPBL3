using DataAccessLayer;
using ValueObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class NhanVienBUS
    {
        NhanVienDAO dao = new NhanVienDAO();
        public DataTable GetData()
        {
            return dao.GetData();
        }
        public DataTable GetData(string query)
        {
            return dao.GetData(query);
        }
        public int Insert(NhanVien nv)
        {
            return dao.Insert(nv);
        }
        public int Delete(string id )
        {
            return dao.Delete(id);
        }
        public int Update( NhanVien nv)
        {
            return dao.Update( nv);
        }
        public int UpdateByNhanVien(NhanVien nv)
        {
            return dao.UpdateByNhanVien(nv);
        }
        public HashSet<string> GetSeperatedData(string column)
        {
            return dao.GetSeperatedData(column);
        }
        public List<string> GetNameColumns()
        {
            return dao.GetNameColumns();
        }
        public string GetLastID()
        {
            return dao.GetLastID();
        }
        public string GetID(string txt)
        {
            return dao.GetID(txt);
        }
    }
}
