using System;

namespace Exercice_Convertion_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, veuillez introduire un premier nombre :");
            string input_01 = Console.ReadLine();
            int.TryParse(input_01, out int nb1);
            Console.WriteLine("Veuillez introduire un second nombre :");
            string input_02 = Console.ReadLine();
            int.TryParse(input_02, out int nb2);
            int result = nb1 + nb2;
            Console.WriteLine($"{nb1}+{nb2}={result}");
        }
    }
}
