using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManger : IGamerService
    {
        IUserValidationService userValidationService;

        public GamerManger(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void add(Gamer gamer)
        {
            if (userValidationService.validate(gamer)==true)
            {
                Console.WriteLine("kayıt oldu");
            }
            else
            {
                Console.WriteLine("dogrulama başarısız kayıt başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("kayıt silindi");

        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("kayıt güncelendi");

        }
    }
}
