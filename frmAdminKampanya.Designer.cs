
namespace Ucbet0._1
{
    partial class frmAdminKampanya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminKampanya));
            this.dgvKampanyalar = new System.Windows.Forms.DataGridView();
            this.pcrAfis = new System.Windows.Forms.PictureBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.rtboxAciklama = new System.Windows.Forms.RichTextBox();
            this.txtKampanyaAdi = new System.Windows.Forms.TextBox();
            this.pcrGeri = new System.Windows.Forms.PictureBox();
            this.btnAfisekle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKampanyalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrAfis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKampanyalar
            // 
            this.dgvKampanyalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKampanyalar.Location = new System.Drawing.Point(12, 63);
            this.dgvKampanyalar.Name = "dgvKampanyalar";
            this.dgvKampanyalar.RowHeadersWidth = 51;
            this.dgvKampanyalar.RowTemplate.Height = 24;
            this.dgvKampanyalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKampanyalar.Size = new System.Drawing.Size(561, 254);
            this.dgvKampanyalar.TabIndex = 0;
            this.dgvKampanyalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKampanyalar_CellClick);
            // 
            // pcrAfis
            // 
            this.pcrAfis.Location = new System.Drawing.Point(12, 348);
            this.pcrAfis.Name = "pcrAfis";
            this.pcrAfis.Size = new System.Drawing.Size(235, 288);
            this.pcrAfis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrAfis.TabIndex = 1;
            this.pcrAfis.TabStop = false;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(372, 576);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(95, 36);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGüncelle.Location = new System.Drawing.Point(266, 576);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(95, 36);
            this.btnGüncelle.TabIndex = 3;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(479, 576);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(95, 36);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // rtboxAciklama
            // 
            this.rtboxAciklama.Location = new System.Drawing.Point(266, 348);
            this.rtboxAciklama.Name = "rtboxAciklama";
            this.rtboxAciklama.Size = new System.Drawing.Size(307, 125);
            this.rtboxAciklama.TabIndex = 6;
            this.rtboxAciklama.Text = "";
            // 
            // txtKampanyaAdi
            // 
            this.txtKampanyaAdi.Location = new System.Drawing.Point(326, 488);
            this.txtKampanyaAdi.Multiline = true;
            this.txtKampanyaAdi.Name = "txtKampanyaAdi";
            this.txtKampanyaAdi.Size = new System.Drawing.Size(164, 30);
            this.txtKampanyaAdi.TabIndex = 7;
            // 
            // pcrGeri
            // 
            this.pcrGeri.Image = ((System.Drawing.Image)(resources.GetObject("pcrGeri.Image")));
            this.pcrGeri.Location = new System.Drawing.Point(12, 12);
            this.pcrGeri.Name = "pcrGeri";
            this.pcrGeri.Size = new System.Drawing.Size(72, 37);
            this.pcrGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrGeri.TabIndex = 8;
            this.pcrGeri.TabStop = false;
            this.pcrGeri.Click += new System.EventHandler(this.pcrGeri_Click);
            // 
            // btnAfisekle
            // 
            this.btnAfisekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAfisekle.Location = new System.Drawing.Point(79, 658);
            this.btnAfisekle.Name = "btnAfisekle";
            this.btnAfisekle.Size = new System.Drawing.Size(92, 31);
            this.btnAfisekle.TabIndex = 9;
            this.btnAfisekle.Text = "Afiş Ekle";
            this.btnAfisekle.UseVisualStyleBackColor = true;
            this.btnAfisekle.Click += new System.EventHandler(this.btnAfisekle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAdminKampanya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 753);
            this.Controls.Add(this.btnAfisekle);
            this.Controls.Add(this.pcrGeri);
            this.Controls.Add(this.txtKampanyaAdi);
            this.Controls.Add(this.rtboxAciklama);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.pcrAfis);
            this.Controls.Add(this.dgvKampanyalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminKampanya";
            this.Text = "frmAdminKampanya";
            this.Load += new System.EventHandler(this.frmAdminKampanya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKampanyalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrAfis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrGeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKampanyalar;
        private System.Windows.Forms.PictureBox pcrAfis;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.RichTextBox rtboxAciklama;
        private System.Windows.Forms.TextBox txtKampanyaAdi;
        private System.Windows.Forms.PictureBox pcrGeri;
        private System.Windows.Forms.Button btnAfisekle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}