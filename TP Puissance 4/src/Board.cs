using System;

namespace Puissance4
{
    public class Board
    {
        public Colonne[] Colonnes { get; }
        public  Board()
        {
            Colonnes = new[]
            {
                new Colonne(),
                new Colonne(),
                new Colonne(),
                new Colonne(),
                new Colonne(),
                new Colonne(),
                new Colonne(),
            };
        }

        public override string ToString()
        {
            string retour = string.Empty;
            for (int j = 5; j >= 0; j--)
            {
                foreach (var colonne in Colonnes)
                {
                    string affichage = string.IsNullOrEmpty(colonne.Lignes[j])? " ":colonne.Lignes[j];
                    Console.Write($"|{affichage}");
                }

                Console.WriteLine('|');
            }
           
            return retour;
        }
    }
}