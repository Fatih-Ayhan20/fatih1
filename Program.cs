Console.WriteLine("Rüya manavına hoşgeldiniz!");
Console.WriteLine("Lütfen bir meyve seçiniz:");
Console.WriteLine("1. Elma:2 TL");
Console.WriteLine("2. Armut:3 TL");
Console.WriteLine("3. Çilek: 2 TL");
Console.Write("Seçiminiz: ");
string meyve = Console.ReadLine();
switch (meyve.ToLower())
{ 
 case "elma":
    Console.WriteLine("Elma seçtiniz, 2 TL ödeyin.");
    break;
case "armut":
    Console.WriteLine("Armut seçtiniz,3 TL ödeyin.");
    break;
case "çilek":
    Console.WriteLine("Çilek seçtiniz,2 TL ödeyin.");
    break;
    default:
    Console.WriteLine("Geçersiz meyve seçimi.");
    break;
}