using System;

class Program
{
    static void Main()
    {
        // Merhaba kullanıcı! 
        // Senden bir seçim yapmanı isteyeceğiz, çünkü elimizde birbirinden güzel 3 tane oyun var
        while (true)
        {
            Console.WriteLine("\n === Proje Uygulaması Menüsü ===");
            Console.WriteLine("1 - Rastgele Sayı Bulma Oyunu");
            Console.WriteLine("2 - Hesap Makinesi");
            Console.WriteLine("3 - Ortalama Hesaplama");
            Console.WriteLine("0 - Çıkış");
            Console.Write("Ne yapmak istersiniz? Seçiminizi girin: ");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    RastgeleSayiOyunu(); // 5 can hakkının olduğu oyunda kazanabilecek misin?
                    break;
                case "2":
                    HesapMakinesi(); // Matematiği aşırı seviyorsan kaçırmamalısın
                    break;
                case "3":
                    OrtalamaHesaplama(); // Not ortalamanı hesaplayalım bakalım, geçtin mi? 
                    break;
                case "0":
                    // Programı kapatıyoruz
                    Console.WriteLine("\nProgramdan çıkılıyor. Görüşmek üzere!");
                    Console.WriteLine("Kapatmak için bir tuşa bas...");
                    Console.ReadKey(); // Kullanıcının vedalaşmak için bir tuşa basmasını istiyoruz.
                    Environment.Exit(0); 
                    break;
                default:
                    Console.WriteLine("Hatalı giriş! Lütfen 0 ile 3 arasında bir seçim yap.");
                    break;
            }
        }
    }

    // 1) RASTGELE SAYI BULMA OYUNU
    static void RastgeleSayiOyunu()
    {
        Random rnd = new Random();
        int dogruSayi = rnd.Next(1, 101); // 1-100 arasında rastgele sayı tutuluyor
        int can = 5; // Toplam 5 can hakkı var

        Console.WriteLine("\n Rastgele Sayı Bulma Oyunu Başladı!");
        Console.WriteLine("1 ile 100 arasında bir sayı tuttum. Bakalım tahmin edebilecek misin?");
        Console.WriteLine($"Toplam {can} tahmin hakkın var.");

        while (can > 0)
        {
            Console.Write("Tahminin: ");
            bool sayiOkundu = int.TryParse(Console.ReadLine(), out int tahmin);

            if (!sayiOkundu)
            {
                Console.WriteLine("Lütfen geçerli bir sayı gir.");
                continue;
            }

            if (tahmin == dogruSayi)
            {
                Console.WriteLine(" Tebrikler! Doğru tahmin ettin!");
                break; // Doğru tahmin yapıldığında oyun sona eriyor
            }
            else
            {
                can--; // Yanlış tahmin = 1 can azalır

                if (tahmin < dogruSayi)
                    Console.WriteLine("Daha büyük bir sayı denemelisin.");
                else
                    Console.WriteLine("Daha küçük bir sayı denemelisin.");

                if (can > 0)
                    Console.WriteLine($"Kalan can: {can}");
                else
                {
                    Console.WriteLine("Canın bitti! Oyunu kaybettin.");
                    Console.WriteLine($"Bilgisayarın tuttuğu sayı: {dogruSayi}");
                }
            }
        }
    }


    // 2) HESAP MAKİNESİ
    static void HesapMakinesi()
    {
        Console.WriteLine("\n Hesap Makinesi - Dört işlem uzmanı");
        
        //İlk sayıyı isteyelim
        Console.Write("İlk sayıyı gir: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        //İkinci sayıyı isteyelim
        Console.Write("İkinci sayıyı gir: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        //Hangi işlemi yapacağını seçtirelim
        Console.Write("İşlem seç (+, -, *, /): ");
        string islem = Console.ReadLine();

        switch (islem)
        {
            case "+":
                Console.WriteLine($"Toplam: {sayi1 + sayi2}");
                break;
            case "-":
                Console.WriteLine($"Fark: {sayi1 - sayi2}");
                break;
            case "*":
                Console.WriteLine($"Çarpım: {sayi1 * sayi2}");
                break;
            case "/":
                if (sayi2 == 0)
                    Console.WriteLine(" Hata: Sıfıra bölme yapılamaz!");
                else
                    Console.WriteLine($"Bölüm: {sayi1 / sayi2}");
                break;
            default:
                Console.WriteLine(" Geçersiz işlem sembolü!");
                break;
        }
    }

    // 3) ORTALAMA HESAPLAMA
    static void OrtalamaHesaplama()
    {
        Console.WriteLine("\n Ortalama Hesaplama Zamanı!");
        double[] notlar = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"{i + 1}. dersi notunu gir (0-100): ");
            if (!double.TryParse(Console.ReadLine(), out notlar[i]) || notlar[i] < 0 || notlar[i] > 100)
            {
                Console.WriteLine(" Hatalı not girdin. Lütfen 0 ile 100 arasında bir değer gir.");
                return; 
            }
        }

        double ortalama = (notlar[0] + notlar[1] + notlar[2]) / 3;
        string harf = HarfNotuHesapla(ortalama);

        Console.WriteLine($"\n Ortalaman: {ortalama:F2}");
        Console.WriteLine($" Harf Notun: {harf}");
    }

    static string HarfNotuHesapla(double ort)
    {
        //Kullanıcının girdiği sayıya göre harf notu belirlenir.
        if (ort >= 90) return "AA";
        else if (ort >= 85) return "BA";
        else if (ort >= 80) return "BB";
        else if (ort >= 75) return "CB";
        else if (ort >= 70) return "CC";
        else if (ort >= 65) return "DC";
        else if (ort >= 60) return "DD";
        else if (ort >= 55) return "FD";
        else return "FF";
    }
}