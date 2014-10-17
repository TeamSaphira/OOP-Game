namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public class PlayerGroundUnit : GroundUnit
    {
        public PlayerGroundUnit(UnitSize size, int health, int price)
            : base(size, health, price)
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
