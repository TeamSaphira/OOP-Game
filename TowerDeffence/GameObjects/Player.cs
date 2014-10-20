namespace TowerDeffence.GameObjects
{
    using Interfaces;
    using System;

    public class Player : GameObject, IPlayer
    {
        private int lives;

        public Player(string name, int lives, double balance)
        {
            this.Lives = lives;
            this.Name = name;
            this.Money = balance;
        }

        public int Lives 
        {
            get
            {
                return this.lives;
            }
            protected set
            {
                this.lives = value;
            }
        }

        public string Name { get; protected set; }

        public double Money { get; protected set; }

    }
}
