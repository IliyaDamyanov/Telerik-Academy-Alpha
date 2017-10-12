using System;
using System.Collections.Generic;
using System.IO;

namespace Defining_Classes___Part_2
{
    public class Path
    {
        private List<Point3D> pointsSequence = new List<Point3D>();
        private readonly string pathFileName;

        public Path(string pathFileName)
        {
            this.pathFileName = pathFileName;
        }

        public Path(string pathFileName, params Point3D[] points)
        {
            this.pathFileName = pathFileName;
            foreach (Point3D point in points)
            {
                PointsSequence.Add(point);
            }
        }

        public string PathFileName
        {
            get
            {
                return pathFileName;
            }
        }

        public List<Point3D> PointsSequence
        {
            get
            {
                return pointsSequence;
            }
            set
            {
                pointsSequence = value;
            }
        }

        public void AddPoint(Point3D point)
        {
            this.PointsSequence.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.PointsSequence.Remove(point);
        }

        public void ClearPointSequence(List<Point3D> pointsSequence)
        {
            this.PointsSequence.Clear();
        }
               
    }
}
