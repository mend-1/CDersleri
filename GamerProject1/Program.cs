namespace GamerProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
           
            gamerManager.Add(new Gamer
            {
                Id=1,
                FirstName="Menderes",
                LastName="Öztürk",
                BirthYear=1998
            }
                );
            
        }
    }
}