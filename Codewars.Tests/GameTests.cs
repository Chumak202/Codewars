using CodeWars.Tasks;

namespace CodeWars.Tests
{
    public class GameTests
    {
        [TestCase]
        public void BasicTest1()
        {
            Game game = new Game();
            string shoal = "";
            Assert.AreEqual(1, game.fish(shoal));
        }

        [TestCase]
        public void BasicTest2()
        {
            Game game = new Game();
            string shoal = "0";
            Assert.AreEqual(1, game.fish(shoal));
        }

        [TestCase]
        public void BasicTest3()
        {
            Game game = new Game();
            string shoal = "6";
            Assert.AreEqual(1, game.fish(shoal));
        }

        [TestCase]
        public void BasicTest4()
        {
            Game game = new Game();
            string shoal = "1111";
            Assert.AreEqual(2, game.fish(shoal));
        }

        [TestCase]
        public void BasicTest5()
        {
            Game game = new Game();
            string shoal = "11112222";
            Assert.AreEqual(3, game.fish(shoal));
        }

        [TestCase]
        public void BasicTest6()
        {
            Game game = new Game();
            string shoal = "111122223333";
            Assert.AreEqual(4, game.fish(shoal));
        }

        [TestCase]
        public void BasicTest7()
        {
            Game game = new Game();
            string shoal = "111111111111";
            Assert.AreEqual(3, game.fish(shoal));
        }

        [TestCase]
        public void ExtraTest8()
        {
            Game game = new Game();
            string shoal = "111111111111111111112222222222";
            Assert.AreEqual(5, game.fish(shoal));
        }

        [TestCase]
        public void BasicTest9()
        {
            Game game = new Game();
            string shoal = "151128241212192113722321331";
            Assert.AreEqual(5, game.fish(shoal));
        }
    }
}