namespace Puissance4.Moteur
{
    public interface IMoteurDeJeu
    {
        void Jouer(int colonneNumber);
        (bool,string) QuiAGagner();
        string QuiJoue();
        string Affichage();
    }
}