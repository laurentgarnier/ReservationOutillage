using System;
using System.Diagnostics;


namespace ResaTiama.Tests
{
    class Program
    {
        static void Main()
        {
            AfficherMenu();
        }

        static void AfficherMenu()
        {
            Console.Clear();
            Console.WriteLine("Application de test");
            Console.WriteLine("1 - Ajout de matériel");


            Console.WriteLine("Q - Quitter");
            Console.Write("Choix : ");
            ConsoleKeyInfo touche = Console.ReadKey();
            Console.WriteLine();

            switch (touche.Key)
            {
                case ConsoleKey.NumPad1: Console.WriteLine("Ajout de matériel");
                    AjouterMateriel();
                    break;
                case ConsoleKey.Q: Console.WriteLine("Quitter");
                    break;
                default: AfficherMenu();
                    break;
            }
            Console.ReadKey(); 
        }

        private static void AjouterMateriel()
        {
            
        }
    }
}
