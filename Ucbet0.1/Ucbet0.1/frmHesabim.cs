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
    public partial class frmHesabim : Form
    {
        public frmHesabim()
        {
            InitializeComponent();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Kullanici k = db.Kullanici.Where(x => x.kullaniciID == Program.kul.kullaniciID).SingleOrDefault();
            k.yetkiId = 1;
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
            db.SaveChanges();
            MessageBox.Show("Değişiklikler kaydedildi");
        }

        ucbetdb db = new ucbetdb();
        private void frmHesabim_Load(object sender, EventArgs e)
        {
            Kullanici k = db.Kullanici.Where(x => x.kullaniciID == Program.kul.kullaniciID).SingleOrDefault();
            txtAd.Text = k.ad;
            txtSoyad.Text = k.soyad;
            mkdboxTC.Text = k.TCno;
            mkdBoxPasaport.Text = k.pasaportNo;
            cmbUyruk.SelectedItem = k.uyruk;
            dtpDogumT.Value = k.doğumt;
            if (k.cinsiyet == "erkek")
            {
                rderkek.Checked = true;
            }
            else if (k.cinsiyet == "kadın")
            {
               rdKadın.Checked = true;
            }
            else
            {
                rdNone.Checked = true;
            }
            mkdTelefonNo.Text = k.telefonNo;
            txtEposta.Text = k.Eposta;
            txtSifre.Text = k.kullaniciSifre;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Kullanici k = db.Kullanici.Where(x => x.kullaniciID == Program.kul.kullaniciID).SingleOrDefault();
            if (k != null)
            {
                DialogResult sonuc = MessageBox.Show("Hesabınızı silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    db.Kullanici.Remove(k);
                    db.SaveChanges();
                    MessageBox.Show("Silme işlemi başarılı.");
                    frmGiris grs = new frmGiris();
                    grs.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi");
                }
            }
            else
            {
                MessageBox.Show("Hesap Bulunmadı!");
            }
        }
    }
}
