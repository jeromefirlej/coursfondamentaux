using System.Collections.Generic;

namespace Puissance4Correction.AireDeJeu
{
    public interface IColonne
    {
        Queue<char> Value { get; }
        void Enqueue(char value);
        char ShowValue(int index);
    }
}