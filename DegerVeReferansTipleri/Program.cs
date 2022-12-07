namespace DegerVeReferansTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslemManager = new DortIslem();

            dortIslemManager.Bolme(9, 3);

            dortIslemManager.ModAlma(20, 3);
        }
    }
}