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
    public partial class Themsanpham : Form
    {
        SanPhamBUS sanphambus = new SanPhamBUS();
        public bool isEdit { get; set; }
        public string idsanpham {  get; set; }
        public string phanloai {  get; set; }
        public string tensanpham { get; set; }
        public string giaban { get; set; }
        //CÁC HÀM KHỞI TẠO CƠ BẢN
        public Themsanpham()
        {
            InitializeComponent();
           
        }
        private void Themsanpham_Load(object sender, EventArgs e)
        {
            Load_Phan_Loai();
            if(isEdit)
            {
                cb_phanloai.Enabled = false;
                Load_Thong_Tin();
            }
       
        }
        //CÁC HÀM XỬ LÍ SỰ KIỆN
       
        private void btn_ok_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txt_tensp.Text) &&
                !string.IsNullOrEmpty(cb_phanloai.SelectedItem.ToString()) &&
                !string.IsNullOrEmpty(txt_giatien.Text))
            {
                if (isEdit)
                {
                    Chinh_Sua_Thong_Tin();
                }
                else
                {
                    Them_San_Pham(San_Pham_Can_Them());
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cb_phanloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hien_Thi_ID_Tu_Dong(cb_phanloai.SelectedItem.ToString());
        }
        private void txt_tensp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        //CÁC HÀM BỔ TRỢ
        public void Load_Phan_Loai()
        {
            HashSet<string> list = sanphambus.GetSeperatedDataByColumn("PhanLoai");
            foreach (string s in list) 
            {
                cb_phanloai.Items.Add(s);                             
            }
        }
        public void Hien_Thi_ID_Tu_Dong(string ten_danh_muc)
        {
            string id = "";
            string last_id = sanphambus.GetLastID(ten_danh_muc);
            string prefix = last_id.Substring(0, 1); // Lấy ký tự đầu tiên
            int number = int.Parse(last_id.Substring(1))+1;//Lấy các kí tự còn lại và ép kiểu
            if (number <= 9)
            {
                id += prefix + "0" + number;
            }
            else
            {
                id += prefix + number;
            }
            lbl_id.Text = id;
        }
        public SanPham San_Pham_Can_Them()
        {
            SanPham sp = new SanPham();
            sp.IDSanPham = lbl_id.Text;
            sp.Ten = txt_tensp.Text;
            sp.PhanLoai = cb_phanloai.SelectedItem.ToString();
            sp.GiaBan = decimal.Parse(txt_giatien.Text);
            return sp;
        }
        public bool CheckGiaSanPham()
        {
            double res = 0;
            if(double.TryParse(txt_giatien.Text, out res))
            {
                return true;
            }
            return false;
        }
        public void Them_San_Pham(SanPham sp)
        {
            if(CheckGiaSanPham())
            {
                if(sanphambus.Insert(sp) == 1)
                {
                    MessageBox.Show("Đã thêm sản phẩm thành công");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng giá tiền");
            }
            
        }
  
       public void Load_Thong_Tin()
        {
            lbl_id.Text = idsanpham;
            cb_phanloai.SelectedItem = phanloai;
            txt_tensp.Text = tensanpham;
            txt_giatien.Text = giaban; 
        }
        public void Chinh_Sua_Thong_Tin()
        {
            SanPham sp = new SanPham();
            sp.IDSanPham = idsanpham;
            sp.PhanLoai = phanloai;
            sp.Ten = txt_tensp.Text;
            sp.GiaBan = decimal.Parse(txt_giatien.Text);
            if(sanphambus.Update(sp) == 1)
            {
                MessageBox.Show("Đã sửa đổi thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa đỏi không thành công");
            }
        }
    }
}
