using System;
using System.Text;

namespace Exercice_Operateurs_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez introduire votre BBAN :");
            string bban_input = Console.ReadLine();
            //long bban;
            if (bban_input.Length == 12 && long.TryParse(bban_input, out _))
            {
                string two_last = bban_input.Substring(10); //Equivalant à Substring(10,2)
                string code = string.Concat(two_last, two_last, 111400);
                //string code = $"{two_last}{two_last}111400";
                //string code = string.Format("{0}{0}111400",two_last);
                //string code = two_last + two_last + 111400;

                /*StringBuilder*/
                /*StringBuilder sb = new StringBuilder();
                sb.Append(two_last);
                sb.Append(two_last);
                sb.Append(111400);
                string code = sb.ToString();*/

                long be00 = long.Parse(code);
                short calcIBAN = (short)(98 - (be00 % 97));
                Console.WriteLine($"Votre compte BBAN : {bban_input}\na pour IBAN : BE{calcIBAN} {bban_input}");
            }
            else {
                Console.WriteLine("Code BBAN invalide...");
            }
        }
    }
}
