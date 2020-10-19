namespace Fnac
{
    public class Roman : Livre
    {
        public Roman(string auteur, string titre) : base(auteur, titre)
        {
            this.Prix = 5;
        }
    }
}