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
    public partial class YoneticiPaneli : Form
    {
        public YoneticiPaneli()
        {
            InitializeComponent();

        }



          public static string[] user = new string[1];
         public static string[] pass = new string[1];
        public static int m = 1;

        
        private void btnkullaniciekle_Click(object sender, EventArgs e)
        {
            if (txtkullaniciadiekle.Text == "" || txtparolaekle.Text == "" || txtkullaniciadiekle.Text == "Kullanıcı Adınız" || txtparolaekle.Text == "Parolanız")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Array.IndexOf(user, txtkullaniciadiekle.Text) == -1)
                {
                    Array.Resize(ref user, user.Length + 1);
                    Array.Resize(ref pass, pass.Length + 1);
                    user[m] = txtkullaniciadiekle.Text;
                    pass[m] = txtparolaekle.Text;
                    m++;

                    kayitlikullanicilar.Items.Clear();
                    for (int k = 0; k < user.Length; k++)
                    {
                        if (user[k] != null)
                        {
                            kayitlikullanicilar.Items.Add(user[k] + " " + pass[k]);
                            
                        }
                    }
                    MessageBox.Show("Kullanıcı ekleme işlemi tamamlandı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtkullaniciadiekle.Text = "";
                    txtparolaekle.Text = "";
                }
                else
                {
                     MessageBox.Show("Böyle Bir kullanıcı zaten kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnkullaniciduzenle_Click(object sender, EventArgs e)
        {
            if (txtkullaniciadiekle.Text == "" || txtkullaniciadiekle.Text == "Kullanıcı Adınız")
            {
                MessageBox.Show("Lütfen Parolasını değiştirmek istediğiniz kullanıcıyı seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtparolaekle.Text== "Parolanız" || txtparolaekle.Text == "")
            {
                MessageBox.Show("Lütfen Parolayı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Array.IndexOf(user, txtkullaniciadiekle.Text) != -1)
                {
                    int sira = Array.IndexOf(user, txtkullaniciadiekle.Text);
                    user[sira] = txtkullaniciadiekle.Text;
                    pass[sira] = txtparolaekle.Text;
                    kayitlikullanicilar.Items.Clear();
                    for (int k = 0; k < user.Length; k++)
                    {
                        if (user[k] != null)
                        {
                            kayitlikullanicilar.Items.Add(user[k] + " " + pass[k]);
                        }
                    }
                    MessageBox.Show("Parolanız başarıyla güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtkullaniciadiekle.Text = "";
                    txtparolaekle.Text = "";
                }
                else
                {
                    MessageBox.Show("Böyle Bir kullanıcı  kayıtlı değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnkullanicisil_Click(object sender, EventArgs e)
        {
            if (txtkullaniciadiekle.Text == "" || txtparolaekle.Text == "" || txtkullaniciadiekle.Text == "Kullanıcı Adınız" || txtparolaekle.Text == "Parolanız")
            {
                MessageBox.Show("Lütfen Boş alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Array.IndexOf(user, txtkullaniciadiekle.Text) != -1)
                {
                    int sira = Array.IndexOf(user, txtkullaniciadiekle.Text);
                    Array.Clear(user, sira, 1);
                    Array.Clear(pass, sira, 1);

                    kayitlikullanicilar.Items.Clear();
                    for (int k = 0; k < user.Length; k++)
                    {
                        if (user[k] != null)
                        {
                            kayitlikullanicilar.Items.Add(user[k] + " " + pass[k]);
                        }
                    }
                    MessageBox.Show("Kullanıcı silme işlemi başarıyla tamamlandı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtkullaniciadiekle.Text = "";
                    txtparolaekle.Text = "";
                }
                else
                {
                    MessageBox.Show("Böyle Bir kullanıcı  kayıtlı değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            AnaEkran geri = new AnaEkran();
            this.Hide();
            geri.Show();
        }

        private void txtkullaniciadiekle_Leave(object sender, EventArgs e)
        {
            if (txtkullaniciadiekle.Text == "")
            {
                txtkullaniciadiekle.Text = "Kullanıcı Adınız";
                txtkullaniciadiekle.ForeColor = Color.Gray;
            }
        }

        private void txtkullaniciadiekle_Enter(object sender, EventArgs e)
        {
            if (txtkullaniciadiekle.Text == "Kullanıcı Adınız")
            {
                txtkullaniciadiekle.Text = "";
                txtkullaniciadiekle.ForeColor = Color.Black;
            }
        }

        private void YoneticiPaneli_Load(object sender, EventArgs e)
        {
            kayitlikullanicilar.Items.Clear();
            for (int k = 0; k < user.Length; k++)
            {
                if (user[k] != null)
                {
                    kayitlikullanicilar.Items.Add(user[k] + " " + pass[k]);
                }
            }

            txtkullaniciadiekle.Text = "Kullanıcı Adınız";
            txtkullaniciadiekle.ForeColor = Color.Gray;
            txtparolaekle.Text = "Parolanız";
            txtparolaekle.ForeColor = Color.Gray;
        }

        private void txtparolaekle_Leave(object sender, EventArgs e)
        {
            if (txtparolaekle.Text == "")
            {
                txtparolaekle.Text = "Parolanız";
                txtparolaekle.ForeColor = Color.Gray;
            }
        }

        private void txtparolaekle_Enter(object sender, EventArgs e)
        {
            if (txtparolaekle.Text == "Parolanız")
            {
                txtparolaekle.Text = "";
                txtparolaekle.ForeColor = Color.Black;
            }
        }

        private void kayitlikullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] parca = kayitlikullanicilar.SelectedItem.ToString().Split(' ');
            txtkullaniciadiekle.Text = parca[0];
            txtparolaekle.Text = parca[1];
            txtkullaniciadiekle.ForeColor = Color.Black;
            txtparolaekle.ForeColor = Color.Black;
        }
    }
}
