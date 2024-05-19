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
    public partial class Khachhang_Nhanvien : Form
    {
        KhachHangBUS bus = new KhachHangBUS();
  
        //CÁC HÀM KHỞI TẠO CƠ BẢN
        public Khachhang_Nhanvien()
        {
            InitializeComponent();
        }
        private void Khachhang_Nhanvien_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Load_Khach_Hang();
            Load_Thuoc_Tinh();
            Load_BoLoc();
        }
        //CÁC HÀM XỬ LÍ SỰ KIỆN
        private void btn_them_Click(object sender, EventArgs e)
        {
            ThemKhachHang f = new ThemKhachHang(null);
            f.isEdit = false;
            f.ShowDialog();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dataGridView1.SelectedRows[0];
                ThemKhachHang f = new ThemKhachHang(null);
                f.isEdit = true;
                f.kh = new KhachHang();
                f.kh.ID = r.Cells[0].Value.ToString() ;
                f.kh.Ten = r.Cells[1].Value.ToString();
                f.kh.SDT = r.Cells[2].Value.ToString();
                f.kh.Diem = int.Parse(r.Cells[3].Value.ToString());
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng bạn muốn chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            Hien_Thi_Tim_Kiem();
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {

            if(dataGridView1.SelectedRows.Count>0)
            {   
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng có ID là "+id, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    if (bus.Delete(id) > 0)
                    {
                        MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng bạn muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
        public void Load_BoLoc()
        {

        }
        public void Hien_Thi_Tim_Kiem()
        {
            string ten_tim_kiem = txt_timkiem.Text;
            string ten_thuoc_tinh = cb_thuoctinh.SelectedItem.ToString();
            if(ten_tim_kiem == "")
            {
                Load_Khach_Hang();
            }
            else
            {
               dataGridView1.DataSource =  bus.GetData("select * from khachhang where "+ten_thuoc_tinh+" LIKE '%"+ten_tim_kiem+"%'");   
            }
        }

     
    }
}
