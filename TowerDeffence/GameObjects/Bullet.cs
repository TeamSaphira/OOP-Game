using System;

namespace TowerDeffence.GameObjects
{
    using Helpers;
    using Interfaces;

    public class Bullet : IMoveable
    {
        public double Speed { get; set; }
        public Position Position { get; set; }

        public Bullet(Position position, double speed)
        {
            this.Speed = speed;
            this.Position = position;
        }


        public void Move(double speed)
        {
            throw new NotImplementedException();
        }
    }
}
