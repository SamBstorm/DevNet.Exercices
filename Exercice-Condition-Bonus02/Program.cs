using System;

namespace Exercice_Condition_Bonus02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez introduire des dimensions pour les côtés de votre triangle,");
            Console.Write("côté [AB] : ");
            string input = Console.ReadLine();
            int big_side;
            if (!int.TryParse(input, out big_side)) Console.WriteLine("Valeur invalide...");
            else
            {
                if (big_side == 0) Console.WriteLine("Triangle impossible...");
                else
                {
                    if (big_side < 0) big_side *= -1;
                    Console.Write("côté [BC] : ");
                    input = Console.ReadLine();
                    int second_side;
                    if (!int.TryParse(input, out second_side)) Console.WriteLine("Valeur invalide...");
                    else
                    {
                        if (second_side == 0) Console.WriteLine("Triangle impossible...");
                        else
                        {
                            if (second_side < 0) second_side *= -1;
                            if (second_side > big_side)
                            {
                                int temp = second_side;
                                second_side = big_side;
                                big_side = temp;
                            }
                            Console.Write("côté [CA] : ");
                            input = Console.ReadLine();
                            int third_side;
                            if (!int.TryParse(input, out third_side)) Console.WriteLine("Valeur invalide...");
                            else
                            {
                                if (third_side == 0) Console.WriteLine("Triangle impossible...");
                                else
                                {
                                    if (third_side < 0) third_side *= -1;
                                    if (third_side > big_side)
                                    {
                                        int temp = third_side;
                                        third_side = big_side;
                                        big_side = temp;
                                    }
                                    Console.WriteLine($"{big_side} - {third_side} - {second_side}");
                                    if (big_side > second_side + third_side) Console.WriteLine("Triangle impossible...");
                                    else
                                    {
                                        string side_type = "scalène";
                                        string angle_type = "accutanlge";
                                        if (big_side == second_side && big_side == third_side) side_type = "équilatéral";
                                        else if (big_side == second_side || big_side == third_side || second_side == third_side) side_type = "isocèle";
                                        if (big_side * big_side == (second_side * second_side) + (third_side * third_side)) angle_type = "rectangle";
                                        else if (big_side * big_side > (second_side * second_side) + (third_side * third_side)) angle_type = "obtusangle";
                                        Console.WriteLine($"Votre triangle est {side_type} {angle_type}.");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
