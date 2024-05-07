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
        public ThemHoadon()
        {
            InitializeComponent();
            SetBill();
        }
        private void SetBill()
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
