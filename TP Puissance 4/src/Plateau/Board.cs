using System;

namespace Puissance4.Plateau
{
    public class Board : IBoard
    {
        public IColonne[] Colonnes { get; }
        public  Board()
        {
            Colonnes = new IColonne[]
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

            for (int j = 0; j < 6; j++)
            {
                string line = string.Empty;
                foreach (var colonne in Colonnes)
                {
                    line += "|" + colonne.ShowValue(j);
                }
                line += "|";
                retour = $"{line}\n{retour}";
            }
            return retour;
        }
        
        public void Joue(int colonneId, string symbole)
        {
            Colonnes[colonneId-1].Enqueue(symbole);
        }
    }
}