namespace KutuphaneOtomasyonu
{
    partial class FormLogGor
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
            rtbLoglar = new RichTextBox();
            SuspendLayout();
            // 
            // rtbLoglar
            // 
            rtbLoglar.Dock = DockStyle.Fill;
            rtbLoglar.Location = new Point(0, 0);
            rtbLoglar.Name = "rtbLoglar";
            rtbLoglar.Size = new Size(800, 450);
            rtbLoglar.TabIndex = 0;
            rtbLoglar.Text = "";
            rtbLoglar.TextChanged += rtbLoglar_TextChanged;
            // 
            // FormLogGor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbLoglar);
            Name = "FormLogGor";
            Text = "FormLogGor";
            Load += FormLogGor_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbLoglar;
    }
}