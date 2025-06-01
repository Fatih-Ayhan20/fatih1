using System;

class Program
{
    static void SarkiSozuYaz()
    {
        Console.WriteLine("Dilerim ki asla caymazsın benim olmaktan.");
    }

    static int RastgeleKalan()
    {
        Random rnd = new Random();
        int sayi = rnd.Next(1, 100);
        Console.WriteLine($" Rastgele Üretilen sayı: {sayi}");
        return sayi % 2;
    }

    static int Carpim(int sayi1, int sayi2)
    {
        return sayi1 * sayi2;
    }

    static void Hosgeldiniz(string isim, string soyisim)
    {
        Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}");
    }

    static void Main()
    {
        SarkiSozuYaz();
        int kalan = RastgeleKalan();
        Console.WriteLine($"2'ye bölümünden kalan: {kalan}");
        int carpimSonucu = Carpim(6, 7);
        Console.WriteLine($"Çarpım sonucu: {carpimSonucu}");
        Hosgeldiniz("Fatih", "Ayhan");
    }
}