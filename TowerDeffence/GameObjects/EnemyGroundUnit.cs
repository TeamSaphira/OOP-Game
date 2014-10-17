using TowerDeffence.Helpers;

namespace TowerDeffence.GameObjects
{
    using Interfaces;

    public class EnemyGroundUnit : GroundUnit, IMoveable
    {
        public EnemyGroundUnit(UnitSize size, int health, int price, double speed, Position position)
            : base(size, health, price, position)
        {
            this.Speed = speed;
        }

        public double Speed { get; set; }

        public void Move(double speed, char direction)
        {
            // check 
            bool canMove = false;
            if()
            if (/* can move */)
            {
                if (direction.Equals('r')) // direction == 'r'
                {
                    // move right
                    // row + 1 col + 1
                }
                else if (direction.Equals('l'))
                {
                    // move left
                    // row + 1 col - 1
                    throw new System.NotImplementedException();
                }
            }
            else
            {
                
            }
            // r l

            throw new System.NotImplementedException();
        }

        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}
