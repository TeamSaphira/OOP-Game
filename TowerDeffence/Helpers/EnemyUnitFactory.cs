namespace TowerDeffence.Helpers
{
    using System.Collections.Generic;

    using Interfaces;
    using GameObjects;

    public class EnemyUnitFactory : IEnemyUnitFactory
    {
        public EnemyAirUnit CreateEnemyAirUnit(/* params */)
        {
            return new EnemyAirUnit(/* params */);
        }

        public ICollection<EnemyAirUnit> CreateEnemyAirUnitByCount(int count)
        {
            for (int i = 0; i < count; i++)
            {
                
            }
            return null;
        }
    }
}
