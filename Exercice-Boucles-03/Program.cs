﻿using System;

namespace Exercice_Boucles_03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Avec While
            //int limit;
            //Console.WriteLine("Indiquez le nombre de nombres premiers voulu (au minimum 1):");
            //while (!int.TryParse(Console.ReadLine(), out limit) || limit < 1)
            //{
            //    Console.WriteLine("Erreur veuillez entrer un autre nombre");
            //}

            //int cpt = 2;
            //int cptIsPrime = 0;
            //do
            //{
            //    bool isPrime = true;
            //    int buffer = cpt / 2;
            //    while (isPrime && buffer > 1)
            //    {
            //        if (cpt % buffer == 0) isPrime = false;
            //        buffer--;
            //    }
            //    if (isPrime)
            //    {
            //        Console.WriteLine(cpt);
            //        cptIsPrime++;
            //    }
            //    cpt++;
            //} while (cptIsPrime < limit); 
            #endregion
            #region Avec For
            int limit;
            Console.WriteLine("Indiquez le nombre de nombres premiers voulu (au minimum 1):");
            while (!int.TryParse(Console.ReadLine(), out limit) || limit < 1)
            {
                Console.WriteLine("Erreur veuillez entrer un autre nombre");
            }

            int cpt = 2;
            for (int cptIsPrime = 0; cptIsPrime < limit; cpt++)
            {
                bool isPrime = true;
                for (int buffer = cpt / 2; isPrime && buffer > 1; buffer--)
                {
                    if (cpt % buffer == 0) isPrime = false;
                }
                if (isPrime)
                {
                    Console.WriteLine(cpt);
                    cptIsPrime++;
                }
            }
            #endregion
        }
    }
}
