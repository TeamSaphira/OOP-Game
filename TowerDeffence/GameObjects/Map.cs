﻿namespace TowerDeffence.GameObjects
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
