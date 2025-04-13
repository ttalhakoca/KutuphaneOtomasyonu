namespace KutuphaneOtomasyonu
{
    partial class FormSifreDegistir
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
            lblEskiSifre = new Label();
            txtEskiSifre = new TextBox();
            lblYeniSifre = new Label();
            lblYeniTekrar = new Label();
            txtYeniSifre = new TextBox();
            txtYeniSifreTekrar = new TextBox();
            btnGuncelle = new Button();
            btnIptal = new Button();
            SuspendLayout();
            // 
            // lblEskiSifre
            // 
            lblEskiSifre.AutoSize = true;
            lblEskiSifre.ForeColor = Color.White;
            lblEskiSifre.Location = new Point(182, 94);
            lblEskiSifre.Name = "lblEskiSifre";
            lblEskiSifre.Size = new Size(53, 15);
            lblEskiSifre.TabIndex = 7;
            lblEskiSifre.Text = "Eski Şifre";
            // 
            // txtEskiSifre
            // 
            txtEskiSifre.BackColor = Color.FromArgb(50, 50, 50);
            txtEskiSifre.ForeColor = Color.White;
            txtEskiSifre.Location = new Point(286, 91);
            txtEskiSifre.Name = "txtEskiSifre";
            txtEskiSifre.Size = new Size(100, 23);
            txtEskiSifre.TabIndex = 0;
            txtEskiSifre.UseSystemPasswordChar = true;
            // 
            // lblYeniSifre
            // 
            lblYeniSifre.AutoSize = true;
            lblYeniSifre.ForeColor = Color.White;
            lblYeniSifre.Location = new Point(182, 131);
            lblYeniSifre.Name = "lblYeniSifre";
            lblYeniSifre.Size = new Size(55, 15);
            lblYeniSifre.TabIndex = 5;
            lblYeniSifre.Text = "Yeni Şifre";
            // 
            // lblYeniTekrar
            // 
            lblYeniTekrar.AutoSize = true;
            lblYeniTekrar.ForeColor = Color.White;
            lblYeniTekrar.Location = new Point(182, 166);
            lblYeniTekrar.Name = "lblYeniTekrar";
            lblYeniTekrar.Size = new Size(98, 15);
            lblYeniTekrar.TabIndex = 4;
            lblYeniTekrar.Text = "Yeni Şifre (Tekrar)";
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.BackColor = Color.FromArgb(50, 50, 50);
            txtYeniSifre.ForeColor = Color.White;
            txtYeniSifre.Location = new Point(286, 128);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(100, 23);
            txtYeniSifre.TabIndex = 1;
            txtYeniSifre.UseSystemPasswordChar = true;
            // 
            // txtYeniSifreTekrar
            // 
            txtYeniSifreTekrar.BackColor = Color.FromArgb(50, 50, 50);
            txtYeniSifreTekrar.ForeColor = Color.White;
            txtYeniSifreTekrar.Location = new Point(286, 163);
            txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            txtYeniSifreTekrar.Size = new Size(100, 23);
            txtYeniSifreTekrar.TabIndex = 3;
            txtYeniSifreTekrar.UseSystemPasswordChar = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(50, 50, 50);
            btnGuncelle.FlatAppearance.BorderColor = Color.Gray;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(205, 215);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 25);
            btnGuncelle.TabIndex = 4;
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
            btnIptal.Location = new Point(286, 215);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(75, 25);
            btnIptal.TabIndex = 5;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // FormSifreDegistir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(584, 361);
            Controls.Add(btnIptal);
            Controls.Add(btnGuncelle);
            Controls.Add(txtYeniSifreTekrar);
            Controls.Add(txtYeniSifre);
            Controls.Add(lblYeniTekrar);
            Controls.Add(lblYeniSifre);
            Controls.Add(txtEskiSifre);
            Controls.Add(lblEskiSifre);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormSifreDegistir";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Şifre Değiştir";
            Load += FormSifreDegistir_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEskiSifre;
        private TextBox txtEskiSifre;
        private Label lblYeniSifre;
        private Label lblYeniTekrar;
        private TextBox txtYeniSifre;
        private TextBox txtYeniSifreTekrar;
        private Button btnGuncelle;
        private Button btnIptal;
    }
}
