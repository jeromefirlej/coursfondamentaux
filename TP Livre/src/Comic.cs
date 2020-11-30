namespace Fnac
{
    public class Comic : Livre
    {
        public Comic(string auteur, string titre) : base(auteur, titre)
        {
            this.Prix = 20;
        }
    }
}