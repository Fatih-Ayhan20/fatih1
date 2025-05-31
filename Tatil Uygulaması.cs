using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        bool devamEt = true;

        while (devamEt)
        {
            string lokasyon = "";
            int kisiSayisi = 0;
            int ulasimSecimi = 0;
            int paketFiyati = 0;
            int ulasimFiyati = 0;
            string ozettxt = "";

            // Lokasyon seçimi yapalım
            while (true)
            {
                Console.WriteLine("Lütfen gitmek istediğiniz lokasyonu giriniz (Bodrum, Marmaris, Çeşme):");
                lokasyon = Console.ReadLine().Trim().ToLower();

                if (lokasyon == "bodrum")
                {
                    paketFiyati = 4000;
                    ozettxt = "Bodrum: Deniz, gece hayatı ve tarihi yerler ile sizi bekliyor.";
                    break;
                }
                else if (lokasyon == "marmaris")
                {
                    paketFiyati = 3000;
                    ozettxt = "Marmaris: Doğal güzellikler, yat turları ve temiz plajlar tatilinizde sizi mutlu edecek.";
                    break;
                }
                else if (lokasyon == "çeşme" || lokasyon == "cesme")
                {
                    paketFiyati = 5000;
                    ozettxt = "Çeşme: Lüks plajlar, Alaçatı sokakları ve rüzgar sörfü için muazzam bi deneyim olacak.";
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş! Geçerli lokasyonlar: Bodrum, Marmaris, Çeşme.");
                }
            }

            // Kişi sayısı bilgisi
            while (true)
            {
                Console.WriteLine("Kaç kişi için tatil planlamak istiyorsunuz?");
                if (int.TryParse(Console.ReadLine(), out kisiSayisi) && kisiSayisi > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Geçerli bir kişi sayısı giriniz.");
                }
            }

            // Özet 
            Console.WriteLine($"\nSeçilen lokasyon: {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(lokasyon)}");
            Console.WriteLine($"Tatil özeti: {ozettxt}\n");

            // Ulaşım tercihi nedir
            while (true)
            {
                Console.WriteLine("Tatilinize hangi ulaşım şekliyle gitmek istersiniz?");
                Console.WriteLine("1 - Kara yolu (Kişi başı gidiş-dönüş 1500 TL)");
                Console.WriteLine("2 - Hava yolu (Kişi başı gidiş-dönüş 4000 TL)");
                Console.Write("Lütfen yukarıdaki seçeneklerden bir tanesini seçiniz (1 ya da 2): ");
                string secim = Console.ReadLine().Trim();

                if (secim == "1")
                {
                    ulasimFiyati = 1500;
                    ulasimSecimi = 1;
                    break;
                }
                else if (secim == "2")
                {
                    ulasimFiyati = 4000;
                    ulasimSecimi = 2;
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı seçim! Lütfen sadece 1 ya da 2 giriniz.");
                }
            }

            // Toplam tutar hesaplaması yapalım
            int toplamTutar = kisiSayisi * (paketFiyati + ulasimFiyati);
            string ulasimStr = ulasimSecimi == 1 ? "Kara yolu" : "Hava yolu";

            Console.WriteLine($"\n--- Tatil Planı Özeti ---");
            Console.WriteLine($"Lokasyon: {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(lokasyon)}");
            Console.WriteLine($"Kişi sayısı: {kisiSayisi}");
            Console.WriteLine($"Ulaşım şekli: {ulasimStr}");
            Console.WriteLine($"Toplam tahmini tutar: {toplamTutar} TL\n");

            // Devam etmek ister mi diye soralım
            Console.WriteLine("Başka bir tatil planlamak ister misiniz? (E/H)");
            string devam = Console.ReadLine().Trim().ToLower();

            if (devam != "e")
            {
                Console.WriteLine("İyi günler dileriz!");
                devamEt = false;
            }
        }
    }
}