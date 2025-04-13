using System;
using System.Drawing;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class FormAyarlar : Form
    {
        public FormAyarlar()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(30, 30, 30);
            this.ForeColor = Color.White;

            var butonlar = new[] { btnSifreDegistir, btnVerileriSifirla, btnYedekAl, btnLogGor, btnHakkinda };

            foreach (var btn in butonlar)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.FromArgb(50, 50, 50);
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderColor = Color.Gray;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            }

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            FormSifreDegistir sifreForm = new FormSifreDegistir();
            sifreForm.ShowDialog();
        }

        private void btnLogGor_Click(object sender, EventArgs e)
        {
            new FormLogGor().ShowDialog();
        }

        private void btnYedekAl_Click(object sender, EventArgs e)
        {
            string mesaj = Veritabani.VeritabaniYedekle();
            MessageBox.Show(mesaj, "Yedekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVerileriSifirla_Click(object sender, EventArgs e)
        {
            DialogResult ilkSoru = MessageBox.Show(
                "Tüm kitap, üye ve ödünç verileri silinecek.\nBu işlem geri alınamaz.\nDevam etmek istiyor musunuz?",
                "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
            );

            if (ilkSoru == DialogResult.Yes)
            {
                DialogResult ikinciSoru = MessageBox.Show(
                    "Bu işlemi gerçekten yapmak istiyor musunuz?\nTüm veriler kalıcı olarak silinecek!",
                    "Son Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation
                );

                if (ikinciSoru == DialogResult.Yes)
                {
                    Veritabani.VerileriSifirla();
                    MessageBox.Show("Veriler başarıyla sıfırlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnHakkinda_Click(object sender, EventArgs e)
        {
            new FormHakkinda().ShowDialog();
        }

        private void FormAyarlar_Load(object sender, EventArgs e)
        {

        }
    }
}

