using System;

namespace TowerDeffence.Helpers
{
    using Interfaces;
    using GameObjects;

    class PlayerUnitDecorator : ITower
    {
        public PlayerUnitDecorator(ITower tower)
        {
            this.Tower = tower;
        }

        public ITower Tower { get; private set; }

        public virtual double Range
        {
            get
            {
                return this.Tower.Range;
            }
        }

        public virtual double Damage
        {
            get
            {
                return this.Tower.Damage;
            }
        }

        public virtual double FireRate
        {
            get
            {
                return this.Tower.FireRate;
            }
        }
    }
}
