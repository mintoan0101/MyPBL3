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

        private static KhachHangDAO _Instance;
        public static KhachHangDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new KhachHangDAO();
                }
                return _Instance;
            }
            private set { }
        }
        private KhachHangDAO()
        {

        }
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
            return db.ExcuteData("insert into khachhang(ID,SDT,Ten,Diem) values ('" + kh.ID + kh.SDT + "','" + kh.Ten + "','" + kh.Diem + ")");
        }
        public int Delete(string id)
        {
            return db.ExcuteData("delete from khachhang where ID = '"+id+"'");
        }
        public int Update(string id,KhachHang kh)
        {
            return db.ExcuteData("update khachhang set SDT ='"+kh.SDT+"',Ten ='"+kh.Ten+ "', Diem = " + kh.Diem + "' where ID = '"+kh.ID+"'");
        }
        
    }
}
