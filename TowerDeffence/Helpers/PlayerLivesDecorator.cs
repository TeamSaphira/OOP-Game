using TowerDeffence.Interfaces;

namespace TowerDeffence.Helpers
{
    public class PlayerLivesDecorator : PlayerDecorator
    {
        public PlayerLivesDecorator(IPlayer player)
            : base(player)
        {
            
        }

        public override int Lives
        {
            get { return this.Player.Lives - 1; }
        }
    }
}
