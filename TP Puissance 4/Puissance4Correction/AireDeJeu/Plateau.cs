namespace Puissance4Correction.AireDeJeu
{
    public class Plateau : IPlateau
    {

        public IColonne[] Board { get; }

        public Plateau()
        {
            Board = new[]{
                new Colonne(),
                new Colonne(),
                new Colonne(),
                new Colonne(),
                new Colonne(),
                new Colonne(),
                new Colonne()
            };
        }

        public void Joue(int colonneId, char symbole)
        {
            Board[colonneId].Value.Enqueue(symbole);
        }

        public override string ToString()
        {
            string retour = string.Empty;

            for (int j = 0; j < 6; j++)
            {
                string line = string.Empty;
                for (int i = 0; i < Board.Length; i++)
                {
                    line += "|" + Board[i].ShowValue(j);
                }
                line += "|";
                retour = $"{line}\n{retour}";
            }
            return retour;
        }
    }

}