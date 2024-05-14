using System;
using System.Diagnostics;

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

            // Solution date
            Console.WriteLine("Entrez un jour");
            bool dateValide = int.TryParse(Console.ReadLine() ?? string.Empty, out int jour);
            Console.WriteLine("Entrez un mois");
            dateValide &= int.TryParse(Console.ReadLine() ?? string.Empty, out int mois);
            Console.WriteLine("Entrez une annee");
            dateValide &= int.TryParse(Console.ReadLine() ?? string.Empty, out int annee);

            dateValide &= DateValide(jour, mois, annee);
            Console.WriteLine($"{jour}/{mois}/{annee} ");
            if (dateValide)
                Console.WriteLine("est valide.");
            else
                Console.WriteLine("n'est pas valide.");
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


        /// <summary>
        /// Détermine si l'année est bissextile ou non. Une année est bissextile si elle est divisible par
        /// 4 mais pas par 100, ou si elle est divisible par 400.
        /// </summary>
        /// <param name="annee">l'année</param>
        /// <returns>Vrai si année est bissextile, faux sinon.</returns>
        public static bool EstBissextile(int annee)
        {
            return annee % 4 == 0 && annee % 100 != 0 || annee % 400 == 0;
        }

        /// <summary>
        /// Retourne le nombre de jour dans un mois
        /// </summary>
        /// <param name="mois">Le mois</param>
        /// <param name="annee">L'année</param>
        /// <returns>28, 29, 30 ou 31, dépendemment du mois et de l'année. Si le mois est invalide, la fonction retourne 31.</returns>
        public static int NbJoursDansMois(int mois, int annee)
        {
            switch (mois)
            {
                case 2:
                    if (EstBissextile(annee))
                        return 29;
                    else
                        return 28;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                default:
                    return 31;
            }
        }

        /// <summary>
        /// Détermine si le trio jour/mois/année forme une date valide selon le calendrier.
        /// </summary>
        /// <param name="jour">Le jour</param>
        /// <param name="mois">Le mois</param>
        /// <param name="annee">L'année</param>
        /// <returns>Vrai si le trio forme une date valide, faux sinon</returns>
        public static bool DateValide(int jour, int mois, int annee)
        {
            return 1 <= mois && mois <= 12
                && 1 <= jour && jour <= NbJoursDansMois(mois, annee);
        }
    }
}
