using System;
using System.Collections;

namespace Exercice_Collections_Bonus_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //A.introduit des températures tant que "OUI"
            //  1."Veuillez indiquer une temp"
            //  2."Veuillez indiquer l'unité"
            //  3.Sauver les valeurs dans une collections dont la taille peut varier (ArrayList)
            //  4."Voulez-vous introduire d'autre temp"
            //B.Lire les données de chaque temp.
            //  1.Afficher chaque temp.
            //  2.Si Fahrenheit => conversion
            //  3.Calculer une somme (addition de temp)
            //C. Afficher moyenne (somme/nbr éléments)

            ArrayList temps = new ArrayList();
            string ok = "non";
            do
            {
                Console.WriteLine("Veuillez indiquer une température :");
                double temp;
                while (!double.TryParse(Console.ReadLine(), out temp)) Console.WriteLine("Erreur de valeur, veuillz recommencer :");
                Console.WriteLine("Quel unité de mesure : C ou F ?");
                bool isCelsius;
                string input = Console.ReadLine().ToUpper();
                while (input != "C" && input != "F") {
                    Console.WriteLine("Erreur de valeur, veuillz recommencer :");
                    input = Console.ReadLine();
                }
                isCelsius = input == "C";
                object[] pair = { temp, isCelsius };
                temps.Add(pair);
                Console.WriteLine("Voulez-vous encoder d'autres données ? Tapez 'Oui' pour continuer.");
                ok = Console.ReadLine();
            } while (ok.ToLower() == "oui");

            double somme = 0;
            foreach (object[] temp in temps)
            {
                bool isCelsius = (bool)temp[1];
                Console.WriteLine($"{temp[0]}°{((isCelsius)?"C":"F")}");
                double value;
                //if (!isCelsius) value = ((double)temp[0] - 32) * (5 / 9D);
                //else value = (double)temp[0];
                value = (!isCelsius) ? ((double)temp[0] - 32) * (5 / 9D) : (double)temp[0];
                somme += value;
            }

            Console.WriteLine($"La moyenne de températures en Celsius est de {(somme/temps.Count):F2}°C.");
        }
    }
}
