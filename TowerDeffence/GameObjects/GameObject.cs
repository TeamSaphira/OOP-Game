namespace TowerDeffence.GameObjects
{
    using Helpers;

    public abstract class GameObject
    {
        protected GameObject(Position position)
        {
            this.Position = position;
        }

        public Position Position { get; protected set; }
    }
}
