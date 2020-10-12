using System;

namespace examples
{
    class Program
    {
        static void Main(string[] args)
        {
            string marque = "Bmw";
            IVoiture voiture = new Voiture(marque);

            //voiture.Marque = "totot";
            Console.WriteLine(voiture.Marque);
            
            Console.WriteLine(voiture.Claxonner());
        }
    }
}
