using System;

namespace CompteClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i < 10000000; i++)
            {
                random.Next(1, 15);
            }
            Console.WriteLine($"le gagnant est l'éléve n°{random.Next(1, 15)}");

            Console.WriteLine("Création Compte");
            ICompte compte;

            Console.WriteLine("Cas comptes");
            compte = new Compte();
            compte.Deposer(100);
            Console.WriteLine(compte.ToString());
            compte.Retirer(10);
            Console.WriteLine(compte.ToString());

            Console.WriteLine("Cas comptes epargne");
            compte = new CompteEpargne();
            compte.Deposer(100);
            Console.WriteLine(compte.ToString());
            compte.Retirer(10);
            Console.WriteLine(compte.ToString());
            ((ICompteEpargne)compte).Calcul_Interet(); 
            Console.WriteLine(compte.ToString());

            Console.WriteLine("Cas comptes payant");
            compte = new ComptePayant();
            compte.Deposer(100);
            Console.WriteLine(compte.ToString());
            compte.Retirer(10);
            Console.WriteLine(compte.ToString());

           
        }
    }
}
