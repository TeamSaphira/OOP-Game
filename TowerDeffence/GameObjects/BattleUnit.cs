namespace TowerDeffence.GameObjects
{
    using Interfaces;
    using Helpers;

    public abstract class BattleUnit : GameObject, IBattleUnit, IDrawable
    {
        public event UnitOnDeathHandler OnDeath;

        public Position Position
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

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
