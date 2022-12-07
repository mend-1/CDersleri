using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject1
{
    internal class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı Eklendi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı Güncellendi");
        }
    }
}
