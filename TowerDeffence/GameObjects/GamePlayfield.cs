﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TowerDeffense.GameObjects
{
    using Interfaces;

    public class GamePlayfield : GameObject
    {
        public IMap Map
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