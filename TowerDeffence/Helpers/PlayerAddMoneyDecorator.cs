namespace TowerDeffence.Helpers
{
    using Interfaces;

    public class PlayerAddMoneyDecorator : PlayerDecorator
    {
        public PlayerAddMoneyDecorator(IPlayer player, double amount)
            : base(player)
        {
            Amount = amount;
        }

        protected double Amount { get; set; }

        public override double Money
        {
            get { return this.Player.Money + Amount; }
        }
    }
}
