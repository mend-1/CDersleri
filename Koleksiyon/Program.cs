using System.Collections.Generic;

namespace Koleksiyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> { "A","B","C","D"};
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }
        }
    }
}