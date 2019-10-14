namespace Puissance4Correction.AireDeJeu
{
    public interface IPlateau
    {
        IColonne[] Board { get; }        
        void Joue(int colonneId, char symbole);
        string ToString();
    }
}