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

        /// <summary>
        /// Détermine si une année est bissextile ou pas. Une année est bissextile si elle
        /// est divisible par 4 mais pas par 100, ou si elle est divisible par 400.
        /// </summary>
        /// <param name="annee">L'année</param>
        /// <returns>Vrai si l'année est bissextile, Faux sinon</returns>
        static bool Bissextile(int annee)
        {
            return annee % 4 == 0 && annee % 100 != 0 || annee % 400 == 0;
        }

        /// <summary>
        /// Détermine le nombre de jours dans un mois. 
        /// 
        /// Les mois de 30 jours sont 
        /// 4 (avril), 6 (juin), 9 (septembre) et 11 (novembre).
        /// 
        /// 2 (février) a 29 jour si l'année est bissextile, 28 sinon.
        /// 
        /// Les autres mois ont 31 jours.
        /// 
        /// Si un mois est invalide, la fonction retourne 31.
        /// </summary>
        /// <param name="mois">Le mois</param>
        /// <param name="annee">L'année</param>
        /// <returns>Le nombre de jours dans le mois de l'année demandée</returns>
        static int NombreJoursDansMois(int mois, int annee)
        {
            switch (mois)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    if (Bissextile(annee))
                        return 29;
                    else
                        return 28;
                default:
                    return 31;
            }
        }

        /// <summary>
        /// Détermine si une date est valide
        /// </summary>
        /// <param name="jour">jour</param>
        /// <param name="mois">mois</param>
        /// <param name="annee">annee</param>
        /// <returns>vrai si la date est une date valide dans le calendrier. Faux sinon</returns>
        static bool DateValide(int jour, int mois, int annee)
        {
            if (mois < 1 || mois > 12)
            {
                return false;
            }
            int nbJoursDansMois = NombreJoursDansMois(mois, annee);
            return 1 <= jour && jour <= nbJoursDansMois;
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

            do
            {
                Console.WriteLine("Entrez un jour, un mois et une année");
                bool valide = int.TryParse(Console.ReadLine(), out int jour);
                valide &= int.TryParse(Console.ReadLine(), out int mois);
                valide &= int.TryParse(Console.ReadLine(), out int annee);
                Console.Write($"{jour}/{mois}/{annee} ");
                if (valide && DateValide(jour, mois, annee))
                {
                    Console.WriteLine("est une date valide.");
                }
                else
                {
                    Console.WriteLine("n'est pas une date valide.");
                }
                Console.WriteLine("Voulez-vous recommencer? (O/n)");
            } while (Console.ReadLine().ToUpper() == "O");
        }
    }
}
