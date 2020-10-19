using System;
using Puissance4.Player;

namespace Puissance4
{
    class Program
    {
        static void Main(string[] args)
        {
            IJoueur joueur1, joueur2;
            while (true)
            {
                Console.WriteLine("Bienvenu dans puissance 4");
                Console.WriteLine("Quel est le nom de joueur 1 ?");
                string joueur1Name = Console.ReadLine();
                joueur1 = new Joueur1(joueur1Name);
                Console.WriteLine("Quel est le nom de joueur 2 ?");
                string joueur2Name = Console.ReadLine();
                joueur2 = new Joueur2(joueur2Name);
                
                MoteurDeJeu moteur = new MoteurDeJeu(joueur1,joueur2);
                while (moteur.QuiAGagner() == string.Empty)
                {
                    //Afficher board
                    Console.WriteLine(moteur.Affichage());
                    // Affiche qui joue
                    Console.WriteLine($"{moteur.QuiJoue()} joue");
                    Console.WriteLine("Choisissez une colonne 1 à 7");
                    
                    //Joue
                    string numColonne = Console.ReadLine();
                    moteur.Jouer( int.Parse(numColonne));
                }
                Console.WriteLine($"{moteur.QuiAGagner()} a gagné");
                
                Console.WriteLine("Voulez-vous rejouez ? (y/N)");
                if (Console.ReadLine().ToLowerInvariant() != "y")
                    break;
            }
        }
    }
}
