namespace KutuphaneOtomasyonu
{
    partial class FormUyeEkle
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
            lblAdSoyad = new Label();
            txtAdSoyad = new TextBox();
            btnUyeKaydet = new Button();
            btnIptal = new Button();
            SuspendLayout();
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.ForeColor = Color.White;
            lblAdSoyad.Location = new Point(59, 47);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(89, 15);
            lblAdSoyad.TabIndex = 0;
            lblAdSoyad.Text = "Üye Adı Soyadı:";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.BackColor = Color.FromArgb(50, 50, 50);
            txtAdSoyad.ForeColor = Color.White;
            txtAdSoyad.Location = new Point(168, 44);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(200, 23);
            txtAdSoyad.TabIndex = 1;
            // 
            // btnUyeKaydet
            // 
            btnUyeKaydet.BackColor = Color.FromArgb(50, 50, 50);
            btnUyeKaydet.FlatAppearance.BorderColor = Color.Gray;
            btnUyeKaydet.FlatStyle = FlatStyle.Flat;
            btnUyeKaydet.ForeColor = Color.White;
            btnUyeKaydet.Location = new Point(123, 85);
            btnUyeKaydet.Name = "btnUyeKaydet";
            btnUyeKaydet.Size = new Size(100, 33);
            btnUyeKaydet.TabIndex = 2;
            btnUyeKaydet.Text = "Kaydet";
            btnUyeKaydet.UseVisualStyleBackColor = false;
            btnUyeKaydet.Click += btnUyeKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.FromArgb(50, 50, 50);
            btnIptal.FlatAppearance.BorderColor = Color.Gray;
            btnIptal.FlatStyle = FlatStyle.Flat;
            btnIptal.ForeColor = Color.White;
            btnIptal.Location = new Point(245, 85);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(100, 33);
            btnIptal.TabIndex = 3;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // FormUyeEkle
            // 
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(480, 180);
            Controls.Add(lblAdSoyad);
            Controls.Add(txtAdSoyad);
            Controls.Add(btnUyeKaydet);
            Controls.Add(btnIptal);
            ForeColor = Color.White;
            Name = "FormUyeEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Üye Ekle";
            Load += FormUyeEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdSoyad;
        private TextBox txtAdSoyad;
        private Button btnUyeKaydet;
        private Button btnIptal;
    }
}
