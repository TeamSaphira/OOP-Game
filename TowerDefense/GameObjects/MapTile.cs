using TowerDeffence.Helpers;

namespace TowerDeffence.GameObjects
{
    public abstract class MapTile : GameObject
    {
        protected MapTile(Position position)
        {
            Position = position;
            Width = 50;
            Height = 50;
        }

        public static double Width { get; set; }
        public static double Height { get; set; }
    }
}