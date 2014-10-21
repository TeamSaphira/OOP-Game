namespace TowerDeffence.Interfaces
{
    public interface IPlayer
    {
        string Name { get; set; }

        double Money { get; }

        int Lives { get; }
    }
}
