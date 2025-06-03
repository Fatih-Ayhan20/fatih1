namespace OkulYonetimSistemi
{
    public class Person
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }

        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Doğum Tarihi: {DogumTarihi.ToShortDateString()}");
        }
    }

    public class Ogrenci : Person
    {
        public string OgrenciNo { get; set; }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"Öğrenci No: {OgrenciNo}");
        }
    }

    public class Ogretmen : Person
    {
        public string Brans { get; set; }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"Branş: {Brans}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci
            {
                Ad = "Barış ",
                Soyad = "Yılmaz",
                DogumTarihi = new DateTime(2010, 03, 14),
                OgrenciNo = "12345"
            };

            Ogrenci ogr2 = new Ogrenci
            {
                Ad = "Ayşe",
                Soyad = "İlker",
                DogumTarihi = new DateTime(2008, 12, 2),
                OgrenciNo = "12346"
            };

            Ogretmen ogretmen1 = new Ogretmen
            {
                Ad = "Emin",
                Soyad = "Ayhan",
                DogumTarihi = new DateTime(1979,07, 28),
                Brans = "Matematik"
            };

            Ogretmen ogretmen2 = new Ogretmen
            {
                Ad = "Fatma",
                Soyad = "Ayhan",
                DogumTarihi = new DateTime(1980, 02, 04),
                Brans = "Türkçe"
            };

            List<Person> kisiler = new List<Person> { ogr1, ogr2, ogretmen1, ogretmen2 };

            foreach (var kisi in kisiler)
            {
                kisi.BilgileriYazdir();
                Console.WriteLine("-----------------------------");
            }

            Console.ReadLine();
        }
    }
}