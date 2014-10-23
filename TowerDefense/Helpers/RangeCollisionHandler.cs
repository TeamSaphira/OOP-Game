namespace TowerDeffence.Helpers
{
    using System;
    using GameObjects;
    using Interfaces;
    public class RangeCollisionHandler : CollisionHandler
    {
        public bool IsInRange(ITower tower, IEnemyUnit enemy)
        {
            double towerX = tower.Position.X;
            double towerY = tower.Position.Y;
            double towerRange = tower.Range;
            double enemyX = enemy.Position.X;
            double enemyY = enemy.Position.Y;

            return Math.Pow((enemyX - towerX), 2) + Math.Pow((enemyY - towerY), 2) <= Math.Pow(towerRange, 2);
        }
    }
}
