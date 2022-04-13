using System;

namespace Exercice_Enumeration_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Carte[] deck = new Carte[52];

            /*Pas possible de changer les valeurs de la structure dans un foreach...*/
            //foreach (Carte carte in deck)
            //{
            //    carte.couleur = Couleurs.Treffle;
            //    carte.valeur = Valeurs.As;
            //}
            int i = 0;
            foreach (string couleurName in Enum.GetNames(typeof(Couleurs)))
            {
                //Couleurs couleurEnum = (Couleurs)Enum.Parse(typeof(Couleurs), couleur);
                Couleurs couleurEnum = Enum.Parse<Couleurs>(couleurName);
                foreach (string valeurName in Enum.GetNames(typeof(Valeurs)))
                {
                    Valeurs valeurEnum = Enum.Parse<Valeurs>(valeurName);
                    deck[i].valeur = valeurEnum;
                    deck[i].couleur = couleurEnum;
                    i++;
                }
            }

            //for (int i = 0; i < deck.Length; i++)
            //{
            //    deck[i].couleur = (Couleurs)(i % 4);
            //    deck[i].valeur = (Valeurs)((i % 13)+2);
            //}

            foreach (Carte carte in deck)
            {
                Console.WriteLine($"{carte.couleur} - {carte.valeur}");
            }
        }
    }
}
