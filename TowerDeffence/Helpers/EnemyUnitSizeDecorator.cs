using System;

namespace TowerDeffence.Helpers
{
    using GameObjects;
    using Interfaces;

    class EnemyUnitSizeDecorator : EnemyUnitDecorator
    {
        public EnemyUnitSizeDecorator(IEnemyUnit enemyUnit,UnitSize size) : base(enemyUnit)
        {
            this.NewSize = size;
        }

        public UnitSize NewSize { get; set; }

        public override UnitSize Size
        {
            
        }
    }
}
