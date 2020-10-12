namespace Fnac
{
    public interface ILivre
    {
        string Titre { get; set; }
        string Auteur { get; }
        double Prix { get; }
        string Affichage();
    }
}