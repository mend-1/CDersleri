using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooop3
{
    internal class KonutKrediManager : IKrediManager
    {
        public void TutariGetir()
        {
            Console.WriteLine("konut kredi tutarın belirlendi");
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredin hazır");
        }
    }
}
