using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.Birthday == 1999 && gamer.FirstName == "METİN" && gamer.LastName == "KESKİN" && gamer.IdentityNumber ==12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
