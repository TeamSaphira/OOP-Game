namespace TowerDeffence.Helpers.Enemies
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


        public ICollection<EnemyGroundUnit> CreateEnemyGroundUnitByCount(UnitSize size, int health, int price, double speed, Position position, int count)
        {
            var units = new List<EnemyGroundUnit>();
            for (int i = 0; i < count; i++)
            {
                // create
                // add to list
                EnemyGroundUnit groundUnit = CreateEnemyGroundUnit(size, health, price, speed, position);
                units.Add(groundUnit);
            }
            return units;
        }

        public ICollection<EnemyAirUnit> CreateEnemyAirUnitByCount(UnitSize size, int health, int price, double speed, Position position, int count)
        {
            var units = new List<EnemyAirUnit>();
            for (int i = 0; i < count; i++)
            {
                EnemyAirUnit airUnit = CreateEnemyAirUnit(size, health, price, speed, position);
                units.Add(airUnit);
            }
            return units;
        }
    }
}
