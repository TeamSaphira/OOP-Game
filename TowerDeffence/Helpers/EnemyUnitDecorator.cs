
namespace TowerDeffence.Helpers
{
    using Interfaces;
    using GameObjects;

    class EnemyUnitDecorator : IEnemyUnit
    {
        public EnemyUnitDecorator(IEnemyUnit enemyUnit)
        {
            this.EnemyUnit = enemyUnit;
        }

        public IEnemyUnit EnemyUnit { get; private set; }

        public virtual UnitSize Size 
        {
            get { return this.EnemyUnit.Size; }
        }

        public virtual int Health 
        {
            get { return this.EnemyUnit.Health; }
        }

        public virtual double Speed
        {
            get { return this.EnemyUnit.Speed; }
        }
    }
}
