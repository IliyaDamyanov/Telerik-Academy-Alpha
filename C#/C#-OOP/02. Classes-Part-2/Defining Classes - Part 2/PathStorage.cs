using System;
using System.IO;
using System.Collections.Generic;

namespace Defining_Classes___Part_2
{
    public static class PathStorage
    {
        public static void Save(Path path)
        {
            using (StreamWriter writer = new StreamWriter($"{path.PathFileName}"))
            {
                foreach (Point3D point in path.PointsSequence)
                {
                    writer.WriteLine(point.X.ToString());
                    writer.WriteLine(point.Y.ToString());
                    writer.WriteLine(point.Z.ToString());
                }               
            }
        }
        public static void Load(Path path)
        {
            using (StreamReader reader = new StreamReader($"{path.PathFileName}"))
            {
                string line1;
                while ((line1 = reader.ReadLine())!=null)
                {
                    string line2 = reader.ReadLine();
                    string line3 = reader.ReadLine();
                    path.AddPoint(new Point3D(x:int.Parse(line1),y: int.Parse(line2), z: int.Parse(line3)));                    
                }
            }
        }
    }
}
