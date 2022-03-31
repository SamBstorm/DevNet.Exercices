using System;

namespace Exercice01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, veuillez renseigner votre nom :");
            string nom = Console.ReadLine();
            Console.WriteLine("Merci, et maintenant, renseignez votre prénom :");
            string prenom = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Bienvenue {nom} {prenom}!");
        }
    }
}
