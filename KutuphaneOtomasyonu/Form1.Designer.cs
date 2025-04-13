namespace KutuphaneOtomasyonu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbArkaPlan = new PictureBox();
            btnListele = new Button();
            btnUyeleriListele = new Button();
            btnOduncVer = new Button();
            btnOduncListele = new Button();
            btnCikis = new Button();
            btnKitapEkle = new Button();
            pbKitapListele = new PictureBox();
            pbKitapEkle = new PictureBox();
            pbUyeEkle = new PictureBox();
            pbUyeleriListele = new PictureBox();
            pbOduncVer = new PictureBox();
            pbOduncListele = new PictureBox();
            pbCikis = new PictureBox();
            btnUyeEkle = new Button();
            pnlMenu = new Panel();
            pbAyarlar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbArkaPlan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbKitapListele).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbKitapEkle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUyeEkle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUyeleriListele).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOduncVer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOduncListele).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCikis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAyarlar).BeginInit();
            SuspendLayout();
            // 
            // pbArkaPlan
            // 
            pbArkaPlan.Dock = DockStyle.Fill;
            pbArkaPlan.Image = (Image)resources.GetObject("pbArkaPlan.Image");
            pbArkaPlan.InitialImage = null;
            pbArkaPlan.Location = new Point(0, 0);
            pbArkaPlan.Name = "pbArkaPlan";
            pbArkaPlan.Size = new Size(1330, 630);
            pbArkaPlan.TabIndex = 9;
            pbArkaPlan.TabStop = false;
            // 
            // btnListele
            // 
            btnListele.BackColor = Color.FromArgb(45, 45, 48);
            btnListele.FlatAppearance.BorderColor = Color.DimGray;
            btnListele.FlatStyle = FlatStyle.Flat;
            btnListele.ForeColor = Color.White;
            btnListele.Location = new Point(363, 368);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(130, 45);
            btnListele.TabIndex = 1;
            btnListele.Text = "Kitapları Listele";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // btnUyeleriListele
            // 
            btnUyeleriListele.BackColor = Color.FromArgb(45, 45, 48);
            btnUyeleriListele.FlatAppearance.BorderColor = Color.DimGray;
            btnUyeleriListele.FlatStyle = FlatStyle.Flat;
            btnUyeleriListele.ForeColor = Color.White;
            btnUyeleriListele.Location = new Point(635, 368);
            btnUyeleriListele.Name = "btnUyeleriListele";
            btnUyeleriListele.Size = new Size(130, 45);
            btnUyeleriListele.TabIndex = 3;
            btnUyeleriListele.Text = "Üyeleri Listele";
            btnUyeleriListele.UseVisualStyleBackColor = false;
            btnUyeleriListele.Click += btnUyeleriListele_Click;
            // 
            // btnOduncVer
            // 
            btnOduncVer.BackColor = Color.FromArgb(45, 45, 48);
            btnOduncVer.FlatAppearance.BorderColor = Color.DimGray;
            btnOduncVer.FlatStyle = FlatStyle.Flat;
            btnOduncVer.ForeColor = Color.White;
            btnOduncVer.Location = new Point(771, 368);
            btnOduncVer.Name = "btnOduncVer";
            btnOduncVer.Size = new Size(130, 45);
            btnOduncVer.TabIndex = 4;
            btnOduncVer.Text = "Kitap Ödünç Ver";
            btnOduncVer.UseVisualStyleBackColor = false;
            btnOduncVer.Click += btnOduncVer_Click;
            // 
            // btnOduncListele
            // 
            btnOduncListele.BackColor = Color.FromArgb(45, 45, 48);
            btnOduncListele.FlatAppearance.BorderColor = Color.DimGray;
            btnOduncListele.FlatStyle = FlatStyle.Flat;
            btnOduncListele.ForeColor = Color.White;
            btnOduncListele.Location = new Point(907, 368);
            btnOduncListele.Name = "btnOduncListele";
            btnOduncListele.Size = new Size(130, 45);
            btnOduncListele.TabIndex = 5;
            btnOduncListele.Text = "Ödünç Listele";
            btnOduncListele.UseVisualStyleBackColor = false;
            btnOduncListele.Click += btnOduncListele_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.FromArgb(45, 45, 48);
            btnCikis.FlatAppearance.BorderColor = Color.DimGray;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.ForeColor = Color.White;
            btnCikis.Location = new Point(1043, 368);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(130, 45);
            btnCikis.TabIndex = 6;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnKitapEkle
            // 
            btnKitapEkle.BackColor = Color.FromArgb(45, 45, 48);
            btnKitapEkle.FlatAppearance.BorderColor = Color.DimGray;
            btnKitapEkle.FlatStyle = FlatStyle.Flat;
            btnKitapEkle.ForeColor = Color.White;
            btnKitapEkle.Location = new Point(227, 368);
            btnKitapEkle.Name = "btnKitapEkle";
            btnKitapEkle.Size = new Size(130, 45);
            btnKitapEkle.TabIndex = 0;
            btnKitapEkle.Text = "Kitap Ekle";
            btnKitapEkle.UseVisualStyleBackColor = false;
            btnKitapEkle.Click += btnKitapEkle_Click;
            // 
            // pbKitapListele
            // 
            pbKitapListele.BackColor = Color.Black;
            pbKitapListele.Image = (Image)resources.GetObject("pbKitapListele.Image");
            pbKitapListele.Location = new Point(392, 292);
            pbKitapListele.Name = "pbKitapListele";
            pbKitapListele.Size = new Size(70, 70);
            pbKitapListele.SizeMode = PictureBoxSizeMode.Zoom;
            pbKitapListele.TabIndex = 31;
            pbKitapListele.TabStop = false;
            // 
            // pbKitapEkle
            // 
            pbKitapEkle.BackColor = Color.Black;
            pbKitapEkle.Image = (Image)resources.GetObject("pbKitapEkle.Image");
            pbKitapEkle.Location = new Point(260, 292);
            pbKitapEkle.Name = "pbKitapEkle";
            pbKitapEkle.Size = new Size(70, 70);
            pbKitapEkle.SizeMode = PictureBoxSizeMode.Zoom;
            pbKitapEkle.TabIndex = 30;
            pbKitapEkle.TabStop = false;
            // 
            // pbUyeEkle
            // 
            pbUyeEkle.BackColor = Color.Black;
            pbUyeEkle.Image = (Image)resources.GetObject("pbUyeEkle.Image");
            pbUyeEkle.Location = new Point(532, 292);
            pbUyeEkle.Name = "pbUyeEkle";
            pbUyeEkle.Size = new Size(70, 70);
            pbUyeEkle.SizeMode = PictureBoxSizeMode.Zoom;
            pbUyeEkle.TabIndex = 32;
            pbUyeEkle.TabStop = false;
            // 
            // pbUyeleriListele
            // 
            pbUyeleriListele.BackColor = Color.Black;
            pbUyeleriListele.Image = (Image)resources.GetObject("pbUyeleriListele.Image");
            pbUyeleriListele.Location = new Point(666, 292);
            pbUyeleriListele.Name = "pbUyeleriListele";
            pbUyeleriListele.Size = new Size(70, 70);
            pbUyeleriListele.SizeMode = PictureBoxSizeMode.Zoom;
            pbUyeleriListele.TabIndex = 33;
            pbUyeleriListele.TabStop = false;
            // 
            // pbOduncVer
            // 
            pbOduncVer.BackColor = Color.Black;
            pbOduncVer.Image = (Image)resources.GetObject("pbOduncVer.Image");
            pbOduncVer.Location = new Point(800, 292);
            pbOduncVer.Name = "pbOduncVer";
            pbOduncVer.Size = new Size(70, 70);
            pbOduncVer.SizeMode = PictureBoxSizeMode.Zoom;
            pbOduncVer.TabIndex = 34;
            pbOduncVer.TabStop = false;
            // 
            // pbOduncListele
            // 
            pbOduncListele.BackColor = Color.Black;
            pbOduncListele.Image = (Image)resources.GetObject("pbOduncListele.Image");
            pbOduncListele.Location = new Point(937, 292);
            pbOduncListele.Name = "pbOduncListele";
            pbOduncListele.Size = new Size(70, 70);
            pbOduncListele.SizeMode = PictureBoxSizeMode.Zoom;
            pbOduncListele.TabIndex = 35;
            pbOduncListele.TabStop = false;
            // 
            // pbCikis
            // 
            pbCikis.BackColor = Color.Black;
            pbCikis.Image = (Image)resources.GetObject("pbCikis.Image");
            pbCikis.Location = new Point(1072, 292);
            pbCikis.Name = "pbCikis";
            pbCikis.Size = new Size(70, 70);
            pbCikis.SizeMode = PictureBoxSizeMode.Zoom;
            pbCikis.TabIndex = 36;
            pbCikis.TabStop = false;
            // 
            // btnUyeEkle
            // 
            btnUyeEkle.BackColor = Color.FromArgb(45, 45, 48);
            btnUyeEkle.FlatAppearance.BorderColor = Color.DimGray;
            btnUyeEkle.FlatStyle = FlatStyle.Flat;
            btnUyeEkle.ForeColor = Color.White;
            btnUyeEkle.Location = new Point(499, 368);
            btnUyeEkle.Name = "btnUyeEkle";
            btnUyeEkle.Size = new Size(130, 45);
            btnUyeEkle.TabIndex = 2;
            btnUyeEkle.Text = "Üye Ekle";
            btnUyeEkle.UseVisualStyleBackColor = false;
            btnUyeEkle.Click += btnUyeEkle_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.AutoSize = true;
            pnlMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlMenu.Location = new Point(99, 158);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(0, 0);
            pnlMenu.TabIndex = 8;
            // 
            // pbAyarlar
            // 
            pbAyarlar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbAyarlar.BackColor = Color.Transparent;
            pbAyarlar.Cursor = Cursors.Hand;
            pbAyarlar.Image = (Image)resources.GetObject("pbAyarlar.Image");
            pbAyarlar.Location = new Point(1286, 12);
            pbAyarlar.Name = "pbAyarlar";
            pbAyarlar.Size = new Size(32, 32);
            pbAyarlar.SizeMode = PictureBoxSizeMode.Zoom;
            pbAyarlar.TabIndex = 37;
            pbAyarlar.TabStop = false;
            pbAyarlar.Click += pbAyarlar_Click;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1330, 630);
            Controls.Add(pbAyarlar);
            Controls.Add(pbCikis);
            Controls.Add(btnUyeEkle);
            Controls.Add(btnCikis);
            Controls.Add(btnKitapEkle);
            Controls.Add(pnlMenu);
            Controls.Add(btnOduncListele);
            Controls.Add(pbOduncListele);
            Controls.Add(pbUyeEkle);
            Controls.Add(pbKitapListele);
            Controls.Add(btnListele);
            Controls.Add(btnOduncVer);
            Controls.Add(btnUyeleriListele);
            Controls.Add(pbOduncVer);
            Controls.Add(pbUyeleriListele);
            Controls.Add(pbKitapEkle);
            Controls.Add(pbArkaPlan);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Kütüphane Takip Otomasyonu";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbArkaPlan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbKitapListele).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbKitapEkle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUyeEkle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUyeleriListele).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOduncVer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOduncListele).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCikis).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAyarlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbArkaPlan;
        private Button btnListele;
        private Button btnUyeleriListele;
        private Button btnOduncVer;
        private Button btnOduncListele;
        private Button btnCikis;
        private Button btnKitapEkle;
        private PictureBox pbKitapListele;
        private PictureBox pbKitapEkle;
        private PictureBox pbUyeEkle;
        private PictureBox pbUyeleriListele;
        private PictureBox pbOduncVer;
        private PictureBox pbOduncListele;
        private PictureBox pbCikis;
        private Button btnUyeEkle;
        private Panel pnlMenu;
        private PictureBox pbAyarlar;
    }
}