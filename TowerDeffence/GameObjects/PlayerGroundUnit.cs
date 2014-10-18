namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public abstract class PlayerGroundUnit : GroundUnit, IUpgradeable
    {
        protected enum TowerState { idle, loadin, shot };

        protected TowerState towerState;

        protected float range, attackRate;
        protected int level, damage, baseCost;
        protected EnemyGroundUnit enemy;

        //returns amount of damage of this tower
        public int getDamage()
        {
            return damage;
        }
        //returns building cost of this tower
        public int getCost()
        {
            return baseCost;
        }

        public abstract void calculateDamage();
    }
}
