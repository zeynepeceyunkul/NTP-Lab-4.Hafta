using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraçKiralama
{
    // KiralıkArac sınıfı, araç bilgilerini ve kiralama işlemlerini içerir
    class KiralıkArac
    {
        // Aracın plakası
        public string Plaka;

        // Aracın günlük kiralama ücreti
        public decimal GunlukUcret;

        // Aracın müsait olup olmadığını belirten özel değişken
        bool MusaitMi;

        // KiralıkArac sınıfının yapıcı metodu; araç plakası ve günlük ücret ile nesne oluşturulur
        public KiralıkArac(string plaka, decimal gunlukucret)
        {
            Plaka = plaka;
            GunlukUcret = gunlukucret;
            MusaitMi = true; // Araç başlangıçta müsait olarak ayarlanır
        }

        // Aracı kiralama işlemi gerçekleştirilir
        public void AracKirala()
        {
            // Eğer araç müsaitse, kiralanır
            if (MusaitMi)
            {
                Console.WriteLine("Aracı kiralayabilirsiniz.");
                MusaitMi = false; // Araç kiralanınca müsaitlik durumu güncellenir
            }
            else
            {
                // Araç zaten kiralanmışsa uyarı mesajı verilir
                Console.WriteLine("Bu araç zaten kiralanmış.");
            }
        }

        // Aracı teslim etme işlemi gerçekleştirilir
        public String AracTeslimEt()
        {
            MusaitMi = true; // Araç teslim edilince tekrar müsait hale gelir
            Console.WriteLine("Araç teslim edilmiştir.");
            return "Araç tekrardan müsait";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Yeni bir KiralıkArac nesnesi oluşturulur
            KiralıkArac arac = new KiralıkArac("34 ECE 555", 5000);

            // Aracın bilgileri ekrana yazdırılır
            Console.WriteLine("Aracın Plakası: " + arac.Plaka);
            Console.WriteLine(arac.Plaka + " plakalı aracın günlük ücreti: " + arac.GunlukUcret);

            // Araç kiralama işlemi çağrılır
            arac.AracKirala();

            // Aynı aracı tekrar kiralamaya çalışılır
            arac.AracKirala();

            // Araç teslim edilir
            arac.AracTeslimEt();

            Console.ReadKey(); // Konsol ekranını açık tutmak için bir tuşa basılmasını bekler
        }
    }
}
