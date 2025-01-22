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
    public partial class frmUyeKayıt : Form
    {
        public frmUyeKayıt()
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
        private void btnKayıt_Click(object sender, EventArgs e)
        {
            Kullanici k = new Kullanici();
            k.yetkiId = 2;
            k.ad = txtAd.Text;
            k.soyad = txtSoyad.Text;
            k.TCno = mkdboxTC.Text;
            k.pasaportNo = mkdBoxPasaport.Text;
            k.uyruk = (string)cmbUyruk.SelectedItem;
            k.doğumt = dtpDogumT.Value;
            if (rdKadın.Checked == true)
            {
                k.cinsiyet = "Kadın";
            }
            else if (rderkek.Checked == true)
            {
                k.cinsiyet = "Erkek";
            }
            else
            {
                k.cinsiyet = "None";
            }
            k.telefonNo = mkdTelefonNo.Text;
            k.Eposta = txtEposta.Text;
            k.kullaniciSifre = txtSifre.Text;

            db.Kullanici.Add(k);

            db.SaveChanges();
            MessageBox.Show("Kayıt başarılı");
            Program.kul = k;
            this.Hide();
            frmMenu frmmnu = new frmMenu();
            frmmnu.Show();

        }
    }
}
