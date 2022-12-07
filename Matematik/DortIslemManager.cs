using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslemManager
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }

        public void Cikarma(int sayi1, int sayi2)
        {
            //negatif gelmemesi icin
            //if (sayi1<sayi2)
            //{
            //    int terstencikar = sayi2 - sayi1;
            //    Console.WriteLine(terstencikar);
            //}
            //else
            //{
            //    int cikar = sayi1 - sayi2;
            //    Console.WriteLine(cikar);
            //}
            int cikar = sayi1 - sayi2;
            Console.WriteLine(cikar);
        }

        public void Carpma(int sayi1, int sayi2)
        {
            int carpma = sayi1 * sayi2;
            Console.WriteLine(carpma);
        }
    }
}
