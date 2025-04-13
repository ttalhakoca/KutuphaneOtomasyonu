namespace KutuphaneOtomasyonu
{
    partial class FormKitapGuncelle
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
            lblKitapAdi = new Label();
            lblYazar = new Label();
            lblYayinYili = new Label();
            lblKategori = new Label();
            txtKitapAdi = new TextBox();
            txtYazar = new TextBox();
            txtYayinYili = new TextBox();
            btnGuncelle = new Button();
            btnIptal = new Button();
            cmbKategoriGuncelle = new ComboBox();
            SuspendLayout();
            // 
            // lblKitapAdi
            // 
            lblKitapAdi.AutoSize = true;
            lblKitapAdi.ForeColor = Color.White;
            lblKitapAdi.Location = new Point(97, 37);
            lblKitapAdi.Name = "lblKitapAdi";
            lblKitapAdi.Size = new Size(55, 15);
            lblKitapAdi.TabIndex = 0;
            lblKitapAdi.Text = "Kitap Adı";
            // 
            // lblYazar
            // 
            lblYazar.AutoSize = true;
            lblYazar.ForeColor = Color.White;
            lblYazar.Location = new Point(97, 84);
            lblYazar.Name = "lblYazar";
            lblYazar.Size = new Size(34, 15);
            lblYazar.TabIndex = 2;
            lblYazar.Text = "Yazar";
            // 
            // lblYayinYili
            // 
            lblYayinYili.AutoSize = true;
            lblYayinYili.ForeColor = Color.White;
            lblYayinYili.Location = new Point(97, 135);
            lblYayinYili.Name = "lblYayinYili";
            lblYayinYili.Size = new Size(54, 15);
            lblYayinYili.TabIndex = 4;
            lblYayinYili.Text = "Yayın Yılı";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.ForeColor = Color.White;
            lblKategori.Location = new Point(97, 190);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(51, 15);
            lblKategori.TabIndex = 6;
            lblKategori.Text = "Kategori";
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.BackColor = Color.FromArgb(45, 45, 45);
            txtKitapAdi.BorderStyle = BorderStyle.FixedSingle;
            txtKitapAdi.ForeColor = Color.White;
            txtKitapAdi.Location = new Point(222, 34);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(180, 23);
            txtKitapAdi.TabIndex = 1;
            // 
            // txtYazar
            // 
            txtYazar.BackColor = Color.FromArgb(45, 45, 45);
            txtYazar.BorderStyle = BorderStyle.FixedSingle;
            txtYazar.ForeColor = Color.White;
            txtYazar.Location = new Point(222, 81);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(180, 23);
            txtYazar.TabIndex = 3;
            // 
            // txtYayinYili
            // 
            txtYayinYili.BackColor = Color.FromArgb(45, 45, 45);
            txtYayinYili.BorderStyle = BorderStyle.FixedSingle;
            txtYayinYili.ForeColor = Color.White;
            txtYayinYili.Location = new Point(222, 132);
            txtYayinYili.Name = "txtYayinYili";
            txtYayinYili.Size = new Size(180, 23);
            txtYayinYili.TabIndex = 5;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(70, 130, 180);
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(136, 250);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(100, 35);
            btnGuncelle.TabIndex = 8;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.FromArgb(100, 100, 100);
            btnIptal.FlatStyle = FlatStyle.Flat;
            btnIptal.ForeColor = Color.White;
            btnIptal.Location = new Point(260, 250);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(100, 35);
            btnIptal.TabIndex = 9;
            btnIptal.Text = "Çıkış";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // cmbKategoriGuncelle
            // 
            cmbKategoriGuncelle.BackColor = Color.FromArgb(45, 45, 45);
            cmbKategoriGuncelle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategoriGuncelle.FlatStyle = FlatStyle.Flat;
            cmbKategoriGuncelle.ForeColor = Color.White;
            cmbKategoriGuncelle.Location = new Point(222, 187);
            cmbKategoriGuncelle.Name = "cmbKategoriGuncelle";
            cmbKategoriGuncelle.Size = new Size(180, 23);
            cmbKategoriGuncelle.TabIndex = 7;
            // 
            // FormKitapGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(600, 350);
            Controls.Add(lblKitapAdi);
            Controls.Add(txtKitapAdi);
            Controls.Add(lblYazar);
            Controls.Add(txtYazar);
            Controls.Add(lblYayinYili);
            Controls.Add(txtYayinYili);
            Controls.Add(lblKategori);
            Controls.Add(cmbKategoriGuncelle);
            Controls.Add(btnGuncelle);
            Controls.Add(btnIptal);
            ForeColor = Color.White;
            Name = "FormKitapGuncelle";
            Text = "Kitap Güncelle";
            Load += FormKitapGuncelle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKitapAdi;
        private Label lblYazar;
        private Label lblYayinYili;
        private Label lblKategori;
        private TextBox txtKitapAdi;
        private TextBox txtYazar;
        private TextBox txtYayinYili;
        private Button btnGuncelle;
        private Button btnIptal;
        private ComboBox cmbKategoriGuncelle;
    }
}