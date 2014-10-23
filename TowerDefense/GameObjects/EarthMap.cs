namespace TowerDeffence.GameObjects
{
    using System;
    using System.Collections.Generic;

    using Engine;
    using Interfaces;

    public class EarthMap : GameObject, IMap
    {
        public EarthMap()
        {
            MapTiles = new byte[0, 0];
            InitMapTiles();
        }
        public byte[,] MapTiles { get; set; }

        private void InitMapTiles()
        {
            var mapValues = LoadManager.Instance.FillMapFromFile();
            MapTiles = new byte[mapValues.Count, mapValues[0].Count];
            for (int i = 0; i < MapTiles.GetLength(0); i++)
            {
                for (int j = 0; j < MapTiles.GetLength(1); j++)
                {
                    MapTiles[i, j] = mapValues[i][j];
                }
            }
        }
    }
}
