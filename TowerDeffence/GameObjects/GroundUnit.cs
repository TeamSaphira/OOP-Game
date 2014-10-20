namespace TowerDeffence.GameObjects
{
    using Helpers;

    public abstract class GroundUnit : BattleUnit
    {
        protected GroundUnit(int price, Position position)
            : base(price, position)
        {
        }
    }
}
