for (int i = 0; i <= 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, yazılım işini halledeceğim. ");
}
Console.WriteLine("-----------------------------------------------------------------------------------------");

for (int i = 2 ; i < 20; i++)
{
    Console.WriteLine($"i değeri {i}");
}
Console.WriteLine("-----------------------------------------------------------------------------------------");
for (int i = 2; i < 20; i+=2)
{
    Console.WriteLine($"i değeri {i}");
}

Console.WriteLine("-----------------------------------------------------------------------------------------");

int sayı1 = 50;
int sayı2 = 150;
int toplam = 0;
for (int i = 51; i < 150; i++)
{
    toplam += i;
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı ="+ toplam);
Console.WriteLine("-----------------------------------------------------------------------------------------");

int tek = 0;
int çift = 0;
for (int i = 0; i < 120; i++)
{
    if (i % 2 == 0)
    {
        çift++;
    }
    else
    {
        tek++;
    }
}
Console.WriteLine("0 ile 120 arasındaki çift sayıların toplamı = " + çift);
Console.WriteLine("0 ile 120 arasındaki tek sayıların toplamı = " + tek);

