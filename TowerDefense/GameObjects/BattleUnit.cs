using System;

namespace TowerDeffence.GameObjects
{
    using Interfaces;
    using Helpers;
    public abstract class BattleUnit : GameObject, IBattleUnit, IDrawable
    {
        protected BattleUnit(int price, Position position)
            : base(position)
        {
            Price = price;
        }
        public int Price { get; set; }

        public abstract void Draw();
    }
}
