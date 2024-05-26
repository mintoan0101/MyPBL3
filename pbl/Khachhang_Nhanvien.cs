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
                ThemKhachHang f = new ThemKhachHang(r.Cells["SDT"].Value.ToString());
                f.isEdit = true;
                f.kh = KhachHangBUS.Instance.GetKhachHangBySDT(r.Cells[0].Value.ToString());
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng bạn muốn chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string txt = txt_timkiem.Text;
            string phanloai = cb_thuoctinh.SelectedItem.ToString();
            string boloc = cbb_BoLoc.SelectedItem.ToString();   
            dataGridView1.DataSource = KhachHangBUS.Instance.Search(txt, phanloai, boloc);
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns[0].Width = 90;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].Width = 70;
            }
        }

        public void Load_Thuoc_Tinh()
        {
            cb_thuoctinh.Items.Add("SĐT");
            cb_thuoctinh.Items.Add("Tên");
            cb_thuoctinh.SelectedItem = "SĐT";
        }
        public void Load_BoLoc()
        {
            cbb_BoLoc.Items.Add("< 500k");
            cbb_BoLoc.Items.Add("500k - 1 triệu");
            cbb_BoLoc.Items.Add("1 - 5 triệu");
            cbb_BoLoc.Items.Add("5 - 17 triệu");
            cbb_BoLoc.Items.Add(" > 17 triệu");
            cbb_BoLoc.Items.Add("Tất cả");
            cbb_BoLoc.SelectedItem = "Tất cả";
        }
       

     
    }
}
