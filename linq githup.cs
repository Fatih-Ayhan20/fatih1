using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Örnek bir liste oluşturalım
        List<int> numbers = new List<int> { -5, 2, -7, 4, -9, 5, 7, 25, 14, 10 };

        // LINQ kullanarak çift sayıları seçelim
        var evenNumbers = numbers.Where(x => x % 2 == 0);

        //LINQ kullanarak tek sayıları seçelim
        var evenNumbers2 = numbers.Where(x => x % 2 == 1);

        //LINQ kullanarak pozitif sayıları seçelim
        var positiveNumbers = numbers.Where(x => x > 0);

        // LINQ kullanarak negatif sayıları seçelim
        var negativeNumbers = numbers.Where(x => x < 0);

        // LINQ kullanarak 15'den büyük sayıları seçelim
        var greaterThanTen = numbers.Where(x => x > 15);

        // LINQ kullanarak 22'den küçük sayıları seçelim
        var lessThanTen = numbers.Where(x => x < 22);

        // LINQ kullanarak her bir sayını karesini alalım
        var squares = numbers.Select(x => x * x);

        // Sonuçları ekrana yazdıralım
        Console.WriteLine("Çift Sayılar: " + string.Join(", ", evenNumbers));
        Console.WriteLine("Tek Sayılar: " + string.Join(", ", evenNumbers2));
        Console.WriteLine("Pozitif Sayılar: " + string.Join(", ", positiveNumbers));
        Console.WriteLine("Negatif Sayılar: " + string.Join(", ", negativeNumbers));
        Console.WriteLine("15'den Büyük Sayılar: " + string.Join(", ", greaterThanTen));
        Console.WriteLine("22'den Küçük Sayılar: " + string.Join(", ", lessThanTen));
        Console.WriteLine("Kareler: " + string.Join(", ", squares));

    }
}
       

