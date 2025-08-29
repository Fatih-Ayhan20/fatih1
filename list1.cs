using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Davetlilerin isimlerini tutacak liste
        List<string> davetliler = new List<string>();

        // Listeye isim ekleyelim
        davetliler.Add("Ahmet");
        davetliler.Add("Ayşe");
        davetliler.Add("Mehmet");
        davetliler.Add("Zeynep");
        davetliler.Add("Fatma");

        Console.WriteLine(" Patika Plus Gala Gecesi Davetlileri \n");

        // foreach ile listeyi dönelim
        foreach (var isim in davetliler)
        {
            Console.WriteLine(isim);
        }

        // Alternatif: for döngüsüyle de yazdırabiliriz
        /*
        for (int i = 0; i < davetliler.Count; i++)
        {
            Console.WriteLine(davetliler[i]);
        }
        */
    }
}
