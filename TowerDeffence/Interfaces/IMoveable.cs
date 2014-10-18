namespace TowerDeffence.Interfaces
{
    public interface IMoveable
    {
        double Speed
        {
            get;
            set;
        }

        void Move(double speed, char direction);
    }
}
