namespace TowerDeffence.Helpers.Data
{
    public class EnemyData
    {
        public EnemyData(int count, string size, int health, int bounty, int speed, string type)
            : this()
        {
            Count = count;
            Size = size;
            Health = health;
            Bounty = bounty;
            Speed = speed;
            Type = type;
        }

        public EnemyData()
        {

        }

        public int Count { get; set; }

        public string Size { get; set; }

        public int Health { get; set; }

        public int Bounty { get; set; }

        public int Speed { get; set; }

        public string Type { get; set; }
    }
}
