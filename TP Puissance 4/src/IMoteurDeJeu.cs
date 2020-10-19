namespace Puissance4
{
    public interface IMoteurDeJeu
    {
        void Jouer(int colonneNumber);
        string QuiAGagner();
        string QuiJoue();
        string Affichage();
    }
}