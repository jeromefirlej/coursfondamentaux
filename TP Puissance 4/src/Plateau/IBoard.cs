namespace Puissance4.Plateau
{
    public interface IBoard
    {
        IColonne[] Colonnes { get; }
        void Joue(int colonneId, string symbole);
    }
}