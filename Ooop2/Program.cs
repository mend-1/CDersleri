namespace Ooop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri gercekMusteri = new GercekMusteri();
            gercekMusteri.Id = 1;
            gercekMusteri.MusteriNo = "1";
            gercekMusteri.Adi = "Mehmet";
            gercekMusteri.Soyadi = "Aslan";


            TuzelMusteri tuzelMusteri= new TuzelMusteri();
            tuzelMusteri.Id = 2;

            Musteri muster3= new GercekMusteri();
            Musteri muster4 = new TuzelMusteri();

            MusteriManager musteriManager= new MusteriManager();
            musteriManager.Ekle(gercekMusteri);

        }
    }
}