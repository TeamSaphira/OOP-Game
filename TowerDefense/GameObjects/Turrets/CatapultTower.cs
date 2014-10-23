using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDeffence.GameObjects;
using TowerDeffence.Helpers;

namespace TowerDeffence.Turrets
{
    class CatapultTower : PlayerGroundUnit
    {
        public CatapultTower(int price, Position position, double range, double damage, double fireRate)
            : base(price, position, range, damage, fireRate)
        {

        }
    }
}
