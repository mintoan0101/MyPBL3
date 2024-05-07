using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class NhaPhanPhoiDAO
    {
        DBConnection db = new DBConnection();
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
    }
}
