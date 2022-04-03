using System;

namespace Exercice_Condition_Bonus01
{
    class Program
    {
        static Random RNG = new Random();
        static void Main(string[] args)
        {
            int cpu_choice = RNG.Next(1,4);
            Console.WriteLine("Pierre, Papier, Ciseaux!\nL'ordinateur va faire son choix, faîtes le votre :\n1) Pierre\n2) Papier\n3) Ciseaux");
            string input = Console.ReadLine();
            int player_choice;
            if (!int.TryParse(input, out player_choice)) Console.WriteLine("Choix non-valide...");
            else {
                Console.Write("CPU : ");
                switch (cpu_choice)
                {
                    case 1:
                        Console.Write("Pierre");
                        break;
                    case 2:
                        Console.Write("Papier");
                        break;
                    case 3:
                        Console.Write("Ciseaux");
                        break;
                }
                Console.Write(" - Votre choix : ");
                switch (player_choice)
                {
                    case 1:
                        Console.WriteLine("Pierre");
                        break;
                    case 2:   
                        Console.WriteLine("Papier");
                        break;
                    case 3:   
                        Console.WriteLine("Ciseaux");
                        break;
                }
                if (player_choice == cpu_choice) Console.WriteLine("Match null!");
                else if (player_choice - cpu_choice == -1 || player_choice - cpu_choice == 2) Console.WriteLine("Perdu");
                else Console.WriteLine("Gagné!");
            }
        }
    }
}
