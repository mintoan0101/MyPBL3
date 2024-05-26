using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class ChiTietSanPham_View
    {
        public string IDChiTiet { get; set; }
        public string PhanLoai { get; set; }
        public string Ten { get; set; }
        public DateTime HanSuDung { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuong { get; set; }
        public bool Check { get; set; }
    }
    public class SoLuongCTSP
    { 
        public string IDChiTiet { get; set; }
        public int SoLuong { get; set; }
    }
}
