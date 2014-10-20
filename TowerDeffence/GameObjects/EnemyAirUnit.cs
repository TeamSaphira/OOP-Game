namespace TowerDeffence.GameObjects
{
    using System;

    using Helpers;
    using Interfaces;

    public class EnemyAirUnit : AirUnit, IMoveable, IEnemyUnit
    {
        public EnemyAirUnit(UnitSize size, int health, int price, double speed, Position position)
            : base(price, position)
        {
            this.Health = health;
            this.Size = size;
            this.Speed = speed;
        }

        public UnitSize Size { get; protected set; }

        public int Health { get; protected set; }

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
