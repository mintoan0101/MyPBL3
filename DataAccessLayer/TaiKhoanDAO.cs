using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using ValueObject;
using System.Data.Entity;
namespace DataAccessLayer
{
    public class TaiKhoanDAO
    {
        PBL3Entities db = new PBL3Entities();
        public bool CheckAccount(string username,string password)
        {
            var anccount = db.TaiKhoans.Where(p => p.TenTaiKhoan == username).FirstOrDefault();
            if (anccount != null) //có tài khoản trùng tên
            {
                if(anccount.MatKhau == password)//trùng cả mật khẩu
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public bool CheckAdmin(string username)
        {
            var anccount = db.TaiKhoans.Where(p => p.TenTaiKhoan == username).FirstOrDefault();
            if (anccount.isAdmin == 1)
            {
                return true;
            }
            return false;
        }
        public string GetLastID()
        {
            var anccount = db.TaiKhoans.OrderByDescending(p => p.IDTaiKhoan).FirstOrDefault();
            if (anccount != null)
            {
                return anccount.IDTaiKhoan;
            }
            return null;
        }
        public int Insert(TaiKhoan tk)
        {
            db.TaiKhoans.Add(tk);
            db.SaveChanges();
            return 1;
        }
        public int Update(TaiKhoan tk)
        {
            var anccount = db.TaiKhoans.Where(p => p.IDTaiKhoan == tk.IDTaiKhoan).FirstOrDefault();
            if (anccount != null)
            {
                anccount = tk;
                db.SaveChanges();
                return 1;
            }
            return 0;
        }

    }
}
