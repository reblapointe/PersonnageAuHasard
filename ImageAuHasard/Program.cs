using System;

namespace PersonnageAuHasard
{
    class Program
    {
		const int NB_TYPES_PERSONNAGES = 3;

        /// <summary>
        /// Retourne un personnage au hasard
        /// </summary>
        /// <returns>Un personnage au hasard</returns>
		static string DecrirePersonnage()
        {
            Random generateur = new Random();
            int personnage = generateur.Next(NB_TYPES_PERSONNAGES);
            string personnageDescription;
            switch (personnage)
            {
                case 0:
                    personnageDescription = "Sorcière";
                    break;
                case 1:
                    personnageDescription = "Robot";
                    break;
                case 2:
                    personnageDescription = "Zombie";
                    break;
                default:
                    personnageDescription = "Erreur dans le switch du personnage";
                    break;
            }
			return personnageDescription;
        }

        static void Main(string[] args)
        {
            string personnage1Description;
            string personnage2Description;
            string personnage3Description;

            personnage1Description = DecrirePersonnage();
            personnage2Description = DecrirePersonnage();
            personnage3Description = DecrirePersonnage();

            Console.WriteLine($"Les trois personnages pigés sont {personnage1Description}, {personnage2Description} et {personnage3Description}");
		}
	}
}
