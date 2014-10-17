namespace TowerDeffence.GameObjects
{
    using Interfaces;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using TowerDeffence.Helpers;

    public class EarthMap : GameObject, IMap
    {
        private List<PictureBox> tiles;

        //public MapTile[,] MapTiles
        //{
        //    get
        //    {
        //        throw new System.NotImplementedException();
        //    }
        //    set
        //    {
        //    }
        //}

        public EarthMap(Form form)
        {
            tiles = new List<PictureBox>();
            FillMapWithTiles(form);
        }

        private void FillMapWithTiles(Form form)
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    PictureBox tile = new PictureBox();
                    tile.BackColor = Color.Green;
                    tile.Width = 40;
                    tile.Height = 40;
                    tile.Location = new Point(x, y);
                    tile.Parent = form;
                    tiles.Add(tile);
                }
            }
        }
    }
}
