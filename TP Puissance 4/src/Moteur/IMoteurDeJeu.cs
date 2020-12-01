namespace Puissance4.Moteur
{
    public interface IMoteurDeJeu
    {
        void Jouer(int colonneNumber);
        (bool aGagner,string nomGagnant) QuiAGagner();
        string QuiJoue();
        string Affichage();
    }
}