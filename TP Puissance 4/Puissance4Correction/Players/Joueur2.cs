namespace Puissance4Correction.Players
{
    public class Joueur2 : Joueur
    {
        public Joueur2() : this("Joueur 2")
        {
        }

        public Joueur2(string name) : base('O')
        {
            this.name = name;
        }
    }
}