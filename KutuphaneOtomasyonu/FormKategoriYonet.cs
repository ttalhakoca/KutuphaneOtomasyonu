using System;
using System.Linq;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class FormKategoriYonet : Form
    {
        public FormKategoriYonet()
        {
            InitializeComponent();
        }

        private void FormKategoriYonet_Load(object sender, EventArgs e)
        {
            dgvKategoriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKategoriler.MultiSelect = false;
            KategorileriYukle();
        }

        private void KategorileriYukle()
        {
            var kategoriler = Veritabani.KategorileriGetir();
            kategoriler.Sort();

            dgvKategoriler.DataSource = kategoriler
                .Select(k => new { Kategori = k })
                .ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string kategoriAdi = txtKategoriAdi.Text.Trim();

            if (string.IsNullOrEmpty(kategoriAdi))
            {
                MessageBox.Show("Kategori adı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Veritabani.KategoriEkle(kategoriAdi))
            {
                MessageBox.Show("Kategori başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKategoriAdi.Clear();
                KategorileriYukle();
            }
            else
            {
                MessageBox.Show("Bu kategori zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvKategoriler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir kategori seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult sonuc = MessageBox.Show("Seçili kategoriyi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                string kategoriAdi = dgvKategoriler.SelectedRows[0].Cells[0].Value.ToString();

                if (Veritabani.KategoriSil(kategoriAdi))
                {
                    MessageBox.Show("Kategori başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KategorileriYukle();
                }
                else
                {
                    MessageBox.Show("Bu kategoriye bağlı kitaplar olduğu için silinemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


