namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dinamik yapı
            //örneğin bir e ticaret sitesindeki tüm kategorileri tek tek yazdırmak yerine böyle dinamik bir yapı oluşturabilirisin
            
            //Döngüler örnek
            
            string[] kurslar = new string[]
            {
                "a kursu","b kursu", "c kursu","d kursu","e kursu", "f kursu"
            };
            

            for (int i = 0; i < kurslar.Length; i++)
            {
                //Array.Sort(kurslar);
                //Array.Reverse(kurslar);
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("//////////////////////////////////////////");

            //daha dinamik olması için foreach kullan
            //foreach her bir elemanı tek tek dolaşır

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}