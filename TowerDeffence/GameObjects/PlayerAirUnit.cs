using TowerDeffence.Helpers;

namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public class PlayerAirUnit : AirUnit
    {
        public PlayerAirUnit(UnitSize size, int health, int price, Position position)
            : base(size, health, price, position)
        {
        }

        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}
