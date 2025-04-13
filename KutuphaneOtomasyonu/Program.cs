using System;
using System.IO;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Veritabani.VeritabaniOlustur();

            Application.Run(new FormGiris());
        }
    }
}
