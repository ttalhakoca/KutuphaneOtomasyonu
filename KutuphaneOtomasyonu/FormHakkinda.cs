using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class FormHakkinda : Form
    {
        public FormHakkinda()
        {
            InitializeComponent();
        }

        private void FormHakkinda_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.ForeColor = Color.White;

            string logoYolu = Application.StartupPath + "\\D_Renkli_KoyuZemin.png";
            if (File.Exists(logoYolu))
            {
                pbLogo.Image = Image.FromFile(logoYolu);
                pbLogo.BackColor = Color.Transparent;
                pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            }
            foreach (Control c in Controls)
            {
                if (c is Label lbl)
                    lbl.ForeColor = Color.White;

                if (c is Button btn)
                {
                    btn.BackColor = Color.FromArgb(50, 50, 50);
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.Gray;
                    btn.FlatAppearance.BorderSize = 1;
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
