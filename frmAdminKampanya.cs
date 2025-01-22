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
    public partial class frmAdminKampanya : Form
    {
        public void Doldur()
        {
            dgvKampanyalar.DataSource = db.Kampanyalar.ToList();
        }
        public frmAdminKampanya()
        {
            InitializeComponent();
        }
        ucbetdb db = new ucbetdb();
        private void pcrGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminAnasayfa ansf = new frmAdminAnasayfa();
            ansf.Show();
        }
         int kampanyaID = 0;
        private void dgvKampanyalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kampanyaID = (int)dgvKampanyalar.SelectedRows[0].Cells[0].Value;
            Kampanyalar kampanya = db.Kampanyalar.Where(x => x.kampanyaID ==kampanyaID).SingleOrDefault();
            txtKampanyaAdi.Text = kampanya.kampanyaAd;
            rtboxAciklama.Text = kampanya.kampanyaAciklama;
            pcrAfis.ImageLocation = kampanya.kampanyaGorsel;
            pcrAfis.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Kampanyalar k = db.Kampanyalar.Where(x => x.kampanyaID == kampanyaID).SingleOrDefault();
            k.kampanyaAd = txtKampanyaAdi.Text;
            k.kampanyaAciklama = rtboxAciklama.Text;
            k.kampanyaGorsel = pcrAfis.ImageLocation;
            db.SaveChanges();

            MessageBox.Show("Güncelleme başarıyla gerçekleştirildi.");
            Doldur();
        }

        private void btnAfisekle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pcrAfis.ImageLocation = openFileDialog1.FileName;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Kampanyalar kamp = db.Kampanyalar.Where(x => x.kampanyaID == kampanyaID).SingleOrDefault();
            db.Kampanyalar.Remove(kamp);
            db.SaveChanges();
            MessageBox.Show("Kampanya başarıyla silindi.");
            Doldur();
            txtKampanyaAdi.Text = rtboxAciklama.Text =pcrAfis.ImageLocation="";
            

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kampanyalar k = new Kampanyalar();
            k.kampanyaAd =txtKampanyaAdi.Text;
            k.kampanyaAciklama = rtboxAciklama.Text;
            k.kampanyaGorsel = pcrAfis.ImageLocation;
            db.Kampanyalar.Add(k);
            db.SaveChanges();
            MessageBox.Show("Kampanya başarıyla eklendi.");
            Doldur();
        }

        private void frmAdminKampanya_Load(object sender, EventArgs e)
        {
            dgvKampanyalar.DataSource = db.Kampanyalar.ToList();
        }
    }
}
