namespace TeknikServisOtomasyonu
{
    partial class Frm_personelguncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_personelguncelle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtf_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bttn_perguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.sifre_check = new System.Windows.Forms.CheckBox();
            this.maskedguncel_tel = new System.Windows.Forms.MaskedTextBox();
            this.txtf_gncl_mail = new System.Windows.Forms.TextBox();
            this.txtf_sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.txtf_id);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bttn_perguncelle);
            this.panel1.Controls.Add(this.sifre_check);
            this.panel1.Controls.Add(this.maskedguncel_tel);
            this.panel1.Controls.Add(this.txtf_gncl_mail);
            this.panel1.Controls.Add(this.txtf_sifre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 344);
            this.panel1.TabIndex = 0;
            // 
            // txtf_id
            // 
            this.txtf_id.Enabled = false;
            this.txtf_id.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtf_id.Location = new System.Drawing.Point(108, 152);
            this.txtf_id.Name = "txtf_id";
            this.txtf_id.Size = new System.Drawing.Size(100, 21);
            this.txtf_id.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(94, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 123);
            this.panel2.TabIndex = 19;
            // 
            // bttn_perguncelle
            // 
            this.bttn_perguncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_perguncelle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.bttn_perguncelle.Appearance.Options.UseFont = true;
            this.bttn_perguncelle.Appearance.Options.UseForeColor = true;
            this.bttn_perguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttn_perguncelle.ImageOptions.Image")));
            this.bttn_perguncelle.Location = new System.Drawing.Point(108, 290);
            this.bttn_perguncelle.Name = "bttn_perguncelle";
            this.bttn_perguncelle.Size = new System.Drawing.Size(167, 38);
            this.bttn_perguncelle.TabIndex = 18;
            this.bttn_perguncelle.Text = "Bilgileri Güncelle";
            this.bttn_perguncelle.Click += new System.EventHandler(this.bttn_perguncelle_Click_1);
            // 
            // sifre_check
            // 
            this.sifre_check.AutoSize = true;
            this.sifre_check.BackColor = System.Drawing.Color.Transparent;
            this.sifre_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_check.ForeColor = System.Drawing.Color.White;
            this.sifre_check.Location = new System.Drawing.Point(218, 217);
            this.sifre_check.Name = "sifre_check";
            this.sifre_check.Size = new System.Drawing.Size(93, 17);
            this.sifre_check.TabIndex = 17;
            this.sifre_check.Text = "Şifre Göster";
            this.sifre_check.UseVisualStyleBackColor = false;
            this.sifre_check.CheckedChanged += new System.EventHandler(this.sifre_check_CheckedChanged_1);
            // 
            // maskedguncel_tel
            // 
            this.maskedguncel_tel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedguncel_tel.Location = new System.Drawing.Point(108, 179);
            this.maskedguncel_tel.Mask = "(999) 000-0000";
            this.maskedguncel_tel.Name = "maskedguncel_tel";
            this.maskedguncel_tel.Size = new System.Drawing.Size(100, 21);
            this.maskedguncel_tel.TabIndex = 16;
            // 
            // txtf_gncl_mail
            // 
            this.txtf_gncl_mail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtf_gncl_mail.Location = new System.Drawing.Point(108, 251);
            this.txtf_gncl_mail.Name = "txtf_gncl_mail";
            this.txtf_gncl_mail.Size = new System.Drawing.Size(167, 21);
            this.txtf_gncl_mail.TabIndex = 15;
            // 
            // txtf_sifre
            // 
            this.txtf_sifre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtf_sifre.Location = new System.Drawing.Point(108, 215);
            this.txtf_sifre.Name = "txtf_sifre";
            this.txtf_sifre.PasswordChar = '•';
            this.txtf_sifre.Size = new System.Drawing.Size(100, 21);
            this.txtf_sifre.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "E-Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Telefon:";
            // 
            // Frm_personelguncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 344);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Frm_personelguncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profil Bilgisi Güncelleme";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtf_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton bttn_perguncelle;
        private System.Windows.Forms.CheckBox sifre_check;
        public System.Windows.Forms.MaskedTextBox maskedguncel_tel;
        public System.Windows.Forms.TextBox txtf_gncl_mail;
        public System.Windows.Forms.TextBox txtf_sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}