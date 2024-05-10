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
    public partial class ThemHoadon : Form
    {
        private ChiTietSanPhamBUS ctspBUS = new ChiTietSanPhamBUS();
        private SanPhamBUS spBUS = new SanPhamBUS();
        public ThemHoadon()
        {
            InitializeComponent();
            Load_DS_San_Pham();
            Load_CBB_Sap_Xep();
            SetBill();
        }
        private void SetBill()
        {
            lb_DateTime.Text = DateTime.Now.ToString();
            lb_ID.Text = HoaDonBUS.Instance.SetID();
        }

        //List lưu tên các cột trong DataGridView
        public List<string> GetColumnNamesFromDataGridView(DataGridView dataGridView)
        {
            List<string> columnNames = new List<string>();
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                columnNames.Add(column.HeaderText);
            }
            return columnNames;
        }
        private void bt_Search_Click(object sender, EventArgs e)
        {
            string PhanLoai = cbb_PhanLoai.SelectedItem.ToString();
            string txt = txt_TimKiem.Text;
            if (PhanLoai != null && txt != null)
            {
                dataGridView1.DataSource = ctspBUS.Search(PhanLoai, txt);
            }   
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public void Load_DS_San_Pham()
        {
            string query = "SELECT " +
                           "chitietsanpham.IDChiTiet AS 'ID Chi Tiết', " +
                           "sanpham.Ten AS 'Tên Sản Phẩm', " +
                           "sanpham.PhanLoai AS 'Phân Loại', " +
                           "sanpham.GiaBan AS 'Giá Bán', " +
                           "chitietsanpham.SoLuong AS 'Số Lượng', " +
                           "chitietsanpham.HanSuDung AS 'Hạn Sử Dụng' " +
                           "FROM CHITIETSANPHAM chitietsanpham " +
                           "JOIN SANPHAM sanpham ON chitietsanpham.IDSanPham = sanpham.IDSanPham";
            dataGridView1.DataSource = ctspBUS.GetData2(query);
        }
        public void Load_CBB_Sap_Xep()
        {
            List<string> ColunmName = GetColumnNamesFromDataGridView (dataGridView1);
            cbb_SapXep.Items.Add("Tất Cả");
            foreach (string s in ColunmName)
            {
                cbb_SapXep.Items.Add(s);
            }
            cbb_SapXep.SelectedItem = "Tất Cả";
        }
     
        
        private void cbb_SapXep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
