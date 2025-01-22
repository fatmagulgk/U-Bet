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
    public partial class frmAdminUcuslar : Form
    {
        public void Doldur()
        {
            dgvUcuslar.DataSource = db.Ucuslar.ToList();
        }
        public frmAdminUcuslar()
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
         
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ucuslar uc = new Ucuslar();
            uc.kalkisYeri =(string) cmbKalkis.SelectedItem;
            uc.varisYeri = (string)cmbVaris.SelectedItem;
            uc.ucusTarih = dtpUcusT.Value;
            uc.ucusSaat =TimeSpan.Parse(mskUcusS.Text);
            uc.bagaj = txtBagaj.Text;
            uc.fiyat = Convert.ToDecimal(txtFiyat.Text);
            //
            
          
            db.Ucuslar.Add(uc);
            db.SaveChanges();
            MessageBox.Show("Uçuş başarıyla eklendi.");
            Doldur();
        }
         int ucusId = 0;
        private void btnSil_Click(object sender, EventArgs e)
        {
            ucusId = (int)dgvUcuslar.SelectedRows[0].Cells[0].Value;
            Ucuslar uc = db.Ucuslar.Where(x => x.ucusID == ucusId).SingleOrDefault();
            db.Ucuslar.Remove(uc);
            db.SaveChanges();
            MessageBox.Show("Uçuş başarıyla silinmiştir.");
            Doldur();
            mskUcusS.Text = txtBagaj.Text = txtFiyat.Text = "";
            dtpUcusT.Value = DateTime.Now;
        }

        private void frmAdminUcuslar_Load(object sender, EventArgs e)
        {
            dgvUcuslar.DataSource = db.Ucuslar.ToList();
        }

        
    }
}
