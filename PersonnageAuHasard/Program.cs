using System;

namespace PersonnageAuHasard
{
    class Program
    {
        public static void Main(string[] _)
        {
            string personnage1;
            bool personnage1Valide;
            do
            {
                personnage1Valide = true;
                Console.WriteLine("Quel est le type du premier personnage? (R)obot, (S)orcière ou (Z)ombie?");
                personnage1 = Console.ReadLine() ?? string.Empty;
                personnage1 = personnage1.ToUpper().Trim();
                switch (personnage1)
                {
                    case "R":
                    case "ROBOT":
                        personnage1 = "Robot";
                        break;
                    case "Z":
                    case "ZOMBIE":
                        personnage1 = "Zombie";
                        break;
                    case "S":
                    case "SORCIÈRE":
                    case "SORCIERE":
                        personnage1 = "Sorcière";
                        break;
                    default:
                        Console.WriteLine(personnage1 + " n'est pas un personnage valide.");
                        personnage1Valide = false;
                        break;
                }
            } while (!personnage1Valide);



            string personnage2;
            bool personnage2Valide;
            do
            {
                personnage2Valide = true;
                Console.WriteLine("Quel est le type du deuxième personnage? (R)obot, (S)orcière ou (Z)ombie?");
                personnage2 = Console.ReadLine() ?? string.Empty;
                personnage2 = personnage2.ToUpper().Trim();
                switch (personnage2)
                {
                    case "R":
                    case "ROBOT":
                        personnage2 = "Robot";
                        break;
                    case "Z":
                    case "ZOMBIE":
                        personnage2 = "Zombie";
                        break;
                    case "S":
                    case "SORCIÈRE":
                    case "SORCIERE":
                        personnage2 = "Sorcière";
                        break;
                    default:
                        Console.WriteLine(personnage2 + " n'est pas un personnage valide.");
                        personnage2Valide = false;
                        break;
                }
            } while (!personnage2Valide);


            string personnage3;
            bool personnage3Valide;
            do
            {
                personnage3Valide = true;
                Console.WriteLine("Quel est le type du troisième personnage? (R)obot, (S)orcière ou (Z)ombie?");
                personnage3 = Console.ReadLine() ?? string.Empty;
                personnage3 = personnage3.ToUpper().Trim();
                switch (personnage3)
                {
                    case "R":
                    case "ROBOT":
                        personnage3 = "Robot";
                        break;
                    case "Z":
                    case "ZOMBIE":
                        personnage3 = "Zombie";
                        break;
                    case "S":
                    case "SORCIÈRE":
                    case "SORCIERE":
                        personnage3 = "Sorcière";
                        break;
                    default:
                        Console.WriteLine(personnage3 + " n'est pas un personnage valide.");
                        personnage3Valide = false;
                        break;
                }
            } while (!personnage3Valide);

            Console.WriteLine($"Vos trois personnages sont {personnage1}, {personnage2} et {personnage3}");
        }
    }
}
