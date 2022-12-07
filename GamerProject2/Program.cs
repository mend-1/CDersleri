namespace GamerProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());

            gamerManager.Add(new Gamer
            {
                Id = 1,
                FirstName = "Menderes",
                LastName = "Öztürk",
                BhirtYear=1998,
                IdentityNumber = 12345
            
            }
                ); ;
        }
    }
}