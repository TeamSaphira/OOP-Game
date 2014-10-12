using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TowerDeffense.GameObjects
{
    using Interfaces;
    using Helpers;

    public abstract class BattleUnit : GameObject, IBattleUnit
    {
        public event UnitOnDeathHandler OnDeath;
    }
}
