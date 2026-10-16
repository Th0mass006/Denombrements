using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {
            string choix = "1";
            int nbSousEnsemble = 0, total_element = 0;
            while (choix != "0")
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = Console.ReadLine();
                if (choix == "1" || choix == "2" || choix == "3")
                {
                    Console.Write("Nombre total d'éléments à gérer = ");
                    total_element = int.Parse(Console.ReadLine());
                    if (choix == "2" || choix == "3")
                    {
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        nbSousEnsemble = int.Parse(Console.ReadLine());
                    }

                }
                // switch permettant d'optimiser le code et éviter les if répétitif
                switch (choix)
                {
                    case "0":
                        { Environment.Exit(0); }
                        break;
                    case "1":
                        Console.WriteLine(Permutation(total_element));

                        break;
                    case "2":  
                        Console.WriteLine(Arrangement(total_element, nbSousEnsemble));
                        break;
                    case "3":
                        Console.WriteLine(Combinaison(total_element, nbSousEnsemble));
                        break;
                    default:
                        Console.WriteLine("Choix incorrect."); 
                        break;


                }
            }
            Console.ReadLine();


        }



        // Fonction permettant de calculer l'arangement
        static string Permutation(int total_element)
        {
            long r = 1;
            for (int k = 1; k <= total_element; k++)
            {
                r *= k;
            }

            return (total_element + "! = " + r);
        }
        
        // Fonction permettant de calculer l'arangement
        static string Arrangement(int total_element, int nbSousEnsemble)
        {
            long r = 1;
            for (int k = (total_element - nbSousEnsemble + 1); k <= total_element; k++)
            {
                r *= k;
            }
            return "A(" + total_element + "/" + nbSousEnsemble + ") = " + r;
        }
        
        
        // Fonction permettant de calculer la combinaison, éviter la surchage dans le main
        static string Combinaison(int total_element, int nbSousEnsemble)
        {
            // calcul de r1
            long r1 = 1;
            for (int k = (total_element - nbSousEnsemble + 1); k <= total_element; k++)
            {
                r1 *= k;
            }
            // calcul de r2
            long r2 = 1;
            for (int k = 1; k <= nbSousEnsemble; k++)
            {
                r2 *= k;
            }
            return ("C(" + total_element + "/" + nbSousEnsemble + ") = " + (r1 / r2));


        }
    }
} 

