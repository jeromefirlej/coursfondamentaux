using System.Collections.Generic;

namespace Puissance4Correction.AireDeJeu
{
    public class Colonne : IColonne
    {
        public Queue<char> Value { get; private set; }

        public Colonne()
        {
            Value = new Queue<char>();
        }

        public void Enqueue(char value)
        {
            Value.Enqueue(value);
        }

        public char ShowValue(int index)
        {
            var colonne = Value.ToArray();
            return colonne.Length <= index ? ' ' : colonne[index];
        }
    }
}
