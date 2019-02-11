using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sinema_Programı
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void btnkullanici_Click(object sender, EventArgs e)
        {
            KullaniciGirisEkrani kullanici = new KullaniciGirisEkrani();
            this.Hide();
            kullanici.Show();
        }

        private void btnyonetici_Click(object sender, EventArgs e)
        {
            YoneticiGirisEkrani yonetici = new YoneticiGirisEkrani();
            this.Hide();
            yonetici.Show();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
