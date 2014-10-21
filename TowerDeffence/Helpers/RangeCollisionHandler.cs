namespace TowerDeffence.Helpers
{
    using System;
    using TowerDeffence.GameObjects;
    using TowerDeffence.Interfaces;
    public class RangeCollisionHandler : CollisionHandler
    {
        public bool isInRange(ITower Tower, BattleUnit Enemy)
        {
            double towerX = Tower.Position.X;
            double towerY = Tower.Position.Y;
            double towerRange = Tower.Range;
            double enemyX = Enemy.Position.X;
            double enemyY = Enemy.Position.Y;

            return Math.Pow((enemyX - towerX), 2) + Math.Pow((enemyY - towerY), 2) <= Math.Pow(towerRange, 2);
        }
    }
}
