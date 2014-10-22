using TowerDeffence.Helpers;

namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public class PlayerGroundUnit : GroundUnit, ITower, IUpgradeable
    {
        public PlayerGroundUnit(int price, Position position, double range, double damage, double fireRate, string type)
            : base(price, position)
        {
            this.Price = price;
            this.Position = position;
            this.Range = range;
            this.Damage = damage;
            this.FireRate = fireRate;
        }

        public TowerState TowerState { get; set; }

        public double Range  { get; private set; }

        public double Damage { get; private set; }

        public double FireRate { get; private set; }
        public string Type { get; private set; } //Ground / Air

        public void Upgrade()
        {
            
        }

        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}
