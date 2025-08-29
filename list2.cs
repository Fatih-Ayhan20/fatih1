using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> kahveler = new List<string>();

        Console.WriteLine("☕ 5 kahve ismi giriniz:");

        // 5 kez kullanıcıdan giriş al
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"{i}. kahve: ");
            string kahveAdi = Console.ReadLine();
            kahveler.Add(kahveAdi);
        }

        Console.WriteLine("\n--- Girdiğiniz Kahveler ---");

        // foreach ile listeyi yazdır
        foreach (var kahve in kahveler)
        {
            Console.WriteLine(kahve);
        }
    }
}
