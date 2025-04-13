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
    public partial class FormLogGor : Form
    {
        public FormLogGor()
        {
            InitializeComponent();
        }

        private void rtbLoglar_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogGor_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            rtbLoglar.BackColor = Color.FromArgb(45, 45, 45);
            rtbLoglar.ForeColor = Color.White;
            rtbLoglar.BorderStyle = BorderStyle.None;
            rtbLoglar.ReadOnly = true;

            string logDosyaYolu = Application.StartupPath + @"\Logs\log.txt";
            if (File.Exists(logDosyaYolu))
            {
                rtbLoglar.Text = File.ReadAllText(logDosyaYolu);
            }
            else
            {
                rtbLoglar.Text = "Henüz log oluşturulmamış.";
            }
        }

    }
}
