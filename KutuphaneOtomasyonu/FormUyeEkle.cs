using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class FormUyeEkle : Form
    {
        private string uyeID = "";

        public FormUyeEkle()
        {
            InitializeComponent();
        }

        public FormUyeEkle(string adSoyad, string id) : this()
        {
            txtAdSoyad.Text = adSoyad;
            uyeID = id;
        }

        private void FormUyeEkle_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnUyeKaydet;
        }

        private void btnUyeKaydet_Click(object sender, EventArgs e)
        {
            string adSoyad = txtAdSoyad.Text.Trim();

            if (string.IsNullOrWhiteSpace(adSoyad))
            {
                MessageBox.Show("Ad Soyad boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\kutuphane.db;Version=3;"))
            {
                conn.Open();
                string query = string.IsNullOrEmpty(uyeID)
                    ? "INSERT INTO Uyeler (AdSoyad) VALUES (@adSoyad)"
                    : "UPDATE Uyeler SET AdSoyad = @adSoyad WHERE UyeID = @id";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@adSoyad", adSoyad);
                    if (!string.IsNullOrEmpty(uyeID))
                        cmd.Parameters.AddWithValue("@id", uyeID);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
            string logMesaji = string.IsNullOrEmpty(uyeID)
                ? $"Yeni üye eklendi: {adSoyad}"
                : $"Üye güncellendi (ID: {uyeID}): {adSoyad}";
            Veritabani.LogEkle(logMesaji);

            MessageBox.Show(
                string.IsNullOrEmpty(uyeID) ? "Üye başarıyla eklendi!" : "Üye bilgisi güncellendi!",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information
            );

            txtAdSoyad.Clear();
            txtAdSoyad.Focus();
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
