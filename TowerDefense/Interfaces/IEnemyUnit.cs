namespace TowerDeffence.Interfaces
{
    using GameObjects;

    public interface IEnemyUnit : IPositionable
    {
        UnitSize Size { get; }

        int Health { get; set; }
    }
}
