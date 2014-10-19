using System;

namespace TowerDeffence.GameObjects
{
    using Helpers;
    using Interfaces;

    class Bullet : GroundUnit
    {
        protected Position startPosition,position,targetPosition;
        protected float speed;
        protected int damage;
        protected EnemyGroundUnit enemy;

        public delegate void FiredEvent(Bullet sender);
        public FiredEvent bulletHit;

        public Bullet(Position position,EnemyGroundUnit enemy,int damage)
        {
            this.enemy = enemy;
            this.damage = damage;
            this.position = position;
            startPosition = position;
            speed = 10;
        }

        public void setEnemy(EnemyGroundUnit enemy)
        {
            this.enemy = enemy;
            startPosition = position;
            targetPosition = enemy.getPosition();
        }
    }
}
