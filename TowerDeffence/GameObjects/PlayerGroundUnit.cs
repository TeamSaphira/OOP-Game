using TowerDeffence.Helpers;

namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public class PlayerGroundUnit : GroundUnit
    {
        public PlayerGroundUnit(int price, Position position)
            : base(price, position)
        {
            
        }
        public void Upgrade()
        {
            throw new System.NotImplementedException();
        }

        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}
