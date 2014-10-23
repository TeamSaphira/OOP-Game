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

        public void Move(Position targetPosition)
        {
            Position bulletPosition = new Position(this.Position.X, this.Position.Y);
            

            //calculate distance to target
            double deltaX = targetPosition.X - bulletPosition.X;
            double deltaY = targetPosition.Y - bulletPosition.Y;
            Position distanceToTarget = new Position(deltaX, deltaY);

            //move bullet towards enemy            
            double angle = Math.Atan2(deltaY, deltaX) * 180 / Math.PI;
            bulletPosition = MoveBullet(bulletPosition, angle);

            
            bool shouldDamageEnemy = false; 
            if (true)
            {
                //target is hit, return something
            }
        }

        private Helpers.Position MoveBullet(Position bulletPosition, double angle)
        {
            bulletPosition.X = bulletPosition.X + this.Speed * Math.Cos(angle);
            bulletPosition.Y = bulletPosition.Y + this.Speed * Math.Sin(angle);
            return bulletPosition;
        }

        private bool IsEnemyHit(Position bulletPosition, Position targetPosition)
        {
            
            return false;
        }
    }
}
