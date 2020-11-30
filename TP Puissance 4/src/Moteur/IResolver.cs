using Puissance4.Plateau;

namespace Puissance4.Moteur
{
    public interface IResolver
    {
        bool JoueurGagne(string symbole, IBoard board);
    }
}