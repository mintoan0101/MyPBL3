using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class ChiTietSanPham
    {
        public string IDChiTiet {  get; set; }
        public string IDSanPham { get; set;}
        public string IDNhaPhanPhoi { get; set;}
        public string HanSuDung { get; set; }
        public int SoLuong {  get; set; }
    }
}
