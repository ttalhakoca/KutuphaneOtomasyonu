namespace KutuphaneOtomasyonu
{
    partial class FormUyeGuncelle
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblAdSoyad = new Label();
            txtAdSoyad = new TextBox();
            btnGuncelle = new Button();
            btnIptal = new Button();
            SuspendLayout();
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.ForeColor = Color.White;
            lblAdSoyad.Location = new Point(81, 46);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(60, 15);
            lblAdSoyad.TabIndex = 0;
            lblAdSoyad.Text = "Ad Soyad:";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.BackColor = Color.FromArgb(50, 50, 50);
            txtAdSoyad.ForeColor = Color.White;
            txtAdSoyad.Location = new Point(160, 43);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(200, 23);
            txtAdSoyad.TabIndex = 1;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(50, 50, 50);
            btnGuncelle.FlatAppearance.BorderColor = Color.Gray;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(134, 84);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(100, 30);
            btnGuncelle.TabIndex = 2;
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
            btnIptal.Location = new Point(240, 84);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(100, 30);
            btnIptal.TabIndex = 3;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // FormUyeGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(467, 176);
            Controls.Add(lblAdSoyad);
            Controls.Add(txtAdSoyad);
            Controls.Add(btnGuncelle);
            Controls.Add(btnIptal);
            ForeColor = Color.White;
            Name = "FormUyeGuncelle";
            Text = "Üye Güncelle";
            Load += FormUyeGuncelle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdSoyad;
        private TextBox txtAdSoyad;
        private Button btnGuncelle;
        private Button btnIptal;
    }
}
