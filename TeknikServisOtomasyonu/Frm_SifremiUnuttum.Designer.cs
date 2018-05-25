namespace TeknikServisOtomasyonu
{
    partial class Frm_SifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SifremiUnuttum));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btton_gonder = new DevExpress.XtraEditors.SimpleButton();
            this.txtf_kad = new System.Windows.Forms.TextBox();
            this.txtf_mail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adınız:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eposta Adresi:";
            // 
            // btton_gonder
            // 
            this.btton_gonder.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btton_gonder.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btton_gonder.Appearance.Options.UseFont = true;
            this.btton_gonder.Appearance.Options.UseForeColor = true;
            this.btton_gonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btton_gonder.ImageOptions.Image")));
            this.btton_gonder.Location = new System.Drawing.Point(295, 208);
            this.btton_gonder.Name = "btton_gonder";
            this.btton_gonder.Size = new System.Drawing.Size(107, 35);
            this.btton_gonder.TabIndex = 2;
            this.btton_gonder.Text = "Gönder";
            this.btton_gonder.Click += new System.EventHandler(this.btton_gonder_Click);
            // 
            // txtf_kad
            // 
            this.txtf_kad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtf_kad.Location = new System.Drawing.Point(200, 120);
            this.txtf_kad.Name = "txtf_kad";
            this.txtf_kad.Size = new System.Drawing.Size(119, 22);
            this.txtf_kad.TabIndex = 3;
            // 
            // txtf_mail
            // 
            this.txtf_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtf_mail.Location = new System.Drawing.Point(200, 169);
            this.txtf_mail.Name = "txtf_mail";
            this.txtf_mail.Size = new System.Drawing.Size(202, 22);
            this.txtf_mail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(94, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "ŞİFREMİ UNUTTUM EKRANI";
            // 
            // Frm_SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(483, 279);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtf_mail);
            this.Controls.Add(this.txtf_kad);
            this.Controls.Add(this.btton_gonder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_SifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifremi Unuttum Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btton_gonder;
        private System.Windows.Forms.TextBox txtf_kad;
        private System.Windows.Forms.TextBox txtf_mail;
        private System.Windows.Forms.Label label3;
    }
}