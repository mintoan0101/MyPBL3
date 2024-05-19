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
    public partial class QuanLyNhaPhanPhoi : Form
    {
        NhaPhanPhoiBUS bus = new NhaPhanPhoiBUS();
        
        public QuanLyNhaPhanPhoi()
        {
            InitializeComponent();
        }
        private void QuanLyNhaPhanPhoi_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Load_NhaPhanPhoi();
            Load_ThuocTinh();
        }
        //CÁC HÀM XỬ LÍ SỰ KIỆN
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            Hien_Thi_Tim_Kiem();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ThemNhaPhanPhoi f = new ThemNhaPhanPhoi();
                f.isEdit = true;
                f.npp = new NhaPhanPhoi();
                f.npp.IDNhaPhanPhoi = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                f.npp.TenNhaPhanPhoi = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                f.npp.SoDienThoai = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                f.npp.DiaChi = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà phân phối cần chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            ThemNhaPhanPhoi f = new ThemNhaPhanPhoi();
            f.isEdit = false;
            f.ShowDialog();
        }

    

       
        //CÁC HÀM BỔ TRỢ
        public void Load_NhaPhanPhoi()
        {
            dataGridView1.DataSource = bus.GetData();
        }
        public void Load_ThuocTinh()
        {
            List<string> ds_thuoctinh = bus.GetColumnsName();
            foreach (string item in ds_thuoctinh)
            {
                cb_thuoctinh.Items.Add(item);
            }
            cb_thuoctinh.SelectedItem = "SoDienThoai";
        }
      
        public void Hien_Thi_Tim_Kiem()
        {
            string ten_tim_kiem = txt_timkiem.Text;
            string ten_thuoc_tinh = cb_thuoctinh.SelectedItem.ToString();
            if(ten_tim_kiem == "")
            {
                Load_NhaPhanPhoi();
            }
            else
            {
                dataGridView1.DataSource = bus.GetData("select * from nhaphanphoi where "+ten_thuoc_tinh+" LIKE '%"+ten_tim_kiem+"%'");
            }
        }
 
    }
}
