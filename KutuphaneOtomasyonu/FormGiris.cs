using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class FormGiris : Form
    {
        private bool sifreGizli = true;
        private readonly string sifreVarsayilan = "admin";

        public FormGiris()
        {
            InitializeComponent();
            this.AcceptButton = btnGiris;
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            Veritabani.VeritabaniOlustur();
            txtSifre.Focus();
            SifreIkonunuGuncelle();
            this.KeyDown += FormGiris_KeyDown;
            pbLogo.Parent = pbArkaplan;
            pbLogo.BackColor = Color.Transparent;
            lblAdmin.Parent = pbArkaplan;
            lblAdmin.BackColor = Color.Transparent;
            lblBaslik.Parent = pbArkaplan;
            lblBaslik.BackColor = Color.Transparent;
            pbSifreGoster.Parent = pbArkaplan;
            pbSifreGoster.BackColor = Color.Transparent;
            this.Icon = new Icon("login.ico");
            string sifreResetDosyasi = Application.StartupPath + @"\sifre_reset.txt";
            if (File.Exists(sifreResetDosyasi))
            {
                Veritabani.SifreGuncelle("admin");
                File.Delete(sifreResetDosyasi);
                MessageBox.Show("Şifre 'admin' olarak sıfırlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtSifre.UseSystemPasswordChar = true;
        }



        private void pbSifreGoster_Click(object sender, EventArgs e)
        {
            sifreGizli = !sifreGizli;
            txtSifre.UseSystemPasswordChar = sifreGizli;
            SifreIkonunuGuncelle();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string girilenSifre = txtSifre.Text.Trim();
            string kayitliSifre = Veritabani.SifreGetir();

            if (girilenSifre == kayitliSifre)
            {
                Form1 anaForm = new Form1();
                anaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı şifre girdiniz!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSifre.Clear();
                txtSifre.Focus();
            }
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SifreIkonunuGuncelle()
        {
            string ikonYolu = sifreGizli ? "Goz_Kapali.png" : "Goz_Acik.png";
            if (File.Exists(ikonYolu))
            {
                pbSifreGoster.Image = Image.FromFile(ikonYolu);
            }
            else
            {

            }
        }
        private void FormGiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.G)
            {
                DialogResult cevap = MessageBox.Show("Şifreyi sıfırlamak istiyor musunuz?\nBu işlem şifreyi tekrar 'admin' yapar.", "Şifre Sıfırlama", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    if (Veritabani.SifreGuncelle("admin"))
                    {
                        MessageBox.Show("Şifre başarıyla sıfırlandı.\nYeni şifreniz: admin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Şifre sıfırlanamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
