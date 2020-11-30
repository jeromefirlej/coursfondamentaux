namespace CompteClass{
    public class ComptePayant:Compte {
        
        public override void Retirer(double parametre){
            solde = solde - 5;
            base.Retirer(parametre);
        }

        public override void Deposer(double parametre)
        {
            solde = solde - 5;
            base.Deposer(parametre);
        }
    }
}