using Puissance4Correction.Moteur;
using Moq;
using Puissance4Correction.Players;
using Puissance4Correction.AireDeJeu;
using Xunit;

namespace Puissance4Correction.Tests
{
    public class MoteurJeuShould
    {
        private IMoteurJeu moteurJeu;
        private Mock<IJoueur> joueur1;
        private Mock<IJoueur> joueur2;
        private Mock<IPlateau> plateau;
        private Mock<IResolver> resolver;
        private const char joueur1Symbol = 'X';
        private const char joueur2Symbol = 'O';

        public MoteurJeuShould()
        {
            joueur1 = new Mock<IJoueur>();
            joueur2 = new Mock<IJoueur>();            
            plateau = new Mock<IPlateau>();            
            resolver = new Mock<IResolver>();
            moteurJeu = new MoteurJeu(joueur1.Object, joueur2.Object, plateau.Object, resolver.Object);
            joueur1.Setup(o => o.Symbole).Returns(joueur1Symbol);
            joueur2.Setup(o => o.Symbole).Returns(joueur2Symbol);
        }

        [Fact]
        public void ReturnJoueur1_WhenCallJoueur1()
        {
            Assert.Equal(joueur1.Object, moteurJeu.Joueur1);
        }

        [Fact]
        public void ReturnJoueur2_WhenCallJoueur2()
        {
            Assert.Equal(joueur2.Object, moteurJeu.Joueur2);
        }

        [Fact]
        public void PlayJoueur1_WhenCallJoueur1Joue()
        {
            const int colonne = 1;

            moteurJeu.Joueur1Joue(colonne);

            plateau.Verify(o => o.Joue(colonne - 1, joueur1Symbol));
        }

        [Fact]
        public void PlayJoueur2_WhenCallJoueur2Joue()
        {
            const int colonne = 1;

            moteurJeu.Joueur2Joue(colonne);

            plateau.Verify(o => o.Joue(colonne - 1, joueur2Symbol));
        }

        [Fact]
        public void ReturnFalseAndStringEmpty_WhenCallAiJeUnGagnant()
        {
            (bool winner, string winnerName) = moteurJeu.AiJeUnGagnant();
            Assert.False(winner);
            Assert.Equal(string.Empty, winnerName);
        }

        [Fact]
        public void ReturnTrueAndJoueur1_WhenCallAiJeUnGagnantAndJoueur1Win()
        {
            const string joueurName = "Joueur 1";
            this.resolver.Setup(o => o.JoueurGagne(joueur1Symbol, plateau.Object.Board))
                .Returns(true);
            this.joueur1.Setup(o => o.ToString())
                .Returns(joueurName);

            (bool winner, string winnerName) = moteurJeu.AiJeUnGagnant();
            Assert.True(winner);
            Assert.Equal(joueurName, winnerName);
        }

        [Fact]
        public void ReturnTrueAndJoueur2_WhenCallAiJeUnGagnantAndJoueur2Win()
        {
            const string joueurName = "Joueur 2";
            this.resolver.Setup(o => o.JoueurGagne(joueur1Symbol, plateau.Object.Board))
                .Returns(false);
            this.resolver.Setup(o => o.JoueurGagne(joueur2Symbol, plateau.Object.Board))
                .Returns(true);
            this.joueur2.Setup(o => o.ToString())
                .Returns(joueurName);

            (bool winner, string winnerName) = moteurJeu.AiJeUnGagnant();
            Assert.True(winner);
            Assert.Equal(joueurName, winnerName);
        }

        [Fact]
        public void ReturnPlateauToString_WhenCallToString()
        {
            const string plateau = "| | | |";
            this.plateau.Setup(o => o.ToString())
                .Returns(plateau);

            Assert.Equal(plateau, moteurJeu.ToString());
        }
    }
}
