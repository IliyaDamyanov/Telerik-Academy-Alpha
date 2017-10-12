using System;

namespace Defining_Classes___Part_2
{
    public class Program
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>(4);
            list.AddElement(10);
            list.AddElement(14);
            list.AddElement(20);

            Console.WriteLine("Index of 1: " + list.FindElementByValue(1));
            Console.WriteLine("List lenght: " + list.Lenght);
            //Console.WriteLine("Index of 1: " + list.FindElementByValue(1));
        }

        private static void PlayWithPaths()
        {
            Point3D point = new Point3D(1, 2, 3);
            Point3D point2 = new Point3D(12, 13, 14);
            CalculateDistanceBetweenPoints.CalculateDistance(point, point2);
            Path FirstPath = new Path("3DPoints.txt", point, point2);
            PathStorage.Save(FirstPath);
            Path SecondPath = new Path("3DPoints.txt");
            PathStorage.Load(SecondPath);
            foreach (Point3D pointt in SecondPath.PointsSequence)
            {
                Console.WriteLine(pointt);
            }
        }
    }
}
