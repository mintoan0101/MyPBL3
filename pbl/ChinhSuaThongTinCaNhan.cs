using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValueObject;

namespace pbl
{
    public partial class ChinhSuaThongTinCaNhan : Form
    {
        NhanVienBUS bus = new NhanVienBUS();
        public string username { get; set; }
        public ChinhSuaThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void ChinhSuaThongTinCaNhan_Load(object sender, EventArgs e)
        {
            Load_Thong_Tin_Ca_Nhan();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if(Kiem_Tra_Day_Du_Thong_Tin())
            {
                NhanVien nv = new NhanVien();
                nv.IDNhanVien = txt_id.Text;
                nv.TenNhanVien = txt_hovaten.Text;
                nv.Email = txt_email.Text;
                nv.SoDienThoai = txt_sdt.Text;
                nv.NgaySinh = dateTimePicker1.Value;
                nv.DiaChi = txt_diachi.Text;
                nv.CCCD = txt_cccd.Text;
                if(bus.UpdateByNhanVien(nv)>0)
                {
                    MessageBox.Show("Đã cập nhật thông tin cá nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void ChinhSuaThongTinCaNhan_KeyDown(object sender, KeyEventArgs e)
        {
            btn_luu.PerformClick();
        }
        //CÁC HÀM BỔ TRỢ
        public void Load_Thong_Tin_Ca_Nhan()
        {
            DataTable dt = bus.GetData("select * from nhanvien join taikhoan on nhanvien.IDTaiKhoan = taikhoan.IDTaiKhoan " +
                "where TenTaiKhoan = '"+username+"'");
            DataRow row = dt.Rows[0];
            txt_id.Text = row["IDNhanVien"].ToString();
            txt_hovaten.Text = row["TenNhanVien"].ToString();
            txt_email.Text = row["Email"].ToString();
            txt_sdt.Text = row["SoDienThoai"].ToString();
            dateTimePicker1.Value = SetStringToDate(row["NgaySinh"].ToString());
            if (row["Nam"].ToString() == "True")
            {
                rad_nam.Checked = true;
            }
            else
            {
                rad_nu.Checked = true;
            }
            txt_cccd.Text = row["CCCD"].ToString();
            txt_diachi.Text = row["DiaChi"].ToString();
        }
        public DateTime SetStringToDate(string date)
        {
            string date2 = date.Substring(0, 10);
            string[] parts = date2.Split('/');
            int y = int.Parse(parts[2]);
            int m = int.Parse(parts[1]);
            int d = int.Parse(parts[0]);
            return new DateTime(y, m, d);

        }
        public bool Kiem_Tra_Day_Du_Thong_Tin()
        {
            if(txt_email.Text != ""&&
                txt_id.Text != ""&&
                txt_hovaten.Text != ""&&
                txt_sdt.Text != ""&&
                txt_diachi.Text != ""&&
                txt_cccd.Text != "")
            {
                return true;
            }
            return false;
        }

      
    }
}
