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
    public partial class MainFormNhanVien : Form
    {
        private Form currentFormChild;
        public string username { get; set; }
        public string id { get; set; }
        public MainFormNhanVien()
        {
            InitializeComponent();
        }
        private void NHANVIEN_Load(object sender, EventArgs e)
        {
            btn_infor.Text = username;
            button1.PerformClick();
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void OpenChildForm1(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.BringToFront();
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
                    }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan t = new ThongTinCaNhan();
            t.username = this.username;
            OpenChildForm1(t);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (panel4.Visible == false)
            {
                panel4.Visible = true;
                panel4.BringToFront();
            }
            else panel4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Hoadon_nhanvien());
            button2.BackColor = panel3.BackColor;
            button1.BackColor = panel2.BackColor;
            button3.BackColor = panel2.BackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new Khachhang_Nhanvien());
            button3.BackColor = panel3.BackColor;
            button1.BackColor = panel2.BackColor;
            button2.BackColor = panel2.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLySanPham f  = new QuanLySanPham();
            f.isAdmin = false;
            OpenChildForm(f);
            button1.BackColor = panel3.BackColor;
            button3.BackColor = panel2.BackColor;
            button2.BackColor = panel2.BackColor;
        }

       
    }
}
