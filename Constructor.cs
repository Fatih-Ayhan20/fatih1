using System;

class Bebek
{
    // Property tanımlamaları
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public DateTime DogumTarihi { get; set; }

    // Parametresiz constructor
    public Bebek()
    {
        DogumTarihi = DateTime.Now;
    }

    // Parametreli constructor (Ad ve Soyad alır)
    public Bebek(string ad, string soyad)
    {
        Ad = ad;
        Soyad = soyad;
        DogumTarihi = DateTime.Now;
    }

    // Bilgileri yazdırmak için metot
    public void BilgileriYazdir()
    {
        Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Doğum Tarihi: {DogumTarihi}");
    }
}

class Program
{
    static void Main()
    {
        // Default constructor ile nesne oluşturma
        Bebek bebek1 = new Bebek();
        bebek1.Ad = "Veli";
        bebek1.Soyad = "Yılmaz";
        bebek1.BilgileriYazdir();

        // Parametreli constructor ile nesne oluşturma
        Bebek bebek2 = new Bebek("Ahmet", "Kaya");
        bebek2.BilgileriYazdir();
    }
}