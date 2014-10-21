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

        public PlayerGroundUnit(int price, Position position) : base (price,position)
        {
            this.Price = price;
            this.Position = position;
        }
        public virtual void Upgrade()
        {
            this.Damage += 10;
            this.FireRate += 15;
            this.Range += 10;
        }

        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}
