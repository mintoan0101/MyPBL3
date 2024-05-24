using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DataAccessLayer
{
    public class ChiTietHoaDonDAO
    {
        DBConnection db = new DBConnection();
        PBL3Entities pbl = new PBL3Entities();

        private static ChiTietHoaDonDAO _Instance;
        public static ChiTietHoaDonDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ChiTietHoaDonDAO();
                }
                return _Instance;
            }
            private set { }
        }
        private ChiTietHoaDonDAO()
        {

        }
        public int Insert(ChiTietHoaDon cthd)
        {
            try
            {
                pbl.ChiTietHoaDons.Add(cthd);
                pbl.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public List<dynamic> GetData(string ID)
        {
            var li = pbl.ChiTietHoaDons.Where(p => p.IDHoaDon == ID)
                                       .Select(p => new { p.ChiTietSanPham.SanPham.Ten, p.SoLuong, p.ChiTietSanPham.SanPham.GiaBan });
            return li.ToList<dynamic>();
        }

    }
}
