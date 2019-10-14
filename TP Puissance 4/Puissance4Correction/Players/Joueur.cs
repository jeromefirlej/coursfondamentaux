namespace Puissance4Correction.Players
{
    public abstract class Joueur : IJoueur
    {
        public char Symbole { get; private set; }
        protected string name;
        public Joueur(char symbole)
        {
            this.Symbole = symbole;
        }


        public override string ToString()
        {
            return name;
        }
    }
}