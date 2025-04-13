using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class FormOduncGuncelle : Form
    {
        int oduncID;

        public FormOduncGuncelle(int oduncID, int kitapID, int uyeID, DateTime verilisTarihi)
        {
            InitializeComponent();
            this.oduncID = oduncID;
            KitaplariYukle();
            UyeleriYukle();
            cmbKitaplar.SelectedValue = kitapID;
            cmbUyeler.SelectedValue = uyeID;
            dtpVerilisTarihi.Value = verilisTarihi;
        }

        private void KitaplariYukle()
        {
            using var conn = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\kutuphane.db;Version=3;");
            conn.Open();

            string query = @"
                SELECT KitapID, KitapAdi FROM Kitaplar
                WHERE KitapID NOT IN (
                    SELECT KitapID FROM Odunc 
                    WHERE TeslimTarihi IS NULL AND OduncID != @mevcutOduncID
                )";

            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@mevcutOduncID", oduncID);

            using var reader = cmd.ExecuteReader();
            var kitaplar = new Dictionary<int, string>();
            while (reader.Read())
                kitaplar.Add(Convert.ToInt32(reader["KitapID"]), reader["KitapAdi"].ToString());

            cmbKitaplar.DataSource = new BindingSource(kitaplar, null);
            cmbKitaplar.DisplayMember = "Value";
            cmbKitaplar.ValueMember = "Key";
        }

        private void UyeleriYukle()
        {
            using var conn = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\kutuphane.db;Version=3;");
            conn.Open();

            string query = @"
                SELECT UyeID, AdSoyad FROM Uyeler
                WHERE UyeID NOT IN (
                    SELECT UyeID FROM Odunc 
                    WHERE TeslimTarihi IS NULL AND OduncID != @mevcutOduncID
                )";

            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@mevcutOduncID", oduncID);

            using var reader = cmd.ExecuteReader();
            var uyeler = new Dictionary<int, string>();
            while (reader.Read())
                uyeler.Add(Convert.ToInt32(reader["UyeID"]), reader["AdSoyad"].ToString());

            cmbUyeler.DataSource = new BindingSource(uyeler, null);
            cmbUyeler.DisplayMember = "Value";
            cmbUyeler.ValueMember = "Key";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int kitapID = ((KeyValuePair<int, string>)cmbKitaplar.SelectedItem).Key;
            int uyeID = ((KeyValuePair<int, string>)cmbUyeler.SelectedItem).Key;

            if (KitapZatenOduncteMi(kitapID))
            {
                MessageBox.Show("Bu kitap şu anda başka bir kullanıcıda ödünçte.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string verilisTarihi = dtpVerilisTarihi.Value.ToString("yyyy-MM-dd");

            using var conn = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\kutuphane.db;Version=3;");
            conn.Open();

            string query = "UPDATE Odunc SET KitapID = @kitapID, UyeID = @uyeID, VerilisTarihi = @verilisTarihi WHERE OduncID = @id";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@kitapID", kitapID);
            cmd.Parameters.AddWithValue("@uyeID", uyeID);
            cmd.Parameters.AddWithValue("@verilisTarihi", verilisTarihi);
            cmd.Parameters.AddWithValue("@id", oduncID);
            cmd.ExecuteNonQuery();
            string kitapAdi = ((KeyValuePair<int, string>)cmbKitaplar.SelectedItem).Value;
            string uyeAdSoyad = ((KeyValuePair<int, string>)cmbUyeler.SelectedItem).Value;
            Veritabani.LogEkle($"Ödünç kaydı güncellendi (ID: {oduncID}) → Kitap: {kitapAdi} | Üye: {uyeAdSoyad} | Tarih: {verilisTarihi}");
            MessageBox.Show("Ödünç kaydı güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private bool KitapZatenOduncteMi(int kitapID)
        {
            using var conn = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\kutuphane.db;Version=3;");
            conn.Open();

            string query = @"
                SELECT COUNT(*) FROM Odunc 
                WHERE KitapID = @kitapID 
                AND TeslimTarihi IS NULL 
                AND OduncID != @mevcutID";

            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@kitapID", kitapID);
            cmd.Parameters.AddWithValue("@mevcutID", oduncID);

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        private void btnIptal_Click(object sender, EventArgs e) => Close();

        private void FormOduncGuncelle_Load(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            ForeColor = System.Drawing.Color.White;

            foreach (Control c in Controls)
            {
                if (c is Button b)
                {
                    b.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
                    b.ForeColor = System.Drawing.Color.White;
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
                    b.FlatAppearance.BorderSize = 1;
                }
                else if (c is ComboBox cb)
                {
                    cb.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
                    cb.ForeColor = System.Drawing.Color.White;
                }
                else if (c is DateTimePicker dtp)
                {
                    dtp.CalendarMonthBackground = System.Drawing.Color.FromArgb(50, 50, 50);
                    dtp.CalendarForeColor = System.Drawing.Color.White;
                    dtp.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
                    dtp.ForeColor = System.Drawing.Color.White;
                }
                else if (c is Label lbl)
                {
                    lbl.ForeColor = System.Drawing.Color.White;
                }
            }
        }
    }
}
