using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    // Banka hesabını temsil eden sınıf
    class BankaHesabı
    {
        // Hesap numarasını tutan alan
        public string HesapNumarasi;

        // Bakiye tutan özel alan (yalnızca sınıf içinde değiştirilebilir)
        private decimal Bakiye;

        // Bakiye'yi yalnızca okunabilir hale getiren özellik
        public decimal bakiye
        {
            get { return Bakiye; }
            private set
            {
                // Eğer bakiye negatif değilse güncelleme yapılır, aksi halde hata fırlatılır
                if (value >= 0)
                {
                    Bakiye = value;
                }
                else
                {
                    throw new ArgumentException("Bakiye negatif olamaz");
                }
            }
        }

        // Banka hesabı oluşturucu metodu
        public BankaHesabı(string hesapnumarasi, decimal ilkbakiye)
        {
            HesapNumarasi = hesapnumarasi;
            Bakiye = ilkbakiye;
        }

        // Hesaba para yatırma işlemi
        public void ParaYatir(decimal miktar)
        {
            if (miktar > 0)
            {
                Bakiye += miktar;
                Console.WriteLine(miktar + " TL hesaba başarıyla yatırıldı. Güncel Bakiye: " + Bakiye + " TL");
            }
        }

        // Hesaptan para çekme işlemi
        public void ParaCek(decimal miktar)
        {
            if (miktar > 0 && miktar <= Bakiye)
            {
                Bakiye -= miktar;
                Console.WriteLine(miktar + " TL hesaptan başarıyla çekildi. Güncel Bakiye: " + Bakiye + " TL");
            }
            else
            {
                Console.WriteLine("Hesabınızda " + miktar + " TL para bulunmuyor. Yetersiz Bakiye!");
            }
        }
    }

    // Ana program sınıfı
    class Program
    {
        static void Main(string[] args)
        {
            // Yeni bir banka hesabı oluşturuluyor
            BankaHesabı hesap1 = new BankaHesabı("5555", 5000);

            // Hesap numarası ve ilk bakiye bilgileri yazdırılıyor
            Console.WriteLine("Hesap Numarası: " + hesap1.HesapNumarasi);
            Console.WriteLine("İlk Bakiye: " + hesap1.bakiye);

            // Hesaba 500 TL yatırılıyor
            hesap1.ParaYatir(500);

            // Hesaptan 50 TL çekiliyor
            hesap1.ParaCek(50);

            // Yetersiz bakiye ile çekim denemesi yapılıyor
            hesap1.ParaCek(5500);

            // Programın kapanmasını engellemek için bir tuşa basılmasını bekler
            Console.ReadKey();
        }
    }
}
