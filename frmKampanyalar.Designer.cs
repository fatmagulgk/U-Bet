
namespace Ucbet0._1
{
    partial class frmKampanyalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKampanyalar));
            this.pcrKampanyalar = new System.Windows.Forms.PictureBox();
            this.pcrGeri = new System.Windows.Forms.PictureBox();
            this.pcrİleri = new System.Windows.Forms.PictureBox();
            this.pnll = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lstAciklama = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcrKampanyalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrİleri)).BeginInit();
            this.pnll.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcrKampanyalar
            // 
            this.pcrKampanyalar.Location = new System.Drawing.Point(95, 105);
            this.pcrKampanyalar.Name = "pcrKampanyalar";
            this.pcrKampanyalar.Size = new System.Drawing.Size(423, 464);
            this.pcrKampanyalar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrKampanyalar.TabIndex = 0;
            this.pcrKampanyalar.TabStop = false;
            // 
            // pcrGeri
            // 
            this.pcrGeri.BackColor = System.Drawing.Color.Transparent;
            this.pcrGeri.Image = ((System.Drawing.Image)(resources.GetObject("pcrGeri.Image")));
            this.pcrGeri.Location = new System.Drawing.Point(30, 302);
            this.pcrGeri.Name = "pcrGeri";
            this.pcrGeri.Size = new System.Drawing.Size(59, 45);
            this.pcrGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrGeri.TabIndex = 1;
            this.pcrGeri.TabStop = false;
            this.pcrGeri.Click += new System.EventHandler(this.pcrGeri_Click);
            // 
            // pcrİleri
            // 
            this.pcrİleri.BackColor = System.Drawing.Color.Transparent;
            this.pcrİleri.Image = ((System.Drawing.Image)(resources.GetObject("pcrİleri.Image")));
            this.pcrİleri.Location = new System.Drawing.Point(524, 303);
            this.pcrİleri.Name = "pcrİleri";
            this.pcrİleri.Size = new System.Drawing.Size(59, 44);
            this.pcrİleri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrİleri.TabIndex = 2;
            this.pcrİleri.TabStop = false;
            this.pcrİleri.Click += new System.EventHandler(this.pcrİleri_Click);
            // 
            // pnll
            // 
            this.pnll.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnll.Controls.Add(this.label1);
            this.pnll.Location = new System.Drawing.Point(-2, 0);
            this.pnll.Name = "pnll";
            this.pnll.Size = new System.Drawing.Size(605, 72);
            this.pnll.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kampanyalar";
            // 
            // lstAciklama
            // 
            this.lstAciklama.FormattingEnabled = true;
            this.lstAciklama.ItemHeight = 16;
            this.lstAciklama.Items.AddRange(new object[] {
            " "});
            this.lstAciklama.Location = new System.Drawing.Point(182, 604);
            this.lstAciklama.Name = "lstAciklama";
            this.lstAciklama.Size = new System.Drawing.Size(284, 84);
            this.lstAciklama.TabIndex = 4;
            // 
            // frmKampanyalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(603, 709);
            this.Controls.Add(this.lstAciklama);
            this.Controls.Add(this.pnll);
            this.Controls.Add(this.pcrİleri);
            this.Controls.Add(this.pcrGeri);
            this.Controls.Add(this.pcrKampanyalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKampanyalar";
            this.Load += new System.EventHandler(this.frmKampanyalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcrKampanyalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrGeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrİleri)).EndInit();
            this.pnll.ResumeLayout(false);
            this.pnll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcrKampanyalar;
        private System.Windows.Forms.PictureBox pcrGeri;
        private System.Windows.Forms.PictureBox pcrİleri;
        private System.Windows.Forms.Panel pnll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAciklama;
    }
}