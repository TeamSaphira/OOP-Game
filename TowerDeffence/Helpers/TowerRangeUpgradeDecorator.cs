using System;

namespace TowerDeffence.Helpers
{
    using Interfaces;
    using GameObjects;

    class TowerRangeUpgradeDecorator : PlayerUnitDecorator
    {
        public TowerRangeUpgradeDecorator(ITower tower,double range) : base(tower)
        {

        }

        public double RangeUpgrade { get; set; }

        public override double Range
        {
            get
            {
                return this.Tower.Range + RangeUpgrade;
            }
        }
    }
}
