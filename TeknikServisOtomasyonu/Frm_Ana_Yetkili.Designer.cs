namespace TeknikServisOtomasyonu
{
    partial class Frm_Ana_Yetkili
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ana_Yetkili));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttn_yntci_grs = new DevExpress.XtraEditors.SimpleButton();
            this.sifre_check = new System.Windows.Forms.CheckBox();
            this.txtf_sifre = new System.Windows.Forms.TextBox();
            this.txtf_nickname = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.lbl_k_adi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.bttn_yntci_grs);
            this.panel1.Controls.Add(this.sifre_check);
            this.panel1.Controls.Add(this.txtf_sifre);
            this.panel1.Controls.Add(this.txtf_nickname);
            this.panel1.Controls.Add(this.lbl_sifre);
            this.panel1.Controls.Add(this.lbl_k_adi);
            this.panel1.Location = new System.Drawing.Point(-82, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 337);
            this.panel1.TabIndex = 12;
            // 
            // bttn_yntci_grs
            // 
            this.bttn_yntci_grs.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_yntci_grs.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttn_yntci_grs.Appearance.Options.UseFont = true;
            this.bttn_yntci_grs.Appearance.Options.UseForeColor = true;
            this.bttn_yntci_grs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttn_yntci_grs.ImageOptions.Image")));
            this.bttn_yntci_grs.Location = new System.Drawing.Point(460, 217);
            this.bttn_yntci_grs.Name = "bttn_yntci_grs";
            this.bttn_yntci_grs.Size = new System.Drawing.Size(98, 33);
            this.bttn_yntci_grs.TabIndex = 17;
            this.bttn_yntci_grs.Text = "Giriş";
            this.bttn_yntci_grs.Click += new System.EventHandler(this.bttn_yntci_grs_Click_1);
            // 
            // sifre_check
            // 
            this.sifre_check.AutoSize = true;
            this.sifre_check.BackColor = System.Drawing.Color.Transparent;
            this.sifre_check.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_check.ForeColor = System.Drawing.Color.Orange;
            this.sifre_check.Location = new System.Drawing.Point(449, 189);
            this.sifre_check.Name = "sifre_check";
            this.sifre_check.Size = new System.Drawing.Size(115, 20);
            this.sifre_check.TabIndex = 16;
            this.sifre_check.Text = "Şifreyi Göster";
            this.sifre_check.UseVisualStyleBackColor = false;
            this.sifre_check.CheckedChanged += new System.EventHandler(this.sifre_check_CheckedChanged);
            // 
            // txtf_sifre
            // 
            this.txtf_sifre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtf_sifre.Location = new System.Drawing.Point(426, 161);
            this.txtf_sifre.Name = "txtf_sifre";
            this.txtf_sifre.PasswordChar = '•';
            this.txtf_sifre.Size = new System.Drawing.Size(132, 23);
            this.txtf_sifre.TabIndex = 15;
            // 
            // txtf_nickname
            // 
            this.txtf_nickname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtf_nickname.Location = new System.Drawing.Point(426, 121);
            this.txtf_nickname.Name = "txtf_nickname";
            this.txtf_nickname.Size = new System.Drawing.Size(132, 23);
            this.txtf_nickname.TabIndex = 14;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sifre.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.ForeColor = System.Drawing.Color.Orange;
            this.lbl_sifre.Location = new System.Drawing.Point(370, 161);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(50, 18);
            this.lbl_sifre.TabIndex = 13;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // lbl_k_adi
            // 
            this.lbl_k_adi.AutoSize = true;
            this.lbl_k_adi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_k_adi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_k_adi.ForeColor = System.Drawing.Color.Orange;
            this.lbl_k_adi.Location = new System.Drawing.Point(314, 121);
            this.lbl_k_adi.Name = "lbl_k_adi";
            this.lbl_k_adi.Size = new System.Drawing.Size(106, 18);
            this.lbl_k_adi.TabIndex = 12;
            this.lbl_k_adi.Text = "Kullanıcı Adı:";
            // 
            // Frm_Ana_Yetkili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 326);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Ana_Yetkili";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Girişi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton bttn_yntci_grs;
        private System.Windows.Forms.CheckBox sifre_check;
        private System.Windows.Forms.TextBox txtf_sifre;
        private System.Windows.Forms.TextBox txtf_nickname;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Label lbl_k_adi;
    }
}