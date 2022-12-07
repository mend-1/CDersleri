using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooop3
{
    internal class TasitKrediManager : IKrediManager
    {
        public void TutariGetir()
        {
            Console.WriteLine("Taşıt kredi tutarın belirlendi");
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredin hazır");
        }
    }
}
