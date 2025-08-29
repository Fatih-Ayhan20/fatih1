using System;

abstract class BaseMakine
{
    public DateTime UretimTarihi { get; private set; }
    public string SeriNo { get; set; }
    public string Ad { get; set; }
    public string Aciklama { get; set; }
    public string IsletimSistemi { get; set; }

    public BaseMakine()
    {
        UretimTarihi = DateTime.Now; // otomatik atama
    }

    // Ortak bilgileri yazdıran metot
    public virtual void BilgileriYazdir()
    {
        Console.WriteLine($"Üretim Tarihi: {UretimTarihi}");
        Console.WriteLine($"Seri No: {SeriNo}");
        Console.WriteLine($"Ad: {Ad}");
        Console.WriteLine($"Açıklama: {Aciklama}");
        Console.WriteLine($"İşletim Sistemi: {IsletimSistemi}");
    }

    // Abstract metot
    public abstract void UrunAdiGetir();
}

// Telefon sınıfı
class Telefon : BaseMakine
{
    public bool TrLisansliMi { get; set; }

    public override void BilgileriYazdir()
    {
        base.BilgileriYazdir();
        Console.WriteLine($"TR Lisanslı mı: {(TrLisansliMi ? "Evet" : "Hayır")}");
    }

    public override void UrunAdiGetir()
    {
        Console.WriteLine($"Telefonunuzun adı ---> {Ad}");
    }
}

// Bilgisayar sınıfı
class Bilgisayar : BaseMakine
{
    private int _usbGirisSayisi;

    public int UsbGirisSayisi
    {
        get { return _usbGirisSayisi; }
        set
        {
            if (value == 2 || value == 4)
                _usbGirisSayisi = value;
            else
            {
                Console.WriteLine("⚠ Usb giriş sayısı sadece 2 veya 4 olabilir! -1 değeri atandı.");
                _usbGirisSayisi = -1;
            }
        }
    }

    public bool BluetoothVarMi { get; set; }

    public override void BilgileriYazdir()
    {
        base.BilgileriYazdir();
        Console.WriteLine($"USB Giriş Sayısı: {UsbGirisSayisi}");
        Console.WriteLine($"Bluetooth: {(BluetoothVarMi ? "Var" : "Yok")}");
    }

    public override void UrunAdiGetir()
    {
        Console.WriteLine($"Bilgisayarınızın adı ---> {Ad}");
    }
}

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Telefon üretmek için 1, Bilgisayar üretmek için 2 tuşlayınız:");
            string secim = Console.ReadLine();

            BaseMakine urun = null;

            if (secim == "1")
            {
                urun = new Telefon();

                Console.Write("Seri No: ");
                urun.SeriNo = Console.ReadLine();

                Console.Write("Ad: ");
                urun.Ad = Console.ReadLine();

                Console.Write("Açıklama: ");
                urun.Aciklama = Console.ReadLine();

                Console.Write("İşletim Sistemi: ");
                urun.IsletimSistemi = Console.ReadLine();

                Console.Write("TR Lisanslı mı? (E/H): ");
                ((Telefon)urun).TrLisansliMi = Console.ReadLine().ToUpper() == "E";
            }
            else if (secim == "2")
            {
                urun = new Bilgisayar();

                Console.Write("Seri No: ");
                urun.SeriNo = Console.ReadLine();

                Console.Write("Ad: ");
                urun.Ad = Console.ReadLine();

                Console.Write("Açıklama: ");
                urun.Aciklama = Console.ReadLine();

                Console.Write("İşletim Sistemi: ");
                urun.IsletimSistemi = Console.ReadLine();

                Console.Write("USB Giriş Sayısı (2 veya 4): ");
                ((Bilgisayar)urun).UsbGirisSayisi = int.Parse(Console.ReadLine());

                Console.Write("Bluetooth Var mı? (E/H): ");
                ((Bilgisayar)urun).BluetoothVarMi = Console.ReadLine().ToUpper() == "E";
            }
            else
            {
                Console.WriteLine("⚠ Geçersiz seçim yaptınız.");
                continue;
            }

            Console.WriteLine("\n✅ Ürün başarıyla üretildi!\n");
            urun.BilgileriYazdir();
            urun.UrunAdiGetir();

            Console.WriteLine("\nBaşka bir ürün üretmek istiyor musunuz? (E/H):");
            string devam = Console.ReadLine().ToUpper();

            if (devam != "E")
            {
                Console.WriteLine("İyi günler dileriz 👋");
                break;
            }

            Console.WriteLine("\n-------------------------------\n");
        }
    }
}
