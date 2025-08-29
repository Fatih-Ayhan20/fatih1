using System;
using System.Collections.Generic;

class Araba
{
    public DateTime UretimTarihi { get; private set; }
    public string SeriNo { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    public int KapiSayisi { get; set; }

    public Araba()
    {
        UretimTarihi = DateTime.Now; // otomatik atama
    }
}

class Program
{
    static void Main()
    {
        List<Araba> arabalar = new List<Araba>();

        while (true)
        {
        Baslangic:
            Console.Write("Araba üretmek istiyor musunuz? (E/H): ");
            string cevap = Console.ReadLine().Trim().ToUpper();

            if (cevap == "H")
            {
                Console.WriteLine("\n Üretim tamamlandı! Üretilen arabaların listesi:");
                foreach (var araba in arabalar)
                {
                    Console.WriteLine($"Seri No: {araba.SeriNo}, Marka: {araba.Marka}");
                }
                Console.WriteLine("\nİyi günler dileriz ");
                break;
            }
            else if (cevap != "E")
            {
                Console.WriteLine(" Geçersiz cevap! Lütfen E veya H giriniz.\n");
                goto Baslangic;
            }

            // Yeni araba nesnesi oluştur
            Araba yeniAraba = new Araba();

            Console.Write("Seri No: ");
            yeniAraba.SeriNo = Console.ReadLine();

            Console.Write("Marka: ");
            yeniAraba.Marka = Console.ReadLine();

            Console.Write("Model: ");
            yeniAraba.Model = Console.ReadLine();

            Console.Write("Renk: ");
            yeniAraba.Renk = Console.ReadLine();

        Kapilar:
            Console.Write("Kapı Sayısı: ");
            string kapiInput = Console.ReadLine();
            try
            {
                yeniAraba.KapiSayisi = Convert.ToInt32(kapiInput);
            }
            catch
            {
                Console.WriteLine(" Geçersiz giriş! Kapı sayısı sayı olmalı.");
                goto Kapilar; // kullanıcıyı tekrar kapı sayısı girişine yönlendir
            }

            arabalar.Add(yeniAraba);
            Console.WriteLine("\n Araba başarıyla üretildi!\n");
        }
    }
}
