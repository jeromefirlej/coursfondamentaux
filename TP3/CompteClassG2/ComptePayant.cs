namespace CompteClass{
    public class ComptePayant : Compte{
        public override void Retrait(double montant){
            base.Retrait(montant);
           CoutOperation();
        }
        
        public override void Depot(double montant){
            base.Depot(montant);
            CoutOperation();
        }

        private void CoutOperation(){
            solde -=5;
        }
    }
}