namespace TowerDeffence.GameObjects
{
    public abstract class AirUnit : BattleUnit
    {
        protected AirUnit(UnitSize size, int health, int price, double speed)
            : base(size, health, price, speed)
        {
            
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
