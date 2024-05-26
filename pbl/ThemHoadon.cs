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
        private NhanVienBUS nvBUS = new NhanVienBUS();
        private bool DaDoiDiem = new bool();
        private List<ChiTietSanPham_View> list = new List<ChiTietSanPham_View>();
        private List<SoLuongCTSP> list_sl = new List<SoLuongCTSP>();
        
        public ThemHoadon()
        {
            InitializeComponent();
            list_sl = ctspBUS.GetSoLuongs();
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
            list = ctspBUS.GetData1();
            dataGridView1.DataSource = list;
            
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
                hd.ChietKhau = Convert.ToDecimal(lb_GiamGia.Text);
                hd.TongTien = Convert.ToDecimal(lb_Tong.Text);
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
                        ChiTietSanPham chiTietSanPham = ctspBUS.GetCTSP(chiTietHoaDon.IDChiTiet);
                        chiTietSanPham.SoLuong -= chiTietHoaDon.SoLuong;
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
                int diem = Convert.ToInt32(Convert.ToDecimal(lb_Tong.Text)/20);
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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem cột thay đổi có phải là cột "Check" và chỉ thực hiện khi dữ liệu đã sẵn sàng
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Check" && e.RowIndex >= 0 && e.RowIndex < list.Count)
            {
                ChiTietSanPham_View selectedItem = list[e.RowIndex];
                int SoLuongCoSan = selectedItem.SoLuong;

                // Nếu cột "Check" được tick
                if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["Check"].Value))
                {
                    if (SoLuongCoSan > 0)
                    {
                        selectedItem.SoLuong = SoLuongCoSan - 1;
                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.CreateCells(dataGridView2);
                        newRow.Cells[0].Value = selectedItem.IDChiTiet;
                        newRow.Cells[1].Value = selectedItem.Ten;
                        newRow.Cells[2].Value = 1;
                        newRow.Cells[3].Value = selectedItem.GiaBan;

                        dataGridView2.Rows.Add(newRow);
                    }
                    else
                    {
                        MessageBox.Show("Sản phẩm không đủ số lượng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dataGridView1.Rows[e.RowIndex].Cells["Check"].Value = false; // Bỏ tick nếu số lượng bằng 0
                    }
                }
                else // Nếu bỏ tick cột "Check"
                {
                    string idChiTiet = selectedItem.IDChiTiet;
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == idChiTiet)
                        {
                            int SoLuong = Convert.ToInt32(row.Cells[2].Value);
                            selectedItem.SoLuong += SoLuong;
                            dataGridView2.Rows.Remove(row);
                            break;
                        }
                    }
                }

                // Cập nhật tổng tiền sau khi thay đổi số lượng hoặc trạng thái Check
                TinhTien();
                Refresh_DataGridView();
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentCell != null && dataGridView2.CurrentCell.OwningColumn.Name == "SoLuong")
            {
                DataGridViewRow currentRow = dataGridView2.CurrentCell.OwningRow;
                try
                {
                    int soLuongMoi = Convert.ToInt32(currentRow.Cells["SoLuong"].Value);
                    string idChiTiet = currentRow.Cells["IDChiTiet"].Value.ToString();
                    int tongSoLuong = 0;
                    foreach (SoLuongCTSP sl in list_sl)
                    {
                        if (sl.IDChiTiet == idChiTiet)
                        {
                            tongSoLuong = sl.SoLuong;
                            break;
                        }
                    }
                    foreach (ChiTietSanPham_View item in list)
                    {
                        if (item.IDChiTiet == idChiTiet)
                        {
                            if (tongSoLuong < soLuongMoi)
                            {
                                MessageBox.Show("Số lượng trong kho không đủ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                currentRow.Cells["SoLuong"].Value = tongSoLuong;
                            }
                            item.SoLuong = tongSoLuong - Convert.ToInt32(currentRow.Cells["SoLuong"].Value);
                            TinhTien();
                            Refresh_DataGridView();
                            break;
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Giá trị số lượng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("Giá trị số lượng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void bt_DoiDiem_Click(object sender, EventArgs e)
        {
            if (DaDoiDiem == false)
            {
                HoaDon hd = new HoaDon();
                hd.IDHoaDon = lb_ID.Text;
                hd.ChietKhau = Convert.ToDecimal(lb_GiamGia.Text);
                hd.TongTien = Convert.ToDecimal(lb_Tong.Text);
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

        private void Refresh_DataGridView()
        {
            dataGridView1.DataSource = null; // Xóa ràng buộc hiện có
            dataGridView1.DataSource = list; // Ràng buộc lại với danh sách
            dataGridView2.Refresh();
        }

        private void TinhTien()
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

