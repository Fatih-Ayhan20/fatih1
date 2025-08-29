using System;
using System.Collections.Generic;

class Film
{
    public string Isim { get; set; }
    public double ImdbPuani { get; set; }

    public Film(string isim, double imdbPuani)
    {
        Isim = isim;
        ImdbPuani = imdbPuani;
    }
}

class Program
{
    static void Main()
    {
        List<Film> filmler = new List<Film>();

        while (true)
        {
            Console.Write("Film adı: ");
            string isim = Console.ReadLine();

            Console.Write("IMDB Puanı: ");
            double imdb = Convert.ToDouble(Console.ReadLine());

            // Nesne oluştur ve listeye ekle
            filmler.Add(new Film(isim, imdb));

            Console.Write("Yeni bir film eklemek ister misiniz? (E/H): ");
            string cevap = Console.ReadLine().ToUpper();

            if (cevap != "E")
                break;

            Console.WriteLine();
        }

        Console.WriteLine("\n🎬 Tüm Filmler:");
        foreach (var film in filmler)
        {
            Console.WriteLine($"{film.Isim} - {film.ImdbPuani}");
        }

        Console.WriteLine("\n⭐ IMDB puanı 4 ile 9 arasında olan filmler:");
        foreach (var film in filmler)
        {
            if (film.ImdbPuani >= 4 && film.ImdbPuani <= 9)
                Console.WriteLine($"{film.Isim} - {film.ImdbPuani}");
        }

        Console.WriteLine("\n🔤 İsmi 'A' ile başlayan filmler:");
        foreach (var film in filmler)
        {
            if (film.Isim.StartsWith("A", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine($"{film.Isim} - {film.ImdbPuani}");
        }
    }
}
