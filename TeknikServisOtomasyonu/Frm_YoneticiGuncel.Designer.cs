namespace TeknikServisOtomasyonu
{
    partial class Frm_YoneticiGuncel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_YoneticiGuncel));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtf_id = new System.Windows.Forms.TextBox();
            this.txtf_kadi = new System.Windows.Forms.TextBox();
            this.txtf_sifre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttn_guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.chck_sifre = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kulanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(80, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(96, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID:";
            // 
            // txtf_id
            // 
            this.txtf_id.Enabled = false;
            this.txtf_id.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtf_id.Location = new System.Drawing.Point(138, 150);
            this.txtf_id.Name = "txtf_id";
            this.txtf_id.Size = new System.Drawing.Size(121, 22);
            this.txtf_id.TabIndex = 3;
            // 
            // txtf_kadi
            // 
            this.txtf_kadi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtf_kadi.Location = new System.Drawing.Point(138, 187);
            this.txtf_kadi.Name = "txtf_kadi";
            this.txtf_kadi.Size = new System.Drawing.Size(121, 22);
            this.txtf_kadi.TabIndex = 4;
            // 
            // txtf_sifre
            // 
            this.txtf_sifre.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtf_sifre.Location = new System.Drawing.Point(138, 225);
            this.txtf_sifre.Name = "txtf_sifre";
            this.txtf_sifre.PasswordChar = '•';
            this.txtf_sifre.Size = new System.Drawing.Size(121, 22);
            this.txtf_sifre.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(138, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 114);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // bttn_guncelle
            // 
            this.bttn_guncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_guncelle.Appearance.Options.UseFont = true;
            this.bttn_guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttn_guncelle.ImageOptions.Image")));
            this.bttn_guncelle.Location = new System.Drawing.Point(119, 271);
            this.bttn_guncelle.Name = "bttn_guncelle";
            this.bttn_guncelle.Size = new System.Drawing.Size(140, 34);
            this.bttn_guncelle.TabIndex = 7;
            this.bttn_guncelle.Text = "Bilgileri Güncelle";
            this.bttn_guncelle.Click += new System.EventHandler(this.bttn_guncelle_Click);
            // 
            // chck_sifre
            // 
            this.chck_sifre.AutoSize = true;
            this.chck_sifre.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chck_sifre.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chck_sifre.Location = new System.Drawing.Point(265, 229);
            this.chck_sifre.Name = "chck_sifre";
            this.chck_sifre.Size = new System.Drawing.Size(72, 19);
            this.chck_sifre.TabIndex = 8;
            this.chck_sifre.Text = "Göster";
            this.chck_sifre.UseVisualStyleBackColor = true;
            this.chck_sifre.CheckedChanged += new System.EventHandler(this.chck_sifre_CheckedChanged);
            // 
            // Frm_YoneticiGuncel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(400, 337);
            this.Controls.Add(this.chck_sifre);
            this.Controls.Add(this.bttn_guncelle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtf_sifre);
            this.Controls.Add(this.txtf_kadi);
            this.Controls.Add(this.txtf_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_YoneticiGuncel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profil Bilgilerini Güncelle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtf_id;
        private System.Windows.Forms.TextBox txtf_kadi;
        private System.Windows.Forms.TextBox txtf_sifre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton bttn_guncelle;
        private System.Windows.Forms.CheckBox chck_sifre;
    }
}