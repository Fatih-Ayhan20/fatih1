using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int kare = sayi * sayi;
            Console.WriteLine($"Girdiğiniz sayının karesi: {kare}");
        }
        catch
        {
            Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
        }
    }
}
