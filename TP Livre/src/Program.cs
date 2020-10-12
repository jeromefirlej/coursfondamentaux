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

            Console.WriteLine(panier.Affichage());
        }
    }
}
