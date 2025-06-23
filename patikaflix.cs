using System;
using System.Collections.Generic;
using System.Linq;

namespace PatikaflixDiziler
{

    public class Dizi
    {
        public string Ad { get; set; }
        public string Tur { get; set; }
        public string Yonetmen { get; set; }
        public int YayınYili { get; set; }
    }

    public class KomediDiziOzet
    {
        public string Ad { get; set; }
        public string Tur { get; set; }
        public string Yonetmen { get; set; }

        public void Yazdir()
        {
            Console.WriteLine($"Dizi: {Ad} | Tür: {Tur} | Yönetmen: {Yonetmen}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Dizi> diziler = new List<Dizi>();
            while (true)
            {
                Dizi yeniDizi = new Dizi();

                Console.Write("Dizi adı: ");
                yeniDizi.Ad = Console.ReadLine();

                Console.Write("Dizi türü: ");
                yeniDizi.Tur = Console.ReadLine();

                Console.Write("Yönetmen: ");
                yeniDizi.Yonetmen = Console.ReadLine();

                Console.Write("Yayın yılı: ");
                yeniDizi.YayınYili = int.Parse(Console.ReadLine());

                diziler.Add(yeniDizi);

                Console.Write("Yeni bir dizi eklemek istiyor musunuz? (e/h): ");
                string cevap = Console.ReadLine().ToLower();

                if (cevap != "e")
                    break;

                Console.WriteLine();
            }


            List<KomediDiziOzet> komediDizileri = diziler
                .Where(d => d.Tur.ToLower() == "komedi")
                .Select(d => new KomediDiziOzet
                {
                    Ad = d.Ad,
                    Tur = d.Tur,
                    Yonetmen = d.Yonetmen
                })
                .OrderBy(d => d.Ad)
                .ThenBy(d => d.Yonetmen)
                .ToList();

            Console.WriteLine("\n--- Komedi Dizileri (Sıralı) ---");
            foreach (var dizi in komediDizileri)
            {
                dizi.Yazdir();
            }
        }
    }
}
