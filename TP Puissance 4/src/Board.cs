using System;
using System.ComponentModel.DataAnnotations.Schema;

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

            for (int i = 0; i < Colonnes.Length; i++)
            {
                var colonne = Colonnes[i];

                for (int j = colonne.Lignes.Length - 1; j >= 0; j--)
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