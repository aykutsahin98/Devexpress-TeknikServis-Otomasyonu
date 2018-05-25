namespace TeknikServisOtomasyonu
{
    partial class Frm_TeknikerGuncel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TeknikerGuncel));
            this.sifre_check = new System.Windows.Forms.CheckBox();
            this.txtf_sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bttn_tknkguncel = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.masked_telefon = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtf_mail = new System.Windows.Forms.TextBox();
            this.txtf_kullanici = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtf_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sifre_check
            // 
            this.sifre_check.AutoSize = true;
            this.sifre_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_check.ForeColor = System.Drawing.Color.Red;
            this.sifre_check.Location = new System.Drawing.Point(241, 317);
            this.sifre_check.Name = "sifre_check";
            this.sifre_check.Size = new System.Drawing.Size(63, 17);
            this.sifre_check.TabIndex = 23;
            this.sifre_check.Text = "Göster";
            this.sifre_check.UseVisualStyleBackColor = true;
            this.sifre_check.CheckedChanged += new System.EventHandler(this.sifre_check_CheckedChanged);
            // 
            // txtf_sifre
            // 
            this.txtf_sifre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtf_sifre.Location = new System.Drawing.Point(123, 315);
            this.txtf_sifre.Name = "txtf_sifre";
            this.txtf_sifre.PasswordChar = '•';
            this.txtf_sifre.Size = new System.Drawing.Size(111, 21);
            this.txtf_sifre.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Şifre:";
            // 
            // bttn_tknkguncel
            // 
            this.bttn_tknkguncel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_tknkguncel.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.bttn_tknkguncel.Appearance.Options.UseFont = true;
            this.bttn_tknkguncel.Appearance.Options.UseForeColor = true;
            this.bttn_tknkguncel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttn_tknkguncel.ImageOptions.Image")));
            this.bttn_tknkguncel.Location = new System.Drawing.Point(71, 356);
            this.bttn_tknkguncel.Name = "bttn_tknkguncel";
            this.bttn_tknkguncel.Size = new System.Drawing.Size(168, 37);
            this.bttn_tknkguncel.TabIndex = 20;
            this.bttn_tknkguncel.Text = "Bilgileri Güncelle";
            this.bttn_tknkguncel.Click += new System.EventHandler(this.bttn_tknkguncel_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(87, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 138);
            this.panel1.TabIndex = 19;
            // 
            // masked_telefon
            // 
            this.masked_telefon.Location = new System.Drawing.Point(123, 246);
            this.masked_telefon.Mask = "(999) 000-0000";
            this.masked_telefon.Name = "masked_telefon";
            this.masked_telefon.Size = new System.Drawing.Size(111, 20);
            this.masked_telefon.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Telefon:";
            // 
            // txtf_mail
            // 
            this.txtf_mail.Location = new System.Drawing.Point(123, 279);
            this.txtf_mail.Name = "txtf_mail";
            this.txtf_mail.Size = new System.Drawing.Size(170, 20);
            this.txtf_mail.TabIndex = 16;
            // 
            // txtf_kullanici
            // 
            this.txtf_kullanici.Location = new System.Drawing.Point(123, 210);
            this.txtf_kullanici.Name = "txtf_kullanici";
            this.txtf_kullanici.Size = new System.Drawing.Size(111, 20);
            this.txtf_kullanici.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "E-Posta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // txtf_id
            // 
            this.txtf_id.Enabled = false;
            this.txtf_id.Location = new System.Drawing.Point(123, 172);
            this.txtf_id.Name = "txtf_id";
            this.txtf_id.Size = new System.Drawing.Size(111, 20);
            this.txtf_id.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(26, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "ID:";
            // 
            // Frm_TeknikerGuncel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 412);
            this.Controls.Add(this.txtf_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sifre_check);
            this.Controls.Add(this.txtf_sifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttn_tknkguncel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.masked_telefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtf_mail);
            this.Controls.Add(this.txtf_kullanici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_TeknikerGuncel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tekniker  Güncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox sifre_check;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton bttn_tknkguncel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtf_sifre;
        public System.Windows.Forms.MaskedTextBox masked_telefon;
        public System.Windows.Forms.TextBox txtf_mail;
        public System.Windows.Forms.TextBox txtf_kullanici;
        public System.Windows.Forms.TextBox txtf_id;
        private System.Windows.Forms.Label label5;
    }
}