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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void pcrAnasayfa_Click(object sender, EventArgs e)
        {
            pnlMenu.Controls.Clear();
            frmAnasayfa ansf = new frmAnasayfa();
            ansf.TopLevel = false;
            pnlMenu.Controls.Add(ansf);
            ansf.Show();
            ansf.Dock = DockStyle.Fill;
            ansf.BringToFront();
        }

        private void pcrKampanya_Click(object sender, EventArgs e)
        {
            pnlMenu.Controls.Clear();
            frmKampanyalar kmp = new frmKampanyalar();
            kmp.TopLevel = false;
            pnlMenu.Controls.Add(kmp);
            kmp.Show();
            kmp.Dock = DockStyle.Fill;
            kmp.BringToFront();
        }

        private void pcrUcuslarim_Click(object sender, EventArgs e)
        {
            pnlMenu.Controls.Clear();
            frmUcuslarim ucus = new frmUcuslarim();
            ucus.TopLevel = false;
            pnlMenu.Controls.Add(ucus);
            ucus.Show();
            ucus.Dock = DockStyle.Fill;
            ucus.BringToFront();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            pnlMenu.Controls.Clear();
            frmAnasayfa ansf = new frmAnasayfa();
            ansf.TopLevel = false;
            pnlMenu.Controls.Add(ansf);
            ansf.Show();
            ansf.Dock = DockStyle.Fill;
            ansf.BringToFront();
        }

        private void pcrCikis_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                Close();
               frmGiris grs = new frmGiris();
                grs.Show();

            }
            else if (secim == DialogResult.No)
            {
                this.Hide();
                frmMenu mnu = new frmMenu();
                mnu.Show();

            }
        }
    }
}
