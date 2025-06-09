using System;

class Program
{
    static void Main()
    {
        // 1
        Console.WriteLine("Merhaba");
        Console.WriteLine("Nasılsın ?");
        Console.WriteLine("İyiyim");
        Console.WriteLine("Sen nasılsın ?");

        // 2
        string ad = "Ahmet";
        int yas = 25;
        Console.WriteLine(ad);
        Console.WriteLine(yas);

        // 3
        Random rnd = new Random();
        int rastgeleSayi = rnd.Next();
        Console.WriteLine(rastgeleSayi);

        // 4
        int sayi = rnd.Next();
        Console.WriteLine(sayi % 3);

        // 5
        Console.Write("Yaşınızı girin: ");
        int kullaniciYas = int.Parse(Console.ReadLine());
        Console.WriteLine(kullaniciYas > 18 ? "+" : "-");

        // 6
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
        }

        // 7
        Console.Write("1. İsmi girin: ");
        string isim1 = Console.ReadLine();
        Console.Write("2. İsmi girin: ");
        string isim2 = Console.ReadLine();
        string temp = isim1;
        isim1 = isim2;
        isim2 = temp;
        Console.WriteLine("1. İsim: " + isim1);
        Console.WriteLine("2. İsim: " + isim2);

        // 8
        BenDegerDondurmem();

        // 9
        int toplam = Topla(5, 7);
        Console.WriteLine("Toplam: " + toplam);

        // 10
        Console.Write("True ya da False girin: ");
        bool dogruMu = bool.Parse(Console.ReadLine());
        string sonuc = BoolToString(dogruMu);
        Console.WriteLine(sonuc);

        // 11
        int y1 = 30, y2 = 25, y3 = 40;
        int enBuyukYas = EnYasli(y1, y2, y3);
        Console.WriteLine("En yaşlı: " + enBuyukYas);

        // 12
        int enBuyuk = EnBuyukSayiyiBul();
        Console.WriteLine("En büyük sayı: " + enBuyuk);

        // 13
        IsimleriDegistir();

        // 14
        Console.Write("Sayı girin: ");
        int sayi14 = int.Parse(Console.ReadLine());
        Console.WriteLine(TekMiCiftMi(sayi14));

        // 15
        Console.Write("Hız girin: ");
        double hiz = double.Parse(Console.ReadLine());
        Console.Write("Zaman girin: ");
        double zaman = double.Parse(Console.ReadLine());
        Console.WriteLine("Yol: " + YolHesapla(hiz, zaman));

        // 16
        Console.Write("Yarıçap girin: ");
        double yaricap = double.Parse(Console.ReadLine());
        Console.WriteLine("Alan: " + DaireAlani(yaricap));

        // 17
        string cumle = "Zaman bir GeRi SayIm";
        Console.WriteLine(cumle.ToUpper());
        Console.WriteLine(cumle.ToLower());

        // 18
        string metin = "    Selamlar   ";
        metin = metin.Trim();
        Console.WriteLine(metin);
    }

    static void BenDegerDondurmem()
    {
        Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
    }

    static int Topla(int a, int b)
    {
        return a + b;
    }

    static string BoolToString(bool deger)
    {
        return deger ? "Doğru girdiniz" : "Yanlış girdiniz";
    }

    static int EnYasli(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }

    static int EnBuyukSayiyiBul()
    {
        int enBuyuk = int.MinValue;
        string giris;
        while (true)
        {
            Console.Write("Sayı girin (bitirmek için boş bırakın): ");
            giris = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(giris)) break;
            int sayi = int.Parse(giris);
            if (sayi > enBuyuk) enBuyuk = sayi;
        }
        return enBuyuk;
    }

    static void IsimleriDegistir()
    {
        Console.Write("İsim 1: ");
        string a = Console.ReadLine();
        Console.Write("İsim 2: ");
        string b = Console.ReadLine();
        string temp = a;
        a = b;
        b = temp;
        Console.WriteLine("Yeni isim 1: " + a);
        Console.WriteLine("Yeni isim 2: " + b);
    }

    static bool TekMiCiftMi(int sayi)
    {
        return sayi % 2 != 0;
    }

    static double YolHesapla(double hiz, double zaman)
    {
        return hiz * zaman;
    }

    static double DaireAlani(double r)
    {
        return Math.PI * r * r;
    }
}