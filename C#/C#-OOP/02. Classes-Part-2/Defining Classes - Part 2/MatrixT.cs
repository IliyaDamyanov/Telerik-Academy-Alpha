using System;

namespace Defining_Classes___Part_2
{
    public class MatrixT<T>
    {
        private T[,] matrixT;
        private int rows;
        private int cols;

        public MatrixT(int rows,int cols)
        {
            this.matrixT = new T[rows, cols];
            this.rows = rows;
            this.cols = cols;
        }
        public T this[int row, int col]
        {
            get
            {
                if ((row < 0) ||(row > this.rows - 1))
                {
                    throw new ArgumentOutOfRangeException ($"The row index must be between 0 and {this.rows - 1}");
                }

                if ((col < 0) || (col > this.cols - 1))
                {
                    throw new ArgumentOutOfRangeException($"The col index must be between 0 and {this.cols - 1}");
                }

                return this.matrixT[row, col];
            }
        }

        //public static MatrixT<T> operator +(T[,] firstMatrix, T[,] secondMatrix)
        //{
        //    if (firstMatrix.GetLength(0)!=secondMatrix.GetLength(0))
        //    {
        //        throw new ArgumentException("The rows of the first and the second matrix must be equal.");
        //    }
        //    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(1))
        //    {
        //        throw new ArgumentException("The cols of the first and the second matrix must be equal.");
        //    }
        //    T[,] finalMatrix = new T[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
        //    for (int row = 0; row < finalMatrix.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < finalMatrix.GetLength(1); col++)
        //        {
        //            finalMatrix[row, col] = firstMatrix[row, col]+ secondMatrix[row, col];
        //        }
        //    }
        //}
    }
}
