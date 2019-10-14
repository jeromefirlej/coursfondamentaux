using Puissance4Correction.Players;
using System;
using Xunit;

namespace Puissance4Correction.Tests
{
    public class Joueur1Should
    {
        [Fact]
        public void ReturnSymbolX()
        {
            Joueur1 joueur1 = new Joueur1();
            Assert.Equal('X', joueur1.Symbole);
        }

        [Fact]
        public void ReturnJoueur1_WhenCallToString()
        {
            Joueur1 joueur1 = new Joueur1();
            Assert.Equal("Joueur 1", joueur1.ToString());
        }

        [Fact]
        public void ReturnName_WhenCreateWithName_AndCallToString()
        {
            Joueur1 joueur1 = new Joueur1("Name");
            Assert.Equal("Name", joueur1.ToString());
        }
    }
}
