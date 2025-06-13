using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] dizi = new int[10];

        Console.WriteLine("Lütfen 10 adet tam sayı giriniz:");
        for (int i = 0; i < dizi.Length; i++)
        {
            Console.Write($"Sayı {i + 1}: ");
            dizi[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nGirdiğiniz sayılar:");
        foreach (int sayi in dizi)
        {
            Console.WriteLine(sayi);
        }

        Console.Write("\nYeni bir sayı giriniz (11. eleman): ");
        int yeniSayi = Convert.ToInt32(Console.ReadLine());

      
        List<int> sayiListesi = new List<int>(dizi);
        sayiListesi.Add(yeniSayi);

        sayiListesi.Sort();
        sayiListesi.Reverse();

        Console.WriteLine("\nSayıların büyükten küçüğe sıralanmış hali:");
        foreach (int sayi in sayiListesi)
        {
            Console.WriteLine(sayi);
        }
    }
}