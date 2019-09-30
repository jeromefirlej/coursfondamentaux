using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace ManipulateurDeChaine
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] chaines = new []{
                "chaise",
                "étagère",
                "mulot",
                "moulus"
            };
           /* Console.WriteLine("TrierChaines");
            string[] chainesTriees = TrierChaines(chaines);
            foreach (string chaine in chainesTriees)
            {
                Console.WriteLine(chaine);
            }

            Console.WriteLine("Contients");
            string[] chainesFiltrees = Contients(
                chaines, 'u');
            foreach (string chaine in chainesFiltrees)
            {
                Console.WriteLine(chaine);
            } */

            Console.WriteLine("Contients");
            string[] chainesFiltrees2 = Contients(chaines, "ul");
            foreach (string chaine in chainesFiltrees2)
            {
                Console.WriteLine(chaine);
            }
        }
        private static string[] Contients(string[] chaines, string filtre)
        {
            string[] result = new String[chaines.Length];
            int i = 0;
            foreach (var chaine in chaines)
            {
                 Regex rx = new Regex(filtre);
                 if(rx.IsMatch(chaine)){
                    result[i] = chaine;
                    i++;
                 }
            }

            return result;
        }
        private static string[] Contients(string[] chaines, char filtre)
        {
            string[] result = new String[chaines.Length];
            int index = 0;
            for (int i = 0; i < chaines.Length; i++)
            {
                var chaine = chaines[i];
                if(chaine.Contains(filtre))
                {
                     result[index] = chaine;
                     index++;
                }
                /*for (int j = 0; j < chaine.Length; j++)
                {
                    if(chaine[j] == filtre){
                        result[index] = chaine;
                        index++;
                        break;
                    }
                }*/
            }
            return result;
        }

        public static List<string> TrierChaines(List<string> chaines){
            List<string> result = new List<string>();
            string[] workTable = chaines;
            //int i = chaines.Length - 1;
            for (int i = 0; i < chaines.Length; i++)
            {
                if(workTable.Length == 1)
                {
                    result.Add(workTable[0]);
                    break;
                }
                result[i] = PlusPetit(workTable);
                
                workTable = TableauMoinsPlusPetit(workTable, result[i]);
            }

            return result;
            /*while(!ToutEstTrier(chaines)){
                if(i >= 1 && 
                    chaines[i].Length < chaines[i-1].Length){
                    string tmp = chaines[i];
                    chaines[i] = chaines[i-1];
                    chaines[i-1] = tmp;
                }
                else {
                    i--;
                }
            }
            return chaines;*/
        }

        public static string[] TableauMoinsPlusPetit(string[] chaines, string plusPetit){
            string[] result = new string[chaines.Length - 1];
            int index = 0;
            for (int i = 0; i < chaines.Length; i++)
            {
                if(chaines[i] != plusPetit)
                {
                    result[index] = chaines[i];
                    index++;
                }
            }
            return result;
        }
        public static string PlusPetit(string[] chaines){
            string plusPetit = chaines[0];
            for (int i = 1; i < chaines.Length; i++)
            {
                if(chaines[i].Length < plusPetit.Length ){
                    plusPetit = chaines[i];
                }
            }
            return plusPetit;
        }
        public static bool ToutEstTrier(string[] chaines){
            int taille = chaines.Length;
            int[] tailles = new int[taille];
            for (int i = 0; i < taille; i++)
            {
                tailles[i] = chaines[i].Length;
            }

            for (int i = 0; i < taille; i++)
            {
                if(i < taille - 1 && tailles[i] > tailles[i+1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
