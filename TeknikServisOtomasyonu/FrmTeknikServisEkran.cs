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
    public partial class FrmTeknikServisEkran : Form
    {
        sqlbaglantisi bgln = new sqlbaglantisi();
        public FrmTeknikServisEkran()
        {
            InitializeComponent();
        }

        int id = 0;
        public FrmTeknikServisEkran(int gelenid)
        {
            InitializeComponent();
            id = gelenid;
            label15.Text = (Convert.ToString(id));
           // arizalar();
        }
        void tarih() //Tarihi Görüntülemek İçin Bir Fonksiyon
        {
            int ay = DateTime.Now.Month;
            int yil = DateTime.Now.Year;
            int gun = DateTime.Now.Day;
            tarih_menu.Text = "Tarih: " + gun + "/" + (ay) + "/" + yil;
        }
        void temizle()
        {
            txtf_gonderen.Text = "";
            txtf_marka.Text = "";
            txtf_model.Text = "";
            richtxtf_detay.Text = "";
            richtxtf_islem.Text = "";
            richtxtf_parca.Text = "";
            cmb_garanti.Text = "";
            masked_seri.Text = "";
            masked_telefon1.Text = "";
        }
        void zaman() //Zamanı Görüntülemek İçin Bir Fonksiyon
        {
            String Sure = DateTime.Now.ToLongTimeString();
            zaman_menu.Text = "Saat: " + Sure;
        }
        void Tekniklistele()
        {
            SqlCommand liste = new SqlCommand("Select AdiSoyadi From Yapilan_Islemler Where Teknik_Id=@p1", bgln.baglanti());
            liste.Parameters.AddWithValue("@p1", id);
            SqlDataReader cikti = liste.ExecuteReader();
            if (cikti.Read())
            {
                txtf_teknik_ad.Text = cikti["AdiSoyadi"].ToString();
            }
            bgln.baglanti().Close();
        }
        void arizalar() //DataGridView De Verileri Listeleme Fonksiyonu
        {
            DataTable dt = new DataTable();//Yeni bir dataset oluştur. 
            SqlDataAdapter da = new SqlDataAdapter("Select A.Ariza_Id,P.AdiSoyadi,P.Telefon,A.Marka, A.Model, A.SeriNo, Ariza_Detay, " +
                "A.Garanti, A.Gönderim_Tarihi From Personeller P, Ariza_Bilgisi A " +
                " Where A.P_Id=P.P_Id", bgln.baglanti());
            da.Fill(dt);
            datagrid_ariza.DataSource = dt;
            datagrid_ariza.Columns[0].HeaderText = "Personel Numarası";
            datagrid_ariza.Columns[1].HeaderText = "Adı Soyadı";
            // datagrid_ariza.Columns[3].HeaderText = "Telefon";
            // datagrid_ariza.Columns[4].HeaderText = "Marka";
            // datagrid_ariza.Columns[5].HeaderText = "Model";
            datagrid_ariza.Columns[5].HeaderText = "Seri No";
            datagrid_ariza.Columns[6].HeaderText = "Arıza Detayı";
            datagrid_ariza.Columns[8].HeaderText = "Gönderim Tarih";
            this.datagrid_ariza.DefaultCellStyle.Font = new Font("Tahoma", 9);
            this.datagrid_ariza.DefaultCellStyle.ForeColor = Color.Black;
            datagrid_ariza.AllowUserToAddRows = false;//son kolonu temizleme
        }

        void gecmislistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select T.Teknik_Id,T.AdiSoyadi,T.Degisen_Parca,T.Yapilan_İslem,T.Teslim_Tarihi," +
                "P.AdiSoyadi,P.Telefon, A.Marka, A.Model, A.SeriNo, A.Ariza_Detay, A.Garanti, A.Gönderim_Tarihi " +
                "From Yapilan_Islemler T, Ariza_Bilgisi A, Personeller P " +
                "Where T.Ariza_Id = A.Ariza_Id And A.P_Id = P.P_Id", bgln.baglanti());
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            dataGridView3.Columns[0].HeaderText = "ID";
            dataGridView3.Columns[1].HeaderText = "Adı Soyadı";
            dataGridView3.Columns[2].HeaderText = "Değişen Parça";
            dataGridView3.Columns[3].HeaderText = "İşlemler";
            dataGridView3.Columns[4].HeaderText = "Teslim Tarihi";
            dataGridView3.Columns[5].HeaderText = "Personel";
            dataGridView3.Columns[9].HeaderText = "Detay";
            dataGridView3.Columns[11].HeaderText = "Gönderim Tarihi";
            this.dataGridView3.DefaultCellStyle.Font = new Font("Tahoma", 9);
            this.dataGridView3.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView3.AllowUserToAddRows = false;//son kolonu temizleme
        }

        private void FrmTeknikServisEkran_Load(object sender, EventArgs e)
        {
            gecmislistele();
            Tekniklistele();
            arizalar();
            timer1.Start();
            tarih();
        }
        private void bilgileriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_TeknikerGuncel git = new Frm_TeknikerGuncel(id);
            git.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman();
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
                //Hiçbirşey Yapma
            }
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_UyeKayit frm = new Frm_UyeKayit();
            frm.Show();
            //this.Hide();
        }

        int i = 0; //İLK  KAYITLARI GETİRME
        private void datagrid_ariza_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            //label18.Text = datagrid_ariza.Rows[i].Cells[0].Value.ToString();
            label16.Text = datagrid_ariza.Rows[i].Cells[0].Value.ToString();
            txtf_gonderen.Text = datagrid_ariza.Rows[i].Cells[1].Value.ToString();
            masked_telefon1.Text = datagrid_ariza.Rows[i].Cells[2].Value.ToString();
            txtf_marka.Text = datagrid_ariza.Rows[i].Cells[3].Value.ToString();
            txtf_model.Text = datagrid_ariza.Rows[i].Cells[4].Value.ToString();
            masked_seri.Text = datagrid_ariza.Rows[i].Cells[5].Value.ToString();
            richtxtf_detay.Text = datagrid_ariza.Rows[i].Cells[6].Value.ToString();
            cmb_garanti.Text = datagrid_ariza.Rows[i].Cells[7].Value.ToString();
            //dateTimePicker1.Text = dataGridView3.Rows[i].Cells[12].Value.ToString();
            //richtxtf_parca.Text = dataGridView3.Rows[i].Cells[2].Value.ToString();
            //richtxtf_islem.Text = dataGridView3.Rows[i].Cells[3].Value.ToString();
            dateTimePicker1.Text = datagrid_ariza.Rows[i].Cells[8].Value.ToString();
        }

        private void bttn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut_ekle = new SqlCommand("insert into Yapilan_Islemler(AdiSoyadi,Degisen_Parca,Yapilan_İslem,Teslim_Tarihi,Ariza_Id)" +
             "values(@p1, @p2, @p3, @p4,@p5)", bgln.baglanti());//İnsert İşlemini Tanımladım. 
            komut_ekle.Parameters.AddWithValue("@p1", txtf_teknik_ad.Text);
            komut_ekle.Parameters.AddWithValue("@p2", richtxtf_parca.Text);
            komut_ekle.Parameters.AddWithValue("@p3", richtxtf_islem.Text);
            komut_ekle.Parameters.AddWithValue("@p4", dateTimePicker1.Value);
            komut_ekle.Parameters.AddWithValue("@p5", datagrid_ariza.Rows[i].Cells[0].Value.ToString());
            komut_ekle.ExecuteNonQuery();//komutları çalıştır.
            bgln.baglanti().Close();//bağlantıyı kapat
            MessageBox.Show("İşlemleriniz Kaydedilmiştir..", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            gecmislistele();
            temizle();
            tabControl2.SelectedIndex = 1;
        }

        private void bttn_sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView3.SelectedRows)  //Seçili Satırları Silme
            {
                DialogResult sil = new DialogResult();
                sil = MessageBox.Show("Arıza Kaydını Silmek İstiyor Musunuz?", "İnfo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sil == DialogResult.Yes)
                {
                    SqlCommand komut = new SqlCommand("Delete From Yapilan_Islemler Where Teknik_Id = @p1", bgln.baglanti());
                    komut.Parameters.AddWithValue("@p1", Convert.ToInt32(row.Cells[0].Value));
                    komut.ExecuteNonQuery();
                    bgln.baglanti().Close();
                    gecmislistele();
                }
                else if (sil == DialogResult.No)
                {
                    //hiçbirşey yapma
                }
            }
        }

        private void bttn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void bttn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut_ekle = new SqlCommand("Update Yapilan_Islemler Set AdiSoyadi=@p1,Degisen_Parca=@p2,Yapilan_İslem=@p3,Teslim_Tarihi=@p4,Marka=@p5," +
                "Model=@p6,SeriNo=@p7,Garanti=@p8,Gönderim_Tarihi=@p9,Ariza_Detay=@p10, P_Id=@p11 Where Teknik_Id=@p12", bgln.baglanti());
            komut_ekle.Parameters.AddWithValue("@p1", txtf_teknik_ad.Text);
            komut_ekle.Parameters.AddWithValue("@p2", richtxtf_parca.Text);
            komut_ekle.Parameters.AddWithValue("@p3", richtxtf_islem.Text);
            komut_ekle.Parameters.AddWithValue("@p4", dateTimePicker1.Value);
            komut_ekle.Parameters.AddWithValue("@p5", txtf_marka.Text);
            komut_ekle.Parameters.AddWithValue("@p6", txtf_model.Text);
            komut_ekle.Parameters.AddWithValue("@p7", masked_seri.Text);
            komut_ekle.Parameters.AddWithValue("@p8", cmb_garanti.Text);
            komut_ekle.Parameters.AddWithValue("@p9", dateTimePicker2.Value);
            komut_ekle.Parameters.AddWithValue("@p10", richtxtf_detay.Text);
            komut_ekle.Parameters.AddWithValue("@p11", Convert.ToInt16(label16.Text));
            komut_ekle.Parameters.AddWithValue("@p12", Convert.ToInt16(id));
            komut_ekle.ExecuteNonQuery();
            gecmislistele();
            temizle();
            tabControl2.SelectedIndex = 1;
        }

        private void listeyiYenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liste Yenilenmiştir.");
            arizalar();
            gecmislistele();
        }
        int j = 0;
        private void bttn_ilk_Click(object sender, EventArgs e)
        {
            j = 0;//index değeri 0 dan başla datagridview hücreleri kadar git.
            txtf_gonderen.Text = dataGridView3.Rows[j].Cells[5].Value.ToString();
            masked_telefon1.Text = dataGridView3.Rows[j].Cells[6].Value.ToString();
            txtf_marka.Text = dataGridView3.Rows[j].Cells[7].Value.ToString();
            txtf_model.Text = dataGridView3.Rows[j].Cells[8].Value.ToString();
            masked_seri.Text = dataGridView3.Rows[j].Cells[9].Value.ToString();
            cmb_garanti.Text = dataGridView3.Rows[j].Cells[11].Value.ToString();
            dateTimePicker2.Text = dataGridView3.Rows[j].Cells[12].Value.ToString();
            richtxtf_detay.Text = dataGridView3.Rows[j].Cells[10].Value.ToString();
            richtxtf_parca.Text = dataGridView3.Rows[j].Cells[2].Value.ToString();
            richtxtf_islem.Text = dataGridView3.Rows[j].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView3.Rows[j].Cells[4].Value.ToString();
        }

        private void bttn_son_Click(object sender, EventArgs e)
        {
            int satir = dataGridView3.Rows.Count;
            cmb_garanti.Text = satir.ToString();
            j = satir - 1; //son kayıta  gelmesi için
            txtf_gonderen.Text = dataGridView3.Rows[j].Cells[5].Value.ToString();
            masked_telefon1.Text = dataGridView3.Rows[j].Cells[6].Value.ToString();
            txtf_marka.Text = dataGridView3.Rows[j].Cells[7].Value.ToString();
            txtf_model.Text = dataGridView3.Rows[j].Cells[8].Value.ToString();
            masked_seri.Text = dataGridView3.Rows[j].Cells[9].Value.ToString();
            cmb_garanti.Text = dataGridView3.Rows[j].Cells[11].Value.ToString();
            dateTimePicker2.Text = dataGridView3.Rows[j].Cells[12].Value.ToString();
            richtxtf_detay.Text = dataGridView3.Rows[j].Cells[10].Value.ToString();
            richtxtf_parca.Text = dataGridView3.Rows[j].Cells[2].Value.ToString();
            richtxtf_islem.Text = dataGridView3.Rows[j].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView3.Rows[j].Cells[4].Value.ToString();
        }

        private void bttn_ileri_Click(object sender, EventArgs e)
        {
            j++;
            if (j < dataGridView3.Rows.Count - 0)//burada datagridview satırlarının sayısı kadar ileriye git
            {
                txtf_gonderen.Text = dataGridView3.Rows[j].Cells[5].Value.ToString();
                masked_telefon1.Text = dataGridView3.Rows[j].Cells[6].Value.ToString();
                txtf_marka.Text = dataGridView3.Rows[j].Cells[7].Value.ToString();
                txtf_model.Text = dataGridView3.Rows[j].Cells[8].Value.ToString();
                masked_seri.Text = dataGridView3.Rows[j].Cells[9].Value.ToString();
                cmb_garanti.Text = dataGridView3.Rows[j].Cells[11].Value.ToString();
                dateTimePicker2.Text = dataGridView3.Rows[j].Cells[12].Value.ToString();
                richtxtf_detay.Text = dataGridView3.Rows[j].Cells[10].Value.ToString();
                richtxtf_parca.Text = dataGridView3.Rows[j].Cells[2].Value.ToString();
                richtxtf_islem.Text = dataGridView3.Rows[j].Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView3.Rows[j].Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Son Kayıta Ulaştınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bttn_geri_Click(object sender, EventArgs e)
        {
            j--;
            if (j >= -0)//i'yi eksilterek listenin gerisine  git
            {
                txtf_gonderen.Text = dataGridView3.Rows[j].Cells[5].Value.ToString();
                masked_telefon1.Text = dataGridView3.Rows[j].Cells[6].Value.ToString();
                txtf_marka.Text = dataGridView3.Rows[j].Cells[7].Value.ToString();
                txtf_model.Text = dataGridView3.Rows[j].Cells[8].Value.ToString();
                masked_seri.Text = dataGridView3.Rows[j].Cells[9].Value.ToString();
                cmb_garanti.Text = dataGridView3.Rows[j].Cells[11].Value.ToString();
                dateTimePicker2.Text = dataGridView3.Rows[j].Cells[12].Value.ToString();
                richtxtf_detay.Text = dataGridView3.Rows[j].Cells[10].Value.ToString();
                richtxtf_parca.Text = dataGridView3.Rows[j].Cells[2].Value.ToString();
                richtxtf_islem.Text = dataGridView3.Rows[j].Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView3.Rows[j].Cells[4].Value.ToString();
            }
            else
            {//-0'ın altına düşmesi durumunda ilk kayıta ulaştınız de.
                MessageBox.Show("İlk Kayıta Ulaştınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            label17.Text = dataGridView3.Rows[i].Cells[0].Value.ToString();
            label16.Text = dataGridView3.Rows[i].Cells[0].Value.ToString();
            txtf_gonderen.Text = dataGridView3.Rows[i].Cells[5].Value.ToString();
            masked_telefon1.Text = dataGridView3.Rows[i].Cells[6].Value.ToString();
            txtf_marka.Text = dataGridView3.Rows[i].Cells[7].Value.ToString();
            txtf_model.Text = dataGridView3.Rows[i].Cells[8].Value.ToString();
            masked_seri.Text = dataGridView3.Rows[i].Cells[9].Value.ToString();
            richtxtf_detay.Text = dataGridView3.Rows[i].Cells[10].Value.ToString();
            cmb_garanti.Text = dataGridView3.Rows[i].Cells[11].Value.ToString();
            dateTimePicker1.Text = dataGridView3.Rows[i].Cells[12].Value.ToString();
            richtxtf_parca.Text = dataGridView3.Rows[i].Cells[2].Value.ToString();
            richtxtf_islem.Text = dataGridView3.Rows[i].Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridView3.Rows[i].Cells[4].Value.ToString();
        }
    }
}