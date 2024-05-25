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
    public partial class ThemNhanvien : Form
    {
        NhanVienBUS nvbus = new NhanVienBUS();
        TaiKhoanBUS tkbus = new TaiKhoanBUS();
        NhanVien nv = new NhanVien();
        TaiKhoan tk = new TaiKhoan();
        public string idnv { get; set; }
        public bool isEdit { get; set; }
        public ThemNhanvien()
        {
            InitializeComponent();
        }

        private void ThemNhanvien_Load(object sender, EventArgs e)
        {
            txt_idtk.Enabled = false;
            txt_idnv.Enabled = false;
            if (isEdit)
            {
                Load_Thong_Tin_Nhan_Vien();
            }
            else
            {
  
                cb_vitri.SelectedItem = "Thu Ngân";
                Hien_Thi_ID_Tu_Dong();
            }
        }
        //CÁC HÀM SỰ KIỆN
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                Luu_Nhan_Vien();
            }
            else
            {
                Them_Nhan_Vien();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txt_hovaten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_diachi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_cccd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_sdt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_tendangnhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tendangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_matkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_luong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_ok.PerformClick();
            }
        }
        //CÁC HÀM BỔ TRỢ
        //Thêm Nhân Viên
        public void Them_Nhan_Vien()
        {
            if (Kiem_Tra_Day_Du_Thong_Tin())
            {
                //Thêm các thông tin tài khoảng trước
                tk.IDTaiKhoan = txt_idtk.Text;
                tk.TenTaiKhoan = txt_tendangnhap.Text;
                tk.MatKhau = txt_matkhau.Text;
                if (tkbus.Insert(tk) > 0)
                {
                    //Rồi thêm các thông tin bên nhân viên
                    nv.TenNhanVien = txt_hovaten.Text;
                    nv.IDNhanVien = txt_idnv.Text;
                    nv.DiaChi = txt_diachi.Text;
                    nv.NgaySinh = dateTimePicker1.Value;
                    nv.Nam = (rad_nam.Checked) ? true : false;
                    nv.SoDienThoai = txt_sdt.Text;
                    nv.IDTaiKhoan = txt_idtk.Text;
                    nv.MucLuong = int.Parse(txt_luong.Text);
                    nv.CCCD = txt_cccd.Text;
                    if (nvbus.Insert(nv) > 0)
                    {
                        MessageBox.Show("Đã thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public bool Kiem_Tra_Day_Du_Thong_Tin()
        {
        
                if (txt_diachi.Text != "" &&
                    txt_email.Text != "" &&
                    txt_hovaten.Text != "" &&
                    txt_matkhau.Text != "" &&
                    txt_tendangnhap.Text != ""&&
                    (rad_nam.Checked == true || rad_nu.Checked == true) 
                 )
                {
                    return true;
                }
            
            return false;
        }
       
        public void Hien_Thi_ID_Tu_Dong()
        {
            //Lấy ID cuối của Nhân Viên
            string lastid_nv = nvbus.GetLastID();
            int l_nv = lastid_nv.Length;
            int num_nv = int.Parse(lastid_nv.Substring(l_nv - 2)) + 1;
            txt_idnv.Text = "NV" + Num_ID(num_nv);
            //Lấy ID cuối Tài khoản
            string lastid_us = tkbus.GetLastID();
            int l_us = lastid_us.Length;
            int num_us = int.Parse(lastid_us.Substring(l_us - 2)) + 1;
            txt_idtk.Text = "US" + Num_ID(num_us);
        }
        public string Num_ID(int num)
        {
            if (num <= 9)
            {
                return "0" + num;
            }
            return num + "";
        }
        //Sửa Nhân Viên
       public void Load_Thong_Tin_Nhan_Vien()
        {
            DataTable dt = nvbus.GetData("select * from nhanvien join taikhoan on nhanvien.IDTaiKhoan = taikhoan.IDTaiKhoan " +
                "where IDNhanVien = '"+idnv+"'");
            DataRow row = dt.Rows[0];
            txt_idnv.Text = idnv;
            txt_idtk.Text = row[1].ToString();
            txt_hovaten.Text = row[2].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(row[3].ToString());
            if (row[4].ToString() =="True")
            {
                rad_nam.Checked = true;
            }
            else
            {
                rad_nu.Checked = true;
            }
            cb_vitri.SelectedItem = row[5].ToString();
            txt_email.Text = row[6].ToString();
            txt_cccd.Text = row[7].ToString();
            txt_sdt.Text = row[8].ToString();
            txt_luong.Text = row[9].ToString();
            txt_diachi.Text = row[10].ToString();
            txt_tendangnhap.Text = row[12].ToString();
            txt_matkhau.Text = row[13].ToString();
        }
       //public DateTime SetStringToDate(string date)
       // {
       //     string date2 = date.Substring(0, 10);
       //     string[] parts = date2.Split('/');
       //     int y = int.Parse(parts[2]);
       //     int m = int.Parse(parts[1]);
       //     int d = int.Parse(parts[0]);
       //     return new DateTime(y, m, d);

       // }
        public void Luu_Nhan_Vien()
        {
            if(Kiem_Tra_Day_Du_Thong_Tin())
            {
                //Lưu thông tin tài khoản trước
                tk.IDTaiKhoan = txt_idtk.Text;
                tk.TenTaiKhoan = txt_tendangnhap.Text;
                tk.MatKhau = txt_matkhau.Text;
                if( tkbus.Update(tk)>0)
                {
                    //Rồi lưu thông tin nhân viên
                    nv.IDNhanVien = txt_idnv.Text;
                    nv.IDTaiKhoan = txt_idtk.Text;
                    nv.TenNhanVien = txt_hovaten.Text;
                    nv.NgaySinh = dateTimePicker1.Value;
                    nv.Nam = (rad_nam.Checked == true) ? true : false;
                    nv.Email = txt_email.Text;
                    nv.CCCD = txt_cccd.Text;
                    nv.SoDienThoai = txt_sdt.Text;
                    nv.MucLuong = int.Parse(txt_luong.Text);
                    nv.DiaChi = txt_diachi.Text;
                    if(nvbus.Update(nv)>0)
                    {
                        MessageBox.Show("Đã chỉnh sửa thông tin nhân viên thành công","Thôn báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Close();
                    }
                }
              
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
