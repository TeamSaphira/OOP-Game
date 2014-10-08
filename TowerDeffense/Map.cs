using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TowerDeffense
{
    public abstract class Map : GameObject, IMap
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
