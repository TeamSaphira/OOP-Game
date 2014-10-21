namespace TowerDeffence.Helpers
{
    using Interfaces;
    using GameObjects;
    public class TowerDamageUpgradeDecorator : PlayerUnitDecorator
    {
        public TowerDamageUpgradeDecorator(ITower tower,double damage) : base(tower)
        {
            DamageUpgrade = damage;
        }

        protected double DamageUpgrade { get; set; }

        public override double Damage
        {
            get 
            {
                return this.Tower.Damage + DamageUpgrade;
            }
        }
    }
}
