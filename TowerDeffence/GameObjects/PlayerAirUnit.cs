namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public class PlayerAirUnit : AirUnit
    {
<<<<<<< HEAD
        public void Upgrade()
        {
            throw new System.NotImplementedException();
=======
        public PlayerAirUnit(UnitSize size, int health, int price)
            : base(size, health, price)
        {
            
>>>>>>> enemyUnits
        }

        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}
