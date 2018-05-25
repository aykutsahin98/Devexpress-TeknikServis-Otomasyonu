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
    public partial class Frm_YoneticiEkrani : Form
    {
        public Frm_YoneticiEkrani()
        {
            InitializeComponent();
        }

        int yontci_id = 0;
        public Frm_YoneticiEkrani(int gelen_id)
        {
            InitializeComponent();
            yontci_id = gelen_id;
            label6.Text = Convert.ToString(yontci_id);
            isimliste();
            teknikerlistele();
        }

        sqlbaglantisi bgln = new sqlbaglantisi();
        void tarih() //Tarihi Görüntülemek İçin Bir Fonksiyon
        {
            int ay = DateTime.Now.Month;
            int yil = DateTime.Now.Year;
            int gun = DateTime.Now.Day;
            tarih_menu.Text = "Tarih: " + gun + "/" + (ay) + "/" + yil;
        }

        void zaman() //Zamanı Görüntülemek İçin Bir Fonksiyon
        {
            String Sure = DateTime.Now.ToLongTimeString();
            zaman_menu.Text = "Saat: " + Sure;
        }

        void isimliste() //Yönetici İsimini Textboxlara veritabanından çekmek  için fonsiyon
        {
            SqlCommand komutlar = new SqlCommand("Select A.Admin_Adi,A.Admin_Soyadi From Yonetici A", bgln.baglanti());
            SqlDataReader oku = komutlar.ExecuteReader();//verileri okut.
            while (oku.Read())
            {
                txtf_ad.Text = oku["Admin_Adi"].ToString();
                txtf_soyad.Text = oku["Admin_Soyadi"].ToString();
            }
            bgln.baglanti().Close();
        }
        
        void teknikerlistele() //Teknikerleri Listeliyorum
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Teknik_Id,AdiSoyadi,Telefon,Mail,KullaniciAdi,Sifre " +
                "From Yapilan_Islemler Where Telefon is not null", bgln.baglanti());
            da.Fill(dt);
            datagrid_tekniker.DataSource = dt;
            datagrid_tekniker.AllowUserToAddRows = false;
            datagrid_tekniker.Columns[0].HeaderText = "ID Numarası";
            datagrid_tekniker.Columns[1].HeaderText = "Adı Soyadı";
            datagrid_tekniker.Columns[3].HeaderText = "E-Posta";
            datagrid_tekniker.Columns[4].HeaderText = "Kullanıcı Adı";
            datagrid_tekniker.Columns[5].HeaderText = "Şifre";
            //Kolon başlıklarının yazı tipi rengini değiştirir.
            datagrid_tekniker.EnableHeadersVisualStyles = false;
            datagrid_tekniker.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            // Kolon başlıklarının yazı tipi,fontu ve font stilini belirler.
            datagrid_tekniker.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Calibri", 10, FontStyle.Bold);  
        }

        void personel_liste() //Personelleri Listelemek İçin Fonskiyon
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select P.P_Id,P.AdiSoyadi,P.Telefon,P.KullaniciAdi,P.Sifre,P.Mail " +
                "From Personeller P", bgln.baglanti());
            da.Fill(dt);
            datagrid_prsnl_liste.DataSource = dt;
            datagrid_prsnl_liste.AllowUserToAddRows = false;
            datagrid_prsnl_liste.Columns[0].HeaderText = "ID Numarası";
            datagrid_prsnl_liste.Columns[1].HeaderText = "Adı Soyadı";
            datagrid_prsnl_liste.Columns[3].HeaderText = "Kullanıcı Adı";
            datagrid_prsnl_liste.Columns[4].HeaderText = "Şifre";
            datagrid_prsnl_liste.Columns[5].HeaderText = "E-Posta";
            //Kolon başlıklarının yazı tipi rengini değiştirir.
            datagrid_prsnl_liste.EnableHeadersVisualStyles = false;
            datagrid_prsnl_liste.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            // Kolon başlıklarının yazı tipi,fontu ve font stilini belirler.
            datagrid_prsnl_liste.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Calibri", 10, FontStyle.Bold);
        }

        void secimlistesi() //Teknikerleri Combobox'a Dolduruyorum.
        {
            SqlCommand komutlar = new SqlCommand("SELECT S.AdiSoyadi From Yapilan_Islemler S Where S.Telefon is not null", bgln.baglanti());
            SqlDataReader oku = komutlar.ExecuteReader();//verileri okut.
            while (oku.Read())
            {
                cmb_tekniker.Items.Add(oku[0]);
            }
            bgln.baglanti().Close();
        }
        void arizalar() //DataGridView De Verileri Listeleme Fonksiyonu
        {
            DataTable dt = new DataTable();//Yeni bir dataset oluştur. 
            SqlDataAdapter da = new SqlDataAdapter("Select P.P_Id,P.AdiSoyadi,P.Telefon,P.Mail,A.Marka, A.Model, A.SeriNo, Ariza_Detay, " +
                "A.Garanti, A.Gönderim_Tarihi From Personeller P, Ariza_Bilgisi A " +
                " Where A.P_Id=P.P_Id", bgln.baglanti());
            da.Fill(dt); //datagridview sorgudan gelen veriler ile doldur.
            datagrid_bekleyen.DataSource = dt;
            datagrid_bekleyen.Columns[0].HeaderText = "Personel Numarası"; //datagridview kolon başlıkları
            datagrid_bekleyen.Columns[1].HeaderText = "Adı Soyadı";
            datagrid_bekleyen.Columns[2].HeaderText = "Telefon";
            datagrid_bekleyen.Columns[3].HeaderText = "Mail";
            datagrid_bekleyen.Columns[6].HeaderText = "Seri No";
            datagrid_bekleyen.Columns[7].HeaderText = "Arıza Detayı";
            datagrid_bekleyen.Columns[8].HeaderText = "Garanti";
            datagrid_bekleyen.Columns[9].HeaderText = "Gönderim Tarihi";
            this.datagrid_bekleyen.DefaultCellStyle.Font = new Font("Tahoma", 9);
            this.datagrid_bekleyen.DefaultCellStyle.ForeColor = Color.Black;

            datagrid_bekleyen.AllowUserToAddRows = false;//son kolonu temizleme
        }

        private void Frm_YoneticiEkrani_Load(object sender, EventArgs e)
        {
            timer1.Start(); //Timer'ı Formun Loadın da Başlatıyorum.
            tarih();
            //teknikerlistele();
            personel_liste();
            secimlistesi();
            arizalar();
        }
        //Timer Nesnesi Ekledikten Sonra Timer'ın İçinde Zaman Fonksiyonu nu Çağırıyorum.
        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman();
        }

        private void bilgileriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_YoneticiGuncel yonetici = new Frm_YoneticiGuncel(yontci_id);
            yonetici.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult info = new DialogResult();
            info = MessageBox.Show("Oturumdan Çıkmak İstiyor Musunuz?", "İnfo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (info == DialogResult.Yes)
            {
                this.Close();
                bgln.baglanti().Close();
                Frm_ilkgiris git = new Frm_ilkgiris();
                git.Show();
            }
            else if (info == DialogResult.No)
            {
            }
        }

        private void teknikerEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_TeknikElemanUye uye = new Frm_TeknikElemanUye();
            uye.Show();
        }

        private void teknikerSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in datagrid_tekniker.SelectedRows)  //Seçili Satırları Silme
            {
                DialogResult sil = new DialogResult();
                sil = MessageBox.Show("Silmek İstiyor Musunuz?", "İnfo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sil == DialogResult.Yes)
                {
                    SqlCommand komut = new SqlCommand("Delete From Yapilan_Islemler Where Teknik_Id = @p1", bgln.baglanti());
                    komut.Parameters.AddWithValue("@p1", Convert.ToInt32(row.Cells[0].Value));
                    komut.ExecuteNonQuery();
                    bgln.baglanti().Close();
                    teknikerlistele();
                }
                else if (sil == DialogResult.No)
                {
                    //hiçbirşey yapma
                }
            }
        }

        private void listeyiYenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liste Yenilenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            teknikerlistele();
            personel_liste();
        }
        //ARAMA İŞLEMİ BÖLÜMÜ
        private void ara_button_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Yapilan_Islemler Where AdiSoyadi like '%" + txtf_ara.Text + "%' or " +
            "KullaniciAdi like '%" + txtf_ara.Text + "%' or " +
            "Mail like '%" + txtf_ara.Text + "%' ", bgln.baglanti());
            DataTable dt = new DataTable(); // yeni bir table nesne üret
            //da.Fill(dt);
            datagrid_tekniker.DataSource = dt;  //datagrid içine alınan bilgileri yükle
            txtf_ara.Text = "";
            tabControl1.SelectedIndex = 1;//her arama yapıldığında tab 2'e git

            if (da.Fill(dt) < 1) //gelen sonuclar 1 den küçük ise 
            {
                MessageBox.Show("Aradığınız Tekniker Kaydı Bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void person_ara_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Personeller Where AdiSoyadi like '%" + txtf_ara.Text + "%' or " +
           "KullaniciAdi like '%" + txtf_ara.Text + "%' or " +
           "Telefon like '%" + txtf_ara.Text + "%' ", bgln.baglanti());
            DataTable dt1 = new DataTable();// yeni bir table nesne üret
            //da1.Fill(dt1);
            datagrid_prsnl_liste.DataSource = dt1; //datagrid içine alınan bilgileri yükle
            txtf_ara.Text = "";
            tabControl1.SelectedIndex = 0; //her arama yapıldığında tab 1'e git

            if (da1.Fill(dt1) < 1) //gelen sonuclar 1 den küçük ise 
            {
                MessageBox.Show("Aradığınız Personel Kaydı Bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void datagrid_bekleyen_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label7.Text = datagrid_bekleyen.SelectedCells[0].Value.ToString();
        }
        FrmTeknikServisEkran ekran = new FrmTeknikServisEkran();
        DataTable table = new DataTable();
        private void bttn_yonlendir_Click(object sender, EventArgs e)
        {
            if (cmb_tekniker.SelectedIndex==0 || cmb_tekniker.SelectedIndex==1)
            {
                MessageBox.Show("Arızanız Teknikere Yönlendirilmiştir.");
            }
        }
    }
}
