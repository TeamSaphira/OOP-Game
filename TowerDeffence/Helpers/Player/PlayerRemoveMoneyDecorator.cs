namespace TowerDeffence.Helpers.Player
{
    using Interfaces;
    using System;

    public class PlayerRemoveMoneyDecorator : PlayerDecorator
    {
        public PlayerRemoveMoneyDecorator(IPlayer player, double amount)
            : base(player)
        {
            Amount = amount;
        }

        protected double Amount { get; set; }

        public override double Money
        {
            get
            {
                if (Amount > this.Player.Money)
                {
                    throw new InvalidOperationException("you can't take out more money than you have");
                }
                else if (Amount < 0)
                {
                    throw new InvalidOperationException("you can't enter a number less than zero");
                }
                return this.Player.Money - Amount; 
            }
        }
    }
}
