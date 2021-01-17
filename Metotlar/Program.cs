using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            product product1 = new product();
            product1.Adi = " Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya elmasi";

            product product2 = new product();
            product2.Adi = " Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakir karpuzu";

            product[] products = new product[] { product1, product2 };

            foreach (product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("--------------metotlar-----------");

            //instance - ornek
            //encapsulation

            sepetManager sepetManager = new sepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("armut", "Yesil armut",12, 9);
            sepetManager.Ekle2("elma", "Yesil elma", 12, 11);
            sepetManager.Ekle2("karpuz", "Dİyarbakır karpuzu", 12, 1);


        }
    }
}




//dont repeat yourself - DRY - clean code - best practice