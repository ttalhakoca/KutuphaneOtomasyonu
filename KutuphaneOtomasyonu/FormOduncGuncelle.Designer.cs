namespace KutuphaneOtomasyonu
{
    partial class FormOduncGuncelle
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
            cmbKitaplar = new ComboBox();
            cmbUyeler = new ComboBox();
            dtpVerilisTarihi = new DateTimePicker();
            btnGuncelle = new Button();
            btnIptal = new Button();
            lblKitap = new Label();
            lblUye = new Label();
            lblTarih = new Label();
            SuspendLayout();
            // 
            // cmbKitaplar
            // 
            cmbKitaplar.BackColor = Color.FromArgb(50, 50, 50);
            cmbKitaplar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKitaplar.ForeColor = Color.White;
            cmbKitaplar.FormattingEnabled = true;
            cmbKitaplar.Location = new Point(420, 70);
            cmbKitaplar.Name = "cmbKitaplar";
            cmbKitaplar.Size = new Size(200, 23);
            cmbKitaplar.TabIndex = 0;
            // 
            // cmbUyeler
            // 
            cmbUyeler.BackColor = Color.FromArgb(50, 50, 50);
            cmbUyeler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUyeler.ForeColor = Color.White;
            cmbUyeler.FormattingEnabled = true;
            cmbUyeler.Location = new Point(420, 115);
            cmbUyeler.Name = "cmbUyeler";
            cmbUyeler.Size = new Size(200, 23);
            cmbUyeler.TabIndex = 1;
            // 
            // dtpVerilisTarihi
            // 
            dtpVerilisTarihi.BackColor = Color.FromArgb(50, 50, 50);
            dtpVerilisTarihi.CalendarForeColor = Color.White;
            dtpVerilisTarihi.CalendarMonthBackground = Color.FromArgb(50, 50, 50);
            dtpVerilisTarihi.ForeColor = Color.White;
            dtpVerilisTarihi.Location = new Point(420, 160);
            dtpVerilisTarihi.Name = "dtpVerilisTarihi";
            dtpVerilisTarihi.Size = new Size(200, 23);
            dtpVerilisTarihi.TabIndex = 2;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(50, 50, 50);
            btnGuncelle.FlatAppearance.BorderColor = Color.Gray;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(379, 215);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.FromArgb(50, 50, 50);
            btnIptal.FlatAppearance.BorderColor = Color.Gray;
            btnIptal.FlatStyle = FlatStyle.Flat;
            btnIptal.ForeColor = Color.White;
            btnIptal.Location = new Point(491, 215);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(75, 23);
            btnIptal.TabIndex = 4;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // lblKitap
            // 
            lblKitap.AutoSize = true;
            lblKitap.ForeColor = Color.White;
            lblKitap.Location = new Point(322, 73);
            lblKitap.Name = "lblKitap";
            lblKitap.Size = new Size(34, 15);
            lblKitap.TabIndex = 5;
            lblKitap.Text = "Kitap";
            // 
            // lblUye
            // 
            lblUye.AutoSize = true;
            lblUye.ForeColor = Color.White;
            lblUye.Location = new Point(322, 118);
            lblUye.Name = "lblUye";
            lblUye.Size = new Size(27, 15);
            lblUye.TabIndex = 6;
            lblUye.Text = "Üye";
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.ForeColor = Color.White;
            lblTarih.Location = new Point(322, 166);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(69, 15);
            lblTarih.TabIndex = 7;
            lblTarih.Text = "Veriliş Tarihi";
            // 
            // FormOduncGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(983, 450);
            Controls.Add(lblTarih);
            Controls.Add(lblUye);
            Controls.Add(lblKitap);
            Controls.Add(btnIptal);
            Controls.Add(btnGuncelle);
            Controls.Add(dtpVerilisTarihi);
            Controls.Add(cmbUyeler);
            Controls.Add(cmbKitaplar);
            ForeColor = Color.White;
            Name = "FormOduncGuncelle";
            Text = "Ödünç Güncelle";
            Load += FormOduncGuncelle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbKitaplar;
        private ComboBox cmbUyeler;
        private DateTimePicker dtpVerilisTarihi;
        private Button btnGuncelle;
        private Button btnIptal;
        private Label lblKitap;
        private Label lblUye;
        private Label lblTarih;
    }
}
