namespace TowerDeffence.Helpers.Player
{
    using System;

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
            get 
            {
                if (Amount < 0)
                {
                    throw new InvalidOperationException("you can't enter a number less than zero");
                }
                return this.Player.Money + Amount;
            }
        }
    }
}
