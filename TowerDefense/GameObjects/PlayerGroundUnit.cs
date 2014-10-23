﻿using System;
using TowerDeffence.Helpers;

namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public class PlayerGroundUnit : GroundUnit, ITower, IUpgradeable
    {
        public PlayerGroundUnit(int price, Position position, double range, double damage, double fireRate)
            : base(price, position)
        {
            Price = price;
            Position = position;
            Range = range;
            Damage = damage;
            FireRate = fireRate;
        }

        public TowerState TowerState { get; set; }

        public double Range  { get; private set; }

        public double Damage { get; private set; }

        public double FireRate { get; private set; }

        public void Upgrade()
        {
            
        }

        public override void Draw()
        {
            Console.SetCursorPosition((int)Position.X, (int)Position.Y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("T");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
