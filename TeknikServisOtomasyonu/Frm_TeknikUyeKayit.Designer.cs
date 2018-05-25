namespace TeknikServisOtomasyonu
{
    partial class Frm_TeknikElemanUye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TeknikElemanUye));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtf_adsoyad = new System.Windows.Forms.TextBox();
            this.txtf_mail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.masked_telefon = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttn_tknk_uye = new DevExpress.XtraEditors.SimpleButton();
            this.txtf_sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sifre_check = new System.Windows.Forms.CheckBox();
            this.txtf_kadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-Posta:";
            // 
            // txtf_adsoyad
            // 
            this.txtf_adsoyad.Location = new System.Drawing.Point(122, 210);
            this.txtf_adsoyad.Name = "txtf_adsoyad";
            this.txtf_adsoyad.Size = new System.Drawing.Size(111, 20);
            this.txtf_adsoyad.TabIndex = 3;
            // 
            // txtf_mail
            // 
            this.txtf_mail.Location = new System.Drawing.Point(122, 316);
            this.txtf_mail.Name = "txtf_mail";
            this.txtf_mail.Size = new System.Drawing.Size(170, 20);
            this.txtf_mail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon:";
            // 
            // masked_telefon
            // 
            this.masked_telefon.Location = new System.Drawing.Point(123, 282);
            this.masked_telefon.Mask = "(999) 000-0000";
            this.masked_telefon.Name = "masked_telefon";
            this.masked_telefon.Size = new System.Drawing.Size(111, 20);
            this.masked_telefon.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(70, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 170);
            this.panel1.TabIndex = 8;
            // 
            // bttn_tknk_uye
            // 
            this.bttn_tknk_uye.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_tknk_uye.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.bttn_tknk_uye.Appearance.Options.UseFont = true;
            this.bttn_tknk_uye.Appearance.Options.UseForeColor = true;
            this.bttn_tknk_uye.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttn_tknk_uye.ImageOptions.Image")));
            this.bttn_tknk_uye.Location = new System.Drawing.Point(70, 404);
            this.bttn_tknk_uye.Name = "bttn_tknk_uye";
            this.bttn_tknk_uye.Size = new System.Drawing.Size(168, 37);
            this.bttn_tknk_uye.TabIndex = 9;
            this.bttn_tknk_uye.Text = "Tekniker Kaydet";
            this.bttn_tknk_uye.Click += new System.EventHandler(this.bttn_tknk_uye_Click);
            // 
            // txtf_sifre
            // 
            this.txtf_sifre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtf_sifre.Location = new System.Drawing.Point(123, 351);
            this.txtf_sifre.Name = "txtf_sifre";
            this.txtf_sifre.PasswordChar = '•';
            this.txtf_sifre.Size = new System.Drawing.Size(111, 21);
            this.txtf_sifre.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şifre:";
            // 
            // sifre_check
            // 
            this.sifre_check.AutoSize = true;
            this.sifre_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_check.ForeColor = System.Drawing.Color.Red;
            this.sifre_check.Location = new System.Drawing.Point(240, 354);
            this.sifre_check.Name = "sifre_check";
            this.sifre_check.Size = new System.Drawing.Size(63, 17);
            this.sifre_check.TabIndex = 12;
            this.sifre_check.Text = "Göster";
            this.sifre_check.UseVisualStyleBackColor = true;
            // 
            // txtf_kadi
            // 
            this.txtf_kadi.Location = new System.Drawing.Point(122, 246);
            this.txtf_kadi.Name = "txtf_kadi";
            this.txtf_kadi.Size = new System.Drawing.Size(111, 20);
            this.txtf_kadi.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kullanıcı Adı:";
            // 
            // Frm_TeknikElemanUye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 453);
            this.Controls.Add(this.txtf_kadi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sifre_check);
            this.Controls.Add(this.txtf_sifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttn_tknk_uye);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.masked_telefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtf_mail);
            this.Controls.Add(this.txtf_adsoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_TeknikElemanUye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Teknik Eleman Ekleme Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtf_adsoyad;
        private System.Windows.Forms.TextBox txtf_mail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox masked_telefon;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton bttn_tknk_uye;
        private System.Windows.Forms.TextBox txtf_sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox sifre_check;
        private System.Windows.Forms.TextBox txtf_kadi;
        private System.Windows.Forms.Label label5;
    }
}