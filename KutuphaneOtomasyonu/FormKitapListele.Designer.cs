namespace KutuphaneOtomasyonu
{
    partial class FormKitapListele
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            databaseHelperBindingSource1 = new BindingSource(components);
            databaseHelperBindingSource = new BindingSource(components);
            dgvKitaplar = new DataGridView();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnIptal = new Button();
            lblAra = new Label();
            txtAra = new TextBox();
            cmbKategoriFiltre = new ComboBox();
            btnTumunuGoster = new Button();
            btnMusaitKitaplar = new Button();
            btnKategoriEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
            SuspendLayout();
            // 
            // dgvKitaplar
            // 
            dgvKitaplar.BackgroundColor = Color.FromArgb(45, 45, 45);
            dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvKitaplar.DefaultCellStyle = dataGridViewCellStyle1;
            dgvKitaplar.Location = new Point(12, 57);
            dgvKitaplar.Name = "dgvKitaplar";
            dgvKitaplar.Size = new Size(461, 491);
            dgvKitaplar.TabIndex = 0;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(50, 50, 50);
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(479, 245);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(101, 41);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(50, 50, 50);
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(479, 198);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(101, 41);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.FromArgb(50, 50, 50);
            btnIptal.FlatStyle = FlatStyle.Flat;
            btnIptal.ForeColor = Color.White;
            btnIptal.Location = new Point(479, 292);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(101, 41);
            btnIptal.TabIndex = 3;
            btnIptal.Text = "Çıkış";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // lblAra
            // 
            lblAra.AutoSize = true;
            lblAra.Location = new Point(12, 31);
            lblAra.Name = "lblAra";
            lblAra.Size = new Size(58, 15);
            lblAra.TabIndex = 4;
            lblAra.Text = "Kitap Ara:";
            // 
            // txtAra
            // 
            txtAra.Location = new Point(73, 28);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(90, 23);
            txtAra.TabIndex = 5;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // cmbKategoriFiltre
            // 
            cmbKategoriFiltre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategoriFiltre.FormattingEnabled = true;
            cmbKategoriFiltre.Location = new Point(352, 28);
            cmbKategoriFiltre.Name = "cmbKategoriFiltre";
            cmbKategoriFiltre.Size = new Size(121, 23);
            cmbKategoriFiltre.TabIndex = 6;
            cmbKategoriFiltre.SelectedIndexChanged += cmbKategoriFiltre_SelectedIndexChanged;
            // 
            // btnTumunuGoster
            // 
            btnTumunuGoster.BackColor = Color.FromArgb(50, 50, 50);
            btnTumunuGoster.FlatStyle = FlatStyle.Flat;
            btnTumunuGoster.ForeColor = Color.White;
            btnTumunuGoster.Location = new Point(479, 57);
            btnTumunuGoster.Name = "btnTumunuGoster";
            btnTumunuGoster.Size = new Size(101, 41);
            btnTumunuGoster.TabIndex = 7;
            btnTumunuGoster.Text = "Tümünü Göster";
            btnTumunuGoster.UseVisualStyleBackColor = false;
            btnTumunuGoster.Click += btnTumunuGoster_Click;
            // 
            // btnMusaitKitaplar
            // 
            btnMusaitKitaplar.BackColor = Color.FromArgb(50, 50, 50);
            btnMusaitKitaplar.FlatStyle = FlatStyle.Flat;
            btnMusaitKitaplar.ForeColor = Color.White;
            btnMusaitKitaplar.Location = new Point(479, 104);
            btnMusaitKitaplar.Name = "btnMusaitKitaplar";
            btnMusaitKitaplar.Size = new Size(101, 41);
            btnMusaitKitaplar.TabIndex = 8;
            btnMusaitKitaplar.Text = "Müsait Kitaplar";
            btnMusaitKitaplar.UseVisualStyleBackColor = false;
            btnMusaitKitaplar.Click += btnMusaitKitaplar_Click;
            // 
            // btnKategoriEkle
            // 
            btnKategoriEkle.BackColor = Color.FromArgb(50, 50, 50);
            btnKategoriEkle.FlatStyle = FlatStyle.Flat;
            btnKategoriEkle.ForeColor = Color.White;
            btnKategoriEkle.Location = new Point(479, 151);
            btnKategoriEkle.Name = "btnKategoriEkle";
            btnKategoriEkle.Size = new Size(101, 41);
            btnKategoriEkle.TabIndex = 9;
            btnKategoriEkle.Text = "Kategori Ekle";
            btnKategoriEkle.UseVisualStyleBackColor = false;
            btnKategoriEkle.Click += btnKategoriEkle_Click;
            // 
            // FormKitapListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(828, 560);
            Controls.Add(btnKategoriEkle);
            Controls.Add(btnMusaitKitaplar);
            Controls.Add(btnTumunuGoster);
            Controls.Add(cmbKategoriFiltre);
            Controls.Add(txtAra);
            Controls.Add(lblAra);
            Controls.Add(btnIptal);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(dgvKitaplar);
            ForeColor = Color.White;
            Name = "FormKitapListele";
            Text = "Kütüphane Kitap Listesi";
            Load += FormKitapListele_Load;
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource databaseHelperBindingSource;
        private BindingSource databaseHelperBindingSource1;
        private DataGridView dgvKitaplar;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnIptal;
        private Label lblAra;
        private TextBox txtAra;
        private ComboBox cmbKategoriFiltre;
        private Button btnTumunuGoster;
        private Button btnMusaitKitaplar;
        private Button btnKategoriEkle;
    }
}