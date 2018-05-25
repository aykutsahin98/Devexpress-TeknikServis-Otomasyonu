using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisOtomasyonu
{
    public partial class Frm_YoneticiGuncel : Form
    {
        public Frm_YoneticiGuncel()
        {
            InitializeComponent();
        }

        int yontci_id = 0;
        public Frm_YoneticiGuncel(int gelen_id)
        {
            InitializeComponent();
            yontci_id = gelen_id;
            txtf_id.Text = Convert.ToString(yontci_id);
            yonetici_listele();
        }

        sqlbaglantisi bgln = new sqlbaglantisi();
        void yonetici_listele()
        {
            SqlCommand komut = new SqlCommand("Select * From Yonetici Where Admin_Id=@p1", bgln.baglanti());
            komut.Parameters.AddWithValue("@p1", Convert.ToString(yontci_id));
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txtf_id.Text = oku["Admin_Id"].ToString();
                txtf_kadi.Text = oku["Admin_Kullanici"].ToString();
                txtf_sifre.Text = oku["Admin_Sifre"].ToString();
            }
            bgln.baglanti().Close();
        }

        private void chck_sifre_CheckedChanged(object sender, EventArgs e)
        {
            txtf_sifre.PasswordChar = chck_sifre.Checked ? '\0' : '•';
        }

        private void bttn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncel = new SqlCommand("Update Yonetici Set Admin_Kullanici=@p1, Admin_Sifre=@p2" +
              " Where Admin_Id=@p3", bgln.baglanti());
            komutguncel.Parameters.AddWithValue("@p1", txtf_kadi.Text);
            komutguncel.Parameters.AddWithValue("@p2", txtf_sifre.Text);
            komutguncel.Parameters.AddWithValue("@p3", txtf_id.Text);
            komutguncel.ExecuteNonQuery();
            bgln.baglanti().Close();//bağlantıyı kapat
            MessageBox.Show("Yönetici Bilgileri Başarıyla Güncellendi.Çıkış Yapıp Tekrardan Giriş Yapınız!", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            yonetici_listele();
            this.Close();
        }
    }
}
