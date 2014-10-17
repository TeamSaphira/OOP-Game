namespace TowerDeffence.GameObjects
{
    public abstract class AirUnit : BattleUnit
    {
        protected AirUnit(UnitSize size, int health, int price)
            : base(size, health, price)
        {
            
        }
    }
}
