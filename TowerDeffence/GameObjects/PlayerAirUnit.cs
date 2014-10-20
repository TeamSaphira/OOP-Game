using TowerDeffence.Helpers;

namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public class PlayerAirUnit : AirUnit
    {
        public PlayerAirUnit(int price, Position position)
            : base(price, position)
        {
        }

        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}
