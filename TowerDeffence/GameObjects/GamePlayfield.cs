namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public class GamePlayfield : GameObject
    {
        public IMap Map { get; set; }

        public void Init()
        {
            // load map data
            var map = new EarthMap(); // loaded data
            AddMap(map);
        }

        private void AddMap(IMap map)
        {
            if (this.Map != null)
            {
                this.Map = map;
            }
        }
    }
}
