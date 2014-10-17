namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public class PlayerGroundUnit : GroundUnit
    {
        public PlayerGroundUnit(UnitSize size, int health, int price, double speed)
            : base(size, health, price, speed)
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
