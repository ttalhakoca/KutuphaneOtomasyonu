using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class FormUyeListele : Form
    {
        public FormUyeListele()
        {
            InitializeComponent();
        }

        private void FormUyeListele_Load(object sender, EventArgs e)
        {
            UyeleriYukle();
            txtUyeAra.TextChanged += (s, e) => UyeAra(txtUyeAra.Text);
        }

        private void UyeleriYukle()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\kutuphane.db;Version=3;"))
            {
                conn.Open();
                string query = "SELECT * FROM Uyeler";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUyeler.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Veri bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                foreach (DataGridViewColumn column in dgvUyeler.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

                conn.Close();
            }
        }


        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.SelectedRows.Count > 0)
            {
                int uyeID = Convert.ToInt32(dgvUyeler.SelectedRows[0].Cells["UyeID"].Value);
                string adSoyad = dgvUyeler.SelectedRows[0].Cells["AdSoyad"].Value.ToString(); // Log için çekiyoruz

                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\kutuphane.db;Version=3;"))
                {
                    conn.Open();

                    string kontrolQuery = "SELECT COUNT(*) FROM Odunc WHERE UyeID = @id AND TeslimTarihi IS NULL";
                    SQLiteCommand kontrolCmd = new SQLiteCommand(kontrolQuery, conn);
                    kontrolCmd.Parameters.AddWithValue("@id", uyeID);
                    int aktifOduncSayisi = Convert.ToInt32(kontrolCmd.ExecuteScalar());

                    if (aktifOduncSayisi > 0)
                    {
                        MessageBox.Show("Bu üyenin teslim edilmemiş kitabı var. Önce kitabı teslim almanız gerekiyor!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult sonuc = MessageBox.Show("Seçili üyeyi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.Yes)
                    {
                        string query = "DELETE FROM Uyeler WHERE UyeID = @id";
                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", uyeID);
                        cmd.ExecuteNonQuery();

                        Veritabani.LogEkle($"Üye silindi (ID: {uyeID}): {adSoyad}");

                        MessageBox.Show("Üye başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UyeleriYukle();
                    }

                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir üye seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.SelectedRows.Count > 0)
            {
                int uyeID = Convert.ToInt32(dgvUyeler.SelectedRows[0].Cells["UyeID"].Value);
                string adSoyad = dgvUyeler.SelectedRows[0].Cells["AdSoyad"].Value.ToString();

                FormUyeGuncelle frm = new FormUyeGuncelle(uyeID, adSoyad);
                frm.ShowDialog();
                UyeleriYukle();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek için bir üye seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void UyeAra(string kelime)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\kutuphane.db;Version=3;"))
            {
                conn.Open();
                string query = "SELECT * FROM Uyeler WHERE AdSoyad LIKE @ara";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@ara", "%" + kelime + "%");

                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUyeler.DataSource = dt;
                conn.Close();
            }
        }

    }
}
