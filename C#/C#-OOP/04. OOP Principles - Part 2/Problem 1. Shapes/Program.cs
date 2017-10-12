using System;

namespace Problem_1.Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of the shape:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the shape:");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the type of shape:");
            string shapeType = Console.ReadLine();            
            Shape[] shapes = new Shape[3];
            shapes[0] = new Square(width, height);
            shapes[1] = new Rectangle(width, height);
            shapes[2] = new Triangle(width, height);
            switch (shapeType.ToLower())
            {
                case "square":
                    if (shapes[0].CalcuteSurface() == -1)
                    {
                        throw new ArgumentException("The width and height of a square must be equal");
                    }
                    else
                    {
                        Console.WriteLine(shapes[0].CalcuteSurface());
                    }
                    break;
                case "rectangle": Console.WriteLine(shapes[1].CalcuteSurface()); break;
                case "triangle": Console.WriteLine(shapes[2].CalcuteSurface()); break;
                default:
                    Console.WriteLine("Enter the right shape type - square , rectangle or triangle."); ;
                    break;
            }
        }
    }
}
