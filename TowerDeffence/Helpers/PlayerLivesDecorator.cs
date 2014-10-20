namespace TowerDeffence.Helpers
{
    using Interfaces;

    public class PlayerLivesDecorator : PlayerDecorator
    {
        public PlayerLivesDecorator(IPlayer player)
            : base(player)
        {

        }

        public override int Lives
        {
            get
            {
                return base.Lives - 1;
            }
        }
    }
}
