using DataAccessLayer;
using pbl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
