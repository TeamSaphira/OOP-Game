using System;

namespace TowerDeffence.Helpers.Enemies
{
    using GameObjects;
    using Interfaces;

    public abstract class BattleUnitDecorator : IBattleUnit
    {
        protected BattleUnitDecorator()
        {
            
        }

        public UnitSize Size
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public int Health
        {
            get { throw new NotImplementedException(); }
        }

        public int Price
        {
            get { throw new NotImplementedException(); }
        }

        public double Speed
        {
            get { throw new NotImplementedException(); }
        }
    }
}
