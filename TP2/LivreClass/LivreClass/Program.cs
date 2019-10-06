using System;

namespace LivreClass
{
    class Program
    {
        private ILivreClass livre;
        public Program(){
           livre = new LivreClass("Titre",
                "auteur", "description", 20.4);
        }

        public Program(ILivreClass livre){
            this.livre = livre;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("---------");
            
            foreach (string str in livre.PrintInfos())
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
