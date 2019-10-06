using System;
using System.Linq;
using System.Collections.Generic;

namespace ManipulationChaine
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] chaines = new []{
                "chaise",
                "étagère",
                "mulots",
                "moulus"
            };
            /*foreach(var value in TriChaine(chaines)){
                Console.WriteLine(value);
            }

            foreach(var value in ContientCaractere(chaines, 'u')){
                Console.WriteLine(value);
            }*/

            Console.WriteLine("Contients : ");
            foreach(var value in ContientCaracteres(chaines, "ul")){
                Console.WriteLine(value);
            }

            Console.WriteLine("Plus long");
            foreach(var value in PlusLong(chaines, "ul")){
                Console.WriteLine(value);
            }

        }
          public static List<string> PlusLong(string[] chaines, string valeur ){
            List<string> result = new List<string>();
            List<string> chainesFiltrees = ContientCaracteres(chaines, valeur);
            string[] chainesTriees = TriChaine(chainesFiltrees.ToArray());
            chainesTriees = chainesTriees.Reverse().ToArray();
            string maximum = chainesTriees[0];
            foreach (string chaine in chainesFiltrees)
            {
                if(chaine.Length >= maximum.Length)
                {
                    maximum = chaine;
                    result.Add(maximum);
                }
            }
            return result;
          }
        public static List<string> ContientCaracteres(string[] chaines, string valeur ){
            List<string> result = new List<string>();
            foreach (string chaine in chaines)
            {
                if(chaine.Contains(valeur)){
                    result.Add( chaine);
                }
            }
            return result;
        }
        public static string[] ContientCaractere(string[] chaines, char valeur ){
            string[] retour = new string[chaines.Length];
            int indice=0;
            for(int i = 0; i<chaines.Length;i++)
            {
                /*if(chaines[i].Contains(valeur))
                {
                    retour[indice]=chaines[i];
                    indice+=1;
                }*/
                foreach(char c in chaines[i])
                {
                    if (c==valeur)
                    {
                        retour[indice]=chaines[i];
                        indice+=1;
                        break;
                    }
                }
            }
            return retour;
        }

        
        public static string[] TriChaine(string[] chaines){
            string[] retour = new string[chaines.Length];
            string[] resteChaines = chaines;
            for(int i = 0; i < chaines.Length; i++){
                retour[i] = PlusPetit(resteChaines);
                bool siCasDeSortie = resteChaines.Length == 1;
                if(siCasDeSortie){
                    break;
                }
                resteChaines = RetrecirTableau(chaines, retour, resteChaines.Length);
            }
            return retour;
            chaines.OrderBy(chaine => chaine.Length);
        }
        public static string[] RetrecirTableau(string[] chaines, string[] retour, int grandeur){
            string[] resteChaines = new string[grandeur -1];
            int index = 0;
            foreach(string valeur in chaines){
                if(!Contients(retour, valeur)){
                    resteChaines[index] = valeur;
                    index += 1;
                }
            }
            return resteChaines;
        }
        public static bool Contients(string[] chaines, string valeur){
            foreach(string valeur2 in chaines){
                if(valeur2 == valeur)
                {
                    return true;
                }
            }
            return false;
        }
        public static string PlusPetit(string[] chaines){
            string plusPetit = chaines[0];
            for(int i= 1; i < chaines.Length;i++){
               if(chaines[i].Length < plusPetit.Length)
               {
                   plusPetit = chaines[i];
               }            
            }
            return plusPetit;
        }
    }
}
