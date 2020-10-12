using System;
using System.Collections.Generic;

namespace Fnac
{
    public class Panier : IPanier
    {
        public Panier()
        {
            Livres = new List<ILivre>();
        }
        public List<ILivre> Livres { get; set; }

        public double Total
        {
            get
            {
                double resultat = 0;
                foreach (ILivre livre in Livres)
                {
                    resultat += livre.Prix;
                }

                foreach (var livre in Livres)
                {
                    int nbAuteur = NbDeLivreDLAuteurDansLePanier(livre);
                    //Livres.Find(l => l.Auteur == livre.Auteur).Count >= 5
                    if (nbAuteur >= 5)
                    {
                        return resultat * 90 / 100;
                    }
                }
                
                // return Livres.Count >= 5 ? resultat * 95 / 100 : resultat;
                if (Livres.Count >= 5)
                {
                    return resultat * 95 / 100;
                }
                return resultat;
                //return livres.Sum(l => l.Prix);
            }
        }

        private int NbDeLivreDLAuteurDansLePanier(ILivre livre)
        {
            int nbAuteur = 0;
            foreach (var livre1 in Livres)
            {
                if (livre1.Auteur == livre.Auteur)
                {
                    nbAuteur++;
                }
            }
            return nbAuteur;
        }

        public string Affichage()
        {
            string monRetour = string.Empty;
            monRetour += "Mon panier contient :" + Environment.NewLine;
            foreach (Livre livre in Livres)
            {
                monRetour += livre.Affichage() + Environment.NewLine;
            }
            monRetour += $"total : {Total:C}";
            return monRetour;
        }
    }
}