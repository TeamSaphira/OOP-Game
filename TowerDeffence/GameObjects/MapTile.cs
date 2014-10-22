using TowerDeffence.Helpers;

namespace TowerDeffence.GameObjects
{
    public abstract class MapTile : GameObject
    {
        protected MapTile(Position position)
        {
            this.Position = position;
        }

        public static double Width { get; set; }
        public static double Height { get; set; }
    }
}