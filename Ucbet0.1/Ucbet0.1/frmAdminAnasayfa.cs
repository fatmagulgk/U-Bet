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
    public partial class frmAdminAnasayfa : Form
    {
        public frmAdminAnasayfa()
        {
            InitializeComponent();
        }

        private void btnKampanyalar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminKampanya adkmp = new frmAdminKampanya();
            adkmp.Show();
        }

        private void btnUcuslar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminUcuslar aducus = new frmAdminUcuslar();
            aducus.Show();
        }

        private void btncikis_Click(object sender, EventArgs e)
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
                frmAdminAnasayfa ansf = new frmAdminAnasayfa();
                ansf.Show();
            }
        }
    }
}
