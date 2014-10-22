using System;
using TowerDeffence.Engine;

namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public class GamePlayfield : GameObject
    {
        public GamePlayfield(int width, int height)
        {
            this.Map = new EarthMap(width, height);
            InitMapTiles();
        }

        public IMap Map { get; set; }

        private void InitMapTiles()
        {
            var mapValues = LoadManager.Instance.FillMapFromFile();
            this.Map.MapTiles = new MapTile[mapValues.Count, mapValues[0].Count];
            for (int i = 0; i < mapValues.Count; i++)
            {
                for (int j = 0; j < mapValues[i].Count; j++)
                {
                    int currentValue = mapValues[i][j];
                    if (currentValue == 1)
                    {
                        //todo
                    }
                    else if (currentValue == 0)
                    {
                        //todo
                    }
                    else
                    {
                        throw new FormatException("Bad map values.");
                    }
                }
            }
        }
    }
}
