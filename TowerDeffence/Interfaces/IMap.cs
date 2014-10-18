namespace TowerDeffence.Interfaces
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
