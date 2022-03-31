using System;

namespace Exercice_Convertion_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, veuillez introduire un premier nombre :");
            ////string input = Console.ReadLine();
            ////int nb1 = int.Parse(input);
            int nb1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez introduire un second nombre :");
            ////input = Console.ReadLine();
            ////int nb2 = int.Parse(input);
            int nb2 = int.Parse(Console.ReadLine());
            int result = nb1 + nb2;
            Console.WriteLine($"{nb1}+{nb2}={result}");

            //Console.WriteLine($"Le resultat est : {int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine())}");
        }
    }
}
