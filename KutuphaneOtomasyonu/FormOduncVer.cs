using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class FormOduncVer : Form
    {
        public FormOduncVer()
        {
            InitializeComponent();
        }

        private void FormOduncVer_Load(object sender, EventArgs e)
        {
            TablolariHazirla();
            KullanicilariYukle();
            KitaplariYukle();

            cmbKitaplar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbKitaplar.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUyeler.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUyeler.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void TablolariHazirla()
        {
            using var conn = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\kutuphane.db;Version=3;");
            conn.Open();

            string oduncQuery = @"CREATE TABLE IF NOT EXISTS Odunc (
                                    OduncID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    KitapID INTEGER NOT NULL,
                                    UyeID INTEGER NOT NULL,
                                    VerilisTarihi TEXT NOT NULL,
                                    TeslimTarihi TEXT)";
            string uyeQuery = @"CREATE TABLE IF NOT EXISTS Uyeler (
                                    UyeID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    AdSoyad TEXT NOT NULL)";
            string teslimTarihiQuery = "ALTER TABLE Odunc ADD COLUMN TeslimTarihi TEXT";

            new SQLiteCommand(oduncQuery, conn).ExecuteNonQuery();
            new SQLiteCommand(uyeQuery, conn).ExecuteNonQuery();
            try { new SQLiteCommand(teslimTarihiQuery, conn).ExecuteNonQuery(); } catch { }

            conn.Close();
        }

        private void KitaplariYukle()
        {
            using var conn = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\kutuphane.db;Version=3;");
            conn.Open();

            string query = @"SELECT KitapID, KitapAdi FROM Kitaplar 
                             WHERE KitapID NOT IN (SELECT KitapID FROM Odunc WHERE TeslimTarihi IS NULL)";

            using var cmd = new SQLiteCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            Dictionary<int, string> kitaplar = new();
            while (reader.Read())
                kitaplar.Add(Convert.ToInt32(reader["KitapID"]), reader["KitapAdi"].ToString());

            cmbKitaplar.DataSource = new BindingSource(kitaplar, null);
            cmbKitaplar.DisplayMember = "Value";
            cmbKitaplar.ValueMember = "Key";
        }

        private void KullanicilariYukle()
        {
            using var conn = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\kutuphane.db;Version=3;");
            conn.Open();

            string query = @"SELECT UyeID, AdSoyad FROM Uyeler 
                             WHERE UyeID NOT IN (SELECT UyeID FROM Odunc WHERE TeslimTarihi IS NULL)";

            using var cmd = new SQLiteCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            Dictionary<int, string> uyeler = new();
            while (reader.Read())
                uyeler.Add(Convert.ToInt32(reader["UyeID"]), reader["AdSoyad"].ToString());

            cmbUyeler.DataSource = new BindingSource(uyeler, null);
            cmbUyeler.DisplayMember = "Value";
            cmbUyeler.ValueMember = "Key";
        }

        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            if (cmbKitaplar.SelectedItem == null || cmbUyeler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen kitap ve üye seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int kitapID = ((KeyValuePair<int, string>)cmbKitaplar.SelectedItem).Key;
            int uyeID = ((KeyValuePair<int, string>)cmbUyeler.SelectedItem).Key;

            if (KitapZatenOduncteMi(kitapID))
            {
                MessageBox.Show("Bu kitap zaten ödünçte. Teslim edilmeden tekrar verilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string verilisTarihi = dtpVerilisTarihi.Value.ToString("yyyy-MM-dd");

            using var conn = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\kutuphane.db;Version=3;");
            conn.Open();

            string query = "INSERT INTO Odunc (KitapID, UyeID, VerilisTarihi, TeslimTarihi) VALUES (@kitapID, @uyeID, @verilisTarihi, NULL)";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@kitapID", kitapID);
            cmd.Parameters.AddWithValue("@uyeID", uyeID);
            cmd.Parameters.AddWithValue("@verilisTarihi", verilisTarihi);
            cmd.ExecuteNonQuery();
            string kitapAdi = ((KeyValuePair<int, string>)cmbKitaplar.SelectedItem).Value;
            string uyeAdi = ((KeyValuePair<int, string>)cmbUyeler.SelectedItem).Value;
            Veritabani.LogEkle($"Kitap ödünç verildi → Kitap: '{kitapAdi}', Üye: '{uyeAdi}', Tarih: {verilisTarihi}");
            MessageBox.Show("Ödünç verme işlemi başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KitaplariYukle();
            KullanicilariYukle();
        }

        private bool KitapZatenOduncteMi(int kitapID)
        {
            using var conn = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\kutuphane.db;Version=3;");
            conn.Open();

            string query = "SELECT COUNT(*) FROM Odunc WHERE KitapID = @kitapID AND TeslimTarihi IS NULL";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@kitapID", kitapID);

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        private void btnIptalOdunc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
