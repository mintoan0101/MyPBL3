using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class NhanVien
    {
        public string IDNhanVien {  get; set; }
        public string IDTaiKhoan { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; } // true: Nam, false: Nữ
        public string ViTri { get; set; }
        public int MucLuong { get; set; }
        public string CCCD { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set;}
        public string Email { get; set; }
        public string SetDinhDangNgaySinh()
        {
            string date = NgaySinh.ToString().Substring(0, 10);
            string[] parts = date.Split('/');
            int y = int.Parse(parts[2]);
            int m = int.Parse(parts[1]);
            int d = int.Parse(parts[0]);
            return y + "-" + m + "-" + d;
        }
    }
}
