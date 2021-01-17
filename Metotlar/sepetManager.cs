using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class sepetManager
    {
        // naming conventing
        //syntax
        public void Ekle(product product) 
        {
            Console.WriteLine("Tebrikler sepete eklendi: " + product.Adi);
        
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int StokAdeti)
        {
            Console.WriteLine("Tebrikler sepete eklendi: " + urunAdi);
        }
    }
}
