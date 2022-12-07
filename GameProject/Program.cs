﻿namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());

            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear =1985,
                FirstName = "Engin",
                LastName="Demiroğ",
                IdentityNumber=12345

            });
            Console.WriteLine("Hello, World!");
        }
    }
}