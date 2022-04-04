using System;

namespace Exercice_Boucles_04
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int table = 1; table <= 5; table++)
            {
                for (int multiple = 1; multiple <= 20; multiple++)
                {
                    Console.Write($"{table}x{multiple}={multiple * table} ; ");
                }
                Console.WriteLine();
            }
        }
    }
}
