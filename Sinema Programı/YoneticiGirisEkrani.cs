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
    public partial class YoneticiGirisEkrani : Form
    {
        public YoneticiGirisEkrani()
        {
            InitializeComponent();
        }
        public static string Yonetici = "Admin";
        public static string parola = "123456";
        private void btnyoneticigiris_Click(object sender, EventArgs e)
        {
            if (txtkullaniciadi.Text == "" || txtparola.Text == "" || txtkullaniciadi.Text == "Kullanıcı Adınız" || txtparola.Text == "Parolanız")
            {
                MessageBox.Show("Lütfen Boş alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtkullaniciadi.Text == Yonetici && txtparola.Text == parola)
                {
                    YoneticiPaneli yoneticipaneli = new YoneticiPaneli();
                    this.Hide();
                    yoneticipaneli.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da parola hatalı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            AnaEkran geri = new AnaEkran();
            this.Hide();
            geri.Show();
        }

        private void txtkullaniciadi_Enter(object sender, EventArgs e)
        {
            if (txtkullaniciadi.Text == "Kullanıcı Adınız")
            {
                txtkullaniciadi.Text = "";
                txtkullaniciadi.ForeColor = Color.Black;
            }
        }

        private void txtkullaniciadi_Leave(object sender, EventArgs e)
        {
            if (txtkullaniciadi.Text == "")
            {
                txtkullaniciadi.Text = "Kullanıcı Adınız";
                txtkullaniciadi.ForeColor = Color.Gray;
            }
        }

        private void YoneticiGirisEkrani_Load(object sender, EventArgs e)
        {
            txtkullaniciadi.Text = "Kullanıcı Adınız";
            txtkullaniciadi.ForeColor = Color.Gray;
            txtparola.Text = "Parolanız";
            txtparola.ForeColor = Color.Gray;
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
