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
    public partial class Frm_TeknkDstk_Giris : Form
    {
        public Frm_TeknkDstk_Giris()
        {
            InitializeComponent();
        }
       
        sqlbaglantisi bgln = new sqlbaglantisi(); // Sql Bağlantı Sınıfı 
        private void bttn_teknik_Click_1(object sender, EventArgs e)
        {
            SqlCommand kontrol = new SqlCommand("Select * From Yapilan_Islemler Where KullaniciAdi=@p1 and " +
                "Sifre=@p2", bgln.baglanti());
            kontrol.Parameters.AddWithValue("@p1", txtf_nickname.Text);
            kontrol.Parameters.AddWithValue("@p2", txtf_sifre.Text);
            SqlDataReader oku = kontrol.ExecuteReader();
            if (oku.Read())
            {
                int id = Convert.ToInt16(oku.GetValue(0)); //kullanıcı id çekme sorgusu
                MessageBox.Show("Giriş Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmTeknikServisEkran ekran = new FrmTeknikServisEkran(id);
                ekran.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız yada Şifreniz Yanlış", "Hata", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chckbox_sifre_CheckedChanged_1(object sender, EventArgs e)
        {
            txtf_sifre.PasswordChar = chckbox_sifre.Checked ? '\0' : '•';
        }
    }
}
