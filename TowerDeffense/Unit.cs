using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TowerDeffense
{
    public abstract class BattleUnit : GameObject
    {
        public event UnitOnDeathHandler OnDeath;
    }
}
