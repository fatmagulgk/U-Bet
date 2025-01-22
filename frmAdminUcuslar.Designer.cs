
namespace Ucbet0._1
{
    partial class frmAdminUcuslar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminUcuslar));
            this.dgvUcuslar = new System.Windows.Forms.DataGridView();
            this.dtpUcusT = new System.Windows.Forms.DateTimePicker();
            this.mskUcusS = new System.Windows.Forms.MaskedTextBox();
            this.txtBagaj = new System.Windows.Forms.TextBox();
            this.cmbKalkis = new System.Windows.Forms.ComboBox();
            this.cmbVaris = new System.Windows.Forms.ComboBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.pcrGeri = new System.Windows.Forms.PictureBox();
            this.lblKoltuk = new System.Windows.Forms.Label();
            this.cmbKoltuk = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcuslar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUcuslar
            // 
            this.dgvUcuslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcuslar.Location = new System.Drawing.Point(12, 63);
            this.dgvUcuslar.Name = "dgvUcuslar";
            this.dgvUcuslar.RowHeadersWidth = 51;
            this.dgvUcuslar.RowTemplate.Height = 24;
            this.dgvUcuslar.Size = new System.Drawing.Size(578, 255);
            this.dgvUcuslar.TabIndex = 0;
            // 
            // dtpUcusT
            // 
            this.dtpUcusT.Location = new System.Drawing.Point(153, 403);
            this.dtpUcusT.Name = "dtpUcusT";
            this.dtpUcusT.Size = new System.Drawing.Size(200, 22);
            this.dtpUcusT.TabIndex = 3;
            // 
            // mskUcusS
            // 
            this.mskUcusS.Location = new System.Drawing.Point(153, 467);
            this.mskUcusS.Mask = "00:00";
            this.mskUcusS.Name = "mskUcusS";
            this.mskUcusS.Size = new System.Drawing.Size(38, 22);
            this.mskUcusS.TabIndex = 4;
            this.mskUcusS.ValidatingType = typeof(System.DateTime);
            // 
            // txtBagaj
            // 
            this.txtBagaj.Location = new System.Drawing.Point(153, 526);
            this.txtBagaj.Name = "txtBagaj";
            this.txtBagaj.Size = new System.Drawing.Size(100, 22);
            this.txtBagaj.TabIndex = 5;
            // 
            // cmbKalkis
            // 
            this.cmbKalkis.FormattingEnabled = true;
            this.cmbKalkis.Items.AddRange(new object[] {
            " Adana",
            " Adıyaman",
            " Afyonkarahisar",
            " Ağrı",
            " Aksaray",
            " Amasya",
            " Ankara",
            " Antalya",
            " Ardahan",
            " Artvin",
            " Aydın",
            " Balıkesir",
            " Bartın",
            " Batman",
            " Bayburt",
            " Bilecik",
            " Bingöl",
            " Bitlis",
            " Bolu",
            " Burdur",
            " Bursa",
            " Çanakkale",
            " Çankırı",
            " Çorum",
            " Denizli",
            " Diyarbakır",
            " Düzce",
            " Edirne",
            " Elazığ",
            " Erzincan",
            " Erzurum",
            " Eskişehir",
            " Gaziantep",
            " Giresun",
            " Gümüşhane",
            " Hakkâri",
            " Hatay",
            " Iğdır",
            " Isparta",
            " İstanbul",
            " İzmir",
            " Kahramanmaraş",
            " Karabük",
            " Karaman",
            " Kars",
            " Kastamonu",
            " Kayseri",
            " Kilis",
            " Kırıkkale",
            " Kırklareli",
            " Kırşehir",
            " Kocaeli",
            " Konya",
            " Kütahya",
            " Malatya",
            " Manisa",
            " Mardin",
            " Mersin",
            " Muğla",
            " Muş",
            " Nevşehir",
            " Niğde",
            " Ordu",
            " Rize",
            " Sakarya",
            " Samsun",
            " Şanlıurfa",
            " Siirt",
            " Sinop",
            " Sivas",
            " Şırnak",
            " Tekirdağ",
            " Tokat",
            " Trabzon",
            " Tunceli",
            " Uşak",
            " Van",
            " Yalova",
            " Yozgat",
            " Zonguldak",
            " Şikago",
            " Boston",
            "New York",
            "Washington D.C",
            "San Francisco",
            "Los Angeles",
            "Miami",
            "San Diego",
            "Houston",
            "Seattle",
            "Philadelphia",
            "Las egas",
            "Austin",
            "Atlanta",
            "Detroit",
            "Baltimore",
            "New Orleans",
            "Dallas",
            "Sacramento",
            "Denver",
            "Virginia Beach",
            "Nashville",
            "Jacksonville",
            "Milwaukee",
            "Minneapolis",
            "San Jose",
            "Portland",
            "Oklahoma City",
            "Pittsburgh",
            "Memphis",
            "Omaha",
            "Kansas City",
            "Phoenix",
            "Cleveland",
            "Albuquerque",
            "Oakland",
            "Columbus",
            "Honolulu",
            "Indıanapolis",
            "St louis",
            "Sait Lake City",
            "San Antonio",
            "Colorado Springs",
            "Charlotte",
            "Louisville",
            "Orlando",
            "Raleigh",
            "Anaheim",
            "Tampa",
            "Tulsa",
            "Wicihita"});
            this.cmbKalkis.Location = new System.Drawing.Point(153, 345);
            this.cmbKalkis.Name = "cmbKalkis";
            this.cmbKalkis.Size = new System.Drawing.Size(121, 24);
            this.cmbKalkis.TabIndex = 6;
            // 
            // cmbVaris
            // 
            this.cmbVaris.FormattingEnabled = true;
            this.cmbVaris.Items.AddRange(new object[] {
            " Adana",
            " Adıyaman",
            " Afyonkarahisar",
            " Ağrı",
            " Aksaray",
            " Amasya",
            " Ankara",
            " Antalya",
            " Ardahan",
            " Artvin",
            " Aydın",
            " Balıkesir",
            " Bartın",
            " Batman",
            " Bayburt",
            " Bilecik",
            " Bingöl",
            " Bitlis",
            " Bolu",
            " Burdur",
            " Bursa",
            " Çanakkale",
            " Çankırı",
            " Çorum",
            " Denizli",
            " Diyarbakır",
            " Düzce",
            " Edirne",
            " Elazığ",
            " Erzincan",
            " Erzurum",
            " Eskişehir",
            " Gaziantep",
            " Giresun",
            " Gümüşhane",
            " Hakkâri",
            " Hatay",
            " Iğdır",
            " Isparta",
            " İstanbul",
            " İzmir",
            " Kahramanmaraş",
            " Karabük",
            " Karaman",
            " Kars",
            " Kastamonu",
            " Kayseri",
            " Kilis",
            " Kırıkkale",
            " Kırklareli",
            " Kırşehir",
            " Kocaeli",
            " Konya",
            " Kütahya",
            " Malatya",
            " Manisa",
            " Mardin",
            " Mersin",
            " Muğla",
            " Muş",
            " Nevşehir",
            " Niğde",
            " Ordu",
            " Rize",
            " Sakarya",
            " Samsun",
            " Şanlıurfa",
            " Siirt",
            " Sinop",
            " Sivas",
            " Şırnak",
            " Tekirdağ",
            " Tokat",
            " Trabzon",
            " Tunceli",
            " Uşak",
            " Van",
            " Yalova",
            " Yozgat",
            " Zonguldak",
            " Şikago",
            " Boston",
            "New York",
            "Washington D.C",
            "San Francisco",
            "Los Angeles",
            "Miami",
            "San Diego",
            "Houston",
            "Seattle",
            "Philadelphia",
            "Las egas",
            "Austin",
            "Atlanta",
            "Detroit",
            "Baltimore",
            "New Orleans",
            "Dallas",
            "Sacramento",
            "Denver",
            "Virginia Beach",
            "Nashville",
            "Jacksonville",
            "Milwaukee",
            "Minneapolis",
            "San Jose",
            "Portland",
            "Oklahoma City",
            "Pittsburgh",
            "Memphis",
            "Omaha",
            "Kansas City",
            "Phoenix",
            "Cleveland",
            "Albuquerque",
            "Oakland",
            "Columbus",
            "Honolulu",
            "Indıanapolis",
            "St louis",
            "Sait Lake City",
            "San Antonio",
            "Colorado Springs",
            "Charlotte",
            "Louisville",
            "Orlando",
            "Raleigh",
            "Anaheim",
            "Tampa",
            "Tulsa",
            "Wicihita"});
            this.cmbVaris.Location = new System.Drawing.Point(418, 342);
            this.cmbVaris.Name = "cmbVaris";
            this.cmbVaris.Size = new System.Drawing.Size(121, 24);
            this.cmbVaris.TabIndex = 7;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(153, 586);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtFiyat.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kalkış Yeri : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Varış Yeri :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Uçuş Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Uçuş Saati :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 529);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bagaj : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 589);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fiyat : ";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(183, 710);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(91, 46);
            this.btnEkle.TabIndex = 15;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(338, 710);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(91, 46);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pcrGeri
            // 
            this.pcrGeri.Image = ((System.Drawing.Image)(resources.GetObject("pcrGeri.Image")));
            this.pcrGeri.Location = new System.Drawing.Point(24, 13);
            this.pcrGeri.Name = "pcrGeri";
            this.pcrGeri.Size = new System.Drawing.Size(67, 36);
            this.pcrGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrGeri.TabIndex = 17;
            this.pcrGeri.TabStop = false;
            this.pcrGeri.Click += new System.EventHandler(this.pcrGeri_Click);
            // 
            // lblKoltuk
            // 
            this.lblKoltuk.AutoSize = true;
            this.lblKoltuk.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKoltuk.Location = new System.Drawing.Point(50, 645);
            this.lblKoltuk.Name = "lblKoltuk";
            this.lblKoltuk.Size = new System.Drawing.Size(67, 19);
            this.lblKoltuk.TabIndex = 21;
            this.lblKoltuk.Text = "Koltuk : ";
            // 
            // cmbKoltuk
            // 
            this.cmbKoltuk.FormattingEnabled = true;
            this.cmbKoltuk.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "A6",
            "A7",
            "A8",
            "A9"});
            this.cmbKoltuk.Location = new System.Drawing.Point(153, 643);
            this.cmbKoltuk.Name = "cmbKoltuk";
            this.cmbKoltuk.Size = new System.Drawing.Size(121, 24);
            this.cmbKoltuk.TabIndex = 22;
            // 
            // frmAdminUcuslar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 800);
            this.Controls.Add(this.cmbKoltuk);
            this.Controls.Add(this.lblKoltuk);
            this.Controls.Add(this.pcrGeri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.cmbVaris);
            this.Controls.Add(this.cmbKalkis);
            this.Controls.Add(this.txtBagaj);
            this.Controls.Add(this.mskUcusS);
            this.Controls.Add(this.dtpUcusT);
            this.Controls.Add(this.dgvUcuslar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminUcuslar";
            this.Text = "frmAdminUcuslar";
            this.Load += new System.EventHandler(this.frmAdminUcuslar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcuslar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrGeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUcuslar;
        private System.Windows.Forms.DateTimePicker dtpUcusT;
        private System.Windows.Forms.MaskedTextBox mskUcusS;
        private System.Windows.Forms.TextBox txtBagaj;
        private System.Windows.Forms.ComboBox cmbKalkis;
        private System.Windows.Forms.ComboBox cmbVaris;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.PictureBox pcrGeri;
        private System.Windows.Forms.Label lblKoltuk;
        private System.Windows.Forms.ComboBox cmbKoltuk;
    }
}