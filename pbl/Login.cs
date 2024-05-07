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
    public partial class Login : Form
    {
        TaiKhoanBUS taikhoanbus = new TaiKhoanBUS();
        //CÁC HÀM KHỞI TẠO
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
        //CÁC HÀM XỬ LÍ SỰ KIỆN
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if(Kiem_Tra_Nhap())
            {
                if(Kiem_Tra_Dang_Nhap())
                {
                    if (Kiem_Tra_QuyenAdmin())
                    {
                        MainFormAdmin f = new MainFormAdmin();
                        f.username = txt_username.Text;
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                        Clear();
                        
                    }
                    else
                    {
                        MainFormNhanVien f = new MainFormNhanVien();
                        f.username = txt_username.Text;

                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không chính xác");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            
        }
        //CÁC HÀM XỬ LÍ SỰ KIỆN
        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_dangnhap.PerformClick();
            }
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //CÁC HÀM BỔ TRỢ
        //Kiểm tra xem người có nhập cá thông tin đầy đủ không
        public bool Kiem_Tra_Nhap()
        {
            if(txt_username.Text != "" && txt_password.Text != "")
            {
                return true;
            }
            return false;
        }
        public bool Kiem_Tra_Dang_Nhap()
        {
                return taikhoanbus.CheckAccount(txt_username.Text, txt_password.Text);
        }
        public bool Kiem_Tra_QuyenAdmin()
        {
            return taikhoanbus.CheckAdmin(txt_username.Text);
        }
        public void Clear()
        {
            txt_password.Clear();
            txt_username.Clear();
        }
     
    }
}
