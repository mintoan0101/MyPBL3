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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pbl
{
    public partial class Quanlynhanvien : Form
    {
        NhanVienBUS nhanvienbus = new NhanVienBUS();
        //CÁC HÀM KHỞI TẠO CƠ BẢN
        public Quanlynhanvien()
        {
            InitializeComponent();
        }
        private void Quanlynhanvien_Load(object sender, EventArgs e)
        {
            Load_DS_Nhan_Vien();
            Load_Name_Column();
            Load_Chuc_Vu();
            
        }
        //CÁC HÀM XỬ LÍ SỰ KIỆN
        private void button4_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên " + row.Cells[2].Value.ToString(),"Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(res == DialogResult.Yes)
                {
                    if (nhanvienbus.Delete(row.Cells[0].Value.ToString())>0)
                    {
                        MessageBox.Show("Đã xóa thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemNhanvien f = new ThemNhanvien();
            f.isEdit = false;
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ThemNhanvien f = new ThemNhanvien();
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                f.idnv = row.Cells[0].Value.ToString();
                f.isEdit = true;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DatLaiMatKhau f = new DatLaiMatKhau();
            f.ShowDialog();
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            Hien_Thi_Tim_Kiem();
        }
        //CÁC HÀM BỔ TRỢ
        public void Load_DS_Nhan_Vien()
        {
            dataGridView1.DataSource = nhanvienbus.GetData();
        }
        public void Load_Name_Column()
        {
            List<string> ds = nhanvienbus.GetNameColumns();
            foreach (string s in ds)
            {
                if (s != "Nam")
                {
                    cb_tencot.Items.Add(s);
                }
            }
            cb_tencot.Items.Add("Nam");
            cb_tencot.Items.Add("Nữ");
            cb_tencot.SelectedItem = "IDNhanVien";
        }
        public void Load_Chuc_Vu()
        {
            cb_timkiem.Items.Add("Tất Cả");
            cb_timkiem.Items.Add("Thu Ngân");
            cb_timkiem.Items.Add("Bảo Vệ");
            cb_timkiem.Items.Add("Tạp Vụ");
            cb_timkiem.SelectedItem = "Tất Cả";
        }
        public void Hien_Thi_Tim_Kiem()
        {
            string tencot = cb_tencot.Text;
            string tenthuoctinh = cb_timkiem.Text;
            string timkiem = txt_timkiem.Text;
            string sql = "select * from nhanvien where ";
            if(tenthuoctinh == "Tất Cả")
            {
                if(timkiem == "")
                {
                    sql = sql.Substring(0,23);
                }
                else
                {
                    sql += tencot + " LIKE '%" + timkiem + "%'";
                }
            }
            else
            {
                if(timkiem =="")
                {
                    sql += " ViTri = '" + tenthuoctinh + "'";
                }
                else
                {
                    sql +=tencot + "LIKE '%"+timkiem+ "%' and ViTri = '" + tenthuoctinh + "'";
                }
            }
            dataGridView1.DataSource = nhanvienbus.GetData(sql);
        }

       
    }
}
