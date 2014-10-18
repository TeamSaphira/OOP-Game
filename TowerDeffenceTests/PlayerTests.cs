namespace TowerDeffenceTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TowerDeffence.Interfaces;
    using TowerDeffence.GameObjects;
    using TowerDeffence.Helpers;

    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void PlayerLivesDecorator()
        {
            IPlayer player = new Player("test", 1000, 5);
            player = new PlayerLivesDecorator(player);
            Assert.AreEqual(4, player.Lives);
        }

        [TestMethod]
        public void PlayerAddMoneyDecorator()
        {
            IPlayer player = new Player("test", 1000, 5);
            player = new PlayerAddMoneyDecorator(player, 500);
            Assert.AreEqual(1500, player.Money);
        }

        [TestMethod]
        public void PlayerRemoveMoneyDecorator()
        {
            IPlayer player = new Player("test", 1000, 5);
            player = new PlayerRemoveMoneyDecorator(player, 500);
            player = new PlayerRemoveMoneyDecorator(player, 400);
            Assert.AreEqual(100, player.Money);
        }
    }
}
