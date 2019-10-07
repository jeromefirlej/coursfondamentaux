 namespace CompteClass{
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