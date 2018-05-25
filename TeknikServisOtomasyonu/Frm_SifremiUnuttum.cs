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
    public partial class Frm_SifremiUnuttum : Form
    {
        public Frm_SifremiUnuttum()
        {
            InitializeComponent();
        }
        private void btton_gonder_Click(object sender, EventArgs e)
        {
            sqlbaglantisi bgln = new sqlbaglantisi();
            SqlCommand komut = new SqlCommand("Select * from Personeller where KullaniciAdi='" + txtf_kad.Text.ToString() +
                        "'and Mail='" + txtf_mail.Text.ToString() + "'", bgln.baglanti());
           
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                try
                {
                    if (bgln.baglanti().State == ConnectionState.Closed) 
                    {
                        bgln.baglanti().Open(); 
                    }
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    String tarih = DateTime.Now.ToLongDateString();
                    String mailadresin = ("teknksrvis@gmail.com");
                    String mailsifren = ("teknik123");
                    String smptsrvr = "smtp.gmail.com"; 
                    String kime = (oku["Mail"].ToString());
                    String konu = ("Şifre Hatırlatma Talebi"); 
                    String yazi = ("Sayın, " + oku["AdiSoyadi"].ToString() + "\n" + "Bizden " + tarih + " tarihi itibariyle şifre hatırlatma talebinde bulundunuz.\n" +
                        "\n" + "Parolanız : " + oku["Sifre"].ToString()
                        +"\n\nİyi Günler.");  // metin

                    smtpserver.Credentials = new NetworkCredential(mailadresin, mailsifren);
                    smtpserver.Port = 587;
                    smtpserver.Host = smptsrvr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadresin);
                    mail.To.Add(kime);
                    mail.Subject = konu;
                    mail.Body = yazi;
                    smtpserver.Send(mail);
                    DialogResult bilgi = new DialogResult(); 
                    bilgi=MessageBox.Show("Girmiş Oldunuz Bilgiler Uyuşuyor Şifreniz Mail Adresinize Yollandı.");
                    this.Hide();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Mail Gönderme Hatası!",hata.Message);
                }
            }
        }
    }
}