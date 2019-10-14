namespace Puissance4Correction.Moteur
{
    using Players;
    using Puissance4Correction.AireDeJeu;
    using System;

    public class MoteurJeu : IMoteurJeu
    {
        public IJoueur Joueur1 { get; private set; }
        public IJoueur Joueur2 { get; private set; }
        private int turn = 0; 

        private readonly IPlateau plateau;
        private readonly IResolver resolver;

        public MoteurJeu()
        {
            Joueur1 = new Joueur1();
            Joueur2 = new Joueur2();
            plateau = new Plateau();
            resolver = new Resolver();
        }

        public MoteurJeu(string joueur1, string joueur2)
        {
            Joueur1 = new Joueur1(joueur1);
            Joueur2 = new Joueur2(joueur2);
            plateau = new Plateau();
            resolver = new Resolver();
        }

        public MoteurJeu(IJoueur joueur1, IJoueur joueur2, IPlateau plateau, IResolver resolver)
        {
            Joueur1 = joueur1;
            Joueur2 = joueur2;
            this.plateau = plateau;
            this.resolver = resolver;
        }

        public void Joueur1Joue(int colonne)
        {
            turn++;
            plateau.Joue(colonne - 1, Joueur1.Symbole);
        }

        public void Joueur2Joue(int colonne)
        {
            turn++;
            plateau.Joue(colonne - 1, Joueur2.Symbole);
        }

        public (bool, string) AiJeUnGagnant()
        {
            if (resolver.JoueurGagne(Joueur1.Symbole, plateau.Board))
            {
                return (true, Joueur1.ToString());
            }
            if (resolver.JoueurGagne(Joueur2.Symbole, plateau.Board))
            {
                return (true, Joueur2.ToString());
            }
            return (false, "");
        }

        public override string ToString()
        {
            if(turn > 46){
                throw new Exception("Personne n'a gagné");
            }
            return plateau.ToString();
        }
    }
}