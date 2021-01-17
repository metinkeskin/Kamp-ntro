using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            kurs kurs1 = new kurs();
            kurs1.KursAdi = "python";
            kurs1.Egitmen = "metin keskin";
            kurs1.IzlenmeOrani = 72;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "serwan tenik";
            kurs2.IzlenmeOrani= 65;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "cv2";
            kurs3.Egitmen = "ismail biçer";
            kurs3.IzlenmeOrani= 77;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            kurs[] kurslar = new kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);
            }

        }
    }
    class kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
