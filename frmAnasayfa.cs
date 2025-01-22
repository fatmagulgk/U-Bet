using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucbet0._1
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void pcrHesabim_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Close();
            frmHesabim hsbm = new frmHesabim();
            hsbm.Show();
        }
    }
}
