namespace TowerDeffence.Helpers
{
    using System.Collections.Generic;

    using Interfaces;
    using GameObjects;

    public class EnemyUnitFactory : IEnemyUnitFactory
    {
        public EnemyGroundUnit CreateEnemyGroundUnit(params object[] args)
        {
            throw new System.NotImplementedException();
        }

        public PlayerGroundUnit CreatePlayerGroundUnit(params object[] args)
        {
            throw new System.NotImplementedException();
        }

        public EnemyAirUnit CreateEnemyAirUnit(params object[] args)
        {
            throw new System.NotImplementedException();
        }

        public PlayerAirUnit CreatePlayerAirUnit(params object[] args)
        {
            throw new System.NotImplementedException();
        }
    }
}
