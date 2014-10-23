namespace TowerDeffence.GameObjects
{
    using Interfaces;
    using Helpers;

    public abstract class GameObject : IPositionable
    {
        protected GameObject()
        {
            Position = new Position(0,0);
        }

        protected GameObject(Position position)
        {
            Position = position;
        }

        public Position Position { get; protected set; }
    }
}
