namespace TowerDeffence.GameObjects
{
    public abstract class GroundUnit : BattleUnit
    {
        protected GroundUnit(UnitSize size, int health, int price, double speed)
            : base(size, health, price, speed)
        {
            
        }
    }
}
