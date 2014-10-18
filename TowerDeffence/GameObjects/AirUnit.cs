using TowerDeffence.Helpers;

namespace TowerDeffence.GameObjects
{
    public abstract class AirUnit : BattleUnit
    {
        protected AirUnit(UnitSize size, int health, int price, Position position)
            : base(size, health, price, position)
        {
        }
    }
}
