using System.Drawing;
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
            Health = health;
            Size = size;
            Speed = speed;
        }

        public UnitSize Size { get; protected set; }

        public int Health { get; set; }

        public double Speed { get; set; }

        public void Move(Position position)
        {
            double enemyX = Position.X;
            double enemyY = Position.Y;

            enemyY += position.Y;

            this.Position = new Position(enemyX, enemyY);
        }

        public override void Draw()
        {
            Console.SetCursorPosition((int)Position.X, (int)Position.Y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("E");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
