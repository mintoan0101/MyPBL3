using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class TaiKhoan
    {
        public string IDTaiKhoan {  get; set; }
        public string TenTaiKhoan{  set; get; }
        public string MatKhau {  set; get; }
        public bool isAdmin { set; get; }
    }
}
