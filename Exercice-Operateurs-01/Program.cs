using System;

namespace Exercice_Operateurs_01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Version if imbriqués
            //int nb1, nb2;
            //Console.WriteLine("Bonjour, veuillez introduire un premier nombre :");
            //string input = Console.ReadLine();
            //if (!int.TryParse(input, out nb1)) Console.WriteLine($"'{input}' n'est pas un nombre...");
            //else
            //{
            //    Console.WriteLine("Ensuite, veuillez introduire un second nombre :");
            //    input = Console.ReadLine();
            //    if(!int.TryParse(input, out nb2)) Console.WriteLine($"'{input}' n'est pas un nombre...");
            //    else Console.WriteLine($"Nombre 1 : {nb1} - Nombre 2 : {nb2}\nDivision entière : {nb1 / nb2} | Modulo : {nb1 % nb2} | Division : {(float)nb1/nb2}");
            //} 
            #endregion

            #region Version if séparé
            int nb1 = 0, nb2 = 0;
            bool isOk = true;
            Console.WriteLine("Bonjour, veuillez introduire un premier nombre :");
            string input = Console.ReadLine();
            isOk = int.TryParse(input, out nb1);
            if (isOk)
            {
                Console.WriteLine("Ensuite, veuillez introduire un second nombre :");
                input = Console.ReadLine();
                isOk = int.TryParse(input, out nb2);
            }

            if (!isOk) Console.WriteLine($"'{input}' n'est pas un nombre...");
            else Console.WriteLine($"Nombre 1 : {nb1} - Nombre 2 : {nb2}\nDivision entière : {nb1 / nb2} | Modulo : {nb1 % nb2} | Division : {(float)nb1 / nb2}"); 
            #endregion
        }
    }
}
