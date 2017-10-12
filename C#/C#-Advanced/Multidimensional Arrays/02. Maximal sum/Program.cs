using System;


namespace _02.Maximal_sum
{
    class Program
    {
        static void Main()
        {
            string[] sizesArrStr = Console.ReadLine().Split(' ');
            int[] sizesArr = new int[sizesArrStr.Length];
            for (int i = 0; i < sizesArrStr.Length; i++)
            {
                sizesArr[i] = int.Parse(sizesArrStr[i]);
            }
            int[,] array = new int[sizesArr[0], sizesArr[1]];
            for (int row = 0; row < sizesArr[0]; row++)
            {
                string[] Ms = Console.ReadLine().Split(' ');
                for (int col = 0; col < Ms.Length; col++)
                {
                    array[row, col] = int.Parse(Ms[col]);
                }
            }
            int sum = 0;
            int bestSum = int.MinValue;
            for (int row = 0; row < array.GetLength(0)-2; row++)
            {
                for (int col = 0; col < array.GetLength(1) - 2; col++)
                {
                    for (int sumRow  = row; sumRow < row + 3; sumRow++)
                    {
                        for (int sumCol = col; sumCol < col+3; sumCol++)
                        {
                            sum += array[sumRow, sumCol];
                        }
                    }
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                    sum = 0;
                }
            }
            Console.WriteLine(bestSum);
        }
    }
}
