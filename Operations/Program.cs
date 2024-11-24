using System;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclarations
            int choix = 1;
            float nb1 = 0, nb2 = 0;

            // boucle sur les choix du menu
            while (choix != 0)
            {
                // affichage du menu
                Console.WriteLine("Ajouter 2 nombres ............... 1");
                Console.WriteLine("Multiplier 2 nombres ............ 2");
                Console.WriteLine("Quitter ......................... 0");
                Console.Write("Votre choix :                     ");
                choix = int.Parse(Console.ReadLine());

                // saisie des nombres si "quitter" n'est pas choisi
                if (choix == 1 || choix == 2)
                {
                    Console.Write("Saisir le 1er nombre = ");
                    nb1 = float.Parse(Console.ReadLine());
                    Console.Write("Saisir le 2ème nombre = ");
                    nb2 = float.Parse(Console.ReadLine());
                }

                // traitement des choix du menu
                if (choix == 1)
                {
                    Console.WriteLine(nb1 + " + " + nb2 + " = " + (nb1 + nb2));
                }
                else
                {
                    if(choix == 2)
                    {
                        Console.WriteLine(nb1 + " x " + nb2 + " = " + (nb1 * nb2));
                    }
                }
            }
        }
    }
}
