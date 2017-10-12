using System;
using System.Linq;

namespace Guards
{
    public class GuardsTest
    {
        public const int Infinity = int.MaxValue;
        public const int NormalStep = 1;
        public const int GuardStep = 3;

        public static void Run()
        {
            int[] mazeDimensions = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();

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
                maze[guardRow, guardCol] = Infinity;

                switch (guardDirection)
                {
                    case "U":
                        if (guardRow > 0 && maze[guardRow - 1, guardCol] == 0)
                        {
                            maze[guardRow - 1, guardCol] = GuardStep;
                        }
                        break;
                    case "D":
                        if (guardRow < rows - 1 && maze[guardRow + 1, guardCol] == 0)
                        {
                            maze[guardRow + 1, guardCol] = GuardStep;
                        }
                        break;
                    case "R":
                        if (guardCol < cols - 1 && maze[guardRow, guardCol + 1] == 0)
                        {
                            maze[guardRow, guardCol + 1] = GuardStep;
                        }
                        break;
                    case "L":
                        if (guardCol > 0 && maze[guardRow, guardCol - 1] == 0)
                        {
                            maze[guardRow, guardCol - 1] = GuardStep;
                        }
                        break;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (maze[i, j] == 0)
                    {
                        maze[i, j] = NormalStep;
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
                        maze[i, j] +=
                            Math.Min(maze[i, j - 1], maze[i - 1, j]);
                    }
                }
            }

            long result = maze[rows - 1, cols - 1];
            if (result >= Infinity)
            {
                Console.WriteLine("Meow");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
