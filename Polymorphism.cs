using System;

// Base Class
class BaseGeometrikSekil
{
    public double Genislik { get; set; }
    public double Yukseklik { get; set; }

    // Sanal metot (override edilebilir)
    public virtual double AlanHesapla()
    {
        return Genislik * Yukseklik;
    }
}

// Kare sınıfı
class Kare : BaseGeometrikSekil
{
    public Kare(double kenar)
    {
        Genislik = kenar;
        Yukseklik = kenar;
    }

    // Kare için özel bir şey yapmaya gerek yok, base class hesaplama yeterli.
    public override double AlanHesapla()
    {
        return base.AlanHesapla();
    }
}

// Dikdörtgen sınıfı
class Dikdortgen : BaseGeometrikSekil
{
    public Dikdortgen(double genislik, double yukseklik)
    {
        Genislik = genislik;
        Yukseklik = yukseklik;
    }

    public override double AlanHesapla()
    {
        return base.AlanHesapla();
    }
}

// Dik Üçgen sınıfı
class DikUcgen : BaseGeometrikSekil
{
    public DikUcgen(double genislik, double yukseklik)
    {
        Genislik = genislik;
        Yukseklik = yukseklik;
    }

    public override double AlanHesapla()
    {
        return (Genislik * Yukseklik) / 2;
    }
}

class Program
{
    static void Main()
    {
        Kare kare = new Kare(5);
        Dikdortgen dikdortgen = new Dikdortgen(4, 6);
        DikUcgen dikUcgen = new DikUcgen(3, 8);

        Console.WriteLine($"Kare Alanı: {kare.AlanHesapla()}");
        Console.WriteLine($"Dikdörtgen Alanı: {dikdortgen.AlanHesapla()}");
        Console.WriteLine($"Dik Üçgen Alanı: {dikUcgen.AlanHesapla()}");
    }
}
