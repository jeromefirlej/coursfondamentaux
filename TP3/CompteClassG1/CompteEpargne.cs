namespace CompteClass{
    using System;
    using System.Globalization;
    public class CompteEpargne : Compte{

        private double TauxInteret = 6;
        public double CalculInteret(){
            return (this.solde)*(1+(TauxInteret/100));
        }
        

    }

    public class ComptePayant :  Compte{

        private void Paiement(){
            this.solde -= 5;
        }
        public override double AjoutArgent(double ajout){
            Paiement();
            return base.AjoutArgent(ajout); 
            
        }
        public override double RetraitArgent(double retrait){
            Paiement();
            return base.RetraitArgent(retrait);
        }
        
        

    }

}


