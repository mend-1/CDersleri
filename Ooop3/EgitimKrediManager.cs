using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooop3
{
    internal class EgitimKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Eğitim Kredin Hazır");
        }

        public void TutariGetir()
        {
            Console.WriteLine("Eğitim Tutarın Hazır");
        }
    }
}
