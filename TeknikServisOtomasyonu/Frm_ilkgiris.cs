using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisOtomasyonu
{
    public partial class Frm_ilkgiris : Form
    { 
        public Frm_ilkgiris()
        {
            InitializeComponent();
            tarih();
        }
        void tarih()
        {
            int ay = DateTime.Now.Month;
            int yil = DateTime.Now.Year;
            int gun = DateTime.Now.Day;
            lbl_tarih.Text = "Tarih: " + gun + "/" + (ay) + "/" + yil;
        }
     
        private void personel_bttn_Click(object sender, EventArgs e)
        {
            Frm_PersonelGiris prsnl_grs = new Frm_PersonelGiris();
            prsnl_grs.Show();
            this.Hide();
        }

        private void bilgislm_bttn_Click(object sender, EventArgs e)
        {
            Frm_Ana_Yetkili bilgi_grs = new Frm_Ana_Yetkili();
            bilgi_grs.Show();
            this.Hide();
        }

        private void technic_bttn_Click(object sender, EventArgs e)
        {
            Frm_TeknkDstk_Giris teknik = new Frm_TeknkDstk_Giris();
            teknik.Show();
            this.Hide();
        }
    }
}
