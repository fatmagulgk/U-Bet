
namespace Ucbet0._1
{
    partial class frnSifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frnSifremiUnuttum));
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pcrGeri = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblbilgi = new System.Windows.Forms.Label();
            this.txtkuleposta = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.btnSifreBul = new System.Windows.Forms.Button();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Controls.Add(this.pcrGeri);
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(604, 69);
            this.pnl1.TabIndex = 0;
            // 
            // pcrGeri
            // 
            this.pcrGeri.Image = ((System.Drawing.Image)(resources.GetObject("pcrGeri.Image")));
            this.pcrGeri.Location = new System.Drawing.Point(11, 21);
            this.pcrGeri.Name = "pcrGeri";
            this.pcrGeri.Size = new System.Drawing.Size(66, 36);
            this.pcrGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrGeri.TabIndex = 1;
            this.pcrGeri.TabStop = false;
            this.pcrGeri.Click += new System.EventHandler(this.pcrGeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Şifremi Unuttum";
            // 
            // lblbilgi
            // 
            this.lblbilgi.AutoSize = true;
            this.lblbilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbilgi.Location = new System.Drawing.Point(105, 146);
            this.lblbilgi.Name = "lblbilgi";
            this.lblbilgi.Size = new System.Drawing.Size(367, 20);
            this.lblbilgi.TabIndex = 1;
            this.lblbilgi.Text = "● Hesabınıza ait olan kullanıcı epostasını giriniz.";
            // 
            // txtkuleposta
            // 
            this.txtkuleposta.ForeColor = System.Drawing.Color.DarkGray;
            this.txtkuleposta.Location = new System.Drawing.Point(193, 196);
            this.txtkuleposta.Multiline = true;
            this.txtkuleposta.Name = "txtkuleposta";
            this.txtkuleposta.Size = new System.Drawing.Size(203, 26);
            this.txtkuleposta.TabIndex = 2;
            this.txtkuleposta.Text = "Eposta";
            this.txtkuleposta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtkuleposta_MouseClick);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifre.Location = new System.Drawing.Point(251, 360);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(0, 19);
            this.lblSifre.TabIndex = 3;
            // 
            // btnSifreBul
            // 
            this.btnSifreBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreBul.Location = new System.Drawing.Point(234, 266);
            this.btnSifreBul.Name = "btnSifreBul";
            this.btnSifreBul.Size = new System.Drawing.Size(114, 31);
            this.btnSifreBul.TabIndex = 4;
            this.btnSifreBul.Text = "Şifremi Bul";
            this.btnSifreBul.UseVisualStyleBackColor = true;
            this.btnSifreBul.Click += new System.EventHandler(this.btnSifreBul_Click);
            // 
            // frnSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 800);
            this.Controls.Add(this.btnSifreBul);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtkuleposta);
            this.Controls.Add(this.lblbilgi);
            this.Controls.Add(this.pnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frnSifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frnSifremiUnuttum";
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrGeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.PictureBox pcrGeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblbilgi;
        private System.Windows.Forms.TextBox txtkuleposta;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Button btnSifreBul;
    }
}