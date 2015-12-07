namespace Points
{
    public class Point3D
    {
        private int x, y, z;
        static readonly Point3D startingPoint = new Point3D(0, 0, 0);

        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        }
        public static Point3D StartingPoint
        {
            get { return startingPoint; }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}",
                this.X, this.Y, this.Z);
        }
    }
}
