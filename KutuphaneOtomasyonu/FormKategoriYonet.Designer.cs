namespace KutuphaneOtomasyonu
{
    partial class FormKategoriYonet
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblKategori = new Label();
            txtKategoriAdi = new TextBox();
            btnEkle = new Button();
            dgvKategoriler = new DataGridView();
            btnCikis = new Button();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKategoriler).BeginInit();
            SuspendLayout();

            // Form Arka Plan ve Genel Ayarlar
            BackColor = Color.FromArgb(30, 30, 30);
            ForeColor = Color.White;
            Font = new Font("Segoe UI", 10);

            // lblKategori
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(280, 60);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(120, 19);
            lblKategori.TabIndex = 0;
            lblKategori.Text = "Yeni Kategori Adı";
            lblKategori.ForeColor = Color.White;

            // txtKategoriAdi
            txtKategoriAdi.Location = new Point(280, 90);
            txtKategoriAdi.Name = "txtKategoriAdi";
            txtKategoriAdi.Size = new Size(180, 25);
            txtKategoriAdi.TabIndex = 1;
            txtKategoriAdi.BackColor = Color.FromArgb(45, 45, 45);
            txtKategoriAdi.ForeColor = Color.White;
            txtKategoriAdi.BorderStyle = BorderStyle.FixedSingle;

            // btnEkle
            btnEkle.Location = new Point(280, 130);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(85, 30);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.BackColor = Color.FromArgb(60, 179, 113);
            btnEkle.ForeColor = Color.White;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Click += btnEkle_Click;

            // btnSil
            btnSil.Location = new Point(375, 130);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(85, 30);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.BackColor = Color.FromArgb(220, 20, 60);
            btnSil.ForeColor = Color.White;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Click += btnSil_Click;

            // dgvKategoriler
            dgvKategoriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKategoriler.Location = new Point(30, 40);
            dgvKategoriler.Name = "dgvKategoriler";
            dgvKategoriler.Size = new Size(220, 400);
            dgvKategoriler.TabIndex = 4;
            dgvKategoriler.BackgroundColor = Color.FromArgb(45, 45, 45);
            dgvKategoriler.DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
            dgvKategoriler.DefaultCellStyle.ForeColor = Color.White;

            // btnCikis
            btnCikis.Location = new Point(700, 480);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(100, 30);
            btnCikis.TabIndex = 5;
            btnCikis.Text = "Çıkış";
            btnCikis.BackColor = Color.Gray;
            btnCikis.ForeColor = Color.White;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Click += btnCikis_Click;

            // FormKategoriYonet
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 530);
            Controls.Add(btnSil);
            Controls.Add(btnCikis);
            Controls.Add(dgvKategoriler);
            Controls.Add(btnEkle);
            Controls.Add(txtKategoriAdi);
            Controls.Add(lblKategori);
            Name = "FormKategoriYonet";
            Text = "Kategori Yönetimi";
            Load += FormKategoriYonet_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKategoriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKategori;
        private TextBox txtKategoriAdi;
        private Button btnEkle;
        private DataGridView dgvKategoriler;
        private Button btnCikis;
        private Button btnSil;
    }
}