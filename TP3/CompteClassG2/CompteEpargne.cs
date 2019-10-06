namespace CompteClass{
    public class CompteEpargne : Compte{
        private int tauxInteret;

        public CompteEpargne(): this(0){

        }
        public CompteEpargne(double soldeInitiale) 
        : this(soldeInitiale, 6){
        }

        public CompteEpargne(double soldeInitiale, int tauxInteret) 
        : base(soldeInitiale){
            this.tauxInteret = tauxInteret;
        }

        public void calculInteret(){
            solde += (solde * tauxInteret)/100; 
        }
    }
}