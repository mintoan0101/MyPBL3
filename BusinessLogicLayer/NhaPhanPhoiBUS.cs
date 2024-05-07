using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class NhaPhanPhoiBUS
    {
        NhaPhanPhoiDAO dao = new NhaPhanPhoiDAO();
        public List<string> GetName()
        {
            return dao.GetName();
        }
        public string GetNameByID(string ID) {
            return dao.GetNameByID(ID);
        }
        public string GetIDByName(string Name) {
            return dao.GetIDByName(Name);
        }
    }
}
