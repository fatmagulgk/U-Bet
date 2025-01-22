
namespace Ucbet0._1
{
    partial class frmAdminAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminAnasayfa));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKampanyalar = new System.Windows.Forms.Button();
            this.btnUcuslar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnKampanyalar
            // 
            this.btnKampanyalar.BackColor = System.Drawing.Color.DimGray;
            this.btnKampanyalar.Location = new System.Drawing.Point(168, 334);
            this.btnKampanyalar.Name = "btnKampanyalar";
            this.btnKampanyalar.Size = new System.Drawing.Size(183, 53);
            this.btnKampanyalar.TabIndex = 1;
            this.btnKampanyalar.Text = "Kampanyalar";
            this.btnKampanyalar.UseVisualStyleBackColor = false;
            this.btnKampanyalar.Click += new System.EventHandler(this.btnKampanyalar_Click);
            // 
            // btnUcuslar
            // 
            this.btnUcuslar.BackColor = System.Drawing.Color.DimGray;
            this.btnUcuslar.Location = new System.Drawing.Point(168, 439);
            this.btnUcuslar.Name = "btnUcuslar";
            this.btnUcuslar.Size = new System.Drawing.Size(183, 53);
            this.btnUcuslar.TabIndex = 2;
            this.btnUcuslar.Text = "Uçuşlar";
            this.btnUcuslar.UseVisualStyleBackColor = false;
            this.btnUcuslar.Click += new System.EventHandler(this.btnUcuslar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.btncikis);
            this.panel1.Controls.Add(this.btnKampanyalar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnUcuslar);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(42, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 718);
            this.panel1.TabIndex = 3;
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.DimGray;
            this.btncikis.Location = new System.Drawing.Point(168, 537);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(183, 55);
            this.btncikis.TabIndex = 3;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // frmAdminAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(603, 800);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminAnasayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKampanyalar;
        private System.Windows.Forms.Button btnUcuslar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncikis;
    }
}