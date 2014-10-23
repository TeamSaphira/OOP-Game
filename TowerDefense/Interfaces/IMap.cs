namespace TowerDeffence.Interfaces
{
    using GameObjects;

    public interface IMap
    {
        byte[,] MapTiles
        {
            get;
            set;
        }
    }
}
