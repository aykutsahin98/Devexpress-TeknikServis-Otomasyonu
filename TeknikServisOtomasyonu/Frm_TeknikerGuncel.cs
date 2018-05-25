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
    public partial class Frm_TeknikerGuncel : Form
    {
        public Frm_TeknikerGuncel()
        {
            InitializeComponent();
        }
        int teknik_id = 0;
        public Frm_TeknikerGuncel(int gelenid)
        {
            InitializeComponent();
            teknik_id = gelenid;
            txtf_id.Text = Convert.ToString(teknik_id);
            listele();
        }

        void listele()
        {
            SqlCommand komut = new SqlCommand("Select * From Yapilan_Islemler Where Teknik_Id=@p1", bgln.baglanti());
            komut.Parameters.AddWithValue("@p1", Convert.ToString(teknik_id));
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txtf_id.Text = oku["Teknik_Id"].ToString();
                txtf_kullanici.Text = oku["KullaniciAdi"].ToString();
                masked_telefon.Text = oku["Telefon"].ToString();
                txtf_sifre.Text = oku["Sifre"].ToString();
                txtf_mail.Text = oku["Mail"].ToString();
            }
            bgln.baglanti().Close();
        }

        sqlbaglantisi bgln = new sqlbaglantisi();
        private void bttn_tknkguncel_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("Update Yapilan_Islemler Set KullaniciAdi=@p1,Telefon=@p2," +
               "Mail=@p3,Sifre=@p4 Where Teknik_Id=@p5", bgln.baglanti());
            guncelle.Parameters.AddWithValue("@p1", txtf_kullanici.Text);
            guncelle.Parameters.AddWithValue("@p2", masked_telefon.Text);
            guncelle.Parameters.AddWithValue("@p3", txtf_mail.Text);
            guncelle.Parameters.AddWithValue("@p4", txtf_sifre.Text);
            guncelle.Parameters.AddWithValue("@p5", txtf_id.Text);
            guncelle.ExecuteNonQuery();//komutları çalıştır.
            bgln.baglanti().Close();//bağlantıyı kapat
            MessageBox.Show("Bilgileriniz Başarıyla Güncellendi.Çıkış Yapıp Tekrardan Giriş Yapınız!", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            listele();
            this.Close();
        }

        private void sifre_check_CheckedChanged(object sender, EventArgs e)
        {
            txtf_sifre.PasswordChar = sifre_check.Checked ? '\0' : '•';
        }
    }
}
