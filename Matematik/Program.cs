namespace Matematik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DortIslemManager dortIslemManager = new DortIslemManager();

            dortIslemManager.Topla(9, 5);

            Console.WriteLine("--------------");

            dortIslemManager.Cikarma(12, 15);

            Console.WriteLine("--------------");

            dortIslemManager.Carpma(6, 4);

        }
    }
}