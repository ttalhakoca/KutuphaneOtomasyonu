namespace KutuphaneOtomasyonu
{
    partial class FormOduncListele
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
            dgvOdunc = new DataGridView();
            btnTeslimEt = new Button();
            btnYenile = new Button();
            btnIptalOdunc = new Button();
            btnGuncelle = new Button();
            btnOduncSil = new Button();
            chkTeslimEdilmemis = new CheckBox();
            txtKitapAra = new TextBox();
            txtUyeAra = new TextBox();
            lblUyeAra = new Label();
            lblKitapAra = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOdunc).BeginInit();
            SuspendLayout();

            // Form Dark Theme
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.ForeColor = Color.White;

            // lblKitapAra
            lblKitapAra.AutoSize = true;
            lblKitapAra.Location = new Point(68, 42);
            lblKitapAra.Name = "lblKitapAra";
            lblKitapAra.Size = new Size(55, 15);
            lblKitapAra.TabIndex = 12;
            lblKitapAra.Text = "Kitap Ara";
            lblKitapAra.ForeColor = Color.White;

            // txtKitapAra
            txtKitapAra.Location = new Point(129, 39);
            txtKitapAra.Name = "txtKitapAra";
            txtKitapAra.Size = new Size(100, 23);
            txtKitapAra.TabIndex = 9;
            txtKitapAra.BackColor = Color.FromArgb(50, 50, 50);
            txtKitapAra.ForeColor = Color.White;

            // lblUyeAra
            lblUyeAra.AutoSize = true;
            lblUyeAra.Location = new Point(264, 42);
            lblUyeAra.Name = "lblUyeAra";
            lblUyeAra.Size = new Size(48, 15);
            lblUyeAra.TabIndex = 11;
            lblUyeAra.Text = "Üye Ara";
            lblUyeAra.ForeColor = Color.White;

            // txtUyeAra
            txtUyeAra.Location = new Point(318, 39);
            txtUyeAra.Name = "txtUyeAra";
            txtUyeAra.Size = new Size(100, 23);
            txtUyeAra.TabIndex = 10;
            txtUyeAra.BackColor = Color.FromArgb(50, 50, 50);
            txtUyeAra.ForeColor = Color.White;

            // chkTeslimEdilmemis
            chkTeslimEdilmemis.AutoSize = true;
            chkTeslimEdilmemis.Location = new Point(622, 43);
            chkTeslimEdilmemis.Name = "chkTeslimEdilmemis";
            chkTeslimEdilmemis.Size = new Size(171, 19);
            chkTeslimEdilmemis.TabIndex = 8;
            chkTeslimEdilmemis.Text = "Teslim Edilmeyenleri Göster";
            chkTeslimEdilmemis.UseVisualStyleBackColor = true;
            chkTeslimEdilmemis.ForeColor = Color.White;

            // dgvOdunc
            dgvOdunc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOdunc.Location = new Point(68, 75);
            dgvOdunc.Name = "dgvOdunc";
            dgvOdunc.Size = new Size(725, 272);
            dgvOdunc.TabIndex = 0;
            dgvOdunc.RowPrePaint += dgvOdunc_RowPrePaint;
            dgvOdunc.BackgroundColor = Color.FromArgb(45, 45, 45);
            dgvOdunc.DefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgvOdunc.DefaultCellStyle.ForeColor = Color.White;
            dgvOdunc.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
            dgvOdunc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvOdunc.EnableHeadersVisualStyles = false;
            dgvOdunc.GridColor = Color.Gray;

            // btnTeslimEt
            btnTeslimEt.Location = new Point(799, 75);
            btnTeslimEt.Name = "btnTeslimEt";
            btnTeslimEt.Size = new Size(96, 44);
            btnTeslimEt.TabIndex = 1;
            btnTeslimEt.Text = "Teslim Et";
            btnTeslimEt.UseVisualStyleBackColor = true;
            btnTeslimEt.BackColor = Color.FromArgb(50, 50, 50);
            btnTeslimEt.ForeColor = Color.White;
            btnTeslimEt.FlatStyle = FlatStyle.Flat;
            btnTeslimEt.FlatAppearance.BorderColor = Color.Gray;
            btnTeslimEt.Click += btnTeslimEt_Click;

            // btnGuncelle
            btnGuncelle.Location = new Point(799, 125);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(96, 44);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.BackColor = Color.FromArgb(50, 50, 50);
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.FlatAppearance.BorderColor = Color.Gray;
            btnGuncelle.Click += btnGuncelle_Click;

            // btnOduncSil
            btnOduncSil.Location = new Point(799, 175);
            btnOduncSil.Name = "btnOduncSil";
            btnOduncSil.Size = new Size(96, 44);
            btnOduncSil.TabIndex = 3;
            btnOduncSil.Text = "Sil";
            btnOduncSil.UseVisualStyleBackColor = true;
            btnOduncSil.BackColor = Color.FromArgb(50, 50, 50);
            btnOduncSil.ForeColor = Color.White;
            btnOduncSil.FlatStyle = FlatStyle.Flat;
            btnOduncSil.FlatAppearance.BorderColor = Color.Gray;
            btnOduncSil.Click += btnOduncSil_Click;

            // btnYenile
            btnYenile.Location = new Point(799, 225);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(96, 44);
            btnYenile.TabIndex = 4;
            btnYenile.Text = "Listeyi Yenile";
            btnYenile.UseVisualStyleBackColor = true;
            btnYenile.BackColor = Color.FromArgb(50, 50, 50);
            btnYenile.ForeColor = Color.White;
            btnYenile.FlatStyle = FlatStyle.Flat;
            btnYenile.FlatAppearance.BorderColor = Color.Gray;
            btnYenile.Click += btnListeyiYenile_Click;

            // btnIptalOdunc
            btnIptalOdunc.Location = new Point(799, 275);
            btnIptalOdunc.Name = "btnIptalOdunc";
            btnIptalOdunc.Size = new Size(96, 44);
            btnIptalOdunc.TabIndex = 5;
            btnIptalOdunc.Text = "Çıkış";
            btnIptalOdunc.UseVisualStyleBackColor = true;
            btnIptalOdunc.BackColor = Color.FromArgb(50, 50, 50);
            btnIptalOdunc.ForeColor = Color.White;
            btnIptalOdunc.FlatStyle = FlatStyle.Flat;
            btnIptalOdunc.FlatAppearance.BorderColor = Color.Gray;
            btnIptalOdunc.Click += btnIptalOdunc_Click;

            // FormOduncListele
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 557);
            Controls.Add(lblKitapAra);
            Controls.Add(lblUyeAra);
            Controls.Add(txtUyeAra);
            Controls.Add(txtKitapAra);
            Controls.Add(chkTeslimEdilmemis);
            Controls.Add(btnOduncSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnIptalOdunc);
            Controls.Add(btnYenile);
            Controls.Add(btnTeslimEt);
            Controls.Add(dgvOdunc);
            Name = "FormOduncListele";
            Text = "Ödünç Kitaplar";
            Load += FormOduncListele_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOdunc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOdunc;
        private Button btnTeslimEt;
        private Button btnYenile;
        private Button btnIptalOdunc;
        private Button btnGuncelle;
        private Button btnOduncSil;
        private CheckBox chkTeslimEdilmemis;
        private TextBox txtKitapAra;
        private TextBox txtUyeAra;
        private Label lblUyeAra;
        private Label lblKitapAra;
    }
}
