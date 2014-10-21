using TowerDeffence.Helpers;

namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public class PlayerGroundUnit : GroundUnit, ITower, IUpgradeable
    {
        public TowerState TowerState { get; set; }

        public double Range  { get; private set; }

        public double Damage { get; private set; }

        public double FireRate { get; private set; }

        public PlayerGroundUnit(int price, Position position, double range, double damage, double fireRate) : base (price,position)
        {
            this.Price = price;
            this.Position = position;
            this.Range = range;
            this.Damage = damage;
            this.FireRate = fireRate;

        }
        public void Upgrade()
        {
            
        }

        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}
