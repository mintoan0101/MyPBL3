using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl
{
    public class HoaDon
    {
        private string IDHoaDon {  get; set; }
        private string IDNhanVien { get; set; }
        private DateTime NgayTaoHoaDon { get; set; }
        private string SDTKhachHang {  get; set; }
        private double TongTien {  get; set; }
        private List<ChiTietHoaDon> listChiTietHoaDon { get; set; }
    }
}
