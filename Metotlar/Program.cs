using Donguler;

namespace Metotlar
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 30;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Çilek";
            urun2.Fiyati = 20;
            urun2.Aciklama = "Strowbery";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach (Urun item in urunler)
            {
                Console.WriteLine(item.Fiyati);
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Aciklama);
            }


            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);       

            sepetManager.Sil();
            sepetManager.Sil();

        }
    }
}