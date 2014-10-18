using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDeffence.GameObjects
{
    class GroundTower : PlayerGroundUnit
    {
        public GroundTower(int positionX,int positionY)
        {
            base.positionX = positionX;
            base.positionY = positionY;
            base.towerState = TowerState.idle;
            base.range = 220;
            base.attackRate = 80;
            base.baseCost = 110;
        }

        public override void calculateDamage()
        {
            damage = 100;
        }
    }
}
