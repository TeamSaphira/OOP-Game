namespace TowerDeffence.Helpers
{
    using Interfaces;
    using System;

    public class PlayerAddMoneyDecorator : PlayerDecorator
    {
        public PlayerAddMoneyDecorator(IPlayer player, double differenceIncrease)
            : base(player)
        {
            DifferenceIncrease = differenceIncrease;
        }

        protected double DifferenceIncrease { get; set; }

        public override double Balance
        {
            get 
            {
                if (DifferenceIncrease < 0)
                {
                    throw new InvalidOperationException("you can't enter a number less than zero");
                }
                return this.Player.Balance + DifferenceIncrease;
            }
        }
    }
}
