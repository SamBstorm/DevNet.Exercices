using System;

namespace Exercice_Boucles_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbFact;
            Console.WriteLine("Veuillez indiquer un nombre :");
            while (!int.TryParse(Console.ReadLine(), out nbFact)) {
                Console.WriteLine("Valeur non valide, veuillez entrer un nouveau nombre :");
            }

            long result = 1;
            for (int i = nbFact; i > 1 ; i--)
            {
                result *= i;
            }
            Console.WriteLine($"Le nombre factoriel de {nbFact} est {result}");


            //F6 = 6 * 5 * 4 * 3 * 2 
        }
    }
}
