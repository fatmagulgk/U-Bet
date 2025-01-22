using System;
using System.Collections;
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
    public partial class frmKampanyalar : Form
    {
        public frmKampanyalar()
        {
            InitializeComponent();
        }
        int ileriDosyaArtisi = 0;
        int dosyaArtisi = 0;
        string yol;
        private void pcrGeri_Click(object sender, EventArgs e)
        {
            lstAciklama.Items.Clear();
            if (dosyaArtisi > files.Count - 1)
            {

                files.Clear();
                var kampanyalar = db.Kampanyalar.ToList();
                foreach (var kampanya in kampanyalar)
                {
                    files.Add(kampanya.kampanyaGorsel);
                }

                dosyaArtisi = 0;
            }
            if (ileriDosyaArtisi <= 0 || dosyaArtisi <= 0)
            {
                dosyaArtisi = ileriDosyaArtisi = 1;
            }



            pcrKampanyalar.ImageLocation = (string)files[dosyaArtisi];
            Kampanyalar kampanyalar1 = db.Kampanyalar.Where(x => x.kampanyaGorsel == pcrKampanyalar.ImageLocation).SingleOrDefault();
            lstAciklama.Items.Add(kampanyalar1.kampanyaAciklama);
            ileriDosyaArtisi = dosyaArtisi;

            dosyaArtisi++;
        }

         ArrayList files = new ArrayList();
        private void pcrİleri_Click(object sender, EventArgs e)
        {
            lstAciklama.Items.Clear();
            if (dosyaArtisi > files.Count - 1)
            {
                files.Clear();
                var kampanyalars = db.Kampanyalar.ToList();
                foreach (var kampanya in kampanyalars)
                {
                    files.Add(kampanya.kampanyaGorsel);

                }
                dosyaArtisi = ileriDosyaArtisi = 1;
            }
            if (dosyaArtisi <= 0 || ileriDosyaArtisi <= 0)
            {
                dosyaArtisi = ileriDosyaArtisi = 1;
            }
            yol = (string)files[ileriDosyaArtisi--];

            dosyaArtisi--;
            pcrKampanyalar.ImageLocation = yol;
            Kampanyalar kampanyalar = db.Kampanyalar.Where(x => x.kampanyaGorsel == pcrKampanyalar.ImageLocation).SingleOrDefault();
            lstAciklama.Items.Add(kampanyalar.kampanyaAciklama);
        }
        ucbetdb db = new ucbetdb();
        private void frmKampanyalar_Load(object sender, EventArgs e)
        {
            var kampanyalars = db.Kampanyalar.ToList();

            foreach (var kampanya in kampanyalars)
            {
                files.Add(kampanya.kampanyaGorsel);
            }
            Random rnd = new Random();
            int i = rnd.Next(0, files.Count);
            pcrKampanyalar.ImageLocation = (string)files[i];
        }
    }
    
}
