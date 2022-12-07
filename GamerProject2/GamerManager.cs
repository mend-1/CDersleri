using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject2
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
            if (_userValidationService.Validate(gamer) ==true)
            {
                Console.WriteLine("Kullanıcı Kaydı Başarılı");
            }
            else
            {
                Console.WriteLine("Kullanıcı Eklemede Hata");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı Güncellendi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı Silindi");
        }
    }
}
