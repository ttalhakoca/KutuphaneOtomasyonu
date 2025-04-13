namespace KutuphaneOtomasyonu
{
    partial class FormKitapEkle
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtKitapAdi = new TextBox();
            txtYazar = new TextBox();
            txtYayinYili = new TextBox();
            btnKaydet = new Button();
            btnIptal = new Button();
            cmbKategori = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(102, 59);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 9;
            label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(102, 104);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 8;
            label2.Text = "Yazar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(102, 150);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 7;
            label3.Text = "Yayın Yılı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(102, 195);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Kategori";
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.BackColor = Color.FromArgb(45, 45, 45);
            txtKitapAdi.BorderStyle = BorderStyle.FixedSingle;
            txtKitapAdi.ForeColor = Color.White;
            txtKitapAdi.Location = new Point(236, 56);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(180, 23);
            txtKitapAdi.TabIndex = 5;
            // 
            // txtYazar
            // 
            txtYazar.BackColor = Color.FromArgb(45, 45, 45);
            txtYazar.BorderStyle = BorderStyle.FixedSingle;
            txtYazar.ForeColor = Color.White;
            txtYazar.Location = new Point(236, 101);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(180, 23);
            txtYazar.TabIndex = 4;
            // 
            // txtYayinYili
            // 
            txtYayinYili.BackColor = Color.FromArgb(45, 45, 45);
            txtYayinYili.BorderStyle = BorderStyle.FixedSingle;
            txtYayinYili.ForeColor = Color.White;
            txtYayinYili.Location = new Point(236, 147);
            txtYayinYili.Name = "txtYayinYili";
            txtYayinYili.Size = new Size(180, 23);
            txtYayinYili.TabIndex = 3;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(70, 130, 180);
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(146, 266);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(90, 30);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.FromArgb(100, 100, 100);
            btnIptal.FlatStyle = FlatStyle.Flat;
            btnIptal.ForeColor = Color.White;
            btnIptal.Location = new Point(269, 266);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(90, 30);
            btnIptal.TabIndex = 1;
            btnIptal.Text = "Çıkış";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // cmbKategori
            // 
            cmbKategori.BackColor = Color.FromArgb(45, 45, 45);
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FlatStyle = FlatStyle.Flat;
            cmbKategori.ForeColor = Color.White;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(236, 192);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(180, 23);
            cmbKategori.TabIndex = 0;
            // 
            // FormKitapEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(600, 400);
            Controls.Add(cmbKategori);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(txtYayinYili);
            Controls.Add(txtYazar);
            Controls.Add(txtKitapAdi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "FormKitapEkle";
            Text = "Kitap Ekle";
            Load += FormKitapEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtKitapAdi;
        private TextBox txtYazar;
        private TextBox txtYayinYili;
        private Button btnKaydet;
        private Button btnIptal;
        private ComboBox cmbKategori;
    }
}
