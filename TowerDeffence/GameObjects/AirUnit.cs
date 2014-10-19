namespace TowerDeffence.GameObjects
{
    using Helpers;

    public abstract class AirUnit : BattleUnit
    {
        protected AirUnit(UnitSize size, int health, int price, Position position)
            : base(size, health, price, position)
        {
        }
    }
}
