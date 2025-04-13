using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public static class Veritabani
    {
        private static readonly string veritabaniYolu = Path.Combine(Application.StartupPath, "kutuphane.db");

        public static SQLiteConnection BaglantiAl()
        {
            if (!File.Exists(veritabaniYolu))
                SQLiteConnection.CreateFile(veritabaniYolu);

            return new SQLiteConnection($"Data Source={veritabaniYolu};Version=3;");
        }

        public static void VeritabaniOlustur()
        {
            using (var baglanti = BaglantiAl())
            {
                baglanti.Open();

                string query = @"
                    CREATE TABLE IF NOT EXISTS Kitaplar (
                        KitapID INTEGER PRIMARY KEY AUTOINCREMENT,
                        KitapAdi TEXT NOT NULL,
                        Yazar TEXT NOT NULL,
                        YayinYili INTEGER NOT NULL,
                        Kategori TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Uyeler (
                        UyeID INTEGER PRIMARY KEY AUTOINCREMENT,
                        AdSoyad TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Odunc (
                        OduncID INTEGER PRIMARY KEY AUTOINCREMENT,
                        KitapID INTEGER NOT NULL,
                        UyeID INTEGER NOT NULL,
                        VerilisTarihi TEXT NOT NULL,
                        TeslimTarihi TEXT,
                        FOREIGN KEY (KitapID) REFERENCES Kitaplar(KitapID),
                        FOREIGN KEY (UyeID) REFERENCES Uyeler(UyeID)
                    );

                    CREATE TABLE IF NOT EXISTS Kategoriler (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        KategoriAdi TEXT UNIQUE NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Ayarlar (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Sifre TEXT NOT NULL
                    );
                ";

                using var cmd = new SQLiteCommand(query, baglanti);
                cmd.ExecuteNonQuery();

                string sifreKontrol = "SELECT COUNT(*) FROM Ayarlar";
                using var sifreCmd = new SQLiteCommand(sifreKontrol, baglanti);
                long sifreSayisi = (long)sifreCmd.ExecuteScalar();

                if (sifreSayisi == 0)
                {
                    string sifreEkle = "INSERT INTO Ayarlar (Sifre) VALUES ('admin')";
                    using var ekleCmd = new SQLiteCommand(sifreEkle, baglanti);
                    ekleCmd.ExecuteNonQuery();
                }
            }
        }

        public static string SifreGetir()
        {
            using var conn = BaglantiAl();
            conn.Open();

            string query = "SELECT Sifre FROM Ayarlar LIMIT 1";
            using var cmd = new SQLiteCommand(query, conn);
            return cmd.ExecuteScalar()?.ToString() ?? "admin";
        }

        public static bool SifreGuncelle(string yeniSifre)
        {
            using var conn = BaglantiAl();
            conn.Open();

            string query = "UPDATE Ayarlar SET Sifre = @sifre";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@sifre", yeniSifre);

            return cmd.ExecuteNonQuery() > 0;
        }
        public static string VeritabaniYedekle()
        {
            try
            {
                string kaynakDosya = Path.Combine(Application.StartupPath, "kutuphane.db");
                string backupKlasor = Path.Combine(Application.StartupPath, "Backup");
                Directory.CreateDirectory(backupKlasor);

                string tarihSaat = DateTime.Now.ToString("yyyy-MM-dd_HH-mm");
                string hedefDosya = Path.Combine(backupKlasor, $"kutuphane_Yedek_{tarihSaat}.db");

                File.Copy(kaynakDosya, hedefDosya, true);

                LogEkle($" Veritabanı yedeklendi: {Path.GetFileName(hedefDosya)}");
                return $"Yedekleme tamamlandı: {Path.GetFileName(hedefDosya)}";
            }
            catch (Exception ex)
            {
                return "Yedekleme başarısız: " + ex.Message;
            }
        }
        public static void VerileriSifirla()
        {
            using var conn = BaglantiAl();
            conn.Open();

            string[] sorgular =
            {
        "DELETE FROM Odunc",
        "DELETE FROM Kitaplar",
        "DELETE FROM Uyeler",
        "DELETE FROM Kategoriler",
        "DELETE FROM Ayarlar"
    };

            foreach (string sorgu in sorgular)
            {
                using var cmd = new SQLiteCommand(sorgu, conn);
                cmd.ExecuteNonQuery();
            }

            string resetSeq = "DELETE FROM sqlite_sequence";
            using (var cmd = new SQLiteCommand(resetSeq, conn))
            {
                cmd.ExecuteNonQuery();
            }

            conn.Close();

            string logKlasoru = Path.Combine(Application.StartupPath, "Logs");
            if (Directory.Exists(logKlasoru))
            {
                foreach (string dosya in Directory.GetFiles(logKlasoru))
                {
                    File.Delete(dosya);
                }
            }

            LogEkle("Tüm veriler sıfırlandı. Tablolar temizlendi, loglar silindi, sistem yeniden doğdu.");
        }

        public static void KitaplariListele()
        {
            using var baglanti = BaglantiAl();
            baglanti.Open();

            string sql = "SELECT * FROM Kitaplar";

            using var cmd = new SQLiteCommand(sql, baglanti);
            using var reader = cmd.ExecuteReader();

            Console.WriteLine("------ Kütüphanedeki Kitaplar ------");
            while (reader.Read())
            {
                Console.WriteLine($"KitapID: {reader["KitapID"]}, Kitap Adı: {reader["KitapAdi"]}, Yazar: {reader["Yazar"]}, Yıl: {reader["YayinYili"]}, Kategori: {reader["Kategori"]}");
            }
        }

        public static List<string> KategorileriGetir()
        {
            var kategoriler = new List<string>();

            using var baglanti = BaglantiAl();
            baglanti.Open();

            string sql = "SELECT KategoriAdi FROM Kategoriler ORDER BY KategoriAdi COLLATE NOCASE ASC";
            using var komut = new SQLiteCommand(sql, baglanti);
            using var okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
                kategoriler.Add(okuyucu["KategoriAdi"].ToString());

            return kategoriler;
        }

        public static bool KategoriEkle(string kategoriAdi)
        {
            using var baglanti = BaglantiAl();
            baglanti.Open();

            string sql = "INSERT INTO Kategoriler (KategoriAdi) VALUES (@adi)";
            using var komut = new SQLiteCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@adi", kategoriAdi);

            try
            {
                komut.ExecuteNonQuery();
                LogEkle($"Kategori eklendi: {kategoriAdi}");
                return true;
            }
            catch (SQLiteException)
            {
                return false;
            }
        }

        public static bool KategoriSil(string kategoriAdi)
        {
            using var baglanti = BaglantiAl();
            baglanti.Open();

            string kontrolSql = "SELECT COUNT(*) FROM Kitaplar WHERE Kategori = @kategori";
            using var kontrolKomut = new SQLiteCommand(kontrolSql, baglanti);
            kontrolKomut.Parameters.AddWithValue("@kategori", kategoriAdi);

            long sayi = (long)kontrolKomut.ExecuteScalar();
            if (sayi > 0)
                return false;

            string sql = "DELETE FROM Kategoriler WHERE KategoriAdi = @adi";
            using var komut = new SQLiteCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@adi", kategoriAdi);
            komut.ExecuteNonQuery();

            LogEkle($"Kategori silindi: {kategoriAdi}");
            return true;
        }

        public static bool KategoriGuncelle(string eskiKategoriAdi, string yeniKategoriAdi)
        {
            using var conn = BaglantiAl();
            conn.Open();

            string query = "UPDATE Kategoriler SET KategoriAdi = @yeni WHERE KategoriAdi = @eski";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@eski", eskiKategoriAdi);
            cmd.Parameters.AddWithValue("@yeni", yeniKategoriAdi);

            bool sonuc = cmd.ExecuteNonQuery() > 0;
            if (sonuc)
                LogEkle($"Kategori güncellendi: {eskiKategoriAdi} -> {yeniKategoriAdi}");

            return sonuc;
        }

        public static void LogEkle(string mesaj)
        {
            string klasorYolu = Path.Combine(Application.StartupPath, "Logs");
            string dosyaYolu = Path.Combine(klasorYolu, "log.txt");

            Directory.CreateDirectory(klasorYolu);
            File.AppendAllText(dosyaYolu, $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {mesaj}{Environment.NewLine}");
        }
    }
}
