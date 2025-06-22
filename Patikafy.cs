using System;
using System.Collections.Generic;
using System.Linq;

namespace PatikafyMüzikPlatformu
{
    public class Sanatçı
    {
        public string Ad { get; set; }
        public string MüzikTürü { get; set; }
        public int ÇıkışYılı { get; set; }
        public double AlbümSatışı { get; set; } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Sanatçı> sanatçılar = new List<Sanatçı>
            {
                new Sanatçı { Ad = "Sezen Aksu", MüzikTürü = "Pop", ÇıkışYılı = 1975, AlbümSatışı = 15 },
                new Sanatçı { Ad = "Tarkan", MüzikTürü = "Pop", ÇıkışYılı = 1992, AlbümSatışı = 14 },
                new Sanatçı { Ad = "Barış Manço", MüzikTürü = "Rock", ÇıkışYılı = 1969, AlbümSatışı = 10 },
                new Sanatçı { Ad = "Sertab Erener", MüzikTürü = "Pop", ÇıkışYılı = 1992, AlbümSatışı = 6 },
                new Sanatçı { Ad = "Ceza", MüzikTürü = "Rap", ÇıkışYılı = 2000, AlbümSatışı = 4 },
                new Sanatçı { Ad = "MFÖ", MüzikTürü = "Pop", ÇıkışYılı = 1984, AlbümSatışı = 9 },
                new Sanatçı { Ad = "Ajda Pekkan", MüzikTürü = "Pop", ÇıkışYılı = 1964, AlbümSatışı = 12 },
                new Sanatçı { Ad = "Athena", MüzikTürü = "Rock", ÇıkışYılı = 1998, AlbümSatışı = 3 },
                new Sanatçı { Ad = "Teoman", MüzikTürü = "Rock", ÇıkışYılı = 1997, AlbümSatışı = 5 },
                new Sanatçı { Ad = "Sıla", MüzikTürü = "Pop", ÇıkışYılı = 2007, AlbümSatışı = 2 },
                new Sanatçı { Ad = "Mabel Matiz", MüzikTürü = "Pop", ÇıkışYılı = 2011, AlbümSatışı = 3 }
            };

            // Adı 'S' ile başlayan şarkıcılar
            var sİleBaşlayanlar = sanatçılar
                .Where(s => s.Ad.StartsWith("S"))
                .ToList();

            Console.WriteLine("Adı 'S' ile başlayan şarkıcılar:");
            sİleBaşlayanlar.ForEach(s => Console.WriteLine($" - {s.Ad}"));

            // Albüm satışı 10 milyonun üzerinde olan şarkıcılar
            var onMilyonÜstü = sanatçılar
                .Where(s => s.AlbümSatışı > 10)
                .ToList();

            Console.WriteLine("\nAlbüm satışı 10 milyonun üzerinde olan şarkıcılar:");
            onMilyonÜstü.ForEach(s => Console.WriteLine($" - {s.Ad} ({s.AlbümSatışı}M)"));

            // 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar
            var eskiPopçular = sanatçılar
                .Where(s => s.ÇıkışYılı < 2000 && s.MüzikTürü == "Pop")
                .OrderBy(s => s.ÇıkışYılı)
                .ThenBy(s => s.Ad)
                .GroupBy(s => s.ÇıkışYılı);

            Console.WriteLine("\n2000 yılı öncesi çıkış yapmış pop şarkıcılar (çıkış yılına göre):");
            foreach (var grup in eskiPopçular)
            {
                Console.WriteLine($"Yıl {grup.Key}:");
                foreach (var s in grup)
                {
                    Console.WriteLine($" - {s.Ad}");
                }
            }

            // En çok albüm satan şarkıcı
            var enÇokSatan = sanatçılar
                .OrderByDescending(s => s.AlbümSatışı)
                .First();

            Console.WriteLine($"\nEn çok albüm satan şarkıcı: {enÇokSatan.Ad} ({enÇokSatan.AlbümSatışı}M)");

            // En yeni ve en eski çıkış yapan şarkıcılar
            var enYeni = sanatçılar
                .OrderByDescending(s => s.ÇıkışYılı)
                .First();

            var enEski = sanatçılar
                .OrderBy(s => s.ÇıkışYılı)
                .First();

            Console.WriteLine($"\nEn yeni çıkış yapan şarkıcı: {enYeni.Ad} ({enYeni.ÇıkışYılı})");
            Console.WriteLine($"En eski çıkış yapan şarkıcı: {enEski.Ad} ({enEski.ÇıkışYılı})");
        }
    }
}