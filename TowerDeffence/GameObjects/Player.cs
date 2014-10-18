namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public class Player : GameObject, IPlayer
    {
        public Player(string name, double money, int lives)
        {
            Name = name;
            Money = money;
            Lives = lives;
        }

        public string Name { get; private set; }

        public double Money { get; private set; }

        public int Lives { get; private set; }
    }
}
