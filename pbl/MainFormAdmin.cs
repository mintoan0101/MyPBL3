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
    public partial class MainFormAdmin : Form
    {
        private Form currentFormChild;
        public string username {  get; set; }
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

        //private void OpenChildForm2(Form childForm)
        //{
        //    if (currentFormChild != null)
        //    {
        //        currentFormChild.Close();
        //    }
        //    currentFormChild = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    panel5.BringToFront();
        //    panel5.Controls.Add(childForm);
        //    panel5.Tag = childForm;
        //    childForm.BringToFront();
        //    childForm.Show();
        //}
        private void OpenChildForm1(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false; 
            childForm.FormBorderStyle = FormBorderStyle.None; 
            panel3.Controls.Add(childForm);
            int centerX = (panel3.Width - childForm.Width) / 2;
            int centerY = (panel3.Height - childForm.Height) / 2;
            childForm.Left = centerX;
            childForm.Top = centerY;
            childForm.BringToFront();
            childForm.Show();
        }

        private void OpenChildForm2(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel5.BringToFront();
            panel5.Controls.Add(childForm);
            panel5.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public MainFormAdmin()
        {
            InitializeComponent();
        }
        private void MainFormAdmin_Load(object sender, EventArgs e)
        {
            btn_infor.Text = username;
            button1.PerformClick();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Khachhang_Nhanvien());
            button2.BackColor = panel2.BackColor;
            button9.BackColor = panel2.BackColor;
            button7.BackColor = panel2.BackColor;
            button1.BackColor = panel2.BackColor;
            button8.BackColor = panel2.BackColor;
            button3.BackColor = panel3.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLySanPham f = new QuanLySanPham();
            f.isAdmin = true;
            OpenChildForm(f);
            button2.BackColor = panel2.BackColor;
            button9.BackColor = panel2.BackColor;
            button7.BackColor = panel2.BackColor;
            button3.BackColor = panel2.BackColor;
            button8.BackColor = panel2.BackColor;
            button1.BackColor = panel3.BackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DanhSachHoaDon f = new DanhSachHoaDon();
            OpenChildForm1(f);
            button3.BackColor = panel2.BackColor;
            button9.BackColor = panel2.BackColor;
            button7.BackColor = panel2.BackColor;
            button1.BackColor = panel2.BackColor;
            button8.BackColor = panel2.BackColor;
            button2.BackColor = panel3.BackColor;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Quanlynhanvien());
            button2.BackColor = panel2.BackColor;
            button9.BackColor = panel2.BackColor;
            button3.BackColor = panel2.BackColor;
            button1.BackColor = panel2.BackColor;
            button8.BackColor = panel2.BackColor;
            button7.BackColor = panel3.BackColor;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KhoHang());
            button2.BackColor = panel2.BackColor;
            button7.BackColor = panel2.BackColor;
            button3.BackColor = panel2.BackColor;
            button1.BackColor = panel2.BackColor;
            button8.BackColor = panel2.BackColor;
            button9.BackColor = panel3.BackColor;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKe());
            button2.BackColor = panel2.BackColor;
            button7.BackColor = panel2.BackColor;
            button3.BackColor = panel2.BackColor;
            button1.BackColor = panel2.BackColor;
            button9.BackColor = panel2.BackColor;
            button8.BackColor = panel3.BackColor;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == false)
            {
                panel4.BringToFront();
                panel4.Visible = true;
            }
            else 
                panel4.Visible = false;
                
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắn chắn muốn đăng xuất","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Hide();
                Login f = new Login();
                f.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm2(new ThongTinCaNhan());
        }


    }
}
