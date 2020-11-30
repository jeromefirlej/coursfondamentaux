namespace CompteClass
{
    public interface ICompte
    {
        void Deposer(double montant);
        void Retirer(double montant);
    }

     public interface ICompteEpargne : ICompte
    {
       void Calcul_Interet();
        
    }
}