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
    public class ChiTietHoaDonBUS
    {
        private static ChiTietHoaDonBUS _Instance;
        public static ChiTietHoaDonBUS Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ChiTietHoaDonBUS();
                }
                return _Instance;
            }
            private set { }
        }
        private ChiTietHoaDonBUS()
        {

        }

        public int Insert(ChiTietHoaDon cthd, string idHoaDon)
        {
            return ChiTietHoaDonDAO.Instance.Insert(cthd, idHoaDon);
        }

        public DataTable GetData(string ID)
        {
            return ChiTietHoaDonDAO.Instance.GetData(ID);
        }
    }
}
