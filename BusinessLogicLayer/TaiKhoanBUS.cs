using DataAccessLayer;
using pbl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAO dao = new TaiKhoanDAO();
        public bool CheckAccount(string username,string password)
        {
            return dao.CheckAccount(username, password);
        }
        public bool CheckAdmin(string username)
        {
            return dao.CheckAdmin(username);
        }
        public int Insert(TaiKhoan tk )
        {
            return dao.Insert(tk);
        }
        public int Update(TaiKhoan tk )
        {
            return dao.Update(tk);
        }
        public string GetLastID()
        {
            return dao.GetLastID();
        }
    }
}
