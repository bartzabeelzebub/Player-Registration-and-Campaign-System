﻿namespace GameProject;
class Program
{
    static void Main(string[] args)
    {
        GamerManager gamerManager = new GamerManager(new UserValidationManager());
        gamerManager.Add(new Gamer
        {
            Id = 1,
            BirthYear = 2001,
            FirstName = "EKREM",
            LastName = "AKKAYA",
            IdentityNumber = 12345
        });
        
    }
}

