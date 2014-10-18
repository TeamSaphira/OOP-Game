using System;

namespace TowerDeffence.GameObjects
{
    class Bullet : GroundUnit
    {
        protected int startPositionX;
        protected int startPositionY;
        protected float speed;
        protected int damage;
        protected EnemyGroundUnit enemy;

        public Bullet(int positionX,int positionY,EnemyGroundUnit enemy,int damage)
        {
            this.enemy = enemy;
            this.positionX = positionX;
            this.positionY = positionY;
            this.damage = damage;
            startPositionX = this.positionX;
            startPositionY = this.positionY;

            speed = 10;
        }

        public void setEnemy(EnemyGroundUnit enemy)
        { 
            
        }
    }
}
