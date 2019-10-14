using Puissance4Correction.AireDeJeu;
using Puissance4Correction.Moteur;
using Xunit;

namespace Puissance4Correction.Tests
{
    public class ResolverShould
    {
        private IResolver resolver;
        public ResolverShould()
        {
            resolver = new Resolver();
        }

        [Fact]
        public void ReturnFalse()
        {
            Assert.False(resolver.JoueurGagne('X', new[]{
                                                        new Colonne(),
                                                        new Colonne(),
                                                        new Colonne(),
                                                        new Colonne(),
                                                        new Colonne(),
                                                        new Colonne(),
                                                        new Colonne()
                                                    }));
        }

        [Fact]
        public void ReturnTrue_WhenHave4SameSymbolVerticaly()
        {
            var colonne = new Colonne();
            colonne.Enqueue('X');
            colonne.Enqueue('X');
            colonne.Enqueue('X');
            colonne.Enqueue('X');

            Assert.True(resolver.JoueurGagne('X', new[]{
                                                        colonne,
                                                        new Colonne(),
                                                        new Colonne(),
                                                        new Colonne(),
                                                        new Colonne(),
                                                        new Colonne(),
                                                        new Colonne()
                                                    }));
        }

        [Fact]
        public void ReturnTrue_WhenHave4SameSymbolHorizontal()
        {
            var colonne = new Colonne();
            colonne.Enqueue('X');

            Assert.True(resolver.JoueurGagne('X', new[]{
                                                        colonne,
                                                        colonne,
                                                        colonne,
                                                        colonne,
                                                        new Colonne(),
                                                        new Colonne(),
                                                        new Colonne()
                                                    }));
        }

        [Fact]
        public void ReturnTrue_WhenHave4SameSymbolDiagonalRight()
        {
            var colonne = new Colonne();
            colonne.Enqueue('X');

            var colonne2 = new Colonne();
            colonne2.Enqueue('O');
            colonne2.Enqueue('X');

            var colonne3 = new Colonne();
            colonne3.Enqueue('O');
            colonne3.Enqueue('O');
            colonne3.Enqueue('X');

            var colonne4 = new Colonne();
            colonne4.Enqueue('O');
            colonne4.Enqueue('O');
            colonne4.Enqueue('O');
            colonne4.Enqueue('X');

            Assert.True(resolver.JoueurGagne('X', new[]{
                                                        colonne,
                                                        colonne2,
                                                        colonne3,
                                                        colonne4,
                                                        new Colonne(),
                                                        new Colonne(),
                                                        new Colonne()
                                                    }));
        }

        [Fact]
        public void ReturnTrue_WhenHave4SameSymbolDiagonalLeft()
        {
            var colonne = new Colonne();
            colonne.Enqueue('X');

            var colonne2 = new Colonne();
            colonne2.Enqueue('O');
            colonne2.Enqueue('X');

            var colonne3 = new Colonne();
            colonne3.Enqueue('O');
            colonne3.Enqueue('O');
            colonne3.Enqueue('X');

            var colonne4 = new Colonne();
            colonne4.Enqueue('O');
            colonne4.Enqueue('O');
            colonne4.Enqueue('O');
            colonne4.Enqueue('X');

            Assert.True(resolver.JoueurGagne('X', new[]{
                                                        colonne4,
                                                        colonne3,
                                                        colonne2,
                                                        colonne,
                                                        new Colonne(),
                                                        new Colonne(),
                                                        new Colonne()
                                                    }));
        }

    }
}
