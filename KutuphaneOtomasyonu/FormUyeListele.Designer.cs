using System.Drawing;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    partial class FormUyeListele
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvUyeler = new DataGridView();
            btnDuzenle = new Button();
            btnSil = new Button();
            btnIptal = new Button();
            txtUyeAra = new TextBox();
            lblUyeAra = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).BeginInit();
            SuspendLayout();
            // 
            // dgvUyeler
            // 
            dgvUyeler.BackgroundColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUyeler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUyeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUyeler.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUyeler.EnableHeadersVisualStyles = false;
            dgvUyeler.GridColor = Color.Gray;
            dgvUyeler.Location = new Point(41, 55);
            dgvUyeler.Name = "dgvUyeler";
            dgvUyeler.Size = new Size(244, 400);
            dgvUyeler.TabIndex = 0;
            // 
            // btnDuzenle
            // 
            btnDuzenle.BackColor = Color.FromArgb(50, 50, 50);
            btnDuzenle.FlatAppearance.BorderColor = Color.Gray;
            btnDuzenle.FlatStyle = FlatStyle.Flat;
            btnDuzenle.ForeColor = Color.White;
            btnDuzenle.Location = new Point(291, 63);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(100, 40);
            btnDuzenle.TabIndex = 1;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = false;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(50, 50, 50);
            btnSil.FlatAppearance.BorderColor = Color.Gray;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(291, 109);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(100, 40);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.FromArgb(50, 50, 50);
            btnIptal.FlatAppearance.BorderColor = Color.Gray;
            btnIptal.FlatStyle = FlatStyle.Flat;
            btnIptal.ForeColor = Color.White;
            btnIptal.Location = new Point(291, 155);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(100, 40);
            btnIptal.TabIndex = 3;
            btnIptal.Text = "Çıkış";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // txtUyeAra
            // 
            txtUyeAra.Location = new Point(98, 26);
            txtUyeAra.Name = "txtUyeAra";
            txtUyeAra.Size = new Size(187, 23);
            txtUyeAra.TabIndex = 4;
            // 
            // lblUyeAra
            // 
            lblUyeAra.AutoSize = true;
            lblUyeAra.ForeColor = SystemColors.ButtonHighlight;
            lblUyeAra.Location = new Point(41, 29);
            lblUyeAra.Name = "lblUyeAra";
            lblUyeAra.Size = new Size(51, 15);
            lblUyeAra.TabIndex = 5;
            lblUyeAra.Text = "Üye Ara:";
            // 
            // FormUyeListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(439, 480);
            Controls.Add(txtUyeAra);
            Controls.Add(dgvUyeler);
            Controls.Add(btnDuzenle);
            Controls.Add(btnSil);
            Controls.Add(btnIptal);
            Controls.Add(lblUyeAra);
            Name = "FormUyeListele";
            Text = "Üye Listele";
            Load += FormUyeListele_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DataGridView dgvUyeler;
        private Button btnIptal;
        private Button btnSil;
        private Button btnDuzenle;
        private TextBox txtUyeAra;
        private Label lblUyeAra;
    }
}
