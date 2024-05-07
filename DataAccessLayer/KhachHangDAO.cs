using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DataAccessLayer
{
    public class KhachHangDAO
    {
        DBConnection db = new DBConnection();
        public DataTable GetData()
        {
            return db.GetData("select * from khachhang");
        }
        public DataTable GetData(string query)
        {
            return db.GetData(query);
        }
        public int Insert(KhachHang kh)
        {
            return db.ExcuteData("insert into khachhang(SDT,Ten) values ('"+kh.SDT+"','"+kh.Ten+"')");
        }
        public int Delete(string id)
        {
            return db.ExcuteData("delete from khachhang where ID = '"+id+"'");
        }
        public int Update(string id,KhachHang kh)
        {
            return db.ExcuteData("update khachhang set SDT ='"+kh.SDT+"',Ten ='"+kh.Ten+"' where ID = '"+kh.ID+"'");
        }
        
    }
}
