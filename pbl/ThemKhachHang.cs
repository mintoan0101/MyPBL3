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
        public ThemKhachHang(string sdt)
        {
            InitializeComponent();
            setGUI(sdt);
        }

        private void setGUI(string sdt)
        {
            if (sdt != null)
            {
                KhachHang kh = KhachHangBUS.Instance.GetKhachHangBySDT(sdt);
                textBox5.Text = sdt;
                textBox2.Text = kh.Ten;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBox5.Text) &&
                !string.IsNullOrEmpty(this.textBox2.Text))
            {
                KhachHang kh = new KhachHang();
                kh.ID = KhachHangBUS.Instance.SetID();
                kh.SDT = textBox5.Text;
                kh.Ten = textBox2.Text;
                kh.Diem = 0;
                KhachHangBUS.Instance.Insert(kh);
                this.Close();
            }
            else MessageBox.Show("Vui lòng điền đầy đủ thông tin");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
