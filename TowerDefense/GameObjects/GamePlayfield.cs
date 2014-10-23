namespace TowerDeffence.GameObjects
{
    using Interfaces;
    using Helpers;

    public class GamePlayfield : GameObject
    {
        public GamePlayfield()
        {
            Map = new EarthMap();
        }

        public IMap Map { get; set; }
    }
}
