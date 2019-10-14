using Puissance4Correction.AireDeJeu;

namespace Puissance4Correction.Moteur
{
    public interface IResolver
    {
        bool JoueurGagne(char symbole, IColonne[] board);
    }
}