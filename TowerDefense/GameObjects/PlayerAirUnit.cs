using System;
using TowerDeffence.Helpers;

namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public class PlayerAirUnit : AirUnit, ITower, IUpgradeable
    {
        public PlayerAirUnit(int price, Position position, double range, double damage, double fireRate) : base (price,position)
        {
            Price = price;
            Position = position;
            Range = range;
            FireRate = fireRate;
            Damage = damage;
        }


        public TowerState TowerState { get; set; }

        public double Range { get; private set; }

        public double Damage { get; private set; }

        public double FireRate { get; private set; }

        public void Upgrade()
        {
            
        }

        public override void Draw()
        {
            Console.SetCursorPosition((int)Position.X, (int)Position.Y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("T");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
