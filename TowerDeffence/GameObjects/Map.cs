using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TowerDeffense.GameObjects
{
    using Interfaces;

    public class Map : GameObject, IMap
    {
        public MapTile[,] MapTiles
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
