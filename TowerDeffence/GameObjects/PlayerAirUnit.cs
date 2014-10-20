using TowerDeffence.Helpers;

namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public class PlayerAirUnit : AirUnit, ITower, IUpgradeable
    {
        public TowerState TowerState { get; set; }

        public double Range  { get; private set; }

        public double Damage { get; private set; }

        public double FireRate { get; private set; }

        public PlayerAirUnit(int price, Position position) : base (price,position)
        {
            this.Price = price;
            this.Position = position;
        }
        public void Upgrade()
        {
            this.Range += 10;
            this.Damage += 15;
            this.FireRate += 15;
        }
    }
}
