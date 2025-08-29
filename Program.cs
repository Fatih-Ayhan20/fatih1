using System;

class Araba
{
    // Otomobil özellikleri
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }

    private int _kapiSayisi; // kapsüllenmiş alan

    // Property ile kapsülleme
    public int KapiSayisi
    {
        get { return _kapiSayisi; }
        set
        {
            if (value == 2 || value == 4)
            {
                _kapiSayisi = value;
            }
            else
            {
                Console.WriteLine("⚠ Geçersiz kapı sayısı! Sadece 2 veya 4 olabilir.");
                _kapiSayisi = -1;
            }
        }
    }

    // Constructor (kurucu metot)
    public Araba(string marka, string model, string renk, int kapiSayisi)
    {
        Marka = marka;
        Model = model;
        Renk = renk;
        KapiSayisi = kapiSayisi; // burada set bloğu çalışacak
    }

    public void BilgiYazdir()
    {
        Console.WriteLine($"Marka: {Marka}, Model: {Model}, Renk: {Renk}, Kapı Sayısı: {KapiSayisi}");
    }
}

partial class Program
{
    static void Main()
    {
        // Geçerli kapı sayısı
        Araba araba1 = new Araba("BMW", "320i", "Siyah", 4);
        araba1.BilgiYazdir();

        // Geçersiz kapı sayısı
        Araba araba2 = new Araba("Mercedes", "A180", "Beyaz", 3);
        araba2.BilgiYazdir();
    }
}
