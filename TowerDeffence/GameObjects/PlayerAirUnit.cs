namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public class PlayerAirUnit : AirUnit
    {
        public PlayerAirUnit(UnitSize size, int health, int price)
            : base(size, health, price)
        {
            
        }

        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}
