namespace Puissance4
{
    using System.Collections.Generic;
    public interface IColonne
    {
        Queue<string> Lignes { get; }
        void Enqueue(string value);
        string ShowValue(int index);
    }
}