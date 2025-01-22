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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_MouseEnter(object sender, EventArgs e)
        {
            btnGiris.BackColor = Color.DarkGreen;
        }

        private void btnGiris_MouseLeave(object sender, EventArgs e)
        {
            btnGiris.BackColor = Color.MediumSeaGreen;
        }

        private void btnUyeol_MouseEnter(object sender, EventArgs e)
        {
            btnUyeol.BackColor = Color.OrangeRed;
        }

        private void btnUyeol_MouseLeave(object sender, EventArgs e)
        {
            btnUyeol.BackColor = Color.DarkOrange;
        }
        ucbetdb db = new ucbetdb();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string eposta, sifre;
            eposta = txtkulposta.Text;
            sifre = txtsifre.Text;
            Kullanici k = db.Kullanici.Where(x => x.Eposta == eposta && x.kullaniciSifre == sifre).SingleOrDefault();
            if (k == null)
            {
                MessageBox.Show("eposta veya şifre yanlış", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtkulposta.Text = txtsifre.Text = "";
                txtkulposta.Focus();


            }
            else if (k != null && k.yetkiId == 2)
            {
                Program.kul = k;
                this.Hide();
                frmMenu mnu = new frmMenu();
                mnu.Show();
            }
            else if (k != null && k.yetkiId == 1)
            {

                Program.kul = k;
                this.Hide();
                frmAdminAnasayfa admin = new frmAdminAnasayfa();
                admin.Show();
            }
        }

        private void btnUyeol_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUyeKayıt kyt = new frmUyeKayıt();
            kyt.Show();
        }

        private void lblSifremiunuttum_Click(object sender, EventArgs e)
        {
            this.Hide();
            frnSifremiUnuttum sfr = new frnSifremiUnuttum();
            sfr.Show();
        }

        private void chBoxSifregoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxSifregoster.Checked)
            {
                txtsifre.PasswordChar = '\0';

            }
            else
            {
                txtsifre.PasswordChar = '*';
            }
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            txtsifre.PasswordChar = '*';
        }
    }
}
