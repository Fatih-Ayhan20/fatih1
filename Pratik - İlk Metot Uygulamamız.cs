using System;

class Program1
{
    static void Main()
    {
        // Değer döndürmeyen bir metodu çağırma
        Greeting();
    }

    // Sevdiğim bir müzik sözü
    static void Greeting()
    {
        Console.WriteLine("Dilerim ki asla caymazsın benim olmaktan...");
    }
}

class Program2
{
    static void Main()
    {
        int kalan = KalanHesapla();
        Console.WriteLine("Kalan: " + kalan);
    }

    static int KalanHesapla()
    {
        Random rnd = new Random();
        int sayi = rnd.Next(1, 10); // 1 ile 10 arasında rastgele bir sayı
        return sayi % 2;
    }
}

class Program3
{
    static int Carp(int sayi1, int sayi2)
    {
        return sayi1 * sayi2;
    }

    static void Main()
    {
        int a = 5;
        int b = 7;
        int sonuc = Carp(a, b);

        Console.WriteLine($"Çarpım: {sonuc}");
    }
}

class Program4
{
    static void HosgeldinizMesaji(string isim, string soyisim)
    {
        Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}");
    }

    static void Main()
    {
        string ad = "Fatih";
        string soyad = "Ayhan";

        HosgeldinizMesaji(ad, soyad);
    }
}
