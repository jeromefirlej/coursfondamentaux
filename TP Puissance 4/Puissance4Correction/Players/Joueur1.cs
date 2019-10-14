namespace Puissance4Correction.Players
{
    public class Joueur1 : Joueur
    {

        public Joueur1() : this("Joueur 1")
        {
        }

        public Joueur1(string name) : base('X')
        {
            this.name = name;
        }

    }
}