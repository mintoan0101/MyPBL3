using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class HoaDon
    {
        public string IDHoaDon {  get; set; }
        public string IDNhanVien { get; set; }
        public DateTime NgayTaoHoaDon { get; set; }
        public string IDKhachHang {  get; set; }
        public double ChietKhau { get; set; }
        public double TongTien {  get; set; }
        public List<ChiTietHoaDon> listChiTietHoaDon { get; set; }
    }
}
