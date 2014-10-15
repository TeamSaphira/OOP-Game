namespace TowerDeffence.GameObjects
{
    using Interfaces;
    using GameObjects;
    using Helpers;

    public abstract class BattleUnit : GameObject, IBattleUnit, IDrawable
    {
        public event UnitOnDeathHandler OnDeath;

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

        public static int Image
        {
            // todo sprite  load image in static constructor
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public abstract void Draw();
    }
}
