using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace KutuphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        private FormKitapListele kitapListeleForm;

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized; 
            this.StartPosition = FormStartPosition.CenterScreen;  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Veritabani.VeritabaniOlustur();
            ArkaPlaniAyarlama();
            AyarlariUygula();
            KontrolleriOrtala();
        }
        private void ArkaPlaniAyarlama()
        {
            pbArkaPlan.Dock = DockStyle.Fill;
            pbArkaPlan.SizeMode = PictureBoxSizeMode.StretchImage;

            if (!this.DesignMode)
            {
                pbArkaPlan.Image = Image.FromFile(Application.StartupPath + @"\Ana_Arkaplan.png");
            }
        }

        private void AyarlariUygula()
        {
            List<PictureBox> ikonlar = new()
            {
                pbKitapEkle, pbKitapListele, pbUyeEkle, pbUyeleriListele,
                pbOduncVer, pbOduncListele, pbCikis
            };

            foreach (var ikon in ikonlar)
            {
                ikon.BackColor = Color.Transparent;
                ikon.Parent = pbArkaPlan;
                ikon.BringToFront();
            }

            List<Button> butonlar = new()
            {
                btnKitapEkle, btnListele, btnUyeEkle, btnUyeleriListele,
                btnOduncVer, btnOduncListele, btnCikis
            };

            foreach (var btn in butonlar)
            {
                btn.Anchor = AnchorStyles.None;
                btn.Parent = this;
                btn.BringToFront();
            }
            pbAyarlar.Parent = pbArkaPlan;
            pbAyarlar.BackColor = Color.Transparent;
            pbAyarlar.BringToFront();

        }
        private void KontrolleriOrtala()
        {
            int toplamButonSayisi = 7;
            int butonGenislik = 150;
            int aralik = 20;
            int ikonYukseklik = 64;
            int ikonButonBosluk = 15;

            int toplamGenislik = (toplamButonSayisi * butonGenislik) + ((toplamButonSayisi - 1) * aralik);
            int baslangicX = (this.ClientSize.Width - toplamGenislik) / 2;

            int toplamBlokYukseklik = ikonYukseklik + ikonButonBosluk + 50;
            int baslangicY = (this.ClientSize.Height - toplamBlokYukseklik) / 2;

            Button[] butonlar = {
        btnKitapEkle, btnListele, btnUyeEkle, btnUyeleriListele,
        btnOduncVer, btnOduncListele, btnCikis
    };

            PictureBox[] ikonlar = {
        pbKitapEkle, pbKitapListele, pbUyeEkle, pbUyeleriListele,
        pbOduncVer, pbOduncListele, pbCikis
    };

            for (int i = 0; i < toplamButonSayisi; i++)
            {
                butonlar[i].Left = baslangicX + i * (butonGenislik + aralik);
                butonlar[i].Top = baslangicY + ikonYukseklik + ikonButonBosluk;

                ikonlar[i].Top = baslangicY;
                ikonlar[i].Left = butonlar[i].Left + (butonlar[i].Width / 2) - (ikonlar[i].Width / 2);
            }
            this.Resize += (s, e) => KontrolleriOrtala();
        }
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            FormKitapListele? acikForm = null;

            foreach (Form form in Application.OpenForms)
            {
                if (form is FormKitapListele listeForm)
                {
                    acikForm = listeForm;
                    break;
                }
            }

            new FormKitapEkle(acikForm).Show();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            if (kitapListeleForm == null || kitapListeleForm.IsDisposed)
                kitapListeleForm = new FormKitapListele();

            kitapListeleForm.Show();
            kitapListeleForm.BringToFront();
        }

        private void btnOduncVer_Click(object sender, EventArgs e) => new FormOduncVer().Show();
        private void btnOduncListele_Click(object sender, EventArgs e) => new FormOduncListele().Show();
        private void btnUyeEkle_Click(object sender, EventArgs e) => new FormUyeEkle().Show();
        private void btnUyeleriListele_Click(object sender, EventArgs e) => new FormUyeListele().Show();
        private void btnCikis_Click(object sender, EventArgs e) => Application.Exit();

        private void btnVerileriSifirla_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tüm verileri (kitaplar, üyeler, ödünç kayýtlarý) silmek üzeresiniz. Devam etmek istiyor musunuz?", "Uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            if (MessageBox.Show("Bu iþlemin geri dönüþü yok. Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            using var conn = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\kutuphane.db;Version=3;");
            conn.Open();

            foreach (var sorgu in new[] { "DELETE FROM Odunc", "DELETE FROM Uyeler", "DELETE FROM Kitaplar" })
            {
                using var cmd = new SQLiteCommand(sorgu, conn);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Tüm veriler baþarýyla sýfýrlandý.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbAyarlar_Click(object sender, EventArgs e)
        {
            FormAyarlar ayarForm = new FormAyarlar();
            ayarForm.ShowDialog();
        }
    }
}
