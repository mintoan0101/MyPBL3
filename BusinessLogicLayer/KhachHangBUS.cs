using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BusinessLogicLayer
{
    public class KhachHangBUS
    {
        KhachHangDAO dao = new KhachHangDAO();
        public DataTable GetData()
        {
            return dao.GetData();
        }
        public DataTable GetData(string query) {
          return dao.GetData(query);
        }
        public int Insert(KhachHang kh)
        {
            return dao.Insert(kh);
        }
        public int Delete(string id)
        {
            return dao.Delete(id);
        }
        public int Update(string id, KhachHang kh)
        {
            return dao.Update(id, kh);
        }
    }
}
