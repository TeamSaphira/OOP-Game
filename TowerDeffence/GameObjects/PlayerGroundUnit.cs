namespace TowerDeffence.GameObjects
{
    using Interfaces;

    using System.Collections.Generic;

    public abstract class PlayerGroundUnit : GroundUnit, ITower, IUpgradeable
    {
        protected PlayerGroundUnit()
        {
            
        }

        public TowerState TowerState { get; set; }

        public double Range
        {
            get { throw new System.NotImplementedException(); }
        }

        public double Damage
        {
            get { throw new System.NotImplementedException(); }
        }

        public double FireRate
        {
            get { throw new System.NotImplementedException(); }
        }

        public void Upgrade()
        {
            throw new System.NotImplementedException();
        }
    }
}
