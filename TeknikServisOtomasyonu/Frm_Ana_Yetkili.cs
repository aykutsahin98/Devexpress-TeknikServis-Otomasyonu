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
    public partial class Frm_Ana_Yetkili : Form
    {

        public Frm_Ana_Yetkili()
        {
            InitializeComponent();
        }
        private void sifre_check_CheckedChanged(object sender, EventArgs e)
        {
            txtf_sifre.PasswordChar = sifre_check.Checked ? '\0' : '•';
        }
        private void bttn_yntci_grs_Click_1(object sender, EventArgs e)
        {
            sqlbaglantisi bgln = new sqlbaglantisi();
            SqlCommand kontrol = new SqlCommand("Select * From Yonetici Where Admin_Kullanici=@p1 and " +
               "Admin_Sifre=@p2", bgln.baglanti());
            kontrol.Parameters.AddWithValue("@p1", txtf_nickname.Text);
            kontrol.Parameters.AddWithValue("@p2", txtf_sifre.Text);
            SqlDataReader oku = kontrol.ExecuteReader();
            if (oku.Read())
            {
                int yontci_id = Convert.ToInt16(oku.GetValue(0)); //kullanıcı id çekme sorgusu
                MessageBox.Show("Hoşgeldin Yönetici", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Frm_YoneticiEkrani home = new Frm_YoneticiEkrani(yontci_id);
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız yada Şifreniz Yanlış", "Hata",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
    }
}
