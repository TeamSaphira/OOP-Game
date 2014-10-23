using System;

namespace TowerDeffence.Helpers
{
    using Interfaces;
    using GameObjects;

    class TowerFireRateUpgradeDecorator : PlayerUnitDecorator
    {
        public TowerFireRateUpgradeDecorator(ITower tower,double fireRateUpgrade) : base(tower)
        {
            this.FireRateUpgrade = fireRateUpgrade;
        }

        public double FireRateUpgrade { get; set; }

        public override double FireRate
        {
            get
            {
                return this.Tower.FireRate + FireRateUpgrade;
            }
        }
    }
}
