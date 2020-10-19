using Puissance4.Player;

namespace Puissance4
{
    public class MoteurDeJeu : IMoteurDeJeu
    {
        private readonly IJoueur _joueur1;
        private readonly IJoueur _joueur2;
        private Board _board;
        
        public MoteurDeJeu(IJoueur joueur1, IJoueur joueur2)
        {
            _joueur1 = joueur1;
            _joueur2 = joueur2;
            _board = new Board();
        }

        public void Jouer(int colonneNumber)
        {
            
        }

        public string QuiAGagner()
        {
            return "";
        }

        public string QuiJoue()
        {
            return _joueur1.ToString();
        }
        
        public string Affichage()
        {
            return _board.ToString();
        }
    }
}