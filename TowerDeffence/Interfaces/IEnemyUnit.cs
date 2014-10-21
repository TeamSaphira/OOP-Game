namespace TowerDeffence.Interfaces
{
    using GameObjects;

    public interface IEnemyUnit
    {
        UnitSize Size { get; }

        int Health { get; }

        double Speed { get; }
    }
}
