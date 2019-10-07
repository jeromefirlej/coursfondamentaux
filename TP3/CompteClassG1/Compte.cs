namespace CompteClass{
    using System;
    using System.Globalization;
    public class Compte{
        private static uint NumCompteCache = 0;
        private uint numeroCompte;
        protected double solde;
        public Compte(double soldeInitiale)
        {
            this.solde= soldeInitiale;
            numeroCompte = NumCompteCache++;
        }

        public Compte() : this(0){
        }

        public virtual double AjoutArgent(double ajout){
            return this.solde += ajout;
        }
        public virtual double RetraitArgent(double retrait){
            return this.solde -= retrait;
        }

        public override string ToString(){
            CultureInfo culture = CultureInfo.CreateSpecificCulture("fr-FR");
            return "votre solde est de :"+ solde.ToString("C",culture);
        }

    }
}