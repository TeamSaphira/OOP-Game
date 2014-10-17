using System.Collections.Generic;

namespace TowerDeffence.Interfaces
{
    using GameObjects;
    using Helpers;

    public interface IEnemyUnitFactory
    {
        EnemyGroundUnit CreateEnemyGroundUnit(UnitSize size, int health, int price, double speed, Position position);

        ICollection<EnemyGroundUnit> CreateEnemyGroundUnitByCount(UnitSize size, int health, int price, double speed, Position position, int count);

        EnemyAirUnit CreateEnemyAirUnit(params object[] args);
    }
}
