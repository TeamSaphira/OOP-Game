using System;
using TowerDeffence.GameObjects;

namespace TowerDeffence.Engine
{
    using System.IO;

    using Helpers;
    using Interfaces;

    public class InteractionManager
    {
        public Position GetNextPosition(IMap map, object unit)
        {
            if (unit is EnemyAirUnit)
            {
                return new Position(0, 1);
            }

            var unitPosX = ((IPositionable)unit).Position.X;
            var unitPosY = ((IPositionable)unit).Position.Y;

            if (map.MapTiles[(int)unitPosY + 1, (int)unitPosX] == 0)
            {
                return new Position(0, 1);
            }
            if (map.MapTiles[(int)unitPosY - 1, (int)unitPosX] == 0)
            {
                return new Position(0, -1);
            }
            if (map.MapTiles[(int)unitPosY, (int)unitPosX + 1] == 0)
            {
                return new Position(1, 0);
            }
            if (map.MapTiles[(int)unitPosY, (int)unitPosX - 1] == 0)
            {
                return new Position(-1, 0);
            }

            return new Position(0, 0);
        }
    }
}
