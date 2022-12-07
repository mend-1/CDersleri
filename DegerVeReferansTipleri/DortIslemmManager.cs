using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipleri
{
    internal class DortIslem
    {
        //Bolme ve modalam metodları oluşturduk
        public void Bolme(int sayi1, int sayi2)
        {
            int bolme = sayi1 / sayi2;
            Console.WriteLine(bolme);
        }

        public void ModAlma(int sayi1, int sayi2)
        {
            int modAlma = sayi1 % sayi2;
            Console.WriteLine(modAlma);
        }
    }
}
