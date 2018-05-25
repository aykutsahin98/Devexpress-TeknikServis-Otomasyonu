using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisOtomasyonu
{
    public partial class Frm_UyeKayit : Form
    {
        public Frm_UyeKayit()
        {
            InitializeComponent();
            lbl_baslik.Text = "PERSONEL EKLEME EKRANI HOŞGELDİNİZ";
            txtf_sifre.Text = CreatePassword(8); //Form İlk Yüklendiğinde Çalıştır.
        }
        private void buttn_kayit_Click(object sender, EventArgs e)
        {
            sqlbaglantisi bgln = new sqlbaglantisi();
            try
            {
                //Verileri Kaydetme Bölümü
                SqlCommand kaydet = new SqlCommand("insert into Personeller" +
                    "(AdiSoyadi,KullaniciAdi,Sifre,Telefon,Mail)" +
                    "values(@p1,@p2,@p3,@p4,@p5)", bgln.baglanti());
                kaydet.Parameters.AddWithValue("@p1", txtf_ad.Text);//İnsert Kısmında Tanımlanmış Olan Parametrelere Uygun Değerleri Getir.
                kaydet.Parameters.AddWithValue("@p2", txtf_nickname.Text);
                kaydet.Parameters.AddWithValue("@p3", txtf_sifre.Text);
                kaydet.Parameters.AddWithValue("@p4", masked_telefon.Text);
                kaydet.Parameters.AddWithValue("@p5", txtf_mail.Text);
                kaydet.ExecuteNonQuery();//komutları çalıştır.
                bgln.baglanti().Close();// Bağlantıyı Kapat.

                SqlCommand cmd = new SqlCommand("Select * From Personeller where AdiSoyadi='" +
                    txtf_ad.Text + "'", bgln.baglanti());
                SqlDataReader dr = cmd.ExecuteReader();//SqlCommand da ki komutu DataReader ile Oku
                bool parola_Verildimi = false;
                if (dr.Read())
                {
                    try
                    {
                        SmtpClient smtpserver = new SmtpClient();
                        MailMessage mail = new MailMessage();
                        String tarih = DateTime.Now.ToLongDateString();
                        String mailadresin = ("teknksrvis@gmail.com"); //gmail adresi
                        String mailsifren = ("teknik123"); // sifre
                        String smptsrvr = "smtp.gmail.com"; //sunucu
                        String kime = (dr["Mail"].ToString());//maili çek
                        String konu = ("Üyelik Bilgilendirmesi Hakkında!"); //konu
                        String yazi = ("Sayın, " + dr["AdiSoyadi"].ToString() + "\n" + "Hesabınız " + tarih + " tarihinde başarıyla oluşturmuştur.\n" +
                       "Teknik Servis Takip Programı'na giriş için gerekli kullanıcı adınız ve şifreniz aşağıda verilmiştir :\n" + "Kullanıcı Adınız: " + dr["KullaniciAdi"].ToString() + "\n" + "Parolanız : " + dr["Sifre"].ToString()
                       + "\n\nİyi Günler Dileriz." + "\n\n\nTeknik Servis Otomasyonu V.1.0");// metin
                        smtpserver.Credentials = new NetworkCredential(mailadresin, mailsifren);
                        smtpserver.Port = 587;
                        smtpserver.Host = smptsrvr;
                        smtpserver.EnableSsl = true; //Güvenliği Aç
                        mail.From = new MailAddress(mailadresin);
                        mail.To.Add(kime);
                        mail.Subject = konu;
                        mail.Body = yazi;
                        smtpserver.Send(mail);
                        MessageBox.Show("Yeni Personel Başarıyla Sisteme Kayıt Edildi. Kullanıcı Adı ve Şifresi Mail ile Teknik Elemana Gönderildi.",
                            "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();//Sayfayı Kapat.

                    }
                    catch (Exception hata)
                    { MessageBox.Show(hata.Message); }
                    parola_Verildimi = true;
                    if (parola_Verildimi) { this.Close(); }
                }
                if (parola_Verildimi == false)
                { MessageBox.Show("Hatalı Bilgiler"); }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                this.Close();
            }
        }
        public string CreatePassword(int size)
        {
            char[] cr = "0123456789abcdefgıjklmnopqrstuwxyzABCDEFGHIJKLMNOPQRSTUWXYZ".ToCharArray(); //char karakterlerden dizi oluştur
            string result = string.Empty; //bellekte tut
            Random r = new Random();
            for (int i = 0; i < size; i++) //fonksiyona gönderilen boyut kadar git
            {
                result += cr[r.Next(0, cr.Length - 1)].ToString(); //sonucu 1 arttır dizinin içinde 8 karakter al
            }
            return result; //sonucu döndür
        }

        private void chck_sifre_CheckedChanged(object sender, EventArgs e)
        {
            txtf_sifre.PasswordChar =chck_sifre.Checked ? '\0' : '•';
        }
    }
}
