using TowerDeffence.Helpers;

namespace TowerDeffence.Interfaces
{
    public interface IMoveable
    {
        double Speed
        {
            get;
            set;
        }

        void Move(Position position);
    }
}
