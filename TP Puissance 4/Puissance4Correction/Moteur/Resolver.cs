namespace Puissance4Correction.Moteur
{
    using Puissance4Correction.AireDeJeu;

    public class Resolver : IResolver
    {
        public bool JoueurGagne(char symbole, IColonne[] board)
        {
            return GagneHorizontalement(symbole, board) ||
                GagneVerticalement(symbole, board) ||
                GagneDiagonaleDroite(symbole, board) ||
                GagneDiagonaleGauche(symbole, board);
        }

        private static bool GagneDiagonaleDroite(char symbole, IColonne[] board)
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
                }
            }
            return false;
        }

        private static bool GagneDiagonaleGauche(char symbole, IColonne[] board)
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
                }
            }
            return false;
        }

        private static bool GagneVerticalement(char symbole, IColonne[] board)
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
            }
            return false;
        }

        private static bool GagneHorizontalement(char symbole, IColonne[] board)
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
            }
            return false;
        }

        private static int NouvelleValeurCount(int count, int boardIndex, int colonneIndex, char symbole, IColonne[] board)
        {

            if (board[boardIndex].ShowValue(colonneIndex) == symbole)
            {
                return count + 1;
            }
            return 0;
        }
    }
}
