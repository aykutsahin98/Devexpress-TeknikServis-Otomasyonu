namespace TeknikServisOtomasyonu
{
    partial class Frm_PersonelGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PersonelGiris));
            this.lbl_unuttum = new System.Windows.Forms.Label();
            this.txtf_kullnci_adi = new System.Windows.Forms.TextBox();
            this.sifre_check = new System.Windows.Forms.CheckBox();
            this.txtf_sifre = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.lbl_adi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttn_giris = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lbl_unuttum
            // 
            this.lbl_unuttum.AutoSize = true;
            this.lbl_unuttum.BackColor = System.Drawing.Color.Transparent;
            this.lbl_unuttum.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lbl_unuttum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_unuttum.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_unuttum.Location = new System.Drawing.Point(196, 236);
            this.lbl_unuttum.Name = "lbl_unuttum";
            this.lbl_unuttum.Size = new System.Drawing.Size(111, 16);
            this.lbl_unuttum.TabIndex = 39;
            this.lbl_unuttum.Text = "Şifremi Unuttum";
            this.lbl_unuttum.Click += new System.EventHandler(this.lbl_unuttum_Click);
            // 
            // txtf_kullnci_adi
            // 
            this.txtf_kullnci_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtf_kullnci_adi.Location = new System.Drawing.Point(159, 167);
            this.txtf_kullnci_adi.Name = "txtf_kullnci_adi";
            this.txtf_kullnci_adi.Size = new System.Drawing.Size(148, 22);
            this.txtf_kullnci_adi.TabIndex = 35;
            // 
            // sifre_check
            // 
            this.sifre_check.AutoSize = true;
            this.sifre_check.BackColor = System.Drawing.Color.Transparent;
            this.sifre_check.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_check.ForeColor = System.Drawing.Color.Red;
            this.sifre_check.Location = new System.Drawing.Point(313, 214);
            this.sifre_check.Name = "sifre_check";
            this.sifre_check.Size = new System.Drawing.Size(108, 18);
            this.sifre_check.TabIndex = 37;
            this.sifre_check.Text = "Şifreyi Göster";
            this.sifre_check.UseVisualStyleBackColor = false;
            this.sifre_check.CheckedChanged += new System.EventHandler(this.sifre_check_CheckedChanged);
            // 
            // txtf_sifre
            // 
            this.txtf_sifre.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtf_sifre.Location = new System.Drawing.Point(159, 211);
            this.txtf_sifre.Name = "txtf_sifre";
            this.txtf_sifre.PasswordChar = '•';
            this.txtf_sifre.Size = new System.Drawing.Size(148, 22);
            this.txtf_sifre.TabIndex = 36;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sifre.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.ForeColor = System.Drawing.Color.White;
            this.lbl_sifre.Location = new System.Drawing.Point(103, 212);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(50, 18);
            this.lbl_sifre.TabIndex = 34;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // lbl_adi
            // 
            this.lbl_adi.AutoSize = true;
            this.lbl_adi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adi.ForeColor = System.Drawing.Color.White;
            this.lbl_adi.Location = new System.Drawing.Point(47, 168);
            this.lbl_adi.Name = "lbl_adi";
            this.lbl_adi.Size = new System.Drawing.Size(106, 18);
            this.lbl_adi.TabIndex = 33;
            this.lbl_adi.Text = "Kullanıcı Adı:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(174, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 128);
            this.panel1.TabIndex = 40;
            // 
            // bttn_giris
            // 
            this.bttn_giris.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_giris.Appearance.ForeColor = System.Drawing.Color.Black;
            this.bttn_giris.Appearance.Options.UseFont = true;
            this.bttn_giris.Appearance.Options.UseForeColor = true;
            this.bttn_giris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttn_giris.ImageOptions.Image")));
            this.bttn_giris.Location = new System.Drawing.Point(213, 265);
            this.bttn_giris.Name = "bttn_giris";
            this.bttn_giris.Size = new System.Drawing.Size(94, 35);
            this.bttn_giris.TabIndex = 41;
            this.bttn_giris.Text = "Giriş";
            this.bttn_giris.Click += new System.EventHandler(this.bttn_giris_Click_1);
            // 
            // Frm_PersonelGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(504, 326);
            this.Controls.Add(this.bttn_giris);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_unuttum);
            this.Controls.Add(this.txtf_kullnci_adi);
            this.Controls.Add(this.sifre_check);
            this.Controls.Add(this.txtf_sifre);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_adi);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Frm_PersonelGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_unuttum;
        private System.Windows.Forms.TextBox txtf_kullnci_adi;
        public System.Windows.Forms.CheckBox sifre_check;
        private System.Windows.Forms.TextBox txtf_sifre;
        public System.Windows.Forms.Label lbl_sifre;
        internal System.Windows.Forms.Label lbl_adi;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton bttn_giris;
    }
}