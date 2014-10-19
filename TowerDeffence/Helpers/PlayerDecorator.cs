namespace TowerDeffence.Helpers
{
    using System;

    using Interfaces;
    using GameObjects;


    public abstract class PlayerDecorator : IPlayer
    {
        public PlayerDecorator(IPlayer player)
        {
            this.Player = player;
        }

        public IPlayer Player { get; private set; }

        public virtual double Balance
        {
            get { return this.Player.Balance; }
        }

        public virtual int Lives
        {
            get { return this.Player.Lives; }
        }
        //public int ReduceLife(int reduce)
        //{
        //    if (reduce > this.Player.Lives)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        return this.Player.Lives - reduce;
        //    }
        //}

        //public double IncreaseMoney(double differenceIncrease)
        //{
        //    if (differenceIncrease < 0)
        //    {
        //        throw new FormatException("you can't enter a number less than zero");
        //    }
        //    return this.Player.Balance + differenceIncrease;
        //}

        //public double DecreaseMoney(double differenceDecrease)
        //{
        //    if (differenceDecrease > this.Player.Balance.Money)
        //    {
        //        throw new FormatException("you can't take out more money than you have");
        //    }
        //    else if (differenceDecrease < 0)
        //    {
        //        throw new FormatException("you can't enter a number less than zero");
        //    }
        //    return this.Player.Balance.Money - differenceDecrease;
        //}

        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    }
}
