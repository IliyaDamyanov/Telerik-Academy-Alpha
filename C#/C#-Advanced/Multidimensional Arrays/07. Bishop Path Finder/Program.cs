using System;

namespace _7.Bishop_Path_Finder
{
    class Program
    {
        static int[,] Chessboard()
        {
            string[] chessboardDimString = Console.ReadLine().Split(' ');
            int R = int.Parse(chessboardDimString[0]);
            int C = int.Parse(chessboardDimString[1]);
            int[,] chessboard = new int[R, C];
            int i = 0;
            int m = 0;
            for (int row = chessboard.GetLength(0) - 1; row >= 0; row--)
            {
                i = m;
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    chessboard[row, col] = i;
                    i += 3;
                }
                m += 3;
            }
            return chessboard;
        }
        static string[,] BishopMoves()
        {  
            int N = int.Parse(Console.ReadLine());
            string[,] bishopMoves = new string[N,2];
            for (int row = 0; row < N; row++)
            {
                string[] wholeRow = Console.ReadLine().Split(' ');
                for (int col = 0; col < 2; col++)
                {
                    bishopMoves[row, col] = wholeRow[col];
                }
            }
            return bishopMoves;
        }
        

        static int BishopMovesSum(int[,] chessboard , string[,] bishopMoves)
        {
            int[,] markArr = new int[chessboard.GetLength(0), chessboard.GetLength(1)];
            int sum = 0;
            int lastRow = chessboard.GetLength(0)-1;
            int lastCol = 0;
            for (int i = 0; i < bishopMoves.GetLength(0); i++)
            {
                switch (bishopMoves[i,0])
                {
                    case "RU":
                    case "UR":
                        {
                            for (int l = 0; l < int.Parse(bishopMoves[i, 1]) && (lastRow < chessboard.GetLength(0) && lastCol < chessboard.GetLength(1) && lastRow >= 0 && lastCol >= 0); l++)
                            {
                                if (l< int.Parse(bishopMoves[i, 1])-1)
                                {
                                    if (markArr[lastRow, lastCol] != 1)
                                    {
                                        sum += chessboard[lastRow, lastCol];
                                        markArr[lastRow, lastCol] = 1;
                                    }
                                    if (lastRow!=0 && lastCol != chessboard.GetLength(1)-1)
                                    {
                                        lastCol++;
                                        lastRow--;
                                    }
                                }
                                else if ((l == int.Parse(bishopMoves[i, 1]) - 1)&& (markArr[lastRow, lastCol] != 1))
                                {
                                        sum += chessboard[lastRow, lastCol];
                                        markArr[lastRow, lastCol] = 1;
                                }                               
                            }
                        }
                        break;
                    case "LU":
                    case "UL":
                        {
                            for (int l = 0; l < int.Parse(bishopMoves[i, 1]) && (lastRow < chessboard.GetLength(0) && lastCol < chessboard.GetLength(1) && lastRow >= 0 && lastCol >= 0); l++)
                            {
                                if (l < int.Parse(bishopMoves[i, 1]) - 1)
                                {
                                    if (markArr[lastRow, lastCol] != 1)
                                    {
                                        sum += chessboard[lastRow, lastCol];
                                        markArr[lastRow, lastCol] = 1;
                                    }
                                    if (lastRow!=0 && lastCol!=0)
                                    {
                                        lastCol--;
                                        lastRow--;
                                    }
                                }
                                else if ((l == int.Parse(bishopMoves[i, 1]) - 1)&& (markArr[lastRow, lastCol] != 1))
                                {
                                        sum += chessboard[lastRow, lastCol];
                                        markArr[lastRow, lastCol] = 1;
                                }
                            }
                        }
                        break;
                    case "LD":
                    case "DL":
                        {
                            for (int l = 0; l < int.Parse(bishopMoves[i, 1]) && (lastRow < chessboard.GetLength(0) && lastCol < chessboard.GetLength(1) && lastRow >= 0 && lastCol >= 0); l++)
                            {
                                if (l < int.Parse(bishopMoves[i, 1]) - 1)
                                {
                                    if (markArr[lastRow, lastCol] != 1)
                                    {
                                        sum += chessboard[lastRow, lastCol];
                                        markArr[lastRow, lastCol] = 1;
                                    }
                                    if (lastRow!=chessboard.GetLength(0)-1 && lastCol!=0)
                                    {
                                        lastCol--;
                                        lastRow++;
                                    }
                                }
                                else if ((l == int.Parse(bishopMoves[i, 1]) - 1)&& (markArr[lastRow, lastCol] != 1))
                                {
                                    sum += chessboard[lastRow, lastCol];
                                    markArr[lastRow, lastCol] = 1;
                                }
                            }
                        }
                        break;
                    case "RD":
                    case "DR":
                        {
                            for (int l = 0; l < int.Parse(bishopMoves[i, 1]) && (lastRow < chessboard.GetLength(0) && lastCol < chessboard.GetLength(1) && lastRow >= 0 && lastCol >= 0); l++)
                            {
                                if (l < int.Parse(bishopMoves[i, 1]) - 1)
                                {
                                    if (markArr[lastRow, lastCol] != 1)
                                    {
                                        sum += chessboard[lastRow, lastCol];
                                        markArr[lastRow, lastCol] = 1;
                                    }
                                    if (lastCol!=chessboard.GetLength(1)-1 && lastRow!=chessboard.GetLength(0)-1)
                                    {
                                        lastCol++;
                                        lastRow++;
                                    }                    
                                }
                                else if ((l == int.Parse(bishopMoves[i, 1]) - 1)&& (markArr[lastRow, lastCol] != 1))
                                {
                                    sum += chessboard[lastRow, lastCol];
                                    markArr[lastRow, lastCol] = 1;
                                }
                            }
                        }
                        break;
                    default: Console.WriteLine("Error!"); break;
                }
            }
            return sum;
        }
        static void Main()
        {
            int[,] chessBoard = Chessboard();
            string[,] bishopMoves = BishopMoves();
            Console.WriteLine(BishopMovesSum(chessBoard, bishopMoves));
        }
    }
}
