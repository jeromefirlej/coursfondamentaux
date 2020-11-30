namespace Fnac
{
    public class Bd : Livre
    {
        public Bd(string auteur, string titre) : base(auteur, titre)
        {
            this.Prix = 15;
        }
    }
}