using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ucbet0._1.Models;

namespace Ucbet0._1
{
    public partial class frnSifremiUnuttum : Form
    {
        public frnSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void pcrGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGiris grs = new frmGiris();
            grs.Show();
        }
        ucbetdb db = new ucbetdb();
        private void btnSifreBul_Click(object sender, EventArgs e)
        {
            Kullanici k = db.Kullanici.Where(x => x.Eposta == txtkuleposta.Text).SingleOrDefault();
            if (k==null)
            {
                MessageBox.Show("Böyle bir eposta bulunmamaktadır!");
            }
            else
            {
                lblSifre.Text = k.kullaniciSifre;
            }
        }

        private void txtkuleposta_MouseClick(object sender, MouseEventArgs e)
        {
            txtkuleposta.Clear();
            Font myfont = new Font("Arial", 10);
            txtkuleposta.Font = myfont;
        }
    }
}
