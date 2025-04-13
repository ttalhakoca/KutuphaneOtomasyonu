namespace KutuphaneOtomasyonu
{
    partial class FormAyarlar
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnSifreDegistir = new Button();
            btnVerileriSifirla = new Button();
            btnYedekAl = new Button();
            btnLogGor = new Button();
            btnHakkinda = new Button();
            btnCikis = new Button();
            SuspendLayout();
            // 
            // btnSifreDegistir
            // 
            btnSifreDegistir.BackColor = Color.FromArgb(50, 50, 50);
            btnSifreDegistir.FlatAppearance.BorderColor = Color.Gray;
            btnSifreDegistir.FlatStyle = FlatStyle.Flat;
            btnSifreDegistir.ForeColor = Color.White;
            btnSifreDegistir.Location = new Point(217, 75);
            btnSifreDegistir.Name = "btnSifreDegistir";
            btnSifreDegistir.Size = new Size(150, 30);
            btnSifreDegistir.TabIndex = 0;
            btnSifreDegistir.Text = "Şifre Değiştir";
            btnSifreDegistir.UseVisualStyleBackColor = false;
            btnSifreDegistir.Click += btnSifreDegistir_Click;
            // 
            // btnVerileriSifirla
            // 
            btnVerileriSifirla.BackColor = Color.FromArgb(50, 50, 50);
            btnVerileriSifirla.FlatAppearance.BorderColor = Color.Gray;
            btnVerileriSifirla.FlatStyle = FlatStyle.Flat;
            btnVerileriSifirla.ForeColor = Color.White;
            btnVerileriSifirla.Location = new Point(217, 183);
            btnVerileriSifirla.Name = "btnVerileriSifirla";
            btnVerileriSifirla.Size = new Size(150, 30);
            btnVerileriSifirla.TabIndex = 1;
            btnVerileriSifirla.Text = "Verileri Sıfırla";
            btnVerileriSifirla.UseVisualStyleBackColor = false;
            btnVerileriSifirla.Click += btnVerileriSifirla_Click;
            // 
            // btnYedekAl
            // 
            btnYedekAl.BackColor = Color.FromArgb(50, 50, 50);
            btnYedekAl.FlatAppearance.BorderColor = Color.Gray;
            btnYedekAl.FlatStyle = FlatStyle.Flat;
            btnYedekAl.ForeColor = Color.White;
            btnYedekAl.Location = new Point(217, 147);
            btnYedekAl.Name = "btnYedekAl";
            btnYedekAl.Size = new Size(150, 30);
            btnYedekAl.TabIndex = 2;
            btnYedekAl.Text = "Verileri Yedekle";
            btnYedekAl.UseVisualStyleBackColor = false;
            btnYedekAl.Click += btnYedekAl_Click;
            // 
            // btnLogGor
            // 
            btnLogGor.BackColor = Color.FromArgb(50, 50, 50);
            btnLogGor.FlatAppearance.BorderColor = Color.Gray;
            btnLogGor.FlatStyle = FlatStyle.Flat;
            btnLogGor.ForeColor = Color.White;
            btnLogGor.Location = new Point(217, 111);
            btnLogGor.Name = "btnLogGor";
            btnLogGor.Size = new Size(150, 30);
            btnLogGor.TabIndex = 3;
            btnLogGor.Text = "Logları Görüntüle";
            btnLogGor.UseVisualStyleBackColor = false;
            btnLogGor.Click += btnLogGor_Click;
            // 
            // btnHakkinda
            // 
            btnHakkinda.BackColor = Color.FromArgb(50, 50, 50);
            btnHakkinda.FlatAppearance.BorderColor = Color.Gray;
            btnHakkinda.FlatStyle = FlatStyle.Flat;
            btnHakkinda.ForeColor = Color.White;
            btnHakkinda.Location = new Point(217, 219);
            btnHakkinda.Name = "btnHakkinda";
            btnHakkinda.Size = new Size(150, 30);
            btnHakkinda.TabIndex = 4;
            btnHakkinda.Text = "Hakkında";
            btnHakkinda.UseVisualStyleBackColor = false;
            btnHakkinda.Click += btnHakkinda_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.FromArgb(50, 50, 50);
            btnCikis.FlatAppearance.BorderColor = Color.Gray;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.ForeColor = Color.White;
            btnCikis.Location = new Point(242, 255);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(100, 30);
            btnCikis.TabIndex = 5;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // FormAyarlar
            // 
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(584, 361);
            Controls.Add(btnCikis);
            Controls.Add(btnSifreDegistir);
            Controls.Add(btnVerileriSifirla);
            Controls.Add(btnYedekAl);
            Controls.Add(btnLogGor);
            Controls.Add(btnHakkinda);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormAyarlar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ayarlar";
            Load += FormAyarlar_Load;
            ResumeLayout(false);
        }


        #endregion

        private Button btnSifreDegistir;
        private Button btnVerileriSifirla;
        private Button btnYedekAl;
        private Button btnLogGor;
        private Button btnHakkinda;
        private Button btnCikis;
    }
}
