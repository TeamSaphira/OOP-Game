using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDeffence.GameObjects;
using TowerDeffence.Helpers;

namespace DragonTower.Turrets
{
    class RangerPost : PlayerGroundUnit
    {
        public RangerPost(int price, Position position, double range, double damage, double fireRate, string type)
            : base(price, position, range, damage, fireRate, type)
        {

        }
    }
}
