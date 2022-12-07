using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject1
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.FirstName == "Menderes" && gamer.LastName == "Öztürk" && gamer.BirthYear == 1998)
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
