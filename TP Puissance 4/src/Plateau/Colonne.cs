using System;
using System.Collections.Generic;

namespace Puissance4
{
    public class Colonne : IColonne
    {
        //On utilise une pile plus simple pour gérer 
        public Queue<string> Lignes { get; }

        public Colonne()
        {
            Lignes = new Queue<string>();
        }
        
        public void Enqueue(string value)
        {
            if(Lignes.Count == 6)
                throw new ArgumentOutOfRangeException("La ligne est pleine");
            Lignes.Enqueue(value);
        }

        public string ShowValue(int index)
        {
            var colonne = Lignes.ToArray();
            return colonne.Length <= index ? " " : colonne[index];
        }
    }
}