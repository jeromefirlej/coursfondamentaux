using System;

namespace LivreClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel est le titre");
            var title = Console.ReadLine();

            IBook livre = new Book(title,"Moi-meme",12.00m);
            Console.WriteLine(livre.Afficher());
        }
    }
}
