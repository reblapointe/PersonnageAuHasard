using System;

namespace PersonnageAuHasard
{
    class Program
    {
        public static void Main(string[] _)
        {
            string personnage1 = ChoisirPersonnage("premier");
            string personnage2 = ChoisirPersonnage("deuxième");
            string personnage3 = ChoisirPersonnage("troisième");

            Console.WriteLine($"Vos trois personnages sont {personnage1}, {personnage2} et {personnage3}");
        }

        /// <summary>
        /// Permet à l'utilisateur de choisir un type de personnage parmis une liste valide.
        /// </summary>
        /// <param name="position">Numérotation dupersonnage.</param>
        /// <returns>Un type de personnage validé.</returns>
        private static string ChoisirPersonnage(string position)
        {
            string personnage;
            bool personnageValide;
            do
            {
                personnageValide = true;
                Console.WriteLine("Quel est le type du " + position + " personnage? (R)obot, (S)orcière ou (Z)ombie?");
                personnage = Console.ReadLine() ?? string.Empty;
                personnage = personnage.ToUpper().Trim();
                switch (personnage)
                {
                    case "R":
                    case "ROBOT":
                        personnage = "Robot";
                        break;
                    case "Z":
                    case "ZOMBIE":
                        personnage = "Zombie";
                        break;
                    case "S":
                    case "SORCIÈRE":
                    case "SORCIERE":
                        personnage = "Sorcière";
                        break;
                    default:
                        Console.WriteLine(personnage + " n'est pas un personnage valide.");
                        personnageValide = false;
                        break;
                }
            } while (!personnageValide);
            return personnage;
        }
    }
}
