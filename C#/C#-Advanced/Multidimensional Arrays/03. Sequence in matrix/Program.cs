using System;

namespace _03.Sequence_in_matrix
{
    class Program
    {
        static int RowSum(int[,] matrix)
        {
            int bestSequence = 0;
            for (int startRow = 0; startRow < matrix.GetLength(0); startRow++)
            {
                int sequence = 1;
                for (int startCol = 0; startCol < matrix.GetLength(1)-1; startCol++)
                {
                    if (matrix[startRow, startCol] == matrix[startRow, startCol + 1])
                    {
                        sequence++;
                    }
                    else if (matrix[startRow, startCol] != matrix[startRow, startCol + 1])
                    {
                        sequence = 1;
                    }
                    if (sequence > bestSequence)
                    {
                        bestSequence = sequence;
                    }
                }
            }
            return bestSequence;
        }
        static int ColSum(int[,] matrix)
        {
            int bestSequence = 0;
            for (int startCol = 0; startCol < matrix.GetLength(1); startCol++)
            {
                int sequence = 1;
                for (int startRow = 0; startRow < matrix.GetLength(0)-1; startRow++)
                {
                    if (matrix[startRow, startCol] == matrix[startRow + 1, startCol])
                    {
                        sequence++;
                    }
                    else if (matrix[startRow, startCol] != matrix[startRow + 1, startCol])
                    {
                        sequence = 1;
                    }
                    if (sequence > bestSequence)
                    {
                        bestSequence = sequence;
                    }
                }
            }
            return bestSequence;
        }
        static int LeftRightDiagonalSum(int[,] matrix)
        {
            int bestSequence = 0;
            for (int startRow = 0; startRow < matrix.GetLength(0)-1; startRow++)
            {
                for (int startCol = 0; startCol < matrix.GetLength(1)-1; startCol++)
                {
                    int sequence = 1;
                    for (int row = startRow , col = startCol; (row < matrix.GetLength(0) - 1)&& (col < matrix.GetLength(1) - 1); row++,col++)
                    {
                        if (matrix[row, col] == matrix[row + 1, col + 1])
                        {
                            sequence++;
                        }
                        else if (matrix[row, col] != matrix[row + 1, col + 1])
                        {
                            sequence = 1;
                        }
                        if (sequence > bestSequence)
                        {
                            bestSequence = sequence;
                        }
                    }
                }
            }
            return bestSequence;
        }
        static int RightLeftDiagonalSum(int[,] matrix)
        {
            int bestSequence = 0;
            for (int startRow = 0; startRow < matrix.GetLength(0) - 1; startRow++)
            {
                for (int startCol = matrix.GetLength(1) - 1; startCol>=1; startCol--)
                {
                    int sequence = 1;
                    for (int row = startRow, col = startCol; (row < matrix.GetLength(0) - 1) && (col >= 1); row++, col--)
                    {
                        if (matrix[row, col] == matrix[row + 1, col - 1])
                        {
                            sequence++;
                        }
                        else if (matrix[row, col] != matrix[row + 1, col - 1])
                        {
                            sequence = 1;
                        }
                        if (sequence > bestSequence)
                        {
                            bestSequence = sequence;
                        }
                    }
                }
            }
            return bestSequence;
        }

        static void Main(string[] args)
        {
            string[] matrixSizesInString = Console.ReadLine().Split(' ');
            int[] matrixSizes = new int[matrixSizesInString.Length];
            for (int i = 0; i < matrixSizes.Length; i++)
            {
                matrixSizes[i] = int.Parse(matrixSizesInString[i]);
            }
            int[,] matrix = new int[matrixSizes[0], matrixSizes[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] Cols = Console.ReadLine().Split(' ');
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(Cols[col]);
                }
            }
            int bigger = Math.Max(RowSum(matrix), ColSum(matrix));
            int bigger2= Math.Max(LeftRightDiagonalSum(matrix), RightLeftDiagonalSum(matrix));
            Console.WriteLine(Math.Max(bigger,bigger2));
        }
    }
}
