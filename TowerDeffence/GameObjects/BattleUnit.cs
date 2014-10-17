namespace TowerDeffence.GameObjects
{
    using Interfaces;
    using Helpers;

    public abstract class BattleUnit : GameObject, IBattleUnit, IDrawable
    {
        public event UnitOnDeathHandler OnDeath;

        protected BattleUnit(UnitSize size, int health, int price, Position position)
            : base(position)
        {
            Size = size;
            Health = health;
            Price = price;
        }

        public UnitSize Size { get; private set; }

        public abstract void Draw();


        public int Health { get; private set; }

        public int Price { get; private set; }
    }
}
