using TowerDeffence.GameObjects;

namespace TowerDeffence.Interfaces
{
    public interface IPlayerUnitFactory
    {
        PlayerAirUnit CreatePlayerAirUnit();

        PlayerGroundUnit CreatePlayerGroundUnit();
    }
}
