namespace TowerDeffence.Helpers.Player
{
    using Interfaces;

    public abstract class PlayerDecorator : IPlayer
    {
        protected PlayerDecorator(IPlayer player)
        {
            Player = player;
        }

        public IPlayer Player { get; private set; }

        public virtual double Money
        {
            get { return Player.Money; }
        }

        public virtual int Lives
        {
            get { return Player.Lives; }
        }

        public string Name { get; set; }
    }
}
