namespace TeknikServisOtomasyonu
{
    partial class Frm_ilkgiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ilkgiris));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.personel_bttn = new DevExpress.XtraEditors.SimpleButton();
            this.technic_bttn = new DevExpress.XtraEditors.SimpleButton();
            this.bilgislm_bttn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tarih.ForeColor = System.Drawing.Color.White;
            this.lbl_tarih.Location = new System.Drawing.Point(353, 9);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(113, 24);
            this.lbl_tarih.TabIndex = 1;
            this.lbl_tarih.Text = "label1";
            // 
            // personel_bttn
            // 
            this.personel_bttn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("personel_bttn.ImageOptions.Image")));
            this.personel_bttn.Location = new System.Drawing.Point(172, 223);
            this.personel_bttn.Name = "personel_bttn";
            this.personel_bttn.Size = new System.Drawing.Size(128, 41);
            this.personel_bttn.TabIndex = 2;
            this.personel_bttn.Text = "Personel Girişi";
            this.personel_bttn.Click += new System.EventHandler(this.personel_bttn_Click);
            // 
            // technic_bttn
            // 
            this.technic_bttn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("technic_bttn.ImageOptions.Image")));
            this.technic_bttn.Location = new System.Drawing.Point(172, 270);
            this.technic_bttn.Name = "technic_bttn";
            this.technic_bttn.Size = new System.Drawing.Size(128, 41);
            this.technic_bttn.TabIndex = 3;
            this.technic_bttn.Text = "Technic Support";
            this.technic_bttn.Click += new System.EventHandler(this.technic_bttn_Click);
            // 
            // bilgislm_bttn
            // 
            this.bilgislm_bttn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bilgislm_bttn.ImageOptions.Image")));
            this.bilgislm_bttn.Location = new System.Drawing.Point(172, 317);
            this.bilgislm_bttn.Name = "bilgislm_bttn";
            this.bilgislm_bttn.Size = new System.Drawing.Size(128, 41);
            this.bilgislm_bttn.TabIndex = 4;
            this.bilgislm_bttn.Text = "Bilgi İşlem Girişi";
            this.bilgislm_bttn.Click += new System.EventHandler(this.bilgislm_bttn_Click);
            // 
            // Frm_ilkgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(478, 420);
            this.Controls.Add(this.bilgislm_bttn);
            this.Controls.Add(this.technic_bttn);
            this.Controls.Add(this.personel_bttn);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_ilkgiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlk Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_tarih;
        private DevExpress.XtraEditors.SimpleButton technic_bttn;
        private DevExpress.XtraEditors.SimpleButton bilgislm_bttn;
        private DevExpress.XtraEditors.SimpleButton personel_bttn;
    }
}