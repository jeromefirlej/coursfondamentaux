using Puissance4Correction.Players;
using Xunit;

namespace Puissance4Correction.Tests
{
    public class Joueur2Should
    {
        [Fact]
        public void ReturnSymbolX()
        {
            Joueur2 joueur2 = new Joueur2();
            Assert.Equal('O', joueur2.Symbole);
        }

        [Fact]
        public void ReturnJoueur1_WhenCallToString()
        {
            Joueur2 joueur2 = new Joueur2();
            Assert.Equal("Joueur 2", joueur2.ToString());
        }

        [Fact]
        public void ReturnName_WhenCreateWithName_AndCallToString()
        {
            Joueur2 joueur2 = new Joueur2("Name");
            Assert.Equal("Name", joueur2.ToString());
        }
    }
}
