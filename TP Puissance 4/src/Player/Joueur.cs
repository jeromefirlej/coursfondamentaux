namespace Puissance4.Player
{
    public abstract class Joueur : IJoueur
    {
        public string Name { get; }
        public string Symbole { get; }
        protected Joueur(string name, string symbole)
        {
            this.Name = name;
            this.Symbole = symbole;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}