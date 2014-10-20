namespace TowerDeffence.GameObjects
{
    using Interfaces;
    using Helpers;

    public abstract class GroundUnit : BattleUnit
    {

        protected GroundUnit(UnitSize size, int health, int price, Position position)
        : base(size, health, price, position)
        {
        }       
    }
}
