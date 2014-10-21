using System;

namespace TowerDeffence.Helpers
{
    using Interfaces;
    using GameObjects;

    class EnemyMovementSpeedDecorator : EnemyUnitDecorator
    {
        public EnemyMovementSpeedDecorator(IEnemyUnit enemyUnit,double slow) : base(enemyUnit)
        {
            Slow = slow;
        }

        protected double Slow { get; set; }

        public override double Speed
        {
            get
            {
                return this.EnemyUnit.Speed - Slow;
            }
        }
    }
}
