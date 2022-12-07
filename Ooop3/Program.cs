namespace Ooop3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager egitimKrediManager = new EgitimKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager, new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService(), new FileLoggerService()});
            //basvuruManager.TutariYaz(esnafKrediManager);


            List<IKrediManager> krediler = new List<IKrediManager>() {
            ihtiyacKrediManager
            };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler); 
           
        }
    }
}