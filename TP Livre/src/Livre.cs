namespace Fnac
{
    public class Livre: ILivre

    {
        // modifiable qu'à l'intérieur de la classe
        public string Auteur { get; internal set; }
        public string Titre { get; set; }
        
        // modifiable que dans le constructeur
        public double Prix { get; protected set; }

        public Livre(string auteur, string titre)
        {
            Auteur = auteur;
            Titre = titre;
            Prix = 15;
        }
        
        
        public string Affichage()
        {
            return $"{Titre} - {Auteur} - {Prix:C}";
        }
    }
}