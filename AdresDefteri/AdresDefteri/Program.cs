using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdresDefteri
{
    // Kisi sınıfı tanımı
    class Kisi
    {
        // Kişi bilgilerini saklayacak alanlar
        string Ad;
        string Soyad;
        string TelefonNo;

        // Yapıcı metot, kişiyi oluştururken ad, soyad ve telefon numarası alır
        public Kisi(string ad, string soyad, string telefonno)
        {
            Ad = ad;
            Soyad = soyad;
            TelefonNo = telefonno;
        }

        // Kişi bilgilerini döndüren bir metot
        public string KisiBilgisi()
        {
            return Ad + " " + Soyad + " " + TelefonNo;
        }
    }

    // Programın başlangıç noktası
    class Program
    {
        static void Main(string[] args)
        {
            // Kisi sınıfından bir örnek oluştur ve bilgilerini göster
            Kisi kisi1 = new Kisi("Zeynep Ece", "YÜnkül", "555");
            Console.WriteLine("Kişi Bilgileri: " + kisi1.KisiBilgisi());

            // Kullanıcının bir tuşa basmasını bekle
            Console.ReadKey();
        }
    }
}
