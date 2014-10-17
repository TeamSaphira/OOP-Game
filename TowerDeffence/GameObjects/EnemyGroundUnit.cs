namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public class EnemyGroundUnit : GroundUnit, IMoveable
    {
        public EnemyGroundUnit(UnitSize size, int health, int price, double speed)
            : base(size, health, price, speed)
        {
            
        }

        public double Speed { get; set; }

        public void Move(double speed)
        {
            throw new System.NotImplementedException();
        }

        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}
