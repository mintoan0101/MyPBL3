using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
     public class SanPham
    {
        public string IDSanPham {  get; set; }
        public string Ten { get; set; }
        public string PhanLoai {  get; set; }
        public double GiaBan { get; set; }
        public bool isDelete { get; set; }
    }
}
