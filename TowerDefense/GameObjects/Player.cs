namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public class Player : GameObject, IPlayer
    {

        public Player(string name, int lives, double balance)
        {
            Lives = lives;
            Name = name;
            Money = balance;
        }

        public int Lives { get; protected set; }

        public string Name { get; set; }

        public double Money { get; protected set; }

    }
}
