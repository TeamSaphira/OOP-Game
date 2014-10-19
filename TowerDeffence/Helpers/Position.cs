namespace TowerDeffence.Helpers
{
    public struct Position
    {
<<<<<<< HEAD
        public double X
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public double Y
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
=======
        public Position(double x, double y) : this()
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; set; }

        public double Y { get; set; }
>>>>>>> enemyUnits
    }
}
