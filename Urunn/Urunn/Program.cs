using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urunn
{
    // Ürün sınıfı tanımlanıyor
    class Urun
    {
        // Ürün adı ve fiyatı için özellikler (property) tanımlanıyor
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }

        // İndirim değeri için özel bir alan tanımlanıyor
        decimal İndirim;

        // İndirim değeri için özellik tanımlanıyor
        public decimal indirim
        {
            get { return İndirim; }
            set
            {
                // İndirim değeri 0'dan küçük ise 0 olarak ayarlanır
                if (value < 0)
                {
                    İndirim = 0;
                }
                // İndirim değeri 50'den büyük ise 50 olarak ayarlanır
                else if (value > 50)
                {
                    İndirim = 50;
                }
                // Aksi halde girilen değer atanır
                else
                {
                    İndirim = value;
                }
            }
        }

        // Yapıcı metot (constructor), ürün adı ve fiyatını ayarlar
        public Urun(string ad, decimal fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }

        // İndirimli fiyatı hesaplayan metot
        public decimal İndirimliFİyat()
        {
            return Fiyat -= Fiyat * İndirim / 100;
        }
    }

    // Program sınıfı ana metodu içerir
    class Program
    {
        static void Main(string[] args)
        {
            // Yeni bir ürün nesnesi oluşturuluyor
            Urun ürün1 = new Urun("Kitap", 300);
            ürün1.indirim = 50; // Ürünün indirim oranı ayarlanıyor

            // Ürün bilgileri ekrana yazdırılıyor
            Console.WriteLine("Ürün adı: " + ürün1.Ad);
            Console.WriteLine("Ürünün fiyatı: " + ürün1.Fiyat + " TL");
            Console.WriteLine("Ürünün indirim oranı: " + ürün1.indirim);
            Console.WriteLine("Ürünün indirimli fiyatı: " + ürün1.İndirimliFİyat());

            // Ekranın kapanmaması için bir tuşa basılması bekleniyor
            Console.ReadKey();
        }
    }
}
