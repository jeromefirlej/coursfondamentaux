namespace CompteClass{
    public class CompteEpargne:Compte{
        private double taux_interet = 0.06;


        public void Calcul_Interet()
        {
            solde=solde*taux_interet+solde;
        }
    }

    
}