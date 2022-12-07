using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooop3
{
    internal class IhtiyacKrediManager : IKrediManager
    {
        public void TutariGetir()
        {
            Console.WriteLine("ihtiyaç kredi tutarın belirlendi");
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredin hazır");
        }

    }
}
