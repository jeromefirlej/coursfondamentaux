using Puissance4.Plateau;
using Puissance4.Player;

namespace Puissance4.Moteur
{
    public class MoteurDeJeu : IMoteurDeJeu
    {
        private readonly IJoueur _joueur1;
        private readonly IJoueur _joueur2;
        private IBoard _board;
        private IJoueur _joueurCourant;
        private IResolver _resolver;
        
        public MoteurDeJeu(IJoueur joueur1, IJoueur joueur2)
        {
            _joueur1 = joueur1;
            _joueur2 = joueur2;
            _board = new Board();
            _joueurCourant = _joueur1;
            _resolver = new Resolver();
        }

        public void Jouer(int colonneNumber)
        {
            _board.Joue(colonneNumber, _joueurCourant.Symbole);
            _joueurCourant = _joueurCourant == _joueur1 ? _joueur2 : _joueur1;
        }

        public (bool aGagner,string nomGagnant) QuiAGagner()
        {
            if (_resolver.JoueurGagne(_joueur1.Symbole, _board))
            {
                return (true, _joueur1.ToString());
            }
            if (_resolver.JoueurGagne(_joueur2.Symbole, _board))
            {
                return (true, _joueur2.ToString());
            }
            return (false, "");
        }

        public string QuiJoue()
        {
            return _joueurCourant.ToString();
        }
        
        public string Affichage()
        {
            return _board.ToString();
        }
    }
}