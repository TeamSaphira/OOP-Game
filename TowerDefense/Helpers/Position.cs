namespace TowerDeffence.Helpers
{
    public struct Position
    {
        public Position(double x, double y) : this()
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }

        public double Y { get; set; }
    }
}
