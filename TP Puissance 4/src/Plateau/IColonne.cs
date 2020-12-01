namespace Puissance4
{
    public interface IColonne
    {
        void Enqueue(string value);
        string ShowValue(int index);
    }
}