using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class FormUyeGuncelle : Form
    {
        private int uyeID;

        public FormUyeGuncelle(int uyeID, string adSoyad)
        {
            InitializeComponent();
            this.uyeID = uyeID;
            txtAdSoyad.Text = adSoyad;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string yeniAd = txtAdSoyad.Text.Trim();

            if (string.IsNullOrWhiteSpace(yeniAd))
            {
                MessageBox.Show("Ad Soyad boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\kutuphane.db;Version=3;"))
                {
                    conn.Open();
                    string query = "UPDATE Uyeler SET AdSoyad = @ad WHERE UyeID = @id";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", yeniAd);
                        cmd.Parameters.AddWithValue("@id", uyeID);
                        cmd.ExecuteNonQuery();
                    }
                    Veritabani.LogEkle($"Üye güncellendi (ID: {uyeID}): {yeniAd}");
                    MessageBox.Show("Üye bilgisi başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUyeGuncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
