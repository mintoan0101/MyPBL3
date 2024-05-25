using BusinessLogicLayer;
using DataAccessLayer;
using MySqlX.XDevAPI.Relational;
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
    public partial class ThemHoadon : Form
    {
        public string IDNhanVien;
        private KhachHang kh = new KhachHang(); 

        private ChiTietSanPhamBUS ctspBUS = new ChiTietSanPhamBUS();
        private SanPhamBUS spBUS = new SanPhamBUS();
        private NhanVienBUS nvBUS = new NhanVienBUS();
        private bool DaDoiDiem = new bool();
        public ThemHoadon()
        {
            InitializeComponent();
            Load_DS_San_Pham();
            SetBill();
            AddColumnsToDataGridView2();
            panel10.Visible = false;
            panel11.Visible = false;
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
            dataGridView1.DataSource = ctspBUS.GetData1();
        }

        private void AddColumnsToDataGridView2()
        {
            dataGridView2.Columns.Add("IDChiTiet", "IDChiTiet");
            dataGridView2.Columns.Add("Ten", "Ten");
            dataGridView2.Columns.Add("SoLuong", "SoLuong");
            dataGridView2.Columns.Add("ThanhTien", "ThanhTien");
            dataGridView2.ColumnHeadersVisible = true;
            dataGridView2.Columns["IDChiTiet"].Visible = false;
        }

        private void cbb_SapXep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_ThanhToan_Click(object sender, EventArgs e)
        {
            if (lb_Tong.Text != "0" && lb_IDKhachHang.Text != "ID:")
            {
                HoaDon hd = new HoaDon();
                hd.IDHoaDon = lb_ID.Text;
                hd.IDNhanVien = nvBUS.GetID(IDNhanVien);
                hd.IDKhachHang = lb_IDKhachHang.Text.Substring(4);
                hd.NgayTaoHoaDon = Convert.ToDateTime(lb_DateTime.Text);
                hd.ChietKhau = Convert.ToDouble(lb_GiamGia.Text);
                hd.TongTien = Convert.ToDouble(lb_Tong.Text);
                List<ChiTietHoaDon> listChiTietHoaDon = new List<ChiTietHoaDon>();
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon
                        {
                            IDHoaDon = hd.IDHoaDon,
                            IDChiTiet = row.Cells["IDChiTiet"].Value.ToString(),
                            SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value)
                        };
                        ChiTietSanPham chiTietSanPham = chiTietHoaDon.ChiTietSanPham;
                        listChiTietHoaDon.Add(chiTietHoaDon);
                        ctspBUS.Update(chiTietSanPham);
                    }
                        

                    
                }
                hd.ChiTietHoaDons = listChiTietHoaDon;
                HoaDonBUS.Instance.Insert(hd);
                foreach (ChiTietHoaDon chitiethoadon in hd.ChiTietHoaDons)
                {
                    ChiTietHoaDonDAO.Instance.Insert(chitiethoadon);
                }
                int diem = Convert.ToInt32(Convert.ToDouble(lb_Tong.Text)/20);
                kh.Diem += diem;
                KhachHangBUS.Instance.Update( kh);
                MessageBox.Show("Thanh toán thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Hoá đơn không hợp lệ");
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sdt = txt_STDKhachHang.Text;
            kh = KhachHangBUS.Instance.GetKhachHangBySDT(sdt);
            if (kh != null)
            {
                panel10.Visible = true;
                panel11.Visible = true;
                lb_IDKhachHang.Text = "ID: " + kh.IDKhachHang;
                lb_TenKhachHang.Text = "Tên: " + kh.Ten;
                lb_DiemThuong.Text = "Điểm Thưởng: " + kh.Diem.ToString();
            }
            else
            {
                ThemKhachHang f = new ThemKhachHang(null);
                f.ShowDialog();
            }
                
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                DataGridViewRow currentRow = dataGridView1.CurrentCell.OwningRow;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView2);
                newRow.Cells[0].Value = currentRow.Cells[0].Value;
                newRow.Cells[1].Value = currentRow.Cells[3].Value;
                newRow.Cells[2].Value = 1; 
                newRow.Cells[3].Value = currentRow.Cells[4].Value;
                if (int.TryParse(currentRow.Cells["SoLuong"].Value?.ToString(), out int soLuongCoSan))
                {
                    currentRow.Cells["SoLuong"].Value = soLuongCoSan - 1;
                }
                dataGridView2.Rows.Add(newRow);
                double thanhtien = 0.0;
                foreach (DataGridViewRow item in dataGridView2.Rows)
                {
                    thanhtien += Convert.ToDouble(item.Cells[2].Value) * Convert.ToDouble(item.Cells[3].Value);

                }
                lb_ThanhTien.Text = thanhtien.ToString();
                double chietkhau = Convert.ToDouble(lb_GiamGia.Text);
                lb_Tong.Text = (thanhtien - chietkhau).ToString();


            }
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentCell != null &&
                dataGridView2.CurrentCell.OwningColumn.Name == "SoLuong")
            {
                DataGridViewRow currentRowInDataGridView2 = dataGridView2.CurrentCell.OwningRow;
                if (double.TryParse(currentRowInDataGridView2.Cells["SoLuong"].Value?.ToString(), out double soLuongMoi))
                {
                    string idChiTiet = currentRowInDataGridView2.Cells["IDChiTiet"].Value?.ToString();
                    DataGridViewRow currentRowInDataGridView1 = null;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    { 
                        if (row.Cells["IDChiTiet"].Value?.ToString() == idChiTiet)
                        {
                        currentRowInDataGridView1 = row;
                            break;
                        } 
                    }

                    if (currentRowInDataGridView1 != null)
                    {
                        if (double.TryParse(currentRowInDataGridView1.Cells["SoLuong"].Value?.ToString(), out double soLuongCoSan))
                        {
                            if (soLuongMoi > soLuongCoSan)
                            {
                                MessageBox.Show("Số lượng trong kho không đủ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                currentRowInDataGridView2.Cells["SoLuong"].Value = soLuongCoSan;
                            }
                            else
                            {
                                double thanhtien = 0.0;
                                foreach (DataGridViewRow item in dataGridView2.Rows)
                                {
                                    thanhtien += Convert.ToDouble(item.Cells[2].Value) * Convert.ToDouble(item.Cells[3].Value);

                                }
                                lb_ThanhTien.Text = thanhtien.ToString();
                                double chietkhau = Convert.ToDouble(lb_GiamGia.Text);
                                lb_Tong.Text = (thanhtien - chietkhau).ToString();
                            }
                        }
                    }
                }
            }
        }

        private void bt_DoiDiem_Click(object sender, EventArgs e)
        {
            if (DaDoiDiem == false)
            {
                HoaDon hd = new HoaDon();
                hd.IDHoaDon = lb_ID.Text;
                hd.ChietKhau = Convert.ToDouble(lb_GiamGia.Text);
                hd.TongTien = Convert.ToDouble(lb_Tong.Text);
                KhachHangBUS.Instance.DoiDiem(hd, kh);
                lb_DiemThuong.Text = "Điểm Thưởng: " + kh.Diem.ToString();
                lb_GiamGia.Text = hd.ChietKhau.ToString();
                lb_Tong.Text = hd.TongTien.ToString();
                DaDoiDiem = true;
            }
                      
        }

        private void ThemHoadon_Load(object sender, EventArgs e)
        {

        }
    }
}

