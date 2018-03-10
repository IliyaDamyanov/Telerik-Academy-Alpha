using System;
using System.IO;
using System.Linq;

namespace Guards
{
    public class Program
    {
        static void Main(string[] args)
        {
            Guards.Run();
        }
    }

    public class Guards
    {
        public const int infinity = int.MaxValue;
        public const int normalStep = 1;
        public const int guardsStep = 3;

        public static void Run()
        {
            int[] mazeDimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = mazeDimensions[0];
            int cols = mazeDimensions[1];
            long[,] maze = new long[rows, cols];

            int numberOfGuards = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfGuards; i++)
            {
                string[] guardProps = Console.ReadLine().Split().ToArray();
                int guardRow = int.Parse(guardProps[0]);
                int guardCol = int.Parse(guardProps[1]);
                string guardDirection = guardProps[2];
                maze[guardRow, guardCol] = infinity;
                switch (guardDirection)
                {
                    case "U":
                        if (guardRow > 0 && maze[guardRow - 1, guardCol] == 0)
                        {
                            maze[guardRow - 1, guardCol] = guardsStep;
                        }
                        break;
                    case "D":
                        if (guardRow < rows - 1 && maze[guardRow + 1, guardCol] == 0)
                        {
                            maze[guardRow + 1, guardCol] = guardsStep;
                        }
                        break;
                    case "R":
                        if (guardCol < cols - 1 && maze[guardRow, guardCol + 1] == 0)
                        {
                            maze[guardRow, guardCol + 1] = guardsStep;
                        }
                        break;
                    case "L":
                        if (guardCol > 0 && maze[guardRow, guardCol - 1] == 0)
                        {
                            maze[guardRow, guardCol - 1] = guardsStep;
                        }
                        break;
                    default:
                        break;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (maze[i, j] == 0)
                    {
                        maze[i, j] = normalStep;
                    }

                    if (i == 0 && j == 0)
                    {
                        continue;
                    }

                    if (i == 0)
                    {
                        maze[i, j] += maze[i, j - 1];
                    }
                    else if (j == 0)
                    {
                        maze[i, j] += maze[i - 1, j];
                    }
                    else
                    {
                        maze[i, j] += Math.Min(maze[i, j - 1], maze[i - 1, j]); 
                    }
                }
            }

            long result = maze[rows - 1, cols - 1];
            if (result>=infinity)
            {
                Console.WriteLine("Meow");
            }
            else
            {
                Console.WriteLine(result);
            }

        }
    }

    //public class Guards
    //{
    //    private const long normalStep = 1;
    //    private const long guardsWatch = 3;
    //    private const long guard = 100000000;

    //    public static void Run()
    //    {
    //        string[] mazeDimensions = Console.ReadLine().Split(' ');
    //        int rows = int.Parse(mazeDimensions[0]);
    //        int columns = int.Parse(mazeDimensions[1]);
    //        long[,] maze = new long[rows, columns];
    //        int guardsNumber = int.Parse(Console.ReadLine());
    //        for (int i = 0, j = 2; i < guardsNumber; i++, j++)
    //        {
    //            string[] guardDescription = Console.ReadLine().Split(' ');
    //            int guardRow = int.Parse(guardDescription[0]);
    //            int guardColumn = int.Parse(guardDescription[1]);
    //            string guardDirection = guardDescription[2];
    //            maze[guardRow, guardColumn] = guard;
    //            switch (guardDirection)
    //            {
    //                case "L":
    //                    if (guardColumn != 0 && maze[guardRow, guardColumn - 1] != guard)
    //                    {
    //                        maze[guardRow, guardColumn - 1] = guardsWatch;
    //                    }
    //                    break;
    //                case "R":
    //                    if (guardColumn != columns - 1 && maze[guardRow, guardColumn + 1] != guard)
    //                    {
    //                        maze[guardRow, guardColumn + 1] = guardsWatch;
    //                    }
    //                    break;
    //                case "U":
    //                    if (guardRow != 0 && maze[guardRow - 1, guardColumn] != guard)
    //                    {
    //                        maze[guardRow - 1, guardColumn] = guardsWatch;
    //                    }
    //                    break;
    //                case "D":
    //                    if (guardRow != rows - 1 && maze[guardRow + 1, guardColumn] != guard)
    //                    {
    //                        maze[guardRow + 1, guardColumn] = guardsWatch;
    //                    }
    //                    break;
    //            }
    //        }

    //        for (int i = 0; i < rows; i++)
    //        {
    //            for (int j = 0; j < columns; j++)
    //            {
    //                maze[i, j] = maze[i, j] == 0 ? 1 : maze[i, j];
    //            }
    //        }

    //        for (int i = 1; i < columns; i++)
    //        {
    //            maze[0, i] += (maze[0, i - 1]);
    //        }

    //        for (int i = 1; i < rows; i++)
    //        {
    //            maze[i, 0] += (maze[i - 1, 0]);
    //        }

    //        for (int i = 1; i < rows; i++)
    //        {
    //            for (int j = 1; j < columns; j++)
    //            {
    //                maze[i, j] += Math.Min(maze[i - 1, j], maze[i, j - 1]);
    //            }
    //        }

    //        Console.WriteLine((maze[rows - 1, columns - 1] < guard ? maze[rows - 1, columns - 1].ToString() : "Meow"));
    //    }
    //}
}
