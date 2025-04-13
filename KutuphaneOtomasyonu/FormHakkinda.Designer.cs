namespace KutuphaneOtomasyonu
{
    partial class FormHakkinda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHakkinda));
            lblVersiyon = new Label();
            lblGelistirici = new Label();
            lblAciklama = new Label();
            btnKapat = new Button();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblVersiyon
            // 
            lblVersiyon.AutoSize = true;
            lblVersiyon.Location = new Point(256, 266);
            lblVersiyon.Name = "lblVersiyon";
            lblVersiyon.Size = new Size(72, 15);
            lblVersiyon.TabIndex = 0;
            lblVersiyon.Text = "Versiyon: 1.0";
            // 
            // lblGelistirici
            // 
            lblGelistirici.AutoSize = true;
            lblGelistirici.Location = new Point(210, 241);
            lblGelistirici.Name = "lblGelistirici";
            lblGelistirici.Size = new Size(164, 15);
            lblGelistirici.TabIndex = 1;
            lblGelistirici.Text = "Geliştirici: Mustafa Talha Koca";
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.Location = new Point(192, 213);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(200, 15);
            lblAciklama.TabIndex = 2;
            lblAciklama.Text = "Kütüphane Otomasyonu - Mart 2025";
            // 
            // btnKapat
            // 
            btnKapat.Location = new Point(255, 294);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(75, 23);
            btnKapat.TabIndex = 3;
            btnKapat.Text = "Çıkış";
            btnKapat.UseVisualStyleBackColor = true;
            btnKapat.Click += btnKapat_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(217, 43);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(150, 150);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 4;
            pbLogo.TabStop = false;
            // 
            // FormHakkinda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(pbLogo);
            Controls.Add(btnKapat);
            Controls.Add(lblAciklama);
            Controls.Add(lblGelistirici);
            Controls.Add(lblVersiyon);
            Name = "FormHakkinda";
            Text = "FormHakkinda";
            Load += FormHakkinda_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVersiyon;
        private Label lblGelistirici;
        private Label lblAciklama;
        private Button btnKapat;
        private PictureBox pbLogo;
    }
}