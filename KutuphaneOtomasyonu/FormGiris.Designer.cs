namespace KutuphaneOtomasyonu
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            lblAdmin = new Label();
            pbLogo = new PictureBox();
            txtSifre = new TextBox();
            pbSifreGoster = new PictureBox();
            btnGiris = new Button();
            btnCikis = new Button();
            lblBaslik = new Label();
            panel1 = new Panel();
            pbArkaplan = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSifreGoster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArkaplan).BeginInit();
            SuspendLayout();
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.BackColor = Color.Transparent;
            lblAdmin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblAdmin.ForeColor = Color.WhiteSmoke;
            lblAdmin.Location = new Point(361, 223);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(78, 25);
            lblAdmin.TabIndex = 0;
            lblAdmin.Text = "ADMIN";
            lblAdmin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.Transparent;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(336, 92);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(128, 128);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.FromArgb(50, 50, 50);
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.ForeColor = Color.White;
            txtSifre.Location = new Point(325, 251);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(150, 23);
            txtSifre.TabIndex = 2;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // pbSifreGoster
            // 
            pbSifreGoster.BackColor = Color.Transparent;
            pbSifreGoster.Cursor = Cursors.Hand;
            pbSifreGoster.Location = new Point(481, 251);
            pbSifreGoster.Name = "pbSifreGoster";
            pbSifreGoster.Size = new Size(22, 23);
            pbSifreGoster.SizeMode = PictureBoxSizeMode.Zoom;
            pbSifreGoster.TabIndex = 3;
            pbSifreGoster.TabStop = false;
            pbSifreGoster.Click += pbSifreGoster_Click;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.FromArgb(50, 50, 50);
            btnGiris.FlatAppearance.BorderSize = 0;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.ForeColor = Color.White;
            btnGiris.Location = new Point(350, 289);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(100, 30);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.FromArgb(50, 50, 50);
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.ForeColor = Color.White;
            btnCikis.Location = new Point(350, 329);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(100, 30);
            btnCikis.TabIndex = 5;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.BackColor = Color.Transparent;
            lblBaslik.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.ForeColor = Color.WhiteSmoke;
            lblBaslik.Location = new Point(253, 9);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(294, 30);
            lblBaslik.TabIndex = 6;
            lblBaslik.Text = "KÜTÜPHANE TAKİP SİSTEMİ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Location = new Point(253, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 2);
            panel1.TabIndex = 7;
            // 
            // pbArkaplan
            // 
            pbArkaplan.Dock = DockStyle.Fill;
            pbArkaplan.Image = (Image)resources.GetObject("pbArkaplan.Image");
            pbArkaplan.Location = new Point(0, 0);
            pbArkaplan.Name = "pbArkaplan";
            pbArkaplan.Size = new Size(800, 450);
            pbArkaplan.SizeMode = PictureBoxSizeMode.StretchImage;
            pbArkaplan.TabIndex = 8;
            pbArkaplan.TabStop = false;
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(lblBaslik);
            Controls.Add(lblAdmin);
            Controls.Add(btnCikis);
            Controls.Add(btnGiris);
            Controls.Add(pbSifreGoster);
            Controls.Add(txtSifre);
            Controls.Add(pbLogo);
            Controls.Add(pbArkaplan);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "FormGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            Load += FormGiris_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSifreGoster).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArkaplan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdmin;
        private PictureBox pbLogo;
        private TextBox txtSifre;
        private PictureBox pbSifreGoster;
        private Button btnGiris;
        private Button btnCikis;
        private Label lblBaslik;
        private Panel panel1;
        private PictureBox pbArkaplan;
    }
}
