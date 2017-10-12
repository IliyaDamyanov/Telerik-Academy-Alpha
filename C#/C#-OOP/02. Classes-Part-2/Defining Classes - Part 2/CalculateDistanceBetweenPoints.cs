using System;

namespace Defining_Classes___Part_2
{
    public static class CalculateDistanceBetweenPoints
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            int XDistance = Math.Abs(firstPoint.X - secondPoint.X);
            int YDistance = Math.Abs(firstPoint.Y - secondPoint.Y);
            int ZDistance = Math.Abs(firstPoint.Z - secondPoint.Z);
            double distance = Math.Sqrt(XDistance * XDistance + YDistance * YDistance + ZDistance * ZDistance);
            return distance;
        }
    }
}
