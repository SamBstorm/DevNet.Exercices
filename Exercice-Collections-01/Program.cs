using System;
using System.Collections;

namespace Exercice_Collections_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Connaitre le nombre maximal
            //2. je défini une valeur de 2 à un nombre à tester (car 1 n'est pas un nombre premier)
            //3. Tant que le nombre à tester est inférieur au maximum
            //  A. Définir un diviseur à 2
            //  B. Tant que le diviseur est plus petit ou égale que notre nombre à tester divisé par 2 et si je n'ai pas prouvé que ce n'est pas un nb Premier
            //      1. Si le nombre à teser est divisible par le diviseur (modulo)
            //          A. ce n'est pas un nb premier
            //      2. J'augmente de 1 le diviseur
            //  C. Si c'est un nombre premier ajouter à une liste (mémoriser)
            //  D. J'augmente de 1 le nombre à tester

            ArrayList nbList = new ArrayList();
            Console.WriteLine("Bonjour, veuillez introduire le nombre premier le plus élevé a retrouver :");
            int nbMax;
            while (!int.TryParse(Console.ReadLine(), out nbMax)) Console.WriteLine("Veuillez introduire une nombre entier :");

            //Même boucle, mais avec un do...while (Attention, le texte sera identique entre chaque itération) 
            //do { Console.WriteLine("Veuillez introduire le nombre premier le plus élevé a retrouver :"); } while (!int.TryParse(Console.ReadLine(), out nbMax));

            int nbTest = 2;
            while (nbTest <= nbMax)
            {
                int div = 2;
                bool isPrime = true;
                while (div <= (nbTest/2) && isPrime) {
                    if (nbTest % div == 0) isPrime = false;
                    div++;
                }
                if (isPrime) nbList.Add(nbTest);
                nbTest++;
            }

            foreach (int nbPrime in nbList)
            {
                Console.WriteLine(nbPrime);
            }
        }
    }
}
