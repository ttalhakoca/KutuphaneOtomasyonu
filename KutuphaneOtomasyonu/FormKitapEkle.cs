using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class FormKitapEkle : Form
    {
        private FormKitapListele kitapListeForm;
        public FormKitapEkle(FormKitapListele listeFormu)
        {
            InitializeComponent();
            kitapListeForm = listeFormu;
        }
        public FormKitapEkle()
        {
            InitializeComponent();
        }
        private void FormKitapEkle_Load(object sender, EventArgs e)
        {
            KategorileriYukle();
        }
        private void KategorileriYukle()
        {
            cmbKategori.Items.Clear();
            var kategoriler = Veritabani.KategorileriGetir();
            kategoriler.Sort();

            foreach (var kategori in kategoriler)
            {
                cmbKategori.Items.Add(kategori);
            }

            if (cmbKategori.Items.Count > 0)
                cmbKategori.SelectedIndex = 0;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string kitapAdi = txtKitapAdi.Text.Trim();
            string yazar = txtYazar.Text.Trim();
            string yayinYili = txtYayinYili.Text.Trim();
            string kategori = cmbKategori.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(kitapAdi) || string.IsNullOrEmpty(yazar) || string.IsNullOrEmpty(yayinYili) || string.IsNullOrEmpty(kategori))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(yayinYili, out _))
            {
                MessageBox.Show("Yayın yılı sayısal bir değer olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SQLiteConnection conn = Veritabani.BaglantiAl())
            {
                conn.Open();
                string query = "INSERT INTO Kitaplar (KitapAdi, Yazar, YayinYili, Kategori) VALUES (@KitapAdi, @Yazar, @YayinYili, @Kategori)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@KitapAdi", kitapAdi);
                    cmd.Parameters.AddWithValue("@Yazar", yazar);
                    cmd.Parameters.AddWithValue("@YayinYili", yayinYili);
                    cmd.Parameters.AddWithValue("@Kategori", kategori);
                    cmd.ExecuteNonQuery();
                }
            }
            Veritabani.LogEkle($"Yeni kitap eklendi: {kitapAdi} - {yazar} ({yayinYili}) [{kategori}]");

            MessageBox.Show("Kitap başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtKitapAdi.Clear();
            txtYazar.Clear();
            txtYayinYili.Clear();
            cmbKategori.SelectedIndex = 0;

            kitapListeForm?.KitaplariYenidenGetir();
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}