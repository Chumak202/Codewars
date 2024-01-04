using CodeWars.Tasks;

namespace CodeWars.Tests
{
    public class GameTests
    {

        [TestCase]
        public void BasicTest1()
        {
            int[,] board = { { 1, 1, 0, 0, 0 },
                             { 1, 1, 0, 0, 0 },
                             { 0, 0, 0, 0, 0 },
                             { 0, 0, 0, 1, 1 },
                             { 0, 0, 0, 1, 1 } };
            Game game = new Game(board);
            Assert.AreEqual(game.play(), 2, "Should return '2'");
        }

        [TestCase]
        public void BasicTest2()
        {
            int[,] board = { { 1, 0, 1, 0, 1 },
                             { 1, 0, 1, 0, 1 },
                             { 1, 1, 1, 0, 0 },
                             { 0, 0, 0, 1, 1 },
                             { 0, 0, 0, 1, 1 } };
            Game game = new Game(board);
            Assert.AreEqual(3, game.play(), "Should return '3'");
        }

        [TestCase]
        public void BasicTest3()
        {
            int[,] board = { { 1, 0, 1, 0, 1 },
                             { 0, 1, 0, 1, 0 },
                             { 1, 0, 1, 0, 1 },
                             { 0, 1, 0, 1, 0 },
                             { 1, 0, 1, 0, 1 } };
            Game game = new Game(board);
            Assert.AreEqual(game.play(), 13, "Should return '13'");
        }

        [TestCase]
        public void BasicTest4()
        {
            int[,] board = { { 1, 0, 0, 0, 0 },
                             { 0, 0, 1, 1, 0 },
                             { 1, 0, 1, 0, 1 },
                             { 1, 1, 1, 1, 0 },
                             { 1, 1, 1, 0, 1 } };
            Game game = new Game(board);
            Assert.AreEqual(game.play(), 4, "Should return '4'");
        }
    }
}