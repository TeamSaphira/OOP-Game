namespace TowerDeffence.GameObjects
{
    using Helpers;

    public abstract class AirUnit : BattleUnit
    {
        protected AirUnit(int price, Position position)
            : base(price, position)
        {
        }
    }
}
