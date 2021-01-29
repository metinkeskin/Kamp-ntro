using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metin Keskin
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 2;
            musteri1.MusteriNo = "12344";
            musteri1.Adi = "Metin";
            musteri1.Soyadi="Keskin";
            musteri1.TcNo = "123454556";

            //keskin ticaret
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12345644789";
            musteri2.SirketAdi = "Keskin ticaret";
            musteri2.VergiNo = "546321";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri1);

        }
    }
}
