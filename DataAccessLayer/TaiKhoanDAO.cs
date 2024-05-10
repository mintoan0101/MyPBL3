using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using ValueObject;
namespace DataAccessLayer
{
    public class TaiKhoanDAO
    {
        DBConnection db = new DBConnection();
        public bool CheckAccount(string username,string password)
        {
            DataTable dt = db.GetData("select * from taikhoan where TenTaiKhoan = '"+username+"'");
            if (dt.Rows.Count > 0) // có tài khoản trùng tên
            {
                string pass = dt.Rows[0]["MatKhau"].ToString();
                if( pass == password)//trùng cả mật khẩu
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
            DataTable dt = db.GetData("select * from taikhoan where TenTaiKhoan = '" + username + "'");
            if (Convert.ToInt32(dt.Rows[0]["isAdmin"]) == 1)
            {
                return true;
            }
            return false;
        }
        public string GetLastID()
        {
            return db.GetLastId("select * from taikhoan");
        }
        public int Insert(TaiKhoan tk)
        {
            return db.ExcuteData("insert into taikhoan(IDTaiKhoan,TenTaiKhoan,MatKhau,isAdmin) values " +
                "('"+tk.IDTaiKhoan+"','"+tk.TenTaiKhoan+"','"+tk.MatKhau+"',0)");
        }
        public int Update(TaiKhoan tk)
        {
            return db.ExcuteData("update taikhoan set TenTaiKhoan = '"+tk.TenTaiKhoan+"', MatKhau = '"+tk.MatKhau+"' where IDTaiKhoan = '"+tk.IDTaiKhoan+"'");
        }
       
    }
}
