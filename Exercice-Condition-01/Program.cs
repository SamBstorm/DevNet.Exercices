using System;

namespace Exercice_Condition_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour! Veux-tu bien introduire un nombre entier s'il te plait?");
            // Correct mais pas assez efficace, n'oubliez pas que l'utilisateur peut être un chimpanzé!
            //int nombre = int.Parse(Console.ReadLine());

            int nombre;
            bool nb_isOk = int.TryParse(Console.ReadLine(), out nombre);

            if (nb_isOk)
            {
                //Tout s'est bien passé, nombre est bien convertit
                int moitier = nombre / 2;
                if (moitier + moitier == nombre) Console.WriteLine($"Le nombre {nombre} est pair!");
                else Console.WriteLine($"Le nombre {nombre} est impair!");
            }
            else {
                //Rien ne s'est passé comme il faut, nombre est resté à sa valeur par défaut
                Console.WriteLine("Ceci n'est pas un nombre!");
            }

        }
    }
}
