namespace CompteClass{
    using System;
    using System.Globalization;

    public class Compte : ICompte{
        private static uint NumCompteCache = 0;
        private uint numeroCompte;
        protected double solde;
        public Compte() : this(0)
        {
        }

        public Compte(double soldeInitiale)
        {
            numeroCompte = NumCompteCache++;
            this.solde = soldeInitiale;
        }



        public virtual void Deposer(double montant)
        {
            solde += montant;
        }

        public virtual void Retirer(double montant)
        {
            solde -= montant;
        }


        public override string ToString ()
{
    string phrase = "votre solde est égal à : ";
    return(phrase + solde + " euros");
}
       

    }
}