using DevExpress.XtraEditors.Filtering.Templates;
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
    public partial class Frm_Persnel_AnaEkran : Form
    {
        sqlbaglantisi bgln = new sqlbaglantisi();
        public Frm_Persnel_AnaEkran()
        {
            InitializeComponent();
            
        }
        int id = 0;//kullanıcı id çekme
        public Frm_Persnel_AnaEkran(int gelenid)
        {
            InitializeComponent();
            id = gelenid;
            label2.Text = (Convert.ToString(id));
            Plistele();
        }
        void tarih()
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
        void Plistele()
        {
            SqlCommand liste = new SqlCommand("Select AdiSoyadi,Telefon,Mail From Personeller Where P_Id=@p1", bgln.baglanti());
            liste.Parameters.AddWithValue("@p1", id);
            SqlDataReader cikti = liste.ExecuteReader();
            while (cikti.Read())
            {
                txtf_adi.Text = cikti["AdiSoyadi"].ToString();
                masked_telefon.Text = cikti["Telefon"].ToString();
                txtf_mail.Text = cikti["Mail"].ToString();
            }
            bgln.baglanti().Close();
        }
        void biten()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select T.Teknik_Id, T.AdiSoyadi, T.Degisen_Parca, T.Yapilan_İslem, T.Teslim_Tarihi, P.AdiSoyadi, P.Telefon, " +
                "A.Marka, A.Model, A.SeriNo, A.Ariza_Detay, A.Garanti, A.Gönderim_Tarihi " +
                "From Yapilan_Islemler T, Personeller P, Ariza_Bilgisi A " +
                "Where T.Ariza_Id = A.Ariza_Id And A.P_Id = P.P_Id And T.AdiSoyadi is not null And P.P_Id=@p1", bgln.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", Convert.ToInt16(id));
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            dataGridView3.Columns[0].HeaderText = "ID";
            dataGridView3.Columns[1].HeaderText = "Adı Soyadı";
            dataGridView3.Columns[2].HeaderText = "Değişen Parça";
            dataGridView3.Columns[3].HeaderText = "İşlemler";
            dataGridView3.Columns[4].HeaderText = "Teslim Tarihi";
            dataGridView3.Columns[5].HeaderText = "Personel";
            dataGridView3.Columns[10].HeaderText = "Detay";
            dataGridView3.Columns[12].HeaderText = "Gönderim Tarihi";
            this.dataGridView3.DefaultCellStyle.Font = new Font("Tahoma", 9);
            this.dataGridView3.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView3.AllowUserToAddRows = false;//son kolonu temizleme
        }

        void islemdekiler()
        {
           
        }
        void temizle()
        {
            txtf_marka.Text = "";
            txtf_model.Text = "";
            masked_seri.Text = "";
            richTextBox1.Text = "";
            cmb_grnti.Text = "";
        }
        void listele() //DataGridView De Verileri Listeleme Fonksiyonu
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select A.Ariza_Id,P.AdiSoyadi,P.Telefon,P.Mail,A.Marka, A.Model, A.SeriNo, Ariza_Detay, " +
                "A.Garanti, A.Gönderim_Tarihi From Personeller P, Ariza_Bilgisi A " +
                " Where A.P_Id=P.P_Id And P.P_Id=@p1", bgln.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", Convert.ToInt16(id));
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Arıza No";
            dataGridView1.Columns[1].HeaderText = "Adı Soyadı";
            dataGridView1.Columns[2].HeaderText = "Telefon";
            dataGridView1.Columns[3].HeaderText = "Mail";
            dataGridView1.Columns[6].HeaderText = "Seri No";
            dataGridView1.Columns[7].HeaderText = "Arıza Detayı";
            dataGridView1.Columns[8].HeaderText = "Garanti";
            dataGridView1.Columns[9].HeaderText = "Gönderim Tarihi";

            dataGridView1.AllowUserToAddRows = false;//son kolonu temizleme
        }

        //Profil Bilgisi Güncelleme
        private void bilgileriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_personelguncelle guncel = new Frm_personelguncelle(id);
            guncel.Show();
        }
        //Listeleme
        private void Frm_Persnel_AnaEkran_Load(object sender, EventArgs e)
        {
            biten();
            timer1.Start();
            tarih();
            listele();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman();
        }
        //Çıkış Kodları
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
                //birşey yapma
            }
        }

        private void bttn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select Ariza_Id From Ariza_Bilgisi Where Model=@p1 and SeriNo=@p2", bgln.baglanti());
            komut.Parameters.AddWithValue("@p1", txtf_model.Text);
            komut.Parameters.AddWithValue("@p2", masked_seri.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("Aynı Arıza Kaydı Bulunmaktadır. Başka Kayıt Giriniz");
            }
            else
            {
                SqlCommand komut_ekle = new SqlCommand("insert into Ariza_Bilgisi(Marka,Model,SeriNo,Ariza_Detay," +
                "Garanti,GÖnderim_Tarihi,P_Id)" +
                "values(@p1, @p2, @p3, @p4,@p5,@p6,@p7)", bgln.baglanti());//İnsert İşlemini Tanımladım. 
                komut_ekle.Parameters.AddWithValue("@p1", txtf_marka.Text);
                komut_ekle.Parameters.AddWithValue("@p2", txtf_model.Text);
                komut_ekle.Parameters.AddWithValue("@p3", masked_seri.Text);
                komut_ekle.Parameters.AddWithValue("@p4", richTextBox1.Text);
                komut_ekle.Parameters.AddWithValue("@p5", cmb_grnti.Text);
                komut_ekle.Parameters.AddWithValue("@p6", dateTimePicker1.Value);
                komut_ekle.Parameters.AddWithValue("@p7", id); //Foreign Key Olduğu İçin İd ekleme işlemini kullanıcı girişinden çekiyorum.
                komut_ekle.ExecuteNonQuery();//komutları çalıştır.
                bgln.baglanti().Close();//bağlantıyı kapat
                MessageBox.Show("Arızanız Başarıyla Eklenmiştir.", "Bilgi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                listele();
                temizle(); //Her Seferinde TextBoxları Temizle
            }
        }
        private void sayfayıYenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void bttn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        //ARIZA SİLME İŞLEMİ
        private void bttn_sil_Click(object sender, EventArgs e)
        {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)  //Seçili Satırları Silme
                {
                    DialogResult sil = new DialogResult();
                    sil = MessageBox.Show("Arıza Kaydını Silmek İstiyor Musunuz?", "İnfo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (sil == DialogResult.Yes)
                    {
                        SqlCommand komut = new SqlCommand("Delete From Ariza_Bilgisi Where Ariza_Id = @p1", bgln.baglanti());
                        komut.Parameters.AddWithValue("@p1", Convert.ToInt32(row.Cells[0].Value));
                        komut.ExecuteNonQuery();
                        bgln.baglanti().Close();
                        listele();
                    }
                    else if (sil == DialogResult.No)
                    {
                        //hiçbirşey yapma
                    }
                }
            }
        
        private void bttn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("Update Ariza_Bilgisi Set Marka=@p4," +
                "Model=@p5,SeriNo=@p6,Ariza_Detay=@p7,Garanti=@p8,Gönderim_Tarihi=@p9 Where Ariza_Id=@p10", bgln.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", txtf_adi.Text);
            komutguncelle.Parameters.AddWithValue("@p2", masked_telefon.Text);
            komutguncelle.Parameters.AddWithValue("@p3", txtf_mail.Text);
            komutguncelle.Parameters.AddWithValue("@p4", txtf_marka.Text);
            komutguncelle.Parameters.AddWithValue("@p5", txtf_model.Text);
            komutguncelle.Parameters.AddWithValue("@p6", masked_seri.Text);
            komutguncelle.Parameters.AddWithValue("@p7", richTextBox1.Text);
            komutguncelle.Parameters.AddWithValue("@p8", cmb_grnti.Text);
            komutguncelle.Parameters.AddWithValue("@p9", dateTimePicker1.Value);
            komutguncelle.Parameters.AddWithValue("@p10", dataGridView1.Rows[i].Cells[0].Value);
            komutguncelle.ExecuteNonQuery();//komutları çalıştır.
            bgln.baglanti().Close();//bağlantıyı kapat
            MessageBox.Show("Arıza Bilgisi Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            listele();
        }

        private void anaSayfayaDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ilkgiris giris = new Frm_ilkgiris();
            MessageBox.Show("Oturumunuz Sonlandırılmıştır.");
            giris.Show();
            bgln.baglanti().Close();
            this.Close();
        }
        int i = 0; //İLK  KAYITLARI GETİRME
        private void btton_ilk_Click(object sender, EventArgs e)
        {
            i = 0;//index değeri 0 dan başla datagridview hücreleri kadar git.
            txtf_adi.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            masked_telefon.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtf_mail.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtf_marka.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtf_model.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            masked_seri.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            cmb_grnti.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();

        }
        //GERİYE GİTME BLOĞU
        private void bttn_geri_Click(object sender, EventArgs e)
        {
            i--;
            if (i >= -0)//i'yi eksilterek listenin gerisine  git
            {
                txtf_adi.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                masked_telefon.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                txtf_mail.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                txtf_marka.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                txtf_model.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                masked_seri.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                richTextBox1.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
                cmb_grnti.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            }
            else
            {//-0'ın altına düşmesi durumunda ilk kayıta ulaştınız de.
                MessageBox.Show("İlk Kayıta Ulaştınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //İLERİ GİTME BLOĞU
        private void bttn_ileri_Click(object sender, EventArgs e)
        {
            i++;
            if (i < dataGridView1.Rows.Count - 0)//burada datagridview satırlarının sayısı kadar ileriye git
            {
                txtf_adi.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                masked_telefon.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                txtf_mail.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                txtf_marka.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                txtf_model.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                masked_seri.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                richTextBox1.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
                cmb_grnti.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            }
            else
            {
                MessageBox.Show("Son Kayıta Ulaştınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //SON KAYITLARA GİTME BLOGU
        private void bttn_son_Click(object sender, EventArgs e)
        {
            int satir = dataGridView1.Rows.Count;
            cmb_grnti.Text = satir.ToString();
            i = satir - 1; //son kayıta  gelmesi için 
            txtf_adi.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            masked_telefon.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtf_mail.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtf_marka.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtf_model.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            masked_seri.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            cmb_grnti.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            txtf_marka.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtf_model.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            masked_seri.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            cmb_grnti.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();

        }

        private void bttn_ara_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Ariza_Bilgisi Where Marka like '%" + txtf_ara.Text + "%' or " +
            "SeriNo like '%" + txtf_ara.Text + "%' or " +
            "Garanti like '%" + txtf_ara.Text + "%' or " +
            "Model like '%" + txtf_ara.Text + "%' ", bgln.baglanti());
            DataTable dt = new DataTable(); // yeni bir table nesne üret
            //da.Fill(dt);
            dataGridView1.DataSource = dt;  //datagrid içine alınan bilgileri yükle
            txtf_ara.Text = "";
            //tabControl1.SelectedIndex = 1;//her arama yapıldığında tab 2'e git

            if (da.Fill(dt) < 1) //gelen sonuclar 1 den küçük ise 
            {
                MessageBox.Show("Aradığınız Arıza Kaydı Bilgisi Bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}