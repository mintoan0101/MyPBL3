using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DataAccessLayer
{
    public class NhaPhanPhoiDAO
    {
        DBConnection db = new DBConnection();
        public DataTable GetData()
        {
            return db.GetData("select * from nhaphanphoi");
        }
        public DataTable GetData(string query)
        {
            return db.GetData(query);
        }
        public int Insert(NhaPhanPhoi p)
        {
            return db.ExcuteData("insert into nhaphanphoi(IDNhaPhanPhoi,TenNhaPhanPhoi,SoDienThoai,DiaChi) values " +
                "('"+p.IDNhaPhanPhoi+"','"+p.TenNhaPhanPhoi+"','"+p.SoDienThoai+"','"+p.DiaChi+"') ");
        }
        public int Delete(string id)
        {
            return db.ExcuteData("delete from nhaphanphoi where IDNhaPhanPhoi = '"+id+"'");
        }
        public int Update(NhaPhanPhoi p)
        {
            return db.ExcuteData("update nhaphanphoi set TenNhaPhanPhoi = '" + p.TenNhaPhanPhoi + "',SoDienThoai = '" + p.SoDienThoai + "',DiaChi = '" + p.DiaChi + "' where IDNhaPhanPhoi = '" + p.IDNhaPhanPhoi + "'"); 
        }
        public List<string> GetName()
        {
            return db.GetDataInColumn("nhaphanphoi","TenNhaPhanPhoi");
        }

        public string GetNameByID(string ID)
        {
            return db.GetStringDataCell("nhaphanphoi","TenNhaPhanPhoi"," IDNhaPhanPhoi = '"+ID+"'");
        }
        public string GetIDByName(string name)
        {
            return db.GetStringDataCell("nhaphanphoi", "IDNhaPhanPhoi", " TenNhaPhanPhoi = '" + name + "'");
        }
        public List<string> GetColumnsName()
        {
            return db.getNameColumns("nhaphanphoi");
        }
        public string GetLastID()
        {
            return db.GetLastId("select * from nhaphanphoi");
        }
    }
}
