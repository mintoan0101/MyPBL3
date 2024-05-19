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
    public partial class DonDatHang : Form
    {
        public DonDatHang()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ThemDonDatHang f = new ThemDonDatHang();
            f.ShowDialog();
        }
    }
}
