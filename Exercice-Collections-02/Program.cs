using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Exercice_Collections_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Connaitre le nombre maximal de nombre premier à afficher
            //2. je défini une valeur de 2 à un nombre à tester (car 1 n'est pas un nombre premier)
            //3. Tant que le nombre de valeur dans ma liste est inférieur au maximum
            //  A. Définir un diviseur à 2
            //  B. Tant que le diviseur est plus petit ou égale que notre nombre à tester divisé par 2 et si je n'ai pas prouvé que ce n'est pas un nb Premier
            //      1. Si le nombre à teser est divisible par le diviseur (modulo)
            //          A. ce n'est pas un nb premier
            //      2. J'augmente de 1 le diviseur
            //  C. Si c'est un nombre premier ajouter à une liste (mémoriser)
            //  D. J'augmente de 1 le nombre à tester

            Stopwatch chrono = new Stopwatch();
            int limit;
            Console.WriteLine("Veuillez indiquer le nombre de nombre premier à retrouver :");
            while (!int.TryParse(Console.ReadLine(), out limit) || limit < 1) Console.WriteLine("Nombre invalide, recommencez!");
            chrono.Start();

            List<int> primes = new List<int>();
            primes.Add(2);
            int cpt = 0;
            for (int nbTest = primes[0]+1; primes.Count < limit; nbTest++)
            {
                bool isPrime = true;
                double sqrt = Math.Sqrt(nbTest);
                for (int i = 0; primes[i] <= sqrt && isPrime; i++)
                {
                    if (nbTest % primes[i] == 0) isPrime = false;
                    cpt++;
                }
                if (isPrime) primes.Add(nbTest);
            }

            foreach (int prime in primes)
            {
                Console.WriteLine(prime);
            }
            Console.WriteLine(cpt);
            chrono.Stop();
            Console.WriteLine(chrono.ElapsedTicks);
        }
    }
}
