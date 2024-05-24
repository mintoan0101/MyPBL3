using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;
using System.Windows.Forms;

namespace pbl
{
    public partial class Them_SuaChiTietSanPham : Form
    {
        public string IDChiTiet { get; set; }
        public string IDSanPham { get; set; }
        public string TenNPP { get; set; }
        public string HSD { get; set; }
        public int SoLuong { get; set; }
        public bool isEdit { get; set; }
        ChiTietSanPhamBUS bus = new ChiTietSanPhamBUS();
        NhaPhanPhoiBUS nppbus = new NhaPhanPhoiBUS();
        public Them_SuaChiTietSanPham()
        {
            InitializeComponent();
        }

        private void Them_SuaChiTietSanPham_Load(object sender, EventArgs e)
        {
            Load_Nha_Phan_Phoi();

            if(isEdit == true)
            {
                Load_Thong_Tin_Chi_Tiet();
            }
            else
            {
                Load_IDChiTiet();
             
            }
        }
        //CÁC HÀM XỬ LÍ SỰ KIỆN
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(CheckSoLuongHopLe())
            {
                if (isEdit == true)
                {
                    if (bus.Update(IDChiTiet, GetCTSP()) == 1)
                    {
                        MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {

                    if (bus.Insert(GetCTSP()) == 1)
                    {
                        MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Số lượng nhập vào không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //CÁC HÀM BỔ TRỢ
        public void Load_Thong_Tin_Chi_Tiet()
        {
            lbl_id.Text = IDChiTiet;
            cb_npp.SelectedItem = TenNPP;
            string hsd = HSD.Substring(0, 10);
            string[] parts = hsd.Split('/');
            int y = int.Parse(parts[2]);
            int m = int.Parse(parts[1]);
            int d = int.Parse(parts[0]);
            DateTime dateTimeValue = new DateTime(y, m, d);
            dateTimePicker1.Value = dateTimeValue;
            txt_soluong.Text = SoLuong + "";
        }
        public void Load_Nha_Phan_Phoi()
        {
            List<string> ds = nppbus.GetName();
            foreach(string s in ds)
            {
                cb_npp.Items.Add(s);
            }
        }
  
        public void Load_IDChiTiet()
        {
            string f = IDSanPham.Substring(0,1);
            int countid = bus.CountID(f)+1;
            lbl_id.Text = "CT" + f + countid;
        }
        public ChiTietSanPham GetCTSP()
        {
            ChiTietSanPham ctsp = new ChiTietSanPham();
            ctsp.IDChiTiet = lbl_id.Text;
            ctsp.IDNhaPhanPhoi = nppbus.GetIDByName(cb_npp.SelectedItem.ToString());
            ctsp.IDSanPham = IDSanPham;
            string[] parts = dateTimePicker1.Value.ToString().Substring(0, 10).Split('/');
            //ctsp.HanSuDung = parts[2] + "-" + parts[1] + "-" + parts[0];
            ctsp.HanSuDung = dateTimePicker1.Value;
            ctsp.SoLuong = int.Parse(txt_soluong.Text) ;
            return ctsp;
        }
        public bool CheckSoLuongHopLe()
        {
            int res = 0;
            if(int.TryParse(txt_soluong.Text, out res))
            {
                return true;
            }
            return false;
        }
        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
