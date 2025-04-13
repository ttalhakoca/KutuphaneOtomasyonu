namespace KutuphaneOtomasyonu
{
    partial class FormOduncVer
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
            lblKitap = new Label();
            lblUye = new Label();
            lblTarih = new Label();
            cmbKitaplar = new ComboBox();
            cmbUyeler = new ComboBox();
            dtpVerilisTarihi = new DateTimePicker();
            btnOduncVer = new Button();
            btnIptalOdunc = new Button();
            SuspendLayout();

            // Form
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(936, 564);
            this.Name = "FormOduncVer";
            this.Text = "Ödünç Kitap Ver";
            this.Load += FormOduncVer_Load;
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.ForeColor = Color.White;

            // Label Kitap
            lblKitap.AutoSize = true;
            lblKitap.Location = new Point(225, 58);
            lblKitap.Name = "lblKitap";
            lblKitap.Size = new Size(34, 15);
            lblKitap.TabIndex = 0;
            lblKitap.Text = "Kitap";
            lblKitap.ForeColor = Color.White;

            // Label Üye
            lblUye.AutoSize = true;
            lblUye.Location = new Point(225, 98);
            lblUye.Name = "lblUye";
            lblUye.Size = new Size(27, 15);
            lblUye.TabIndex = 1;
            lblUye.Text = "Üye";
            lblUye.ForeColor = Color.White;

            // Label Tarih
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(225, 143);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(69, 15);
            lblTarih.TabIndex = 2;
            lblTarih.Text = "Veriliş Tarihi";
            lblTarih.ForeColor = Color.White;

            // ComboBox Kitap
            cmbKitaplar.FormattingEnabled = true;
            cmbKitaplar.Location = new Point(362, 55);
            cmbKitaplar.Name = "cmbKitaplar";
            cmbKitaplar.Size = new Size(200, 23);
            cmbKitaplar.TabIndex = 3;
            cmbKitaplar.BackColor = Color.FromArgb(50, 50, 50);
            cmbKitaplar.ForeColor = Color.White;
            cmbKitaplar.FlatStyle = FlatStyle.Flat;

            // ComboBox Üyeler
            cmbUyeler.FormattingEnabled = true;
            cmbUyeler.Location = new Point(362, 95);
            cmbUyeler.Name = "cmbUyeler";
            cmbUyeler.Size = new Size(200, 23);
            cmbUyeler.TabIndex = 4;
            cmbUyeler.BackColor = Color.FromArgb(50, 50, 50);
            cmbUyeler.ForeColor = Color.White;
            cmbUyeler.FlatStyle = FlatStyle.Flat;

            // DateTimePicker
            dtpVerilisTarihi.Location = new Point(362, 135);
            dtpVerilisTarihi.Name = "dtpVerilisTarihi";
            dtpVerilisTarihi.Size = new Size(200, 23);
            dtpVerilisTarihi.TabIndex = 5;
            dtpVerilisTarihi.CalendarMonthBackground = Color.FromArgb(50, 50, 50);
            dtpVerilisTarihi.CalendarForeColor = Color.White;
            dtpVerilisTarihi.CalendarTitleBackColor = Color.FromArgb(60, 60, 60);

            // Buton Ödünç Ver
            btnOduncVer.Location = new Point(285, 183);
            btnOduncVer.Name = "btnOduncVer";
            btnOduncVer.Size = new Size(75, 23);
            btnOduncVer.TabIndex = 6;
            btnOduncVer.Text = "Ödünç Ver";
            btnOduncVer.UseVisualStyleBackColor = true;
            btnOduncVer.BackColor = Color.FromArgb(50, 50, 50);
            btnOduncVer.ForeColor = Color.White;
            btnOduncVer.FlatStyle = FlatStyle.Flat;
            btnOduncVer.FlatAppearance.BorderColor = Color.Gray;
            btnOduncVer.Click += btnOduncVer_Click;

            // Buton İptal
            btnIptalOdunc.Location = new Point(393, 183);
            btnIptalOdunc.Name = "btnIptalOdunc";
            btnIptalOdunc.Size = new Size(75, 23);
            btnIptalOdunc.TabIndex = 7;
            btnIptalOdunc.Text = "İptal";
            btnIptalOdunc.UseVisualStyleBackColor = true;
            btnIptalOdunc.BackColor = Color.FromArgb(50, 50, 50);
            btnIptalOdunc.ForeColor = Color.White;
            btnIptalOdunc.FlatStyle = FlatStyle.Flat;
            btnIptalOdunc.FlatAppearance.BorderColor = Color.Gray;
            btnIptalOdunc.Click += btnIptalOdunc_Click;

            // Form Controls
            this.Controls.Add(lblKitap);
            this.Controls.Add(lblUye);
            this.Controls.Add(lblTarih);
            this.Controls.Add(cmbKitaplar);
            this.Controls.Add(cmbUyeler);
            this.Controls.Add(dtpVerilisTarihi);
            this.Controls.Add(btnOduncVer);
            this.Controls.Add(btnIptalOdunc);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKitap;
        private Label lblUye;
        private Label lblTarih;
        private ComboBox cmbKitaplar;
        private ComboBox cmbUyeler;
        private DateTimePicker dtpVerilisTarihi;
        private Button btnOduncVer;
        private Button btnIptalOdunc;
    }
}