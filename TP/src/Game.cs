namespace JeuDeLaVie
{
    using System.Linq;
    public class Game{
        private readonly int[] aliveCase;

        private readonly int[] LeaveCase;

        public Game(int[] leaveCase, int[] aliveCase){
            LeaveCase = leaveCase;
            this.aliveCase = aliveCase;
        }
        public string Afficher(string[,] table)
        {
            string retour = string.Empty;
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    retour += (string.IsNullOrEmpty(table[i, j]) ? " " : table[i, j]) + "|";
                }
                retour += "\n";
            }

            return retour;
        }

        public string[,] Jouer(string[,] table)
        {
            string[,] tableRetour = new string[table.GetLength(0), table.GetLength(1)];
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    tableRetour[i,j] = table[i, j] == "v" ? TraiterVivant(table,i,j) : TraiterMort(table,i,j);
                }
            }
            return tableRetour;
        }

        private string TraiterVivant(string[,] table, int x, int y){
            return resteVivante(table, x, y)? "v":"";
        }

         private string TraiterMort(string[,] table, int x, int y){
            return devientVivante(table, x, y)? "v":"";
        }

        private bool resteVivante(string[,] table, int x, int y)
        {
            int voisinVivant = NombreVivants(table, x, y);
            return LeaveCase.Any(c => c == voisinVivant);
        }

        private string GetValue(string[,] table, int x, int y)
        {
            if (x >= 0 && x < table.GetLength(0) && y >= 0 && y < table.GetLength(1))
                return table[x, y];
            return "";
        }
        private bool devientVivante(string[,] table, int x, int y)
        {
            int voisinVivant = NombreVivants(table, x, y);

            return aliveCase.Any(c => c == voisinVivant);
        }

        private int NombreVivants(string[,] table, int x, int y)
        {
            int voisinVivant = 0;
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (GetValue(table, i, j) == "v" && !(i == x && j == y))
                    {
                        voisinVivant++;
                    }
                }
            }
            return voisinVivant;
        }
    }
}