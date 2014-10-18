namespace TowerDeffence.Helpers
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
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }


        public int Health
        {
            get { throw new System.NotImplementedException(); }
        }

        public int Price
        {
            get { throw new System.NotImplementedException(); }
        }

        public double Speed
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}
