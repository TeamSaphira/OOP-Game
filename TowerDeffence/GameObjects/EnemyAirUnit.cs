namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public class EnemyAirUnit : AirUnit, IMoveable
    {
        public EnemyAirUnit(UnitSize size, int health, int price, double speed)
            : base(size, health, price)
        {
            this.Speed = speed;
        }

        public double Speed { get; set; }

        public void Move(double speed, char direction)
        {
            throw new System.NotImplementedException();
        }

        public override void Draw()
        {
            throw new System.NotImplementedException();
            // load image
            // draw image(position)
        }
    }
}
