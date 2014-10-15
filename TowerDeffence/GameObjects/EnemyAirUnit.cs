namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public class EnemyAirUnit : AirUnit, IMoveable
    {
        public double Speed
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public void Move(double speed)
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
