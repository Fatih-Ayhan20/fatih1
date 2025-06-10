using System;

class Kitap
{
    // Property tanımları
    public string Ad { get; set; }
    public string YazarAdi { get; set; }
    public string YazarSoyadi { get; set; }
    public int SayfaSayisi { get; set; }
    public string YayinEvi { get; set; }
    public DateTime KayitTarihi { get; set; }

    // Default constructor (parametresiz)
    public Kitap()
    {
        KayitTarihi = DateTime.Now;
    }

    // Parametreli constructor
    public Kitap(string ad, string yazarAdi, string yazarSoyadi, int sayfaSayisi, string yayinEvi)
    {
        Ad = ad;
        YazarAdi = yazarAdi;
        YazarSoyadi = yazarSoyadi;
        SayfaSayisi = sayfaSayisi;
        YayinEvi = yayinEvi;
        KayitTarihi = DateTime.Now;
    }

    // Bilgileri yazdırma metodu
    public void BilgileriYazdir()
    {
        Console.WriteLine($"Kitap Adı: {Ad}");
        Console.WriteLine($"Yazar: {YazarAdi} {YazarSoyadi}");
        Console.WriteLine($"Sayfa Sayısı: {SayfaSayisi}");
        Console.WriteLine($"Yayınevi: {YayinEvi}");
        Console.WriteLine($"Kayıt Tarihi: {KayitTarihi}");
    }
}

class Program
{
    static void Main()
    {
        // Örnek kitap nesnesi parametreli constructor ile
        Kitap kitap1 = new Kitap("Adı Aylin", "Fatih", "Ayhan", 398, "Remzi Kitabevi");
        kitap1.BilgileriYazdir();

        Console.WriteLine("\n---\n");

        // Default constructor ile kitap oluşturulup değerler sonradan atanır
        Kitap kitap2 = new Kitap();
        kitap2.Ad = "Simyacı";
        kitap2.YazarAdi = "Paulo";
        kitap2.YazarSoyadi = "Coelho";
        kitap2.SayfaSayisi = 190;
        kitap2.YayinEvi = "Can Yayınları";
        kitap2.BilgileriYazdir();
    }
}