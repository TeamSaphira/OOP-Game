namespace TowerDeffence.Interfaces
{
    using GameObjects;
    using Helpers;

    public interface IPlayerUnitFactory
    {
        PlayerAirUnit CreatePlayerAirUnit(int price, Position position, double range, double damage, double fireRate);

        PlayerGroundUnit CreatePlayerGroundUnit(int price, Position position, double range, double damage, double fireRate);
    }
}
