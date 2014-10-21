namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public class Player : GameObject, IPlayer
    {

        public Player(string name, int lives, double balance)
        {
            this.Lives = lives;
            this.Name = name;
            this.Money = balance;
        }

        public int Lives { get; protected set; }

        public string Name { get; set; }

        public double Money { get; protected set; }

    }
}
