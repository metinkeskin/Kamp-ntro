using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string KategoriEtiketi = "KategoriEtiketi" ;
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool SistemeGrisYapMisMi = true;
            double DolarDun = 7.35;
            double DolarBugun = 7.45;

            if (DolarDun>DolarBugun)
            {
                Console.WriteLine("azalıs butonu");
            }
            else if (DolarDun<DolarBugun)
            {
                Console.WriteLine("artıs butonu");
            }
            else
            {
                Console.WriteLine("esittir");
            }




            if (SistemeGrisYapMisMi == true)
            {
                Console.WriteLine("kulanıcı ayarlari butonu");

            }
            else
            {
                Console.WriteLine("gris yap butonu ");
            }

        }
    }
}
