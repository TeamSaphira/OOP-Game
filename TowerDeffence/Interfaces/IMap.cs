using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TowerDeffense.Interfaces
{
    using GameObjects;

    public interface IMap
    {
        MapTile[,] MapTiles
        {
            get;
            set;
        }
    }
}
