using System;

namespace PersonnageAuHasard
{
    class Program
    {
        static void Main(string[] args)
        {
			Random generateur = new Random();
			int personnage1 = generateur.Next(1, 4); // Pige un nombre au hasard entre 1 et 4 (exclu)
			int personnage2 = generateur.Next(1, 4);
			int personnage3 = generateur.Next(1, 4);
			string personnage1Description = "", personnage2Description = "", personnage3Description = "";
			switch (personnage1)
			{
				case 1: 
					personnage1Description = "Sorcière"; 
					break;
				case 2: 
					personnage1Description = "Robot"; 
					break;
				case 3: 
					personnage1Description = "Zombie"; 
					break;
				default: 
					Console.WriteLine(" erreur dans le switch du personnage"); 
					break;
			}

			switch (personnage2)
			{
				case 1: 
					personnage2Description = "Sorcière"; 
					break;
				case 2: 
					personnage2Description = "Robot"; 
					break;
				case 3: 
					personnage2Description = "Zombie"; 
					break;
				default: 
					Console.WriteLine(" erreur dans le switch du personnage"); 
					break;
			}

			switch (personnage3)
			{
				case 1: 
					personnage3Description = "Sorcière"; 
					break;
				case 2: 
					personnage3Description = "Robot"; 
					break;
				case 3: 
					personnage3Description = "Zombie"; 
					break;
				default: 
					Console.WriteLine(" erreur dans le switch du personnage"); 
					break;
			}

			Console.WriteLine($"Les trois personnages pigés sont {personnage1Description}, {personnage2Description} et {personnage3Description}");
		}
	}
}
