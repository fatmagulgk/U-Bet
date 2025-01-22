
namespace Ucbet0._1
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.pcr1 = new System.Windows.Forms.PictureBox();
            this.pcr2 = new System.Windows.Forms.PictureBox();
            this.grpbox1 = new System.Windows.Forms.GroupBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblSifremiunuttum = new System.Windows.Forms.Label();
            this.chBoxSifregoster = new System.Windows.Forms.CheckBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtkulposta = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUyeol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr2)).BeginInit();
            this.grpbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcr1
            // 
            this.pcr1.BackColor = System.Drawing.Color.Transparent;
            this.pcr1.Image = ((System.Drawing.Image)(resources.GetObject("pcr1.Image")));
            this.pcr1.Location = new System.Drawing.Point(-152, -8);
            this.pcr1.Name = "pcr1";
            this.pcr1.Size = new System.Drawing.Size(509, 252);
            this.pcr1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr1.TabIndex = 0;
            this.pcr1.TabStop = false;
            // 
            // pcr2
            // 
            this.pcr2.BackColor = System.Drawing.Color.Transparent;
            this.pcr2.Image = ((System.Drawing.Image)(resources.GetObject("pcr2.Image")));
            this.pcr2.Location = new System.Drawing.Point(363, 1);
            this.pcr2.Name = "pcr2";
            this.pcr2.Size = new System.Drawing.Size(223, 211);
            this.pcr2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr2.TabIndex = 1;
            this.pcr2.TabStop = false;
            // 
            // grpbox1
            // 
            this.grpbox1.BackColor = System.Drawing.Color.Transparent;
            this.grpbox1.Controls.Add(this.btnUyeol);
            this.grpbox1.Controls.Add(this.btnGiris);
            this.grpbox1.Controls.Add(this.lblSifremiunuttum);
            this.grpbox1.Controls.Add(this.chBoxSifregoster);
            this.grpbox1.Controls.Add(this.txtsifre);
            this.grpbox1.Controls.Add(this.pictureBox2);
            this.grpbox1.Controls.Add(this.pictureBox1);
            this.grpbox1.Controls.Add(this.txtkulposta);
            this.grpbox1.Location = new System.Drawing.Point(128, 312);
            this.grpbox1.Name = "grpbox1";
            this.grpbox1.Size = new System.Drawing.Size(327, 405);
            this.grpbox1.TabIndex = 2;
            this.grpbox1.TabStop = false;
            this.grpbox1.Text = "                                                                                 " +
    "    ";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(117, 272);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(126, 43);
            this.btnGiris.TabIndex = 7;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            this.btnGiris.MouseEnter += new System.EventHandler(this.btnGiris_MouseEnter);
            this.btnGiris.MouseLeave += new System.EventHandler(this.btnGiris_MouseLeave);
            // 
            // lblSifremiunuttum
            // 
            this.lblSifremiunuttum.AutoSize = true;
            this.lblSifremiunuttum.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifremiunuttum.Location = new System.Drawing.Point(171, 220);
            this.lblSifremiunuttum.Name = "lblSifremiunuttum";
            this.lblSifremiunuttum.Size = new System.Drawing.Size(95, 17);
            this.lblSifremiunuttum.TabIndex = 6;
            this.lblSifremiunuttum.Text = "Şifremi Unuttum";
            this.lblSifremiunuttum.Click += new System.EventHandler(this.lblSifremiunuttum_Click);
            // 
            // chBoxSifregoster
            // 
            this.chBoxSifregoster.AutoSize = true;
            this.chBoxSifregoster.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxSifregoster.Location = new System.Drawing.Point(66, 219);
            this.chBoxSifregoster.Name = "chBoxSifregoster";
            this.chBoxSifregoster.Size = new System.Drawing.Size(93, 21);
            this.chBoxSifregoster.TabIndex = 5;
            this.chBoxSifregoster.Text = "Şifre Göster";
            this.chBoxSifregoster.UseVisualStyleBackColor = true;
            this.chBoxSifregoster.CheckedChanged += new System.EventHandler(this.chBoxSifregoster_CheckedChanged);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(108, 169);
            this.txtsifre.Multiline = true;
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(177, 28);
            this.txtsifre.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(66, 164);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtkulposta
            // 
            this.txtkulposta.Location = new System.Drawing.Point(108, 115);
            this.txtkulposta.Multiline = true;
            this.txtkulposta.Name = "txtkulposta";
            this.txtkulposta.Size = new System.Drawing.Size(177, 28);
            this.txtkulposta.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(194, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 162);
            this.panel1.TabIndex = 0;
            // 
            // btnUyeol
            // 
            this.btnUyeol.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUyeol.ForeColor = System.Drawing.Color.White;
            this.btnUyeol.Location = new System.Drawing.Point(117, 332);
            this.btnUyeol.Name = "btnUyeol";
            this.btnUyeol.Size = new System.Drawing.Size(126, 43);
            this.btnUyeol.TabIndex = 8;
            this.btnUyeol.Text = "Üye Ol";
            this.btnUyeol.UseVisualStyleBackColor = false;
            this.btnUyeol.Click += new System.EventHandler(this.btnUyeol_Click);
            this.btnUyeol.MouseEnter += new System.EventHandler(this.btnUyeol_MouseEnter);
            this.btnUyeol.MouseLeave += new System.EventHandler(this.btnUyeol_MouseLeave);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpbox1);
            this.Controls.Add(this.pcr2);
            this.Controls.Add(this.pcr1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr2)).EndInit();
            this.grpbox1.ResumeLayout(false);
            this.grpbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcr1;
        private System.Windows.Forms.PictureBox pcr2;
        private System.Windows.Forms.GroupBox grpbox1;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblSifremiunuttum;
        private System.Windows.Forms.CheckBox chBoxSifregoster;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtkulposta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUyeol;
    }
}