namespace TowerDeffence.GameObjects
{
    using Interfaces;
    using Helpers;

    public class EnemyGroundUnit : GroundUnit, IMoveable
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
        }
        public Position getPosition()
        {
            return this.Position;
        }
    }
}
