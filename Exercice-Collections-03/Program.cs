using System;

namespace Exercice_Collections_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Récupération de 2 nombres à additioner
            //index a pour valeur la taille du tableau de caractères - 1
            //Tant que mon index est plus grand que 0
            //  Récupération de chiffres à l'index index de chaque nombre
            //  Addition des chiffres à l'index index chaque nombre
            //  Récupération des unités de la somme (résultat)
            //  Récupération des dizaines de la somme (report)
            //  index est décrémenté


            string nb1, nb2;
            bool tryNb;
            do
            {
                Console.WriteLine("Veuillez indiquer le premier nombre : ");
                nb1 = Console.ReadLine();
                tryNb = int.TryParse(nb1, out _);
            } while (!tryNb);


            do
            {
                Console.WriteLine("Veuillez indiquer le second nombre : ");
                nb2 = Console.ReadLine();
                tryNb = int.TryParse(nb2, out _);
            } while (!tryNb);

            if (nb1.Length < nb2.Length)
            {
                string temp = nb1;
                nb1 = nb2;
                nb2 = temp;
            }

            int diff = nb1.Length - nb2.Length;

            for (int i = 0; i < diff; i++)
            {
                nb2 = "0" + nb2;
            }

            char[] nbOne = nb1.ToCharArray();
            char[] nbTwo = nb2.ToCharArray();

            Console.WriteLine(nb1);
            Console.WriteLine(nb2);

            short report = 0;
            string resultFinal = "";
            for (int i = nbOne.Length - 1; i >= 0; i--)
            {                
                short chiffre1 = (short)(Convert.ToInt32(nbOne[i]) - 48);
                //short chiffre2 = (short)(nbTwo[i] - 48);
                short chiffre2 = short.Parse(nbTwo[i].ToString());
                short result = (short)(chiffre1 + chiffre2 + report);    //13
                report = (short)(result / 10);                  //1
                result = (short)(result % 10);                  //3
                resultFinal = result + resultFinal;
            }
            resultFinal = (report != 0) ? report + resultFinal : resultFinal;
            Console.WriteLine(resultFinal);
        }
    }
}
