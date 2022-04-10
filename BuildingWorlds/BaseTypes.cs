namespace BuildingWorlds
{
    public class Vector2
    {
        public double X;
        public double Y;
        public Vector2(double x = 0, double y = 0)
        {
            this.X = x;
            this.Y = y;
        }
    }

    // May later change this to a Vector3, so making it its own class for upgradability
    public class Position : Vector2 { }

    public interface IPositionToValue
    {
        public abstract double Value(Position pos);
    }
}
