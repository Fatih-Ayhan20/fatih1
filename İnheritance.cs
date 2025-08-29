using System;

// Base sınıf
class BaseKisi
{
    public string Ad { get; set; }
    public string Soyad { get; set; }

    // Metot: Ad ve soyadı yazdır
    public void AdSoyadYazdir()
    {
        Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
    }
}

// Öğrenci sınıfı (BaseKisi'den miras alır)
class Ogrenci : BaseKisi
{
    public int OgrenciNo { get; set; }

    // Metot: Öğrenci bilgilerini yazdır
    public void OgrenciBilgiYazdir()
    {
        // Base sınıfın metodunu çağır
        AdSoyadYazdir();
        Console.WriteLine($"Öğrenci No: {OgrenciNo}");
    }
}

// Öğretmen sınıfı (BaseKisi'den miras alır)
class Ogretmen : BaseKisi
{
    public decimal Maas { get; set; }

    // Metot: Öğretmen bilgilerini yazdır
    public void OgretmenBilgiYazdir()
    {
        // Base sınıfın metodunu çağır
        AdSoyadYazdir();
        Console.WriteLine($"Maaş: {Maas} TL");
    }
}

class Program
{
    static void Main()
    {
        // Öğrenci nesnesi
        Ogrenci ogrenci1 = new Ogrenci()
        {
            Ad = "Ahmet",
            Soyad = "Yılmaz",
            OgrenciNo = 12345
        };

        // Öğretmen nesnesi
        Ogretmen ogretmen1 = new Ogretmen()
        {
            Ad = "Ayşe",
            Soyad = "Kara",
            Maas = 15000
        };

        Console.WriteLine("📘 Öğrenci Bilgileri:");
        ogrenci1.OgrenciBilgiYazdir();

        Console.WriteLine("\n👩‍🏫 Öğretmen Bilgileri:");
        ogretmen1.OgretmenBilgiYazdir();
    }
}
