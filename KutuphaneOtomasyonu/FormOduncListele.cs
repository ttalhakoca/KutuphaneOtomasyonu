using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class FormOduncListele : Form
    {
        public FormOduncListele()
        {
            InitializeComponent();
        }

        private void FormOduncListele_Load(object sender, EventArgs e)
        {
            txtKitapAra.Text = "";
            txtUyeAra.Text = "";
            chkTeslimEdilmemis.Checked = false;

            TeslimTarihiAlaniniEkle();
            ListeyiYenile();

            txtKitapAra.TextChanged += (s, e) => ListeyiYenile();
            txtUyeAra.TextChanged += (s, e) => ListeyiYenile();
            chkTeslimEdilmemis.CheckedChanged += (s, e) => ListeyiYenile();
        }

        private void ListeyiYenile()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\kutuphane.db;Version=3;"))
            {
                conn.Open();

                string kitapAra = txtKitapAra.Text.Trim();
                string uyeAra = txtUyeAra.Text.Trim();
                bool sadeceTeslimEdilmemis = chkTeslimEdilmemis.Checked;

                string query = @"SELECT o.OduncID, k.KitapAdi, u.AdSoyad, o.VerilisTarihi, o.TeslimTarihi
                                 FROM Odunc o
                                 INNER JOIN Kitaplar k ON o.KitapID = k.KitapID
                                 INNER JOIN Uyeler u ON o.UyeID = u.UyeID
                                 WHERE 1=1";

                if (!string.IsNullOrEmpty(kitapAra))
                    query += " AND k.KitapAdi LIKE @kitapAra";

                if (!string.IsNullOrEmpty(uyeAra))
                    query += " AND u.AdSoyad LIKE @uyeAra";

                if (sadeceTeslimEdilmemis)
                    query += " AND o.TeslimTarihi IS NULL";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                if (!string.IsNullOrEmpty(kitapAra))
                    cmd.Parameters.AddWithValue("@kitapAra", "%" + kitapAra + "%");

                if (!string.IsNullOrEmpty(uyeAra))
                    cmd.Parameters.AddWithValue("@uyeAra", "%" + uyeAra + "%");

                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOdunc.DataSource = dt;
                conn.Close();
            }
        }

        private void btnListeyiYenile_Click(object sender, EventArgs e)
        {
            txtKitapAra.Text = "";
            txtUyeAra.Text = "";
            chkTeslimEdilmemis.Checked = false;
            ListeyiYenile();
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (dgvOdunc.SelectedRows.Count > 0)
            {
                int oduncID = Convert.ToInt32(dgvOdunc.SelectedRows[0].Cells["OduncID"].Value);
                string teslimTarihi = DateTime.Now.ToString("yyyy-MM-dd");

                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\kutuphane.db;Version=3;"))
                {
                    conn.Open();
                    string query = "UPDATE Odunc SET TeslimTarihi = @teslimTarihi WHERE OduncID = @oduncID";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@teslimTarihi", teslimTarihi);
                        cmd.Parameters.AddWithValue("@oduncID", oduncID);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }

                string kitapAdi = dgvOdunc.SelectedRows[0].Cells["KitapAdi"].Value.ToString();
                string uyeAdi = dgvOdunc.SelectedRows[0].Cells["AdSoyad"].Value.ToString();
                Veritabani.LogEkle($"Kitap teslim edildi → Kitap: {kitapAdi} | Üye: {uyeAdi} | Tarih: {teslimTarihi}");

                MessageBox.Show("Teslim işlemi tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListeyiYenile();
            }
            else
            {
                MessageBox.Show("Lütfen teslim etmek için bir kayıt seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnIptalOdunc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TeslimTarihiAlaniniEkle()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\kutuphane.db;Version=3;"))
            {
                conn.Open();
                string query = "ALTER TABLE Odunc ADD COLUMN TeslimTarihi TEXT";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch { }
                conn.Close();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvOdunc.SelectedRows.Count > 0)
            {
                int oduncID = Convert.ToInt32(dgvOdunc.SelectedRows[0].Cells["OduncID"].Value);
                string kitapAdi = dgvOdunc.SelectedRows[0].Cells["KitapAdi"].Value.ToString();
                string uyeAdSoyad = dgvOdunc.SelectedRows[0].Cells["AdSoyad"].Value.ToString();
                DateTime verilisTarihi = Convert.ToDateTime(dgvOdunc.SelectedRows[0].Cells["VerilisTarihi"].Value);

                int kitapID = GetKitapIDByAd(kitapAdi);
                int uyeID = GetUyeIDByAdSoyad(uyeAdSoyad);

                FormOduncGuncelle frm = new FormOduncGuncelle(oduncID, kitapID, uyeID, verilisTarihi);
                frm.ShowDialog();
                ListeyiYenile();
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir kayıt seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int GetKitapIDByAd(string kitapAdi)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\kutuphane.db;Version=3;"))
            {
                conn.Open();
                string query = "SELECT KitapID FROM Kitaplar WHERE KitapAdi = @ad";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@ad", kitapAdi);
                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }

        private int GetUyeIDByAdSoyad(string adSoyad)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\kutuphane.db;Version=3;"))
            {
                conn.Open();
                string query = "SELECT UyeID FROM Uyeler WHERE AdSoyad = @ad";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@ad", adSoyad);
                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }

        private void btnOduncSil_Click(object sender, EventArgs e)
        {
            if (dgvOdunc.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seçili ödünç kaydını silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int oduncID = Convert.ToInt32(dgvOdunc.SelectedRows[0].Cells["OduncID"].Value);
                    string kitapAdi = dgvOdunc.SelectedRows[0].Cells["KitapAdi"].Value.ToString();
                    string uyeAdi = dgvOdunc.SelectedRows[0].Cells["AdSoyad"].Value.ToString();

                    using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\kutuphane.db;Version=3;"))
                    {
                        conn.Open();
                        string query = "DELETE FROM Odunc WHERE OduncID = @id";
                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", oduncID);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    Veritabani.LogEkle($"Ödünç kaydı silindi → Kitap: {kitapAdi} | Üye: {uyeAdi} | ID: {oduncID}");
                    MessageBox.Show("Ödünç kaydı başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListeyiYenile();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir ödünç kaydı seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dgvOdunc_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgvOdunc.Rows[e.RowIndex].DataBoundItem != null)
            {
                var row = dgvOdunc.Rows[e.RowIndex];
                var teslimTarihi = row.Cells["TeslimTarihi"].Value?.ToString();

                if (!string.IsNullOrEmpty(teslimTarihi))
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2e7d32"); // Koyu yeşil
                    row.DefaultCellStyle.ForeColor = Color.Gainsboro;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#c62828"); // Koyu kırmızı
                    row.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                }

                row.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#1565c0"); // Koyu mavi
                row.DefaultCellStyle.SelectionForeColor = Color.White;
            }
        }

    }
}