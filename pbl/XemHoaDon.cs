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
    public partial class XemHoaDon : Form
    {
        private HoaDon hd;
        public XemHoaDon(HoaDon hd)
        {
            InitializeComponent();
            this.hd = hd;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void XemHoaDon_Load(object sender, EventArgs e)
        {
            lb_ID.Text = hd.IDHoaDon;
            lb_DateTime.Text = hd.NgayTaoHoaDon.ToString();
            lb_KhachHang.Text = "ID Khách Hàng: " + hd.IDKhachHang;
            lb_NhanVien.Text = "ID Nhân Viên: " + hd.IDNhanVien;
            lb_GiamGia.Text = hd.ChietKhau.ToString();
            lb_Tong.Text = hd.TongTien.ToString();
            lb_ThanhTien.Text = (hd.TongTien + hd.ChietKhau).ToString();
            dataGridView2.DataSource = ChiTietHoaDonBUS.Instance.GetData(hd.IDHoaDon);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
