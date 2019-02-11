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
    public partial class KullaniciGirisEkrani : Form
    {
        public KullaniciGirisEkrani()
        {
            InitializeComponent();
        }

        bool durum = false;
        private void btnkullanicigiris_Click(object sender, EventArgs e)
        {
            if (txtkullaniciadi.Text == "" || txtparola.Text == "" || txtkullaniciadi.Text == "Kullanıcı Adınız" || txtparola.Text == "Parolanız")
            {
                MessageBox.Show("Lütfen Boş alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Array.IndexOf(YoneticiPaneli.user,txtkullaniciadi.Text)==-1)
                {
                    MessageBox.Show("Böyle bir kullanıcı bulunmamaktadır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    for (int i = 0; i < YoneticiPaneli.user.Length; i++)
                    {
                        if (YoneticiPaneli.user[i] == txtkullaniciadi.Text && YoneticiPaneli.pass[i] == txtparola.Text)
                        {
                            SinemaRezervasyonProjesi uygulama = new SinemaRezervasyonProjesi();
                            this.Hide();
                            uygulama.Show();
                            durum = true;
                        }
                    }
                    if (durum==false)
                    {
                        MessageBox.Show("Giriş başarısız! lütfen bilgilerinizi kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }


            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            AnaEkran geri = new AnaEkran();
            this.Hide();
            geri.Show();
        }

        private void KullaniciGirisEkrani_Load(object sender, EventArgs e)
        {
            txtkullaniciadi.Text = "Kullanıcı Adınız";
            txtkullaniciadi.ForeColor = Color.Gray;
            txtparola.Text = "Parolanız";
            txtparola.ForeColor = Color.Gray;

           YoneticiPaneli.user[0] = "Admin";
            YoneticiPaneli.pass[0] = "123456";
        }

        private void txtkullaniciadi_Leave(object sender, EventArgs e)
        {
            if (txtkullaniciadi.Text == "")
            {
                txtkullaniciadi.Text = "Kullanıcı Adınız";
                txtkullaniciadi.ForeColor = Color.Gray;
            }
        }

        private void txtkullaniciadi_Enter(object sender, EventArgs e)
        {
            if (txtkullaniciadi.Text == "Kullanıcı Adınız")
            {
                txtkullaniciadi.Text = "";
                txtkullaniciadi.ForeColor = Color.Black;
            }
        }

        private void txtparola_Leave(object sender, EventArgs e)
        {
            if (txtparola.Text == "")
            {
                txtparola.Text = "Parolanız";
                txtparola.ForeColor = Color.Gray;
            }
        }

        private void txtparola_Enter(object sender, EventArgs e)
        {
            if (txtparola.Text == "Parolanız")
            {
                txtparola.Text = "";
                txtparola.ForeColor = Color.Black;
            }
        }
    }
}
