﻿using BusinessLogicLayer;
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
    public partial class XemChiTietSanPham : Form
    {
        ChiTietSanPhamBUS bus = new ChiTietSanPhamBUS();
        NhaPhanPhoiBUS nppbus = new NhaPhanPhoiBUS();
        public bool isAdmin { get; set; }
        public string idsanpham { get; set; }
        public XemChiTietSanPham()
        {
            InitializeComponent();
        }

        private void ChiTietSanPham_Load(object sender, EventArgs e)
        {
            if(!isAdmin)
            {
                btn_edit.Enabled = false;
                btn_them.Enabled = false;
         
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            
            dataGridView1.DataSource = bus.GetData(idsanpham);
            Load_Nha_Phan_Phoi();
            Load_Bo_Loc();
        }

      
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            Them_SuaChiTietSanPham f = new Them_SuaChiTietSanPham();
            f.isEdit = false;
            f.IDSanPham = idsanpham;
            f.ShowDialog();
        }
        private void btn_edit_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                Them_SuaChiTietSanPham f = new Them_SuaChiTietSanPham();
                f.isEdit = true;
                f.IDChiTiet  = row.Cells[0].Value.ToString();
                f.IDSanPham = idsanpham;
                f.TenNPP = row.Cells[1].Value.ToString();
                f.HSD = row.Cells[2].Value.ToString();
                f.SoLuong = int.Parse(row.Cells[3].Value.ToString());
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chi tiết cần xóa","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string id = row.Cells[0].Value.ToString();
                if(bus.Delete(id)>0)
                {
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chi tiết bạn muốn xóa!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            Hien_Thi_Ket_Qua();
        }
        //CÁC HÀM BỔ TRỢ
        public void Load_Nha_Phan_Phoi()
        {
            List<string> ds_npp = nppbus.GetName();
            cb_nhaphanphoi.Items.Add("Tất Cả");
            foreach(string s in ds_npp)
            {
                cb_nhaphanphoi.Items.Add(s);
            }
            cb_nhaphanphoi.SelectedItem = "Tất Cả";
        }
        public void Load_Bo_Loc()
        {

            cb_boloc.Items.Add("Tất Cả");
            cb_boloc.Items.Add("Đã Hết Hạn");
            cb_boloc.Items.Add("Chưa Hết Hạn");
            cb_boloc.Items.Add("Số Lượng < 50");
            cb_boloc.Items.Add("Số Lượng 50 - 100");
            cb_boloc.Items.Add("Số Lượng > 100");
            cb_boloc.SelectedItem = "Tất Cả";
        }
        public void Hien_Thi_Ket_Qua()
        {
            string npp = cb_nhaphanphoi.SelectedItem.ToString();
            string boloc = cb_boloc.SelectedItem.ToString();
            string sql = "select IDChiTiet,TenNhaPhanPhoi,HanSuDung,SoLuong from chitietsanpham join nhaphanphoi on chitietsanpham.IDNhaPhanPhoi = nhaphanphoi.IDNhaPhanPhoi where IDSanPham = '" + idsanpham + "' ";
            if(npp == "Tất Cả")
            {
                if(boloc == "Tất Cả")
                {

                }
                else
                {
                    sql += Bo_Loc(boloc);
                }
            }
            else
            {
                if(boloc == "Tất Cả")
                {
                    sql += "and TenNhaPhanPhoi = '" + npp + "' ";
                }
                else
                {
                    sql += "and TenNhaPhanPhoi = '" + npp + "' "+ Bo_Loc(boloc);
                }
            }
            dataGridView1.DataSource = bus.GetData2(sql);
        }
       public string Bo_Loc(string boloc)
        {
            string condition = " AND ";
            if (boloc == "Đã Hết Hạn")
            {
                condition += " HanSuDung <= CURDATE()";
            }
            else if (boloc == "Chưa Hết Hạn")
            {
                condition += " HanSuDung > CURDATE()";
            }
            else if(boloc == "Số Lượng < 50")
            {
                condition += " SoLuong < 50";
            }
            else if (boloc == "Số Lượng 50 - 100")
            {
                condition += " SoLuong >= 50 AND SoLuong <= 100";
            }
            else if (boloc == "Số Lượng > 100")
            {
                condition += " SoLuong > 100";
            }
            return condition;
        }

        
    }
}
