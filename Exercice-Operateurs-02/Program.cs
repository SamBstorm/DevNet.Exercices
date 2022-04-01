using System;

namespace Exercice_Operateurs_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenu, veuillez introduire un code BBAN à 12 chiffres :");
            string bban = Console.ReadLine();               //0123 4567 8912
            if (bban.Length == 12)
            {
                string bban_ten_first = bban.Substring(0, 10);   //0123 4567 89
                string bban_two_last = bban.Substring(10, 2);    //12
                long ten_number;
                if (long.TryParse(bban_ten_first, out ten_number)) {
                    short two_number;
                    if (short.TryParse(bban_two_last, out two_number))
                    {
                        short check_value = (short)(ten_number % 97);
                        if (check_value == two_number || (check_value == 0 && two_number == 97)) Console.WriteLine("OK");
                        else Console.WriteLine("KO");
                    }
                    else Console.WriteLine("Code invalide");
                }
                else {
                    Console.WriteLine("Code invalide");
                }
            }
            else
            {
                Console.WriteLine("Il n'y a pas 12 chiffres dans votre code...");
            }

        }
    }
}
