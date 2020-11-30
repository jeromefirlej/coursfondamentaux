using System;

namespace Fnac
{
    class Program
    {
        static void Main(string[] args)
        {
            ILivre livre = new Livre("Philip K. Dick", "Blade Runner");
            IPanier panier = new Panier();
            for(int i = 0; i <5; i++)
            {
                panier.Livres.Add(livre);
            }
            
            ILivre manga = new Manga("???", "Naruto");
            panier.Livres.Add(manga);
            
            ILivre roman = new Roman("Philip K. Dick", "Minority Report");
            panier.Livres.Add(roman);
            
            ILivre comic = new Comic("Frank Miller", "Batman");
            panier.Livres.Add(comic);
            
            ILivre bd = new Bd("Mobius", "L'incal");
            panier.Livres.Add(bd);
            
            Console.WriteLine(panier.Affichage());
        }
    }
}
