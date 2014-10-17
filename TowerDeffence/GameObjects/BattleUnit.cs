namespace TowerDeffence.GameObjects
{
    using Interfaces;
    using Helpers;

    public abstract class BattleUnit : GameObject, IBattleUnit, IDrawable
    {
        public event UnitOnDeathHandler OnDeath;

        protected BattleUnit(UnitSize size, int health, int price, double speed)
        {
            Size = size;
            Health = health;
            Price = price;
            Speed = speed;
        }

        public UnitSize Size { get; private set; }

        public abstract void Draw();


        public int Health { get; private set; }

        public int Price { get; private set; }


        public double Speed { get; private set; }
    }
}
