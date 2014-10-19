namespace TowerDeffence.Helpers
{
    using Interfaces;
    using System;

    public class PlayerRemoveMoneyDecorator : PlayerDecorator
    {
        public PlayerRemoveMoneyDecorator(IPlayer player, double differenceDecrease)
            : base(player)
        {
            DifferenceDecrease = differenceDecrease;
        }

        protected double DifferenceDecrease { get; set; }

        public override double Balance
        {
            get
            {
                if (DifferenceDecrease > this.Player.Balance)
                {
                    throw new InvalidOperationException("you can't take out more money than you have");
                }
                else if (DifferenceDecrease < 0)
                {
                    throw new InvalidOperationException("you can't enter a number less than zero");
                }
                return this.Player.Balance - DifferenceDecrease; 
            }
        }
    }
}
