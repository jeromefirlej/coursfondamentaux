using Puissance4.Plateau;

namespace Puissance4.Moteur
{
    public class Resolver : IResolver
    {
        public bool JoueurGagne(string symbole, IBoard board)
        {
            return GagneHorizontalement(symbole, board.Colonnes) ||
                GagneVerticalement(symbole, board.Colonnes) ||
                GagneDiagonaleDroite(symbole, board.Colonnes) ||
                GagneDiagonaleGauche(symbole, board.Colonnes);
        }

        private static bool GagneDiagonaleDroite(string symbole, IColonne[] board)
        {
            int count = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    int indexColonne = i;
                    int indexLigne = j;
                    while (indexColonne < 6 && indexLigne < board.Length)
                    {
                        count = NouvelleValeurCount(count, indexLigne, indexColonne, symbole, board);
                        if (count == 4)
                        {
                            return true;
                        }
                        indexLigne++;
                        indexColonne++;
                    }
                    count = 0;
                }
            }
            return false;
        }

        private static bool GagneDiagonaleGauche(string symbole, IColonne[] board)
        {
            int count = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    int indexColonne = i;
                    int indexLigne = j;
                    while (indexColonne < 6 && indexLigne >= 0)
                    {
                        count = NouvelleValeurCount(count, indexLigne, indexColonne, symbole, board);
                        if (count == 4)
                        {
                            return true;
                        }
                        indexLigne--;
                        indexColonne++;
                    }
                    count = 0;
                }
            }
            return false;
        }

        private static bool GagneVerticalement(string symbole, IColonne[] board)
        {
            int count = 0;
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    count = NouvelleValeurCount(count, i, j, symbole, board);
                    if (count == 4)
                    {
                        return true;
                    }
                }
                count =0;
            }
            return false;
        }

        private static bool GagneHorizontalement(string symbole, IColonne[] board)
        {
            int count = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    count = NouvelleValeurCount(count, j, i, symbole, board);
                    if (count == 4)
                    {
                        return true;
                    }
                }
                count = 0;
            }
            return false;
        }

        private static int NouvelleValeurCount(int count, int boardIndex, int colonneIndex, string symbole, IColonne[] board)
        {
            if (board[boardIndex].ShowValue(colonneIndex) == symbole)
            {
                return count + 1;
            }
            return 0;
        }
    }
}