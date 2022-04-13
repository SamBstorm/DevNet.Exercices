using System;

namespace Exercice_Methode_02
{
    class Program
    {
        static void Main(string[] args)
        {
            EquationSecDeg eq;
            Console.WriteLine("Sachant que l'équation sera Ax² + Bx + C ,");
            Console.WriteLine("Veuillez introduire la valeur de A assigné à X² :");
            while (!double.TryParse(Console.ReadLine(), out eq.A)) Console.WriteLine("Veuillez ré-essayer");
            Console.WriteLine("Veuillez introduire la valeur de B assigné à X :");
            while (!double.TryParse(Console.ReadLine(), out eq.B)) Console.WriteLine("Veuillez ré-essayer");
            Console.WriteLine("Veuillez introduire la valeur de C assigné à l'unité supplémentaire :");
            while (!double.TryParse(Console.ReadLine(), out eq.C)) Console.WriteLine("Veuillez ré-essayer");

            if (eq.Resoudre(out double? x1, out double? x2)) {
                if (x1 == x2) Console.WriteLine($"L'équation {eq.A}x² + {eq.B}x + {eq.C} donne pour valeur à X : {x1}.");
                else Console.WriteLine($"L'équation {eq.A}x² + {eq.B}x + {eq.C} donne pour valeurs à X : {x1} ou {x2}.");
            }
            else Console.WriteLine($"L'équation {eq.A}x² + {eq.B}x + {eq.C} est impossible à résoudre...");
        }
    }
}
