int i = 0;
while (i <= 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}

Console.WriteLine("---------------------------------------------------------------------------------------------");


int sayac = 2;
while (sayac < 20)
{
    Console.WriteLine($"sayı {sayac}");
    sayac++;
}
Console.WriteLine("---------------------------------------------------------------------------------------------");


int sayac2 = 2;
while (sayac2 < 20)
{
    Console.WriteLine($"sayı {sayac2}");
    sayac2 += 2;
}
Console.WriteLine("---------------------------------------------------------------------------------------------");

int sayı1=50,
    sayı2 = 150,
    toplam = 0;
while (sayı1 <= sayı2)
{
    toplam += sayı1;
    sayı1++;
}
Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı: {toplam}");
Console.WriteLine("---------------------------------------------------------------------------------------------");

int tek = 0;
int çift = 0;
while (sayı1 <= sayı2)
{
    if (sayı1 % 2 == 0)
    {
        çift++;
    }
    else
    {
        tek++;
    }
    sayı1++;
}
Console.WriteLine($"50 ile 150 arasındaki tek sayıların toplamı: {çift}");
sayı1 = 50;
while (sayı1 <= sayı2)
{
    if (sayı1 % 2 == 0)
    {
        çift += sayı1;
    }
    sayı1++;
}

Console.WriteLine($"50 ile 150 arasındaki çift sayıların toplamı: {tek}");
while (sayı1 <= sayı2)
{
    if (sayı1 % 2 == 1)
    {
        çift += sayı1;
    }
    sayı1++;
}



