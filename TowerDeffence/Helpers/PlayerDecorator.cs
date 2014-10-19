namespace TowerDeffence.Helpers
{
    using Interfaces;

    public abstract class PlayerDecorator : IPlayer
    {
        protected PlayerDecorator(IPlayer player)
        {
            this.Player = player;
        }

        public IPlayer Player { get; set; }

        public virtual string Name
        {
            get { throw new System.NotImplementedException(); }
        }

        public virtual double Money
        {
            get { throw new System.NotImplementedException(); }
        }

        public virtual int Lives
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}
