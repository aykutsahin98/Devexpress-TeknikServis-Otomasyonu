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
    public partial class Frm_PersonelGiris : Form
    {
        sqlbaglantisi bgln = new sqlbaglantisi();//SQL Bağlantı Sınıfı
        public Frm_PersonelGiris()
        {
            InitializeComponent();
        }
        //Şifremi Unuttum Ekranına Geçiş 
        private void lbl_unuttum_Click(object sender, EventArgs e)
        {
            Frm_SifremiUnuttum unuttum = new Frm_SifremiUnuttum();
            unuttum.Show();
        }
        //Giriş Kodları
        private void bttn_giris_Click_1(object sender, EventArgs e)
        {
            SqlCommand kontrol = new SqlCommand("Select * From Personeller Where KullaniciAdi=@p1 and " +
               "Sifre=@p2", bgln.baglanti());
            kontrol.Parameters.AddWithValue("@p1", txtf_kullnci_adi.Text);
            kontrol.Parameters.AddWithValue("@p2", txtf_sifre.Text);
            SqlDataReader oku = kontrol.ExecuteReader();
            if (oku.Read())
            {
                int id = Convert.ToInt16(oku.GetValue(0)); 
                MessageBox.Show("Giriş Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Frm_Persnel_AnaEkran ac = new Frm_Persnel_AnaEkran(id);
                ac.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            oku.Close();
        }
        
        //Şifreyi Göster Kontrolü
        private void sifre_check_CheckedChanged(object sender, EventArgs e)
        {
            txtf_sifre.PasswordChar = sifre_check.Checked ? '\0' : '•';
        }
    }
}