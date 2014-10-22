namespace TowerDeffence.GameObjects
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using TowerDeffence.Helpers;

    public class EarthMap : GameObject, IMap
    {
        private int[,] levelMatrix; // This matrix represents numbers from text file of current level;
        public MapTile[,] MapTiles { get; set; }
        public EarthMap(int width, int height)
        {
            this.MapTiles = new MapTile[width, height];
        }

        //private void FillMapWithTiles(int[,] levelMatrix)
        //{
        //    MapTile tile = null;

        //    for (int row = 0; row < levelMatrix.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < levelMatrix.GetLength(1); col++)
        //        {
        //            if(levelMatrix[row, col] == 1)
        //            {
        //                //tile = new TowerTile();
        //            }

        //            if(levelMatrix[row, col] == 0)
        //            {
        //                //tile = new PathTile();
        //            }
                    
        //            MapTiles[row, col] = tile;
        //        }
        //    }
        //}
    }
}
