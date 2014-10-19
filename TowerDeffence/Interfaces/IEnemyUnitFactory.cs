using System.Collections.Generic;

namespace TowerDeffence.Interfaces
{
    using GameObjects;
<<<<<<< HEAD

    public interface IEnemyUnitFactory
    {
        EnemyGroundUnit CreateEnemyGroundUnit(params object[] args);

        PlayerGroundUnit CreatePlayerGroundUnit(params object[] args);

        EnemyAirUnit CreateEnemyAirUnit(params object[] args);

        PlayerAirUnit CreatePlayerAirUnit(params object[] args);
=======
    using Helpers;

    public interface IEnemyUnitFactory
    {
        EnemyGroundUnit CreateEnemyGroundUnit(UnitSize size, int health, int price, double speed, Position position);

        ICollection<EnemyGroundUnit> CreateEnemyGroundUnitByCount(UnitSize size, int health, int price, double speed, Position position, int count);

        EnemyAirUnit CreateEnemyAirUnit(UnitSize size, int health, int price, double speed, Position position);

        ICollection<EnemyAirUnit> CreateEnemyAirUnitByCount(UnitSize size, int health, int price, double speed, Position position, int count);
>>>>>>> enemyUnits
    }
}
