namespace TowerDeffence.Helpers
{
    using Interfaces;

    public class PlayerRemoveMoneyDecorator : PlayerAddMoneyDecorator
    {
        public PlayerRemoveMoneyDecorator(IPlayer player, double amount)
            : base(player, amount)
        {
            
        }

        public override double Money
        {
            get { return Player.Money - Amount; }
        }
    }
}
