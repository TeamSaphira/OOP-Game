namespace TowerDeffence.GameObjects
{
    using Interfaces;

    using System.Collections.Generic;

    public abstract class PlayerGroundUnit : GroundUnit, IUpgradeable
    {
        protected enum TowerState { idle, loading, shot };

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

        public void checkRange(List<EnemyGroundUnit> enemyList)
        {
            if (enemy != null)
                if (((this.Position.X - enemy.getPosition().X) > range) && ((this.Position.Y - enemy.getPosition().Y) > range))
                    enemy = null;
            if (enemy == null)
                for (int i = 0; i < enemyList.Count; i++)
                {
                    if ((this.Position.Y - enemyList[i].getPosition().Y) < range && (this.Position.X - enemyList[i].getPosition().X) < range)
                    {
                        enemy = enemyList[i];
                        i = enemyList.Count + 1;
                    }
                }
        }
    }
}
