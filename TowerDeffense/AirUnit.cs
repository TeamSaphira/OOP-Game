﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TowerDeffense
{
    public abstract class AirUnit : BattleUnit
    {
        public UnitSize UnitSize
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}