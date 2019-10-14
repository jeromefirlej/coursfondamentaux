using Puissance4Correction.Players;

namespace Puissance4Correction.Moteur
{
    public interface IMoteurJeu
    {
        IJoueur Joueur1 { get; }
        IJoueur Joueur2 { get; }

        (bool, string) AiJeUnGagnant();
        void Joueur1Joue(int colonne);
        void Joueur2Joue(int colonne);
        string ToString();
    }
}