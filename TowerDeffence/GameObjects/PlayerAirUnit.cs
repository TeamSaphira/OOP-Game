using TowerDeffence.Helpers;

namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public class PlayerAirUnit : AirUnit, ITower, IUpgradeable
    {
        public PlayerAirUnit(int price, Position position, double range, double damage, double fireRate) : base (price,position)
        {
            this.Price = price;
            this.Position = position;
            this.Range = range;
            this.FireRate = fireRate;
            this.Damage = damage;
        }


        public TowerState TowerState { get; set; }

        public double Range { get; private set; }

        public double Damage { get; private set; }

        public double FireRate { get; private set; }

        public void Upgrade()
        {
            
        }

        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}
