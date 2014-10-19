using System;
using TowerDeffence.Helpers;

namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public class EnemyAirUnit : AirUnit, IMoveable
    {
        public EnemyAirUnit(UnitSize size, int health, int price, double speed, Position position)
            : base(size, health, price, position)
        {
            this.Speed = speed;
        }

        public double Speed { get; set; }

        public void Move(char direction)
        {
            double enemyX = this.Position.X;
            double enemyY = this.Position.Y;

            if (direction.Equals('d')) // direction d = down
            {
                this.Position = new Position(enemyX + 1, enemyY);
            }

            throw new InvalidOperationException("The provided direction is not valid.");
        }

        public override void Draw()
        {
            throw new System.NotImplementedException();
            // load image
            // draw image(position)
        }
    }
}
