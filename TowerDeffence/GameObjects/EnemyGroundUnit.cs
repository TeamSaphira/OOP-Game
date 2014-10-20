namespace TowerDeffence.GameObjects
{
    using System;

    using Helpers;
    using Interfaces;

    public class EnemyGroundUnit : GroundUnit, IMoveable, IEnemyUnit
    {
        public EnemyGroundUnit(UnitSize size, int health, int price, double speed, Position position)
            : base(price, position)
        {
            this.Size = size;
            this.Health = health;
            this.Speed = speed;
        }

        public UnitSize Size { get; protected set; }

        public int Health { get; protected set; }

        public double Speed { get; set; }

        public void Move(char direction)
        {
            double enemyX = this.Position.X;
            double enemyY = this.Position.Y;

            switch (direction)
            {
                case 'u': this.Position = new Position(enemyX - 1, enemyY); break; // direction 'u' = up
                case 'd': this.Position = new Position(enemyX + 1, enemyY); break; // direction 'd' = down
                case 'l': this.Position = new Position(enemyX, enemyY - 1); break; // direction 'l' = left
                case 'r': this.Position = new Position(enemyX, enemyY + 1); break; // direction 'r' = right
                default: throw new InvalidOperationException("The provided direction is not valid");
            }
            throw new System.NotImplementedException();
        }

        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}
