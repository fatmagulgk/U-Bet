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
    public partial class frmUcuslarim : Form
    {
        public frmUcuslarim()
        {
            InitializeComponent();
        }
        ucbetdb db = new ucbetdb();
        string kalkis, varis;
        private void btnUcusAra_Click(object sender, EventArgs e)
        {
            kalkis = (string)cmbKalkis.SelectedItem;
            varis = (string)cmbVaris.SelectedItem;
           
            Ucuslar ucuslar = db.Ucuslar.Where(x => x.ucusTarih == dtpUcusT.Value.Date && x.kalkisYeri==kalkis&& x.varisYeri==varis).SingleOrDefault();
            if (ucuslar != null)
            {
                lblbilet.Text = string.Format("Kalkış Yeri :{0} Varış Yeri :{1} Uçuş Tarihi : {2} Koltuk : {3}",ucuslar.kalkisYeri,ucuslar.varisYeri,ucuslar.ucusTarih,ucuslar.Koltuk.koltukNo);
                btnSatinAl.Visible = true;
            }
        }
    }
}
