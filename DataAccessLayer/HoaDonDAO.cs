using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DataAccessLayer
{
    public class HoaDonDAO
    {
        DBConnection db = new DBConnection();
        PBL3Entities pbl = new PBL3Entities();

        private static HoaDonDAO _Instance;
        public static HoaDonDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new HoaDonDAO();
                }
                return _Instance;
            }
            private set { }
        }
        private HoaDonDAO()
        {

        }
        public List<dynamic> GetData()
        {
            var list = pbl.HoaDons.Select(p => new
            {
                p.IDHoaDon,
                p.NgayTaoHoaDon,
                p.IDNhanVien,
                p.IDKhachHang,
                p.ChietKhau,
                p.TongTien
            });
            return list.ToList<dynamic>();
        }

        public int Insert(HoaDon hd)
        {
            try
            {
                pbl.HoaDons.Add(hd);
                pbl.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public string GetLastID()
        {
            var li = pbl.HoaDons.OrderByDescending(p => p.IDHoaDon).FirstOrDefault().IDHoaDon;
            return li;
        }

        public List<HoaDon> Search(string txt, string phanloai, string boloc)
        {
            var query = pbl.HoaDons.Select(p => p);
            if (string.IsNullOrEmpty(txt) == false)
            {
                switch (phanloai)
                {
                    case "ID Hoá Đơn":
                        query = query.Where(hd => hd.IDHoaDon.Contains(txt));
                        break;
                    case "Ngày Tạo Hoá Đơn":
                        // Không thể sử dụng like trong LINQ to Entities với DateTime
                        break;
                    case "Nhân Viên":
                        query = query.Where(hd => hd.NhanVien.IDNhanVien.Contains(txt) || hd.NhanVien.TenNhanVien.Contains(txt));
                        break;
                    case "Khách Hàng":
                        query = query.Where(hd => hd.KhachHang.IDKhachHang.Contains(txt) || hd.KhachHang.Ten.Contains(txt));
                        break;
                    default:
                        break;
                }
            }

            if (boloc != "Tất Cả")
            {
                switch (boloc)
                {
                    case "< 100K":
                        query = query.Where(hd => hd.TongTien < 100);
                        break;
                    case "100K - 500K":
                        query = query.Where(hd => hd.TongTien >= 100 && hd.TongTien <= 500);
                        break;
                    case "500K - 1000K":
                        query = query.Where(hd => hd.TongTien >= 500 && hd.TongTien <= 1000);
                        break;
                    case "> 1000K":
                        query = query.Where(hd => hd.TongTien > 1000);
                        break;
                }
            }

            return query.ToList();
        }
       
    }
}

