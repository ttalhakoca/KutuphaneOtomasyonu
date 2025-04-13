using System;
using System.Drawing;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class FormSifreDegistir : Form
    {
        public FormSifreDegistir()
        {
            InitializeComponent();
        }

        private void FormSifreDegistir_Load(object sender, EventArgs e)
        {
            txtEskiSifre.Focus();
            this.AcceptButton = btnGuncelle;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string eskiSifre = txtEskiSifre.Text.Trim();
            string yeniSifre = txtYeniSifre.Text.Trim();
            string yeniTekrar = txtYeniSifreTekrar.Text.Trim();
            string kayitliSifre = Veritabani.SifreGetir();

            if (eskiSifre != kayitliSifre)
            {
                MessageBox.Show("Eski şifre yanlış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(yeniSifre) || yeniSifre.Length < 3)
            {
                MessageBox.Show("Yeni şifre en az 3 karakter olmalı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (yeniSifre != yeniTekrar)
            {
                MessageBox.Show("Yeni şifreler birbiriyle uyuşmuyor!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Veritabani.SifreGuncelle(yeniSifre))
            {
                MessageBox.Show("Şifre başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Şifre güncellenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEskiSifre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtYeniSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYeniSifreTekrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormSifreDegistir_Load_1(object sender, EventArgs e)
        {

        }
    }
}
