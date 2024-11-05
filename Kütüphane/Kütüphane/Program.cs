using System;
using System.Collections.Generic;

namespace Kütüphane
{
    // Kitap sınıfı: Her bir kitap için ad, yazar ve yıl bilgilerini tutar
    class Kitap
    {
        public string Ad;
        public string Yazar;
        public int Yıl;

        // Kitap sınıfı için yapıcı metot (constructor)
        public Kitap(string ad, string yazar, int yıl)
        {
            Ad = ad;
            Yazar = yazar;
            Yıl = yıl;
        }
    }

    // Kütüphane sınıfı: Kitap nesnelerini bir liste içinde tutar
    class Kutuphane
    {
        public List<Kitap> Kitaplar;

        // Kütüphane sınıfı için yapıcı metot: Başlangıçta boş bir kitap listesi oluşturur
        public Kutuphane()
        {
            this.Kitaplar = new List<Kitap>();
        }

        // Yeni bir kitap eklemek için metod
        public void KitapEkle(Kitap yenikitap)
        {
            this.Kitaplar.Add(yenikitap);
            Console.WriteLine(yenikitap.Ad + " kitabı kütüphaneye eklenmiştir.");
        }

        // Kütüphanedeki tüm kitapları listeleyen metod
        public void KitaplarıListele()
        {
            Console.WriteLine("Kütüphanedeki Kitaplar:");
            foreach (var kitap in this.Kitaplar)
            {
                Console.WriteLine("Ad: " + kitap.Ad + ", Yazar: " + kitap.Yazar + ", Yıl: " + kitap.Yıl);
            }
        }
    }

    // Program sınıfı: Ana programın çalıştığı yer
    class Program
    {
        static void Main(string[] args)
        {
            // Yeni bir kütüphane nesnesi oluştur
            Kutuphane kutuphane = new Kutuphane();

            // Kütüphaneye birkaç kitap ekle
            kutuphane.KitapEkle(new Kitap("Karanlıktan Sonra", "Haruki Murakami", 2004));
            kutuphane.KitapEkle(new Kitap("Stepford Kadınları", "Ira Levin", 1972));

            // Kütüphanedeki kitapları listele
            kutuphane.KitaplarıListele();

            // Programın kapanmasını engellemek için bir tuşa basmayı bekler
            Console.ReadKey();
        }
    }
}
