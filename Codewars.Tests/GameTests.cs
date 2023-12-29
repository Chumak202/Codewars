using CodeWars.Tasks;

namespace CodeWars.Tests
{
    public class GameTests
    {

        [TestCase]
        public void BasicTest1()
        {
            Game game = new Game(2);
            List<int> original = new List<int> { 1, 3, 4 };
            List<int> result = new List<int> { 1, 3, 4, 6 };
            CollectionAssert.AreEqual(result, game.play(original));
        }

        [TestCase]
        public void BasicTest2()
        {
            Game game = new Game(2);
            List<int> original = new List<int> { 7, 9, 12 };
            List<int> result = new List<int> { 7, 9, 10, 12 };
            CollectionAssert.AreEqual(result, game.play(original));
        }

        [TestCase]
        public void BasicTest3()
        {
            Game game = new Game(2);
            List<int> original = new List<int> { 1, 2, 3, 4, 5, 8, 10, 11, 12 };
            List<int> result = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            CollectionAssert.AreEqual(result, game.play(original));
        }

        [TestCase]
        public void BasicTest4()
        {
            Game game = new Game(2);
            List<int> original = new List<int> { };
            List<int> result = new List<int> { };
            CollectionAssert.AreEqual(result, game.play(original));
        }

        [TestCase]
        public void BasicTest5()
        {
            Game game = new Game(4);
            List<int> original = new List<int> { 20, 21, 24, 26, 33, 34, 35, 38, 39 };
            List<int> result = new List<int> { 20, 21, 24, 25, 26, 29, 30, 33, 34, 35, 38, 39 };
            CollectionAssert.AreEqual(result, game.play(original));
        }
    }
}