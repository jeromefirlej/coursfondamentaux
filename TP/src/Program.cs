using System;

namespace JeuDeLaVie
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            var table = new string[10, 10];
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j]=  r.Next(0,100) > 50 ?"v":"";
                }
            }
            var game = new Game(new []{2,3}, new[]{3});
            while (true)
            {
                Console.Clear();
                Console.WriteLine(game.Afficher(table));
                Console.ReadLine();
                table = game.Jouer(table);
            }
        }

        
    }
}
