namespace TowerDeffence.GameObjects
{
    using Interfaces;
    using Helpers;

    public abstract class BattleUnit : GameObject, IBattleUnit, IDrawable
    {
        public event UnitOnDeathHandler OnDeath;
        protected BattleUnit(int price, Position position)
            : base(position)
        {
            Price = price;
        }
        public int Price { get; private set; }

        public abstract void Draw();
    }
}
