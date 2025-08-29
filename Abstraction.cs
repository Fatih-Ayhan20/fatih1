using System;

// Soyut sınıf (Base)
abstract class Calisan
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Departman { get; set; }

    // Abstract metot -> her alt sınıfta override edilmek zorunda
    public abstract void Gorev();

    // Ortak bir metot
    public void CalisanBilgi()
    {
        Console.WriteLine($"{Ad} {Soyad} - {Departman}");
    }
}

// Yazılım geliştirici sınıfı
class YazilimGelistirici : Calisan
{
    public override void Gorev()
    {
        Console.WriteLine("Yazılım geliştirici olarak çalışıyorum.");
    }
}

// Proje yöneticisi sınıfı
class ProjeYoneticisi : Calisan
{
    public override void Gorev()
    {
        Console.WriteLine("Proje yöneticisi olarak çalışıyorum.");
    }
}

// Satış temsilcisi sınıfı
class SatisTemsilcisi : Calisan
{
    public override void Gorev()
    {
        Console.WriteLine("Satış temsilcisi olarak çalışıyorum.");
    }
}

class Program
{
    static void Main()
    {
        // Çalışan nesneleri
        YazilimGelistirici dev = new YazilimGelistirici()
        {
            Ad = "Ali",
            Soyad = "Demir",
            Departman = "Yazılım"
        };

        ProjeYoneticisi pm = new ProjeYoneticisi()
        {
            Ad = "Hasan",
            Soyad = "Çıldırmış",
            Departman = "Proje Yönetimi"
        };

        SatisTemsilcisi sales = new SatisTemsilcisi()
        {
            Ad = "Ayşe",
            Soyad = "Yıldız",
            Departman = "Satış"
        };

        // Çalışan bilgilerini ve görevlerini yazdır
        dev.CalisanBilgi();
        dev.Gorev();

        Console.WriteLine();

        pm.CalisanBilgi();
        pm.Gorev();

        Console.WriteLine();

        sales.CalisanBilgi();
        sales.Gorev();
    }
}
