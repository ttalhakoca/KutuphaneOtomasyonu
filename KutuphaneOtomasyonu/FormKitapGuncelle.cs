using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class FormKitapGuncelle : Form
    {
        private int kitapID;
        private Action listeyiYenile;
        private string mevcutKategori;
        private string mevcutKitapAdi;
        public FormKitapGuncelle(int kitapID, string kitapAdi, string yazar, int yayinYili, string kategori, Action listeYenileMetodu)
        {
            InitializeComponent();
            this.kitapID = kitapID;
            this.listeyiYenile = listeYenileMetodu;
            this.mevcutKategori = kategori;
            this.mevcutKitapAdi = kitapAdi;

            txtKitapAdi.Text = kitapAdi;
            txtYazar.Text = yazar;
            txtYayinYili.Text = yayinYili.ToString();
        }

        private void FormKitapGuncelle_Load(object sender, EventArgs e)
        {
            KategorileriYukle();
            cmbKategoriGuncelle.SelectedItem = mevcutKategori;
        }

        private void KategorileriYukle()
        {
            cmbKategoriGuncelle.Items.Clear();
            var kategoriler = Veritabani.KategorileriGetir();
            kategoriler.Sort();
            cmbKategoriGuncelle.Items.AddRange(kategoriler.ToArray());

            if (!string.IsNullOrEmpty(mevcutKategori))
                cmbKategoriGuncelle.SelectedItem = mevcutKategori;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string seciliKategori = cmbKategoriGuncelle.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(txtKitapAdi.Text) ||
                string.IsNullOrWhiteSpace(txtYazar.Text) ||
                string.IsNullOrWhiteSpace(txtYayinYili.Text) ||
                string.IsNullOrWhiteSpace(seciliKategori))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtYayinYili.Text.Trim(), out int yayinYili))
            {
                MessageBox.Show("Yayın yılı geçerli bir sayı olmalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var conn = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\kutuphane.db;Version=3;"))
            {
                conn.Open();
                string query = @"UPDATE Kitaplar 
                         SET KitapAdi = @kitapAdi, Yazar = @yazar, YayinYili = @yayinYili, Kategori = @kategori 
                         WHERE KitapID = @kitapID";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kitapAdi", txtKitapAdi.Text.Trim());
                    cmd.Parameters.AddWithValue("@yazar", txtYazar.Text.Trim());
                    cmd.Parameters.AddWithValue("@yayinYili", yayinYili);
                    cmd.Parameters.AddWithValue("@kategori", seciliKategori);
                    cmd.Parameters.AddWithValue("@kitapID", kitapID);
                    cmd.ExecuteNonQuery();
                }
            }

            Veritabani.LogEkle($"Kitap güncellendi (ID: {kitapID}): {mevcutKitapAdi} -> {txtKitapAdi.Text.Trim()}");

            MessageBox.Show("Kitap başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listeyiYenile?.Invoke();
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

