namespace ClassIntro
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C# dersleri";
            kurs1.KursEgitmeni = "Menderes Öztürk";
            kurs1.KursIzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Html Dersleri";
            kurs2.KursEgitmeni = "Şafak Özen";
            kurs2.KursIzlenmeOrani = 80;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "CSS Dersleri";
            kurs3.KursEgitmeni = "Şafak Özen";
            kurs3.KursIzlenmeOrani = 80;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var item in kurslar)
            {
                Console.WriteLine(item.KursAdi+ ":" + item.KursEgitmeni + ":" + item.KursIzlenmeOrani);
            }

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursEgitmeni + " : " + kurs1.KursIzlenmeOrani);

        }
        public class Kurs
        {
            public string KursAdi { get; set; }
            public string KursEgitmeni { get; set; }
            public int KursIzlenmeOrani { get; set; }
            public string KursIzlenmeOrani2 { get; set; }

        }
    }
}