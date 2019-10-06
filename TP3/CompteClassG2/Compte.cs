namespace CompteClass{
    using System;
    using System.Globalization;
    public class Compte{
        private static uint NumCompteCache = 0;
        private uint numeroCompte;
        protected double solde;
        public Compte() : this(0)
        {
            
        }

        public Compte(double soldeInitiale)
        {
            numeroCompte = NumCompteCache++;
            solde = soldeInitiale;
        }
        
        public virtual void Depot(double montant){
            solde += montant;
        }

        public virtual void Retrait(double montant){
            solde -= montant;
        }

        public override string ToString()
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("fr-FR");
            return "Votre solde est de :"+ solde.ToString("C", culture);
        }

    }
}