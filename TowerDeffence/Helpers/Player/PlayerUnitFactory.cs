namespace TowerDeffence.Helpers.Player
{
    using Interfaces;
    using GameObjects;

    public class PlayerUnitFactory : IPlayerUnitFactory
    {

        public PlayerAirUnit CreatePlayerAirUnit(int price, Position position, double range, double damage, double fireRate)
        {
            return new PlayerAirUnit(price, position, range, damage, fireRate);
        }

        public PlayerGroundUnit CreatePlayerGroundUnit(int price, Position position, double range, double damage, double fireRate)
        {
            return new PlayerGroundUnit(price, position, range, damage, fireRate);
        }
    }
}
