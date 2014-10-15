namespace TowerDeffence.Interfaces
{
    using GameObjects;

    public interface IEnemyUnitFactory
    {
        EnemyGroundUnit CreateEnemyGroundUnit(params object[] args);

        PlayerGroundUnit CreatePlayerGroundUnit(params object[] args);

        EnemyAirUnit CreateEnemyAirUnit(params object[] args);

        PlayerAirUnit CreatePlayerAirUnit(params object[] args);
    }
}
