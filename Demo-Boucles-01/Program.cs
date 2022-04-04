using System;

namespace Exercice_Boucles_01
{
    class Program
    {
        static void Main(string[] args)
        {

            //F0 : 0 , F1 : 1, F2 : F0+F1 1, F3 : F1+F2 2, ...., F25 : 75025
            int prev = 0, next = 1;
            Console.WriteLine("F0 : " + prev);
            Console.WriteLine("F1 : " + next);
            for (int i = 2; i <= 25; i++)
            {
                int result = prev + next;
                prev = next;
                next = result;
                Console.WriteLine($"F{i} : {next}");
            }
        }
    }
}
