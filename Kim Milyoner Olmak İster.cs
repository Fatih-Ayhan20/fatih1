Console.WriteLine("Kim Milyoner Olmak İster? yarışmasına hoşgeldiniz.");
Console.WriteLine("Aşağıdaki 3 sorunun 2'sine doğru cevap verirseniz yarışmayı kazanırsınız!");
Console.WriteLine("1) Kızınca tüküren hayvan hangisidir ?");
Console.WriteLine("A)Lama B)Deve C)Kaplan D)Kedi");
// Kullanıcıdan cevap alıyoruz
Console.WriteLine("Cevabınızı giriniz: ");
// Kullanıcıdan cevap alıyoruz
string cevap = Console.ReadLine();
// Kullanıcının cevabını kontrol ediyoruz
if (cevap == "A")
{
    Console.WriteLine("Doğru cevap");
}
else if (cevap == "B")
{
    Console.WriteLine("Yanlış cevap");
}
else
{
    Console.WriteLine("Geçersiz cevap");
}
// İkinci soruyu soruyoruz 

Console.WriteLine("2)  Dünya'ya en yakın gezegen hangisidir ?");
Console.WriteLine("A)Venüs B)Mars");
// Kullanıcıdan cevap alıyoruz
Console.WriteLine("Cevabınızı giriniz: ");
// Kullanıcıdan cevap alıyoruz
string cevap2 = Console.ReadLine();
// Kullanıcının cevabını kontrol ediyoruz
if (cevap2 == "A")
{
    Console.WriteLine("Doğru cevap");
}
else if (cevap2 == "B")
{
    Console.WriteLine("Yanlış cevap");
}
else
{
    Console.WriteLine("Geçersiz cevap");
}
// Üçüncü soruyu soruyoruz
Console.WriteLine("3)  5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?");
Console.WriteLine("A)7 B)12");
// Kullanıcıdan cevap alıyoruz
Console.WriteLine("Cevabınızı giriniz: ");
// Kullanıcıdan cevap alıyoruz
string cevap3 = Console.ReadLine();
// Kullanıcının cevabını kontrol ediyoruz
if (cevap3 == "A")
{
    Console.WriteLine("Yanlış cevap");
}
else if (cevap3 == "B")
{
    Console.WriteLine("Doğru cevap");
}
else
{
    Console.WriteLine("Geçersiz cevap");
}
// Kullanıcının doğru cevap sayısını kontrol ediyoruz
int dogruCevapSayisi = 0;
if (cevap == "A")
{
    dogruCevapSayisi++;
}
if (cevap2 == "A")
{
    dogruCevapSayisi++;
}
if (cevap3 == "A")
{
    dogruCevapSayisi++;
}

// Kullanıcıya doğru cevap sayısını gösteriyoruz
Console.WriteLine("Doğru cevap sayınız: " + dogruCevapSayisi);

// Kullanıcıya kazanıp kazanmadığını kontrol ediyoruz
if (dogruCevapSayisi >= 2)
{
    Console.WriteLine("Tebrikler, yarışmayı kazandınız!");
}
else
{
    Console.WriteLine("Üzgünüm, yarışmayı kaybettiniz.");
}
// Kullanıcıdan tekrar oynamak isteyip istemediğini soruyoruz
Console.WriteLine("Tekrar oynamak ister misiniz? (E/H)");
string tekrarOyna = Console.ReadLine();
if (tekrarOyna == "E")
{
    // Tekrar oynamak için kodu buraya ekleyebilirsiniz
    Console.WriteLine("Yarışmaya tekrar hoşgeldiniz!");
}
else
{
    Console.WriteLine("Yarışmadan çıkılıyor.");
}
// Yarışmadan çıkıyoruz




