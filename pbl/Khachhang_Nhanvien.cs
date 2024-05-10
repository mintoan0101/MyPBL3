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

namespace pbl
{
    public partial class Khachhang_Nhanvien : Form
    {
        //CÁC HÀM KHỞI TẠO CƠ BẢN
        public Khachhang_Nhanvien()
        {
            InitializeComponent();
        }
        private void Khachhang_Nhanvien_Load(object sender, EventArgs e)
        {
            Load_Khach_Hang();
            Load_Thuoc_Tinh();
        }
        //CÁC HÀM XỬ LÍ SỰ KIỆN
        private void button3_Click(object sender, EventArgs e)
        {
            ThemKhachHang f = new ThemKhachHang();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemKhachHang f = new ThemKhachHang();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
        //CÁC HÀM BỔ TRỢ
        public void Load_Khach_Hang()
        {
            dataGridView1.DataSource = KhachHangBUS.Instance.GetData();
        }
        public void Load_Thuoc_Tinh()
        {
            cb_thuoctinh.Items.Add("SDT");
            cb_thuoctinh.Items.Add("Ten");
            cb_thuoctinh.SelectedItem = "SDT";
        }
 
    }
}
