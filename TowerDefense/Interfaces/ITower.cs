namespace TowerDeffence.Interfaces
{
    public interface ITower : IPositionable
    {
        double Range { get; }

        double Damage { get; }

        double FireRate { get; }
    }
}
