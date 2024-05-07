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
    public partial class ThemNhaPhanPhoi : Form
    {
        public ThemNhaPhanPhoi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBox1.Text) &&
                 !string.IsNullOrEmpty(this.textBox2.Text) &&
                 !string.IsNullOrEmpty(this.textBox3.Text) &&
                 !string.IsNullOrEmpty(this.textBox4.Text))
            {
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
