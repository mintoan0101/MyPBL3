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
    public partial class ThemNhaPhanPhoi : Form
    {
        public bool isEdit { get; set; }
        public NhaPhanPhoi npp { get; set; }
        NhaPhanPhoiBUS bus = new NhaPhanPhoiBUS();
        public ThemNhaPhanPhoi()
        {
            InitializeComponent();
        }
        private void ThemNhaPhanPhoi_Load(object sender, EventArgs e)
        {

            if(isEdit)
            {
                Load_Thong_Tin();
            }
            else
            {
                Load_ID_TuDong();
            }
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txt_ten.Text) &&
               !string.IsNullOrEmpty(this.txt_sdt.Text) &&
               !string.IsNullOrEmpty(this.txt_diachi.Text) &&
               !string.IsNullOrEmpty(this.txt_id.Text)
              )
            {
                if(CheckSDT())
                {
                    if (isEdit)
                    {
                        if (Cap_Nhat_Thong_tin())
                        {
                            MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    { 
                        if (Them_Nha_Phan_Phoi())
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

     
        //CÁC HÀM BỔ TRỢ
        public NhaPhanPhoi GetNPP()
        {
            NhaPhanPhoi p = new NhaPhanPhoi(); 
            p.IDNhaPhanPhoi = txt_id.Text;
            p.TenNhaPhanPhoi = txt_ten.Text;
            p.SoDienThoai = txt_sdt.Text.Trim();
            p.DiaChi = txt_diachi.Text;
            return p;
        }
        public void Load_ID_TuDong()
        {
            string last_id = bus.GetLastID();
            int num = int.Parse(last_id.Substring(last_id.Length - 2))+1;
            if(num < 10)
            {
                txt_id.Text = "NPP0" + num;
            }
            else
            {
                txt_id.Text = "NPP" + num;
            }
        }
        public bool Them_Nha_Phan_Phoi()
        {
            if (bus.Insert(GetNPP()) > 0)
            {
                return true;
            }
            return false;
        }
        public void Load_Thong_Tin()
        {
            txt_id.Text = npp.IDNhaPhanPhoi;
            txt_ten.Text = npp.TenNhaPhanPhoi;
            txt_sdt.Text = npp.SoDienThoai;
            txt_diachi.Text = npp.DiaChi;
        }
        public bool Cap_Nhat_Thong_tin()
        {
            if(bus.Update(GetNPP())>0)
            {
                return true;
            }
            return false;
        }
        public bool CheckSDT()
        {
            if(txt_sdt.Text.Length!=10)
            {
                return false;
            }
            return true;
        }
    }
}
