namespace TowerDeffence.Interfaces
{
    using System.Collections.Generic;

    using Helpers;
    using GameObjects;

    public interface IEnemyUnitFactory
    {
        EnemyGroundUnit CreateEnemyGroundUnit(UnitSize size, int health, int price, double speed, Position position);

        ICollection<EnemyGroundUnit> CreateEnemyGroundUnitByCount(UnitSize size, int health, int price, double speed, Position position, int count);

        EnemyAirUnit CreateEnemyAirUnit(UnitSize size, int health, int price, double speed, Position position);

        ICollection<EnemyAirUnit> CreateEnemyAirUnitByCount(UnitSize size, int health, int price, double speed, Position position, int count);
    }
}
