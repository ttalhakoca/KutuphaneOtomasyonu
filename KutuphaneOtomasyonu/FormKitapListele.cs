using System.Data.SQLite;
using System.Data;

namespace KutuphaneOtomasyonu
{
    public partial class FormKitapListele : Form
    {
        private static string connectionString = @"Data Source=" + Application.StartupPath + @"\kutuphane.db;Version=3;";

        public FormKitapListele()
        {
            InitializeComponent();
        }

        private void FormKitapListele_Load(object sender, EventArgs e)
        {
            KitaplariYenidenGetir();
            this.Text = "\uD83D\uDCDA K\u00FCt\u00FCphane Kitap Listesi";
            this.BackColor = Color.FromArgb(30, 30, 30);

            dgvKitaplar.BackgroundColor = Color.FromArgb(45, 45, 45);
            dgvKitaplar.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            dgvKitaplar.DefaultCellStyle.ForeColor = Color.White;
            dgvKitaplar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
            dgvKitaplar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKitaplar.EnableHeadersVisualStyles = false;
            dgvKitaplar.GridColor = Color.DimGray;
            dgvKitaplar.BorderStyle = BorderStyle.None;

            txtAra.BackColor = Color.FromArgb(50, 50, 50);
            txtAra.ForeColor = Color.White;
            cmbKategoriFiltre.BackColor = Color.FromArgb(50, 50, 50);
            cmbKategoriFiltre.ForeColor = Color.White;

            Button[] buttons = { btnSil, btnGuncelle, btnIptal, btnTumunuGoster, btnMusaitKitaplar, btnKategoriEkle };
            foreach (Button btn in buttons)
            {
                btn.BackColor = Color.FromArgb(50, 50, 50);
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.Gray;
                btn.FlatAppearance.BorderSize = 1;
            }

            KategorileriYukle();
        }


        private void KategorileriYukle()
        {
            cmbKategoriFiltre.Items.Clear();
            cmbKategoriFiltre.Items.Add("Tüm Kategoriler");
            var kategoriler = Veritabani.KategorileriGetir();
            foreach (var kategori in kategoriler)
            {
                cmbKategoriFiltre.Items.Add(kategori);
            }
            cmbKategoriFiltre.SelectedIndex = 0;
        }

        public void KitaplariYenidenGetir()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Kitaplar";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvKitaplar.DataSource = dt.Rows.Count > 0 ? dt : null;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Veri bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (dgvKitaplar.Columns.Contains("KitapID"))
                {
                    dgvKitaplar.Columns["KitapID"].Visible = false;
                }

                dgvKitaplar.Visible = false;
                dgvKitaplar.Visible = true;
                dgvKitaplar.Refresh();
            }
        }

        private void KategoriyeGoreFiltrele(string kategori)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = kategori == "Tümü" ? "SELECT * FROM Kitaplar" : "SELECT * FROM Kitaplar WHERE Kategori = @kategori";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                if (kategori != "Tümü")
                {
                    cmd.Parameters.AddWithValue("@kategori", kategori);
                }

                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKitaplar.DataSource = dt;

                conn.Close();
            }
        }

        private void KitaplariFiltrele(string arama)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Kitaplar WHERE KitapAdi LIKE @arama";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@arama", "%" + arama + "%");

                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKitaplar.DataSource = dt;

                conn.Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvKitaplar.SelectedRows.Count > 0)
            {
                DialogResult sonuc = MessageBox.Show("Seçili kitabı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    int kitapID = Convert.ToInt32(dgvKitaplar.SelectedRows[0].Cells["KitapID"].Value);
                    string kitapAdi = dgvKitaplar.SelectedRows[0].Cells["KitapAdi"].Value.ToString();

                    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                    {
                        conn.Open();
                        string kontrolQuery = "SELECT COUNT(*) FROM Odunc WHERE KitapID = @id AND TeslimTarihi IS NULL";
                        using (SQLiteCommand kontrolCmd = new SQLiteCommand(kontrolQuery, conn))
                        {
                            kontrolCmd.Parameters.AddWithValue("@id", kitapID);
                            int aktifOdunc = Convert.ToInt32(kontrolCmd.ExecuteScalar());

                            if (aktifOdunc > 0)
                            {
                                MessageBox.Show("Bu kitap hâlâ ödünçte. Lütfen önce teslim alın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        string query = "DELETE FROM Kitaplar WHERE KitapID = @id";
                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", kitapID);
                            cmd.ExecuteNonQuery();
                        }

                        conn.Close();
                    }
                    Veritabani.LogEkle($"Kitap silindi: {kitapAdi} (ID: {kitapID})");

                    MessageBox.Show("Kitap başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KitaplariYenidenGetir();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir kitap seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvKitaplar.SelectedRows.Count > 0)
            {
                int kitapID = Convert.ToInt32(dgvKitaplar.SelectedRows[0].Cells["KitapID"].Value);
                string kitapAdi = dgvKitaplar.SelectedRows[0].Cells["KitapAdi"].Value.ToString();
                string yazar = dgvKitaplar.SelectedRows[0].Cells["Yazar"].Value.ToString();
                int yayinYili = Convert.ToInt32(dgvKitaplar.SelectedRows[0].Cells["YayinYili"].Value);
                string kategori = dgvKitaplar.SelectedRows[0].Cells["Kategori"].Value.ToString();

                FormKitapGuncelle guncelleForm = new FormKitapGuncelle(kitapID, kitapAdi, yazar, yayinYili, kategori, KitaplariYenidenGetir);
                guncelleForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir kitap seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            KitaplariFiltrele(txtAra.Text);
        }

        private void cmbKategoriFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenKategori = cmbKategoriFiltre.SelectedItem.ToString();
            string aramaKelimesi = txtAra.Text.Trim();

            KitaplariAramaVeFiltrele(aramaKelimesi, secilenKategori);
        }

        private void KitaplariAramaVeFiltrele(string aramaKelimesi, string kategori)
        {
            using (SQLiteConnection conn = Veritabani.BaglantiAl())
            {
                conn.Open();
                string query = kategori == "Tüm Kategoriler"
                    ? "SELECT * FROM Kitaplar WHERE KitapAdi LIKE @aramaKelimesi"
                    : "SELECT * FROM Kitaplar WHERE KitapAdi LIKE @aramaKelimesi AND Kategori = @kategori";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@aramaKelimesi", "%" + aramaKelimesi + "%");
                    if (kategori != "Tüm Kategoriler")
                    {
                        cmd.Parameters.AddWithValue("@kategori", kategori);
                    }

                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvKitaplar.DataSource = dt;
                }

                conn.Close();
            }
        }

        private void btnMusaitKitaplar_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT * FROM Kitaplar WHERE KitapID NOT IN (SELECT KitapID FROM Odunc WHERE TeslimTarihi IS NULL)";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKitaplar.DataSource = dt;
                conn.Close();
            }
        }

        private void btnTumunuGoster_Click(object sender, EventArgs e)
        {
            KitaplariYenidenGetir();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            FormKategoriYonet kategoriForm = new FormKategoriYonet();
            kategoriForm.ShowDialog();
        }
    }
}