using System;

namespace TowerDeffence.Helpers
{
    using GameObjects;
    using Interfaces;
    class EnemyTakeDamageDecorator : EnemyUnitDecorator
    {
        public EnemyTakeDamageDecorator(IEnemyUnit enemyUnit,double damage) : base(enemyUnit)
        {
            Damage = damage;
        }
        protected double Damage { get; set; }

        public override int Health
        {
            get 
            {
                return this.EnemyUnit.Health - (int)Damage;
            }
        }
    }
}
