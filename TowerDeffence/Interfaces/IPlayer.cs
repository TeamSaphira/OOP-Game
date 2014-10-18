namespace TowerDeffence.Interfaces
{
    public interface IPlayer
    {
        string Name { get; }
        double Money { get; }

        int Lives { get; }
    }
}
