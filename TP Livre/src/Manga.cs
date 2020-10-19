namespace Fnac
{
    public class Manga : Livre
    {
        public Manga(string auteur, string titre) : base(auteur, titre)
        {
            this.Prix = 6.5;
        }
    }
}