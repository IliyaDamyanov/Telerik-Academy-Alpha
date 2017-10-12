using System;
using System.IO;

namespace _05.Maximal_area_sum
{
    class Program
    {
        static void MaximalSum(int[,]array)
        {
            int sum = 0;
            int bestSum = int.MinValue;
            for (int row = 0; row < array.GetLength(0)-1; row++)
            {
                for (int col = 0; col < array.GetLength(1)-1; col++)
                {
                    sum = array[row, col] + array[row + 1, col] + array[row, col + 1] + array[row + 1, col + 1];
                    if (sum>bestSum)
                    {
                        bestSum = sum;
                    }
                }
            }
            Console.WriteLine(bestSum);
        }

        static int[,] ReadFile()
        {
            
            int[,] array;
            using (StreamReader readFile = new StreamReader("File.txt"))
            {
                int N = int.Parse(readFile.ReadLine());
                array = new int[N, N];
                for (int row = 0; row < N; row++)
                {
                    string[] arrayRowString = readFile.ReadLine().Split(' ');
                    for (int col = 0; col < N; col++)
                    {
                        array[row, col] = int.Parse(arrayRowString[col]);
                    }
                }
            }
            return array;
        }

        static void Main()
        {
            MaximalSum(ReadFile());
        }
    }
}
