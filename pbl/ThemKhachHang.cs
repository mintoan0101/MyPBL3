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
    public partial class ThemKhachHang : Form
    {
        public KhachHangBUS bus = new KhachHangBUS();
        public KhachHang kh { get; set; }
        public bool isEdit { get; set; }
        public ThemKhachHang(string sdt)
        {
            InitializeComponent();
            setGUI(sdt);
        }
        private void ThemKhachHang_Load(object sender, EventArgs e)
        {
            if(isEdit)
            {
                Load_Thong_Tin();
                txt_diem.Enabled = true;
            }
            else
            {
                Load_ID_TuDong();
                txt_diem.Enabled = false;
                txt_diem.Text = 0+"";
            }
        }
        private void setGUI(string sdt)
        {
            if (sdt != null)
            {
                KhachHang kh = KhachHangBUS.Instance.GetKhachHangBySDT(sdt);
                txt_sdt.Text = sdt;
                txt_ten.Text = kh.Ten;
            }
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txt_sdt.Text) &&
              !string.IsNullOrEmpty(this.txt_ten.Text))
            {
                if(CheckSDT())
                {
                    if(isEdit)
                    {
                        if (CheckDiem())
                        {
                            if (bus.Update(GetKH()) > 0)
                            {
                                MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng điền thông tin Điểm là một số dương và chia hết cho 10", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (bus.Insert(GetKH()) > 0)
                        {
                            MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại đúng 10 chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
           
            }
            else MessageBox.Show("Vui lòng điền đầy đủ thông tin","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public KhachHang GetKH()
        {
            KhachHang kh = new KhachHang();
            kh.ID = txt_id.Text;
            kh.SDT = txt_sdt.Text.Trim();
            kh.Ten = txt_ten.Text;
            kh.Diem = int.Parse(txt_diem.Text.Trim());
            return kh;
        }
        public void Load_ID_TuDong()
        {
            string last_id = bus.GetLastID();
            int num = int.Parse(last_id.Substring(last_id.Length - 2))+1;
            if(num <10)
            {
                txt_id.Text = "KH00" + num;
            }
            else if(num < 100 && num >= 10)
            {
                txt_id.Text = "KH0" + num;
            }
            else if (num >= 100 )
            {
                txt_id.Text = "KH" + num;
            }

        }
        public bool CheckSDT()
        {
            if (txt_sdt.Text.Length != 10)
            {
                return false;
            }
            return true;
        }
        public bool CheckDiem()
        {
            int res = 0;
            if(int.TryParse(txt_diem.Text, out res))
            {
                if (res > 0 && res%10 == 0)
                {
                    return true;
                }
            }
            return false;
        }
        public void Load_Thong_Tin()
        {
            txt_id.Text = kh.ID;
            txt_ten.Text = kh.Ten;
            txt_sdt.Text = kh.SDT;
            txt_diem.Text = kh.Diem+"";
        }
    }
}
