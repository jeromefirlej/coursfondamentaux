using Puissance4Correction.Moteur;
using System;

namespace Puissance4Correction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Nom du Joueur 1 :");
            //string joueur1 = Console.ReadLine();
            //Console.WriteLine("Nom du Joueur 2 :");
            //string joueur2 = Console.ReadLine();
            IMoteurJeu moteurJeu = new MoteurJeu();
            try{
                while (true)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Board");
                    Console.WriteLine(moteurJeu.ToString());

                    Console.WriteLine("------------------------------");
                    (bool unGagnant, string nomGagnant) = moteurJeu.AiJeUnGagnant();
                    if (unGagnant)
                    {
                        Console.WriteLine($"{nomGagnant} a gagné");
                        break;
                    }

                    Console.WriteLine($"{moteurJeu.Joueur1.ToString()} joue :");
                    var coup = int.Parse(Console.ReadLine());
                    moteurJeu.Joueur1Joue(coup);

                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Board");
                    Console.WriteLine(moteurJeu.ToString());
                    (unGagnant, nomGagnant) = moteurJeu.AiJeUnGagnant();
                    if (unGagnant)
                    {
                        Console.WriteLine($"{nomGagnant} a gagné");
                        break;
                    }
                    Console.WriteLine("------------------------------");
                    Console.WriteLine($"{moteurJeu.Joueur2.ToString()} joue :");
                    coup = int.Parse(Console.ReadLine());
                    moteurJeu.Joueur2Joue(coup);
                }
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
