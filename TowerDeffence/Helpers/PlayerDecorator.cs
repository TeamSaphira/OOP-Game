namespace TowerDeffence.Helpers
{
    using Interfaces;


    public abstract class PlayerDecorator : IPlayer
    {
        protected PlayerDecorator(IPlayer player)
        {
            this.Player = player;
        }

        public IPlayer Player { get; private set; }

        public virtual double Money
        {
            get { return this.Player.Money; }
        }

        public virtual int Lives
        {
            get { return this.Player.Lives; }
        }

        public string Name { get; set; }
    }
}
