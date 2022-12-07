using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooop3
{
    //esnaf kredi manager clasımızı IkrediManager interfaceimizden miras aldık
    internal class EsnafKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredin hazır");
        }

        public void TutariGetir()
        {
            Console.WriteLine("Esnaf kredin tutarın belirlendi");
        }
    }
}
