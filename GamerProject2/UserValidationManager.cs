using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject2
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id ==1 && gamer.FirstName =="Menderes" && gamer.LastName=="Öztürk" && gamer.BhirtYear==1998 && gamer.IdentityNumber==12345)
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
