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
    public class SanPhamDAO
    {
        DBConnection db = new DBConnection();
        public DataTable GetData()
        {
            return db.GetData("select * from sanpham");
        }
        public DataTable GetData(string query)
        {
            return db.GetData(query);
        }
        public DataTable GetDataByID(string id)
        {
            return db.GetData("select * from sanpham where IDSanPham = "+ id);
        }
        public HashSet<string> GetSeparatedDataByColumn(string column)
        {
            return db.GetSeperatedDataByColumn("sanpham",column);
        }
        public int Insert(SanPham sp)
        {
           return db.ExcuteData("insert into sanpham(IDSanPham,Ten,PhanLoai,GiaBan) values ('" + sp.IDSanPham + "','" + sp.Ten + "','" + sp.PhanLoai + "','" + sp.GiaBan + "')");
        }
        public int Delete(SanPham sp)
        {
            return db.ExcuteData("delete from sanpham where IDSanPham = "+sp.IDSanPham);
        }
        public int Delete(string id)
        {
            return db.ExcuteData("Delete from SANPHAM where IDSanPham = '"+id+"'");
        }
        public int Update(SanPham sp)
        {
            return db.ExcuteData("update sanpham set Ten = '"+sp.Ten+"', GiaBan = '"+sp.GiaBan+"' where IDSanPham = '"+sp.IDSanPham+"'");
        }
        public List<string> GetList(string column)
        { 
            return db.GetDataInColumn("sanpham", column); 
        }
        public string GetLastID(string query)
        {
            return db.GetLastId(query);
        }
        
    }
}
