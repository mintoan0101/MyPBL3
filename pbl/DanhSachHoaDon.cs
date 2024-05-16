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
    public partial class DanhSachHoaDon : Form
    {
        public DanhSachHoaDon()
        {
            InitializeComponent();
            dataGridView1.DataSource = HoaDonBUS.Instance.GetData();
            Load_Bo_Loc();
        }

        public void Load_Bo_Loc()
        {
            cbb_BoLoc.Items.Add("Tất Cả");
            cbb_BoLoc.Items.Add("< 100K");
            cbb_BoLoc.Items.Add("100K - 500K");
            cbb_BoLoc.Items.Add("500K - 1000K");
            cbb_BoLoc.Items.Add("> 1000K");
            cbb_BoLoc.SelectedItem = "Tất Cả";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = txt_search.Text;
            string phanloai = cbb_PhanLoai.SelectedItem.ToString();
            string boloc = cbb_BoLoc.SelectedItem.ToString();

            double minTotal = -1;
            double maxTotal = -1;

            switch (boloc)
            {
                case "< 100K":
                    maxTotal = 100;
                    break;
                case "100K - 500K":
                    minTotal = 100;
                    maxTotal = 500;
                    break;
                case "500K - 1000K":
                    minTotal = 500;
                    maxTotal = 1000;
                    break;
                case "> 1000K":
                    minTotal = 1000;
                    break;
                default:
                    break;
            }

            dataGridView1.DataSource = HoaDonBUS.Instance.Search(search, phanloai, minTotal, maxTotal);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        public HoaDon GetHoaDonFromDataGridView(DataGridView dgv, int rowIndex)
        {
            HoaDon hoaDon = new HoaDon();

            if (!dgv.Rows[rowIndex].IsNewRow)
            {
                DataGridViewRow row = dgv.Rows[rowIndex];

                hoaDon = new HoaDon
                {
                    IDHoaDon = row.Cells["IDHoaDon"].Value.ToString(),
                    NgayTaoHoaDon = DateTime.Parse(row.Cells["NgayTaoHoaDon"].Value.ToString()),
                    TongTien = double.Parse(row.Cells["TongTien"].Value.ToString()),
                    IDNhanVien = row.Cells["IDNhanVien"].Value.ToString(),
                    IDKhachHang = row.Cells["IDKhachHang"].Value.ToString()
                };
            }

            return hoaDon;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            HoaDon hd = GetHoaDonFromDataGridView(dataGridView1, e.RowIndex);
            XemHoaDon f = new XemHoaDon(hd);
            f.ShowDialog();
        }
    }
}
