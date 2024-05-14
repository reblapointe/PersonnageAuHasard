using System;

namespace PersonnageAuHasard
{
    class Program
    {
        const int NB_TYPES_PERSONNAGES = 3;

        public static void Main(string[] _)
        {
            Random generateur = new();
            int personnage1 = generateur.Next(NB_TYPES_PERSONNAGES);
            int personnage2 = generateur.Next(NB_TYPES_PERSONNAGES);
            int personnage3 = generateur.Next(NB_TYPES_PERSONNAGES);
            string personnage1Description = "", personnage2Description = "", personnage3Description = "";

            switch (personnage1)
            {
                case 0:
                    personnage1Description = "Sorcière";
                    break;
                case 1:
                    personnage1Description = "Robot";
                    break;
                case 2:
                    personnage1Description = "Zombie";
                    break;
                default:
                    personnage1Description = " erreur dans le switch du personnage";
                    break;
            }

            switch (personnage2)
            {
                case 0:
                    personnage2Description = "Sorcière";
                    break;
                case 1:
                    personnage2Description = "Robot";
                    break;
                case 2:
                    personnage2Description = "Zombie";
                    break;
                default:
                    personnage2Description = " erreur dans le switch du personnage";
                    break;
            }

            switch (personnage3)
            {
                case 0:
                    personnage3Description = "Sorcière";
                    break;
                case 1:
                    personnage3Description = "Robot";
                    break;
                case 2:
                    personnage3Description = "Zombie";
                    break;
                default:
                    personnage3Description = " erreur dans le switch du personnage";
                    break;
            }

            Console.WriteLine($"Les trois personnages pigés sont {personnage1Description}, {personnage2Description} et {personnage3Description}");
        }
    }
}
