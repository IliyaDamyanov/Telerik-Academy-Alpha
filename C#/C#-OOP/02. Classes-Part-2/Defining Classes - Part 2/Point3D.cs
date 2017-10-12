using System;

namespace Defining_Classes___Part_2
{
    public struct Point3D
    {
        private int x;
        private int y;
        private int z;

        private static readonly Point3D pointO = new Point3D(0, 0, 0);
        public Point3D(int x , int y , int z):this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public int Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z= value;
            }
        }

        public static Point3D PointO
        {
            get
            {
                return pointO;
            }
        }

        public override string ToString()
        {
            return $"The point is with coordinates X: {X},Y: {Y},Z: {Z}.";
        }
    }
}
