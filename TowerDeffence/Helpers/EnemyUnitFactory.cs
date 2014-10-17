namespace TowerDeffence.Helpers
{
    using System.Collections.Generic;

    using Interfaces;
    using GameObjects;

    public class EnemyUnitFactory : IEnemyUnitFactory
    {

        public EnemyGroundUnit CreateEnemyGroundUnit(UnitSize size, int health, int price, double speed, Position position)
        {
            return new EnemyGroundUnit(size, health, price, speed, position);
        }

        public EnemyAirUnit CreateEnemyAirUnit(UnitSize size, int health, int price, double speed, Position position)
        {
            return new EnemyAirUnit(size, health, price, speed, position);
        }

        // same for air v


        public ICollection<EnemyGroundUnit> CreateEnemyGroundUnitByCount(UnitSize size, int health, int price, double speed, Position position, int count)
        {
            var units = new List<EnemyGroundUnit>();
            for (int i = 0; i < count; i++)
            {
                // create
                // add to list
            }
            return units;
        }
    }
}
