using System;

class Program
{
    static void Main()
    {
        Console.Write("Limit değerini giriniz: ");
        int limit = Convert.ToInt32(Console.ReadLine());

        int sayac = 0;

        // WHILE DÖNGÜSÜ
        Console.WriteLine("\n--- WHILE DÖNGÜSÜ ---");
        sayac = 0;
        while (sayac <= limit)
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayac++;
        }

        // DO-WHILE DÖNGÜSÜ
        Console.WriteLine("\n--- DO-WHILE DÖNGÜSÜ ---");
        sayac = 0;
        do
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayac++;
        } while (sayac <= limit);
    }
}