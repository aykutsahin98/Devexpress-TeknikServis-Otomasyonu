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
    public partial class Frm_personelguncelle : Form
    {
        public Frm_personelguncelle()
        {
            InitializeComponent();
        }

        int id = 0;
        public Frm_personelguncelle(int gelenid)
        {
            InitializeComponent();
            id = gelenid;
            txtf_id.Text = Convert.ToString(id);
            listele();
        }

        sqlbaglantisi bgln = new sqlbaglantisi();
        void listele()
        {
            SqlCommand komut = new SqlCommand("Select * From Personeller Where P_Id=@p1", bgln.baglanti());
            komut.Parameters.AddWithValue("@p1", Convert.ToString(id));
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txtf_id.Text = oku["P_Id"].ToString();
                maskedguncel_tel.Text = oku["Telefon"].ToString();
                txtf_sifre.Text = oku["Sifre"].ToString();
                txtf_gncl_mail.Text = oku["Mail"].ToString();
            }
            bgln.baglanti().Close();
        }
        private void bttn_perguncelle_Click_1(object sender, EventArgs e)
        {
            SqlCommand komutguncel = new SqlCommand("Update Personeller Set Telefon=@p1,Sifre=@p2,Mail=@p3 " +
               "Where P_Id=@p4", bgln.baglanti());
            komutguncel.Parameters.AddWithValue("@p1", maskedguncel_tel.Text);
            komutguncel.Parameters.AddWithValue("@p2", txtf_sifre.Text);
            komutguncel.Parameters.AddWithValue("@p3", txtf_gncl_mail.Text);
            komutguncel.Parameters.AddWithValue("@p4", txtf_id.Text);
            komutguncel.ExecuteNonQuery();
            bgln.baglanti().Close();//bağlantıyı kapat
            MessageBox.Show("Personel Bilgisi Başarıyla Güncellendi.Çıkış Yapıp Tekrardan Giriş Yapınız!", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            listele();
            this.Close();
        }

        private void sifre_check_CheckedChanged_1(object sender, EventArgs e)
        {
            txtf_sifre.PasswordChar = sifre_check.Checked ? '\0' : '•';
        }
    }
}
