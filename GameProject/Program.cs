using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManger gamerManger = new GamerManger(new UserValidationManager());
            gamerManger.add(new Gamer { ıd=1, Birthday=1999, FirstName="METİN", LastName="KESKİN", IdentityNumber=12345})
            Console.WriteLine("Hello World!");
        }
    }
}
