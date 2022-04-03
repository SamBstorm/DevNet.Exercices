/*Créez une application permettant de calculer un prix.
Pour se faire vous devez encoder : 
- un prix à la pièce
- une quantité
- un taux de tva

Vous devez aussi demander si il y a un code Promo:
- si non, vous donner le prix plein
- si oui, vous demander le code promo

Un code promo doit toujours correspondre à
"promo##" où les # corresponde à un chiffre.
Ce chiffre est le pourcentage de remise.
Pour le moment, tout pourcentage doit être multtiple de 5.*/
using System;

namespace Exercice_Operateurs_Bonus
{
    class Program
    {
        static void Main(string[] args)
        {

            string message = "";
            Console.Write("Bonjour, veuillez introduire le prix HTVA de votre article :");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double price))
            {
                Console.Write("Veuillez indiquer la quantité :");
                input = Console.ReadLine();
                if (int.TryParse(input, out int quantity))
                {
                    Console.Write("Veuillez introduire le taux de TVA :");
                    input = Console.ReadLine();
                    if (short.TryParse(input, out short tva))
                    {
                        double total = (price * quantity * (100 + tva)) / 100;
                        Console.WriteLine("Avez-vous un code promo?\n1)Oui\n2)Non");
                        input = Console.ReadLine();
                        if (input == "1")
                        {
                            Console.WriteLine("Indiquez votre code promo :");
                            input = Console.ReadLine();
                            if (input.Length == 7 && input.Substring(0, 5).ToUpper() == "PROMO")
                            {
                                if (short.TryParse(input.Substring(5, 2), out short percent) && percent % 5 == 0)
                                {
                                    total *= percent;
                                    total /= 100;
                                }
                                else message = $"Code promo invalide\n";
                            }
                            else message = $"Code promo invalide\n";
                        }
                        message += $"Veuillez payer {total}€";
                    }
                    else message = $"'{input}' n'est pas un taux de TVA valide.";
                }
                else message = $"'{input}' n'est pas une quantité valide.";
            }
            else message = $"'{input}' n'est pas un prix valide.";
            Console.WriteLine(message);
        }
    }
}
